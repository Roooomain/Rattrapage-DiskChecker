namespace DiskCheckerWPF.Helper;
/// <summary>
/// Classe qui contient les informations sur l'espace disque
/// </summary>
public class DiskCheckerInfo
{
    public long FreeSpace { get; set; }
    public long TotalSpace { get; set; }
    public double Interval { get; set; }
}