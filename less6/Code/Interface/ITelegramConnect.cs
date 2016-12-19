interface ITelegramConnector
{
    string GetUpdates();
    
    string SendMessage(int chatId, string message);
}