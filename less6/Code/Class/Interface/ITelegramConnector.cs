interface ITelegramConnector
{
    RootObject GetUpdates();

    string SendMessage(int chatId, string message);
}