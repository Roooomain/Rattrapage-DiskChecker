using System.IO;
using DiskSpaceWPF.Helper;

namespace DiskSpaceWPF;
public class DiskSpaceLogger : IObserver
{
    private static readonly DiskSpaceLogger _instance = new DiskSpaceLogger();
    public string logFilePath = Path.Combine(Path.GetTempPath(), "logDiskSpace.log");

    public static DiskSpaceLogger Instance
    {
        get { return _instance; }
    }

    private DiskSpaceLogger() { }
    
    public void Update(DiskSpaceInfo info)
    {
        File.AppendAllText(logFilePath, $"{DateTime.Now} {info.FreeSpace}{Environment.NewLine}");
    }
}