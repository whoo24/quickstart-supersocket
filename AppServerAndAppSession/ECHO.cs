using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
#if USE_TELNETSESSION
using SessionType = AppServerAndAppSession.TelnetSession;
#else
using SessionType = SuperSocket.SocketBase.AppSession;
#endif

namespace AppServerAndAppSession {
  public class ECHO : CommandBase<SessionType, StringRequestInfo> {
    public override void ExecuteCommand (SessionType session, StringRequestInfo requestInfo) {
      session.Send(requestInfo.Body);
    }
  }
}
