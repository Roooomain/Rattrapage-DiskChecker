namespace DiskCheckerWPF.Helper;

/// <summary>
/// Interface pour les observateurs (design pattern Observer)
/// </summary>
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}