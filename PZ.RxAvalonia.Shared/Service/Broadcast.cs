using System.Reactive.Subjects;

namespace PZ.RxAvalonia.Shared.Service;

public static class BroadcastEvent
{
    public const string LanguageChanged = "LanguageChanged";
    public const string ThemeChanged = "ThemeChanged";
    public const string WindowActivated = "WindowActivated";
    public const string TimerTick = "TimerTick";
}

public sealed class BroadcastService
{
    private readonly Subject<string> _broadcast = new();
    public IObservable<string> Broadcast => _broadcast;
    public void Publish(string ev) => _broadcast.OnNext(ev);

    private readonly Subject<string> _exceptionCatched = new();
    public IObservable<string> ExceptionCatched => _exceptionCatched;
    public void OnExceptionCatched(string message) => _exceptionCatched.OnNext(message);
}
