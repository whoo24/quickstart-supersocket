using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;

namespace StartSuperSocketByConfiguration.Telnet.Command {
  public class Echo : CommandBase<TelnetSession, StringRequestInfo> {
    public override void ExecuteCommand (TelnetSession session, StringRequestInfo requestInfo) {
      session.Send(requestInfo.Body);
    }
  }
}
