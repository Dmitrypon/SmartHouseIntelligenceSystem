using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseIntelligenceSystem
{
    internal class Consumer : BackgroundService
    {
        //private readonly IConsumerService _consumerService;

        //    public ConsumerHostedService(IConsumerService consumerService)
        //    {
        //        _consumerService = consumerService;
        //    }

        //    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        //{
        //    await _consumerService.ReadMessgaes();
        //}
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IConsumerService
    {
    }
}


