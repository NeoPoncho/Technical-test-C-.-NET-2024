namespace Dependency_Inversion_Principle
{
    public class MessageService(IMessageService messageService)
    {
        private readonly IMessageService _messageService = messageService;

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    }
}
