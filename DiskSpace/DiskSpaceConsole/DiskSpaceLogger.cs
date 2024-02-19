using DiskSpaceConsole.Helper;

public class DiskSpaceLogger : IObserver
{
    private static readonly DiskSpaceLogger _instance = new DiskSpaceLogger();
    private static string logFilePath = Path.Combine(Path.GetTempPath(), "logDiskSpace.log");

    private DiskSpaceLogger() { }

    public static DiskSpaceLogger Instance
    {
        get { return _instance; }
    }

    public void Update(DiskSpaceInfo info)
    {
        File.AppendAllText(logFilePath, $"{DateTime.Now}: {info.FreeSpace}{Environment.NewLine}");
    }
}