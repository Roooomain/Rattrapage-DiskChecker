using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DiskSpaceWPF.Helper
{
    public class DiskSpaceManager : ISubject
    {
        // Attributs de la classe
        private readonly DriveInfo _driveInfo;
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly System.Timers.Timer _timer;

        // Constructeur de la classe, intialisation de timer et driveInfo
        public DiskSpaceManager()
        {
            _driveInfo = new DriveInfo("C");
            _timer = new System.Timers.Timer(10000);
            _timer.Elapsed += (sender, e) => Notify();
            _timer.Start();
        }

        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Detach(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        // Méthode pour vérifier l'espace disque
        public double GetTotalSpace()
        {
            return ToGigaOctet(_driveInfo.TotalSize);
        }

        public double GetAvailableFreeSpace()
        {
            return ToGigaOctet(_driveInfo.AvailableFreeSpace);
        }

        public double GetUtilizedSpace()
        {
            return ToGigaOctet(_driveInfo.TotalSize - _driveInfo.AvailableFreeSpace);
        }

        public double ToGigaOctet(long number) 
        {
            return number / 1000000000 ;
        }
    }
}
