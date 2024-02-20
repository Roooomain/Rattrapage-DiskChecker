using System.Timers;
using DiskCheckerConsole.Helper;

namespace DiskCheckerConsole;

public class DiskCheckerMonitoring : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private DiskCheckerInfo _DiskCheckerInfo;
    
    private System.Timers.Timer _timer;
    private DriveInfo _driveInfo;

    public DiskCheckerMonitoring(int interval)
    {
        _timer = new System.Timers.Timer(interval * 1000);
        _driveInfo = new DriveInfo("C");
        _timer.Elapsed += OnTimerInterval;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    private void OnTimerInterval(Object source, ElapsedEventArgs e)
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

    public void CheckDisk()
    {
        _DiskCheckerInfo = new DiskCheckerInfo
        {
            FreeSpace = _driveInfo.AvailableFreeSpace, 
            TotalSpace = _driveInfo.TotalSize
        };
        Console.WriteLine($"Espace disponible sur le disque C: {_DiskCheckerInfo.FreeSpace} sur {_DiskCheckerInfo.TotalSpace} bytes");
        Notify();
    }   
}
