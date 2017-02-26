
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServerAndAppSession {
  class Program {
    static void Main (string[] args) {
      Console.WriteLine("Press any key to start the server!");
      Console.ReadKey();
      Console.WriteLine();
      var appServer = new TelnetServer();
      //Setup the appServer
      if (!appServer.Setup(2012)) {//Setup with listening port
        Console.WriteLine("Failed to setup!");
        Console.ReadKey();
        return;
      }
      //appServer.NewSessionConnected += new SessionHandler<AppSession>(appServer_NewSessionConnected);
#if !USE_COMMAND
      //appServer.NewRequestReceived += new RequestHandler<AppSession, StringRequestInfo>(appServer_NewRequestReceived);
#endif
      Console.WriteLine();
      //Try to start the appServer
      if (!appServer.Start()) {
        Console.WriteLine("Failed to start!");
        Console.ReadKey();
        return;
      }
      Console.WriteLine("The server started successfully, press key 'q' to stop it!");
      while (Console.ReadKey().KeyChar != 'q') {
        Console.WriteLine();
        continue;
      }
      //Stop the appServer
      appServer.Stop();
      Console.WriteLine("The server was stopped!");
      Console.ReadKey();
    }
  }
}
