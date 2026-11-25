namespace PZ.RxAvalonia.Shared.Service;

public class ExceptionService(BroadcastService broadcast, LogService logger)
{
    private static string FormatException(Exception ex)
    {
        return ex switch
        {
            _ => string.Format("Error: {0}", ex.Message),
        };
    }

    private readonly BroadcastService _broadcast = broadcast;
    private readonly LogService _logger = logger;

    public void CatchException(Exception ex)
    {
        try
        {
            _logger.Error(ex);

            var msg = FormatException(ex);
            _broadcast.OnExceptionCatched(msg);
        }
        catch
        {
            // DO NOTHING
        }
    }
}

