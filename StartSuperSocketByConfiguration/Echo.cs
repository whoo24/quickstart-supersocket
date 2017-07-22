using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;

namespace StartSuperSocketByConfiguration {
  public class Echo : CommandBase<AppSession, StringRequestInfo> {
    public override void ExecuteCommand (AppSession session, StringRequestInfo requestInfo) {
      session.Send(requestInfo.Body);
    }
  }
}
