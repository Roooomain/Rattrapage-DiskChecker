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

            Console.WriteLine($"Surveillance de l'espace disque démarrée. Vérification toutes les {interval} secondes.");
            Console.WriteLine("Appuyez sur 'Enter' pour arrêter...");
            Console.ReadLine();
        }
    }
}
