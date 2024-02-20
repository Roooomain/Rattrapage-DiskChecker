using DiskCheckerConsole.Helper;

public class DiskCheckerLogger : IObserver
{
    private static readonly DiskCheckerLogger _instance = new DiskCheckerLogger();
    public string LogFilePath = Path.Combine(Path.GetTempPath(), "logDiskChecker.log");
    public static DiskCheckerLogger Instance
    {
        get { return _instance; }
    }
    
    private DiskCheckerLogger() { }
    
    public void Update(DiskCheckerInfo info)
    {
        File.AppendAllText(LogFilePath, $"{DateTime.Now} {info.FreeSpace}{Environment.NewLine}");
    }
}