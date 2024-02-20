using DiskCheckerConsole.Helper;

/// <summary>
/// Classe qui permet de logger les informations sur l'espace disque
/// </summary>
public class DiskCheckerLogger : IObserver
{
    // Implentation du design pattern Singleton
    private static readonly DiskCheckerLogger _instance = new DiskCheckerLogger();
    
    // Chemin du fichier de log
    public string LogFilePath = Path.Combine(Path.GetTempPath(), "logDiskChecker.log");
    public static DiskCheckerLogger Instance
    {
        get { return _instance; }
    }
    
    private DiskCheckerLogger() { }
    
    // Implementation du design pattern observer
    public void Update(DiskCheckerInfo info)
    {
        File.AppendAllText(LogFilePath, $"{DateTime.Now} {info.FreeSpace}{Environment.NewLine}");
    }
}