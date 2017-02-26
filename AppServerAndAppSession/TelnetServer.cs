using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
#if USE_TELNETSESSION
using SessionType = AppServerAndAppSession.TelnetSession;
#else
using SessionType = SuperSocket.SocketBase.AppSession;
#endif

namespace AppServerAndAppSession {
  public class TelnetServer : AppServer<SessionType> {
    protected override bool Setup (IRootConfig rootConfig, IServerConfig config) {
      return base.Setup(rootConfig, config);
    }

    protected override void OnStarted () {
      base.OnStarted();
    }

    protected override void OnStopped () {
      base.OnStopped();
    }
  }
}
