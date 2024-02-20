using System.Timers;
using DiskCheckerConsole.Helper;

namespace DiskCheckerConsole;

/// <summary>
/// Classe qui surveille l'espace disque
/// </summary>
public class DiskCheckerMonitoring : ISubject
{
    // Liste des observateurs
    private List<IObserver> _observers = new List<IObserver>();
    
    // Informations sur l'espace disque
    private DiskCheckerInfo _DiskCheckerInfo;
    private DriveInfo _driveInfo;
    
    // Timer
    private System.Timers.Timer _timer;

    // Constructeur
    public DiskCheckerMonitoring(int interval)
    {
        _timer = new System.Timers.Timer(interval * 1000);
        _driveInfo = new DriveInfo("C");
        _timer.Elapsed += OnTimerInterval; // On ajoute l'événement OnTimerInterval à l'événement Elapsed du timer
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    // Méthode pour check l'espace disque quand le timer est déclenché
    private void OnTimerInterval(Object source, ElapsedEventArgs e)
    {
        CheckDisk();
    }
    
    // Implémentation des méthodes de ISubject
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_DiskCheckerInfo);
        }
    }

    // Méthode pour vérifier l'espace disque
    public void CheckDisk()
    {
        // Mise à jour des informations sur l'espace disque
        _DiskCheckerInfo = new DiskCheckerInfo
        {
            FreeSpace = _driveInfo.AvailableFreeSpace, 
            TotalSpace = _driveInfo.TotalSize
        };
        
        // Affichage des informations sur l'espace disque
        Console.WriteLine($"Espace disponible sur le disque C: {_DiskCheckerInfo.FreeSpace} sur {_DiskCheckerInfo.TotalSpace} bytes");
        
        // Notifier les observateurs
        Notify();
    }   
}
