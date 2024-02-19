using System.IO;
using System.Timers;
using DiskSpaceWPF.Helper;

namespace DiskSpaceWPF;

public class DiskSpaceMonitor : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private DiskSpaceInfo _diskSpaceInfo;
    
    private System.Timers.Timer _timer;
    private DriveInfo _driveInfo;
    
    private static readonly DiskSpaceMonitor _instance = new DiskSpaceMonitor();

    public static DiskSpaceMonitor Instance
    {
        get { return _instance; }
    }
    
    private DiskSpaceMonitor()
    {
        _timer = new System.Timers.Timer(10 * 1000);
        _driveInfo = new DriveInfo("C");
        _timer.Elapsed += OnTimedEvent;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    public void UpdateInterval(int interval)
    {
        _timer.Stop();
        _timer.Interval = interval * 1000;
        _timer.Start();
    }
    
    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        CheckDiskSpace();
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
            observer.Update(_diskSpaceInfo);
        }
    }

    public void CheckDiskSpace()
    {
        _diskSpaceInfo = new DiskSpaceInfo
        {
            FreeSpace = _driveInfo.AvailableFreeSpace, 
            TotalSpace = _driveInfo.TotalSize, 
            Interval = (_timer.Interval/1000)
        };
        Notify();
    }   
}
