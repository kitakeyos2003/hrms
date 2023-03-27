using Newtonsoft.Json;
using System.Net;

public class JsonReader
{
    public static T GetObjectFromJson<T>(string url) where T : new()
    {
        using (var client = new WebClient())
        {
            client.Encoding = System.Text.Encoding.UTF8;
            var json = client.DownloadString(url);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}