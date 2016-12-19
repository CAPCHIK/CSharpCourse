using TelegramBot.TelegramClasses;

namespace TelegramBot
{
    public interface ITelegramConnector
    {
         GetUpdatesClass GetUpdate();

         SendMessageClass SendMessage(int id, string message);

    }
}