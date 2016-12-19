using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class Program
{
    static string RequestTemplate =
    "https://api.telegram.org/bot315838170:AAGFPjKbKKft8yQFTIQeVOzjLeVw_GOCGwg/";
    static void Main(string[] args)
    {
        GetUpdates();
    }
    static void GetUpdates()
    {
        string url = RequestTemplate + "getUpdates";
        WebRequest request = WebRequest.Create(url);
        var response = request.GetResponseAsync().Result;
        var stream = response.GetResponseStream();
        using (StreamReader reader = new StreamReader(stream))
        {
            string result = reader.ReadToEnd();
            Console.WriteLine(result);
            JsonConvert.DeserializeObject<RootObject>(result);
        }
    }
}
public class From
{
    public int id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
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

public class Thumb
{
    public string file_id { get; set; }
    public int file_size { get; set; }
    public int width { get; set; }
    public int height { get; set; }
}

public class Sticker
{
    public int width { get; set; }
    public int height { get; set; }
    public string emoji { get; set; }
    public Thumb thumb { get; set; }
    public string file_id { get; set; }
    public int file_size { get; set; }
}

public class Message
{
    public int message_id { get; set; }
    public From from { get; set; }
    public Chat chat { get; set; }
    public int date { get; set; }
    public string text { get; set; }
    public Sticker sticker { get; set; }
}

public class Result
{
    public int update_id { get; set; }
    public Message message { get; set; }
}

public class RootObject
{
    public bool ok { get; set; }
    public List<Result> result { get; set; }
}