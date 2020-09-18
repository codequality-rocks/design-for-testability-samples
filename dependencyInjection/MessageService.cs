using System;

namespace dependencyInjection
{
    class MessageService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}