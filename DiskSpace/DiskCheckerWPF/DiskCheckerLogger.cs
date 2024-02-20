using System.IO;
using DiskCheckerWPF.Helper;

namespace DiskCheckerWPF;
public class DiskCheckerLogger : IObserver
{
    private static readonly DiskCheckerLogger _instance = new DiskCheckerLogger();
    public string logFilePath = Path.Combine(Path.GetTempPath(), "logDiskChecker.log");

    public static DiskCheckerLogger Instance
    {
        get { return _instance; }
    }

    private DiskCheckerLogger() { }
    
    public void Update(DiskCheckerInfo info)
    {
        File.AppendAllText(logFilePath, $"{DateTime.Now} {info.FreeSpace}{Environment.NewLine}");
    }
}