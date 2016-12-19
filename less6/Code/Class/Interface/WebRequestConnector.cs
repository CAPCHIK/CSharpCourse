using System.Net;
using System.IO;
using Newtonsoft.Json;

class WebRequestConnector : ITelegramConnector
{
    private string sampleUrl = "https://api.telegram.org/bot317153897:AAEaJbXn66RCL2DE5DzESVGOuJeG_r_eRfw/";
    public RootObject GetUpdates()
    {
        string newUrl = sampleUrl + "getUpdates";
        var result =  GetResponse(newUrl);
        var rootObject = JsonConvert.DeserializeObject<RootObject>(result);
        return rootObject;
    }

    public string SendMessage(int chatId, string message)
    {
        return "";
    }

    private string GetResponse(string url)
    {
        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponseAsync().Result;
        using(StreamReader reader = new StreamReader(response.GetResponseStream()))
            return reader.ReadToEnd();       
    }

}