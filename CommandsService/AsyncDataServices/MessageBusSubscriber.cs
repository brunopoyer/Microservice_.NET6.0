using CommandsService.EventProcessing;

namespace CommandsService.AsyncDataServices
{
    public class MessageBusSubscriber : BackgroundService
    {
        public MessageBusSubscriber(IConfiguration configuration, IEventProcessor eventProcessor)
        {
            
        }
    }
}