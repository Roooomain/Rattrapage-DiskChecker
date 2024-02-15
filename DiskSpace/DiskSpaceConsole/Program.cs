using DiskSpaceConsole;

namespace DiskSpaceConsole
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Initialisation de l'intervalle à 10 secondes par défaut
            int interval = 10000;

            // Récupération de l'intervalle depuis les arguments
            if (args.Length > 0 && int.TryParse(args[0], out int n))
            {
                // Conversion de l'intervalle en millisecondes
                interval = n * 1000; 
            }

            // Création d'une instance de DiskSpaceManager
            DiskSpaceManager manager = new DiskSpaceManager(interval);

            // Démarrage du manager
            manager.Start();

            // Message de démarrage du programme et affichage de l'intervalle
            Console.WriteLine(@"Le fichier log se situe au chemin : " + Path.Combine(Path.GetTempPath(), "logDiskSpace.json"));
            Console.WriteLine(@"L'intervalle de vérification est de " + interval / 1000 + " secondes.");
            Console.WriteLine(@"Appuyez sur une touche pour quitter.");
            
            // Attente d'une entrée utilisateur pour arrêter le programme
            Console.ReadKey();
            manager.Stop();
        }
    }
}
