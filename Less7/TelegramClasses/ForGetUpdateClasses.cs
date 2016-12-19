using System.Collections.Generic;

namespace TelegramBot.TelegramClasses
{
    public class Message
    {
        public Message(int message_id, From from, Chat chat, int date, string text)
        {
            this.message_id = message_id;
            this.from = from;
            this.chat = chat;
            this.date = date;
            this.text = text;

        }
        public int message_id { get; set; }
        public From from { get; set; }
        public Chat chat { get; set; }
        public int date { get; set; }
        public string text { get; set; }
    }
    public class GetUpdateResult
    {
        public int update_id { get; set; }
        public Message message { get; set; }
    }

    public class GetUpdatesClass 
    {
        public bool ok { get; set; }
        public List<GetUpdateResult> result { get; set; }
    }
}