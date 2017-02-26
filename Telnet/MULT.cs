using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Linq;

namespace Telnet {
  public class MULT : CommandBase<AppSession, StringRequestInfo> {
    public override void ExecuteCommand (AppSession session, StringRequestInfo requestInfo) {
      var result = 1;
      foreach (var factor in requestInfo.Parameters.Select(p => Convert.ToInt32(p))) {
        result *= factor;
      }
      session.Send(result.ToString());
    }
  }
}
