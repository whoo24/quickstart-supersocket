using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
#if USE_TELNETSESSION
using SessionType = AppServerAndAppSession.TelnetSession;
#else
using SessionType = SuperSocket.SocketBase.AppSession;
#endif

namespace AppServerAndAppSession {
  public class TelnetSession : AppSession<SessionType> {
    protected override void OnSessionStarted () {
      this.Send("Welcome to SuperSocket Telnet Server");
    }

    protected override void HandleUnknownRequest (StringRequestInfo requestInfo) {
      this.Send("Unknow request");
    }

    protected override void HandleException (Exception e) {
      this.Send("Application error: {0}", e.Message);
    }

    protected override void OnSessionClosed (CloseReason reason) {
      //add you logics which will be executed after the session is closed
      base.OnSessionClosed(reason);
    }
  }
}
