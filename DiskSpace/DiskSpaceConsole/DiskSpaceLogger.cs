﻿using DiskSpaceConsole.Helper;

public class DiskSpaceLogger : IObserver
{
    private static readonly DiskSpaceLogger _instance = new DiskSpaceLogger();
    public string LogFilePath = Path.Combine(Path.GetTempPath(), "logDiskSpace.log");
    public static DiskSpaceLogger Instance
    {
        get { return _instance; }
    }
    
    private DiskSpaceLogger() { }
    
    public void Update(DiskSpaceInfo info)
    {
        File.AppendAllText(LogFilePath, $"{DateTime.Now} {info.FreeSpace}{Environment.NewLine}");
    }
}