namespace ConsoleModule;

internal class ConsoleBackgroundService : BackgroundService
{
    private int _counter;
    private CancellationToken _cancellationToken;
    private readonly ILogger<ConsoleBackgroundService> _logger;

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="logger"></param>
    public ConsoleBackgroundService(ILogger<ConsoleBackgroundService> logger) => _logger = logger;

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        _cancellationToken = cancellationToken;

        var envVar1 = Environment.GetEnvironmentVariable("envVar1");
        var envVar2 = Environment.GetEnvironmentVariable("envVar2");

        _logger.LogInformation($"Module initialized ('{envVar1}'-'{envVar2}').");

        while (true)
        {
            _counter++;
            _logger.LogInformation($"Counted {_counter} at {DateTime.UtcNow}");

            await Task.Delay(5000);
        }
    }
}
