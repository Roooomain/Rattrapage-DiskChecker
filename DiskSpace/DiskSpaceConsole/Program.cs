using DiskSpaceConsole;

namespace DiskSpaceConsole
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

            var monitor = new DiskSpaceMonitor(interval);
            var logger = DiskSpaceLogger.Instance;

            monitor.Attach(logger);

            Console.WriteLine($"Surveillance du disque C: toutes les {interval} secondes.");
            Console.WriteLine($"Destination du fichier log : {logger.LogFilePath}");
            Console.WriteLine("Appuyez sur une touche pour arrêter...");
            monitor.CheckDiskSpace();
            Console.ReadLine();
        }
    }
}
