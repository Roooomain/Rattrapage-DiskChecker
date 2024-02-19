using System.Timers;
using DiskSpaceConsole.Helper;
using Timer = System.Threading.Timer;

namespace DiskSpaceConsole;

public class DiskSpaceMonitor : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private DiskSpaceInfo diskSpaceInfo;
    
    private System.Timers.Timer _timer;
    private DriveInfo _driveInfo;

    public DiskSpaceMonitor(int intervalInSeconds)
    {
        _timer = new System.Timers.Timer(intervalInSeconds * 1000);
        _driveInfo = new DriveInfo("C");
        _timer.Elapsed += OnTimedEvent;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        CheckDiskSpace();
    }
    
    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(diskSpaceInfo);
        }
    }

    public void CheckDiskSpace()
    {
        diskSpaceInfo = new DiskSpaceInfo { FreeSpace = _driveInfo.AvailableFreeSpace, TotalSpace = _driveInfo.TotalSize };
        Console.WriteLine($"Espace disponible sur le disque C: {diskSpaceInfo.FreeSpace} bytes");
        Notify();
    }   
}
