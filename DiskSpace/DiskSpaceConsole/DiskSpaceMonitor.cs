﻿using System.Timers;
using DiskSpaceConsole.Helper;

namespace DiskSpaceConsole;

public class DiskSpaceMonitor : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private DiskSpaceInfo _diskSpaceInfo;
    
    private System.Timers.Timer _timer;
    private DriveInfo _driveInfo;

    public DiskSpaceMonitor(int interval)
    {
        _timer = new System.Timers.Timer(interval * 1000);
        _driveInfo = new DriveInfo("C");
        _timer.Elapsed += OnTimerInterval;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    private void OnTimerInterval(Object source, ElapsedEventArgs e)
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
            TotalSpace = _driveInfo.TotalSize
        };
        Console.WriteLine($"Espace disponible sur le disque C: {_diskSpaceInfo.FreeSpace} sur {_diskSpaceInfo.TotalSpace} bytes");
        Notify();
    }   
}
