using DiskCheckerConsole;

namespace DiskCheckerConsole
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int interval = 10;
            if (args.Length > 0 && int.TryParse(args[0], out int parsedInterval))
            {
                interval = parsedInterval;
            }

            var monitor = new DiskCheckerMonitoring(interval);
            var logger = DiskCheckerLogger.Instance;

            monitor.Attach(logger);

            Console.WriteLine($"Intervalle de surveillance du disque C : {interval} secondes.");
            Console.WriteLine($"Destination du fichier log : {logger.LogFilePath}");
            Console.WriteLine("Appuyez sur une touche pour arrêter...");
            monitor.CheckDisk();
            Console.ReadLine();
        }
    }
}
