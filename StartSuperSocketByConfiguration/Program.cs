using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase;
using SuperSocket.SocketEngine;

namespace StartSuperSocketByConfiguration {
  class Program {
    static void Main (string[] args) {
      Console.WriteLine("Press any key to start the server!");

      Console.ReadKey();
      Console.WriteLine();

      IBootstrap bootstrap = null;
      try {
        bootstrap = BootstrapFactory.CreateBootstrap();
      } catch (System.Configuration.ConfigurationErrorsException ex) {
        Console.WriteLine(ex.Message);
        Environment.Exit(-1);
      }

      if (!bootstrap.Initialize()) {
        Console.WriteLine("Failed to initialize!");
        Console.ReadKey();
        return;
      }

      var result = bootstrap.Start();
      
      Console.WriteLine("Start result: {0}!", result);

      if (result == StartResult.Failed) {
        Console.WriteLine("Failed to start!");
        Console.ReadKey();
        return;
      }
      
      Console.WriteLine("Press key 'q' to stop it!");

      while (Console.ReadKey().KeyChar != 'q') {
        Console.WriteLine();
        continue;
      }
      

      Console.WriteLine();

      //Stop the appServer
      bootstrap.Stop();

      Console.WriteLine("The server was stopped!");
      Console.ReadKey();
    }

  }
}
