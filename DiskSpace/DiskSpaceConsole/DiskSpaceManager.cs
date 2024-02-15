using System;
using System.IO;
using System.Timers;

namespace DiskSpaceConsole
{
    public class DiskSpaceManager
    {
        // Attributs de la classe
        private readonly System.Timers.Timer _timer;
        private readonly DriveInfo _driveInfo;

        // Constructeur de la classe, intialisation de timer et driveInfo
        public DiskSpaceManager(int interval)
        {
            _driveInfo = new DriveInfo("C");
            _timer = new System.Timers.Timer(interval) { AutoReset = true };
            // Diagramme pattern observer, on abonne une méthode à l'événement Elapsed
            _timer.Elapsed += CheckSpace;
        }

        // Méthode pour vérifier l'espace disque
        private void CheckSpace(object source, ElapsedEventArgs e)
        {
            long freeSpace = _driveInfo.AvailableFreeSpace;
            string message = $"Espace disponible sur le disque C: {freeSpace} bytes";
            Console.WriteLine(message);
            LogManager.Instance.Log(message);
        }

        // Méthode pour démarrer le timer
        public void Start() => _timer.Start();

        // Méthode pour arrêter le timer
        public void Stop() => _timer.Stop();
    }
}
