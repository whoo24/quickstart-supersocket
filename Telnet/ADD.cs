using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Linq;

namespace Telnet {
  public class ADD : CommandBase<AppSession, StringRequestInfo> {
    public override void ExecuteCommand (AppSession session, StringRequestInfo requestInfo) {
      session.Send(requestInfo.Parameters.Select(p => Convert.ToInt32(p)).Sum().ToString());
    }
  }
}
