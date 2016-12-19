namespace TelegramBot.TelegramClasses
{
public class From
{
    public int id { get; set; }
    public string first_name { get; set; }
    public string username { get; set; }
}

public class Chat
{
    public int id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string username { get; set; }
    public string type { get; set; }
}

public class SendMessageResult
{
    public int message_id { get; set; }
    public From from { get; set; }
    public Chat chat { get; set; }
    public int date { get; set; }
    public string text { get; set; }
}

public class SendMessageClass
{
    public bool ok { get; set; }
    public SendMessageResult result { get; set; }
}

}