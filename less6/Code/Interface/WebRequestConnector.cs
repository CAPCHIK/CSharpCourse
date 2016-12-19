using System.Net;
using System.IO;
class WebRequestConnector : ITelegramConnector
{
    public string GetUpdates()
    {
        string newUrl = sampleUrl+"getUpdates";
        return GetResponse(newUrl);
    }
    public string GetResponse(int chatId, string message)
    {
        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponseAsync().Result;
        using(StreamReader reader = new StreamReader(response.GetResponseStream()));
        return reader.ReadToEnd();
    }
}