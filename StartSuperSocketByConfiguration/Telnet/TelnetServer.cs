using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;

namespace StartSuperSocketByConfiguration.Telnet {
    public class TelnetServer : AppServer<TelnetSession> {
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
