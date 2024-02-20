using System.IO;
using System.Timers;
using DiskCheckerWPF.Helper;

namespace DiskCheckerWPF;

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
    
    // Timer pour la surveillance
    private System.Timers.Timer _timer;
    
    // Implentation du design pattern Singleton
    private static readonly DiskCheckerMonitoring _instance = new DiskCheckerMonitoring();
    public static DiskCheckerMonitoring Instance
    {
        get { return _instance; }
    }
    
    private DiskCheckerMonitoring()
    {
        _timer = new System.Timers.Timer(10 * 1000);
        _driveInfo = new DriveInfo("C");
        _timer.Elapsed += OnTimedEvent;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    // Methode pour changer l'intervalle de surveillance
    public void UpdateInterval(int interval)
    {
        _timer.Stop();
        _timer.Interval = interval * 1000;
        _timer.Start();
    }
    
    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        CheckDisk();
    }
    
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

    // Methode pour verifier l'espace disque
    public void CheckDisk()
    {
        _DiskCheckerInfo = new DiskCheckerInfo
        {
            FreeSpace = _driveInfo.AvailableFreeSpace, 
            TotalSpace = _driveInfo.TotalSize, 
            Interval = (_timer.Interval/1000)
        };
        Notify();
    }   
}
