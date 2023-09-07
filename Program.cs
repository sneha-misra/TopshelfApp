//// See https://aka.ms/new-console-template for more information
using Topshelf;
using static Topshelf.ConsoleApp.Service;

//Console.WriteLine("Hello, World!");

class Program {
    static void Main(string[] args)
    {
        HostFactory.Run(x =>
        {
            x.Service<LoggingService>();
            x.EnableServiceRecovery(r => r.RestartService(TimeSpan.FromSeconds(10)));
            x.SetServiceName("TestService");
            x.StartAutomatically();
        }
        );
    }
}
