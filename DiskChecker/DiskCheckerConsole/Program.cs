using DiskCheckerConsole;

namespace DiskCheckerConsole
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Par défaut, on vérifie le disque toutes les 10 secondes
            int interval = 10;
            // Si un argument est passé en ligne de commande, on l'utilise comme intervalle
            if (args.Length > 0 && int.TryParse(args[0], out int parsedInterval))
            {
                interval = parsedInterval;
            }

            // On crée une instance de DiskCheckerMonitoring et de DiskCheckerLogger
            var monitor = new DiskCheckerMonitoring(interval);
            var logger = DiskCheckerLogger.Instance;

            // On attache le logger à l'instance de DiskCheckerMonitoring (design pattern Observer)
            monitor.Attach(logger);

            // On affiche les informations de configuration et on lance une premiére surveillance
            Console.WriteLine($"Intervalle de surveillance du disque C : {interval} secondes.");
            Console.WriteLine($"Destination du fichier log : {logger.LogFilePath}");
            Console.WriteLine("Appuyez sur une touche pour arrêter...");
            monitor.CheckDisk();
            Console.ReadLine();
        }
    }
}
