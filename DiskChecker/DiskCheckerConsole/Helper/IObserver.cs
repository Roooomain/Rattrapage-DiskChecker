namespace DiskCheckerConsole.Helper;

/// <summary>
/// Interface pour les observateurs (design pattern Observer)
/// </summary>
public interface IObserver
{
    void Update(DiskCheckerInfo info);
}