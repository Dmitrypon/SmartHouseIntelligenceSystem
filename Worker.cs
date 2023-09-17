
namespace SmartHouseIntelligenceSystem
{
    //public class Worker : BackgroundService
    //{
    //    private readonly ILogger<Worker> _logger;

    //    public Worker(ILogger<Worker> logger)
    //    {
    //        _logger = logger;
    //    }

    //protected override async Task<Task> ExecuteAsync(CancellationToken stoppingToken)
    //{
    //    while (!stoppingToken.IsCancellationRequested)
    //    {
    //        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
    //        await Task.Delay(1000, stoppingToken);
    //        _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(600));

    //        return Task.CompletedTask;

    //    }
    //}

    //}

    public class Worker : IHostedService, IDisposable
    {
        private int executionCount = 0;
        private readonly ILogger<TimedHostedService> _logger;
        private Timer? _timer = null;

        //public TimedHostedService(ILogger<TimedHostedService> logger)
        //{
        //    _logger = logger;
        //}

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            var count = Interlocked.Increment(ref executionCount);

            _logger.LogInformation(
                "Timed Hosted Service is working. Count: {Count}", count);
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}


