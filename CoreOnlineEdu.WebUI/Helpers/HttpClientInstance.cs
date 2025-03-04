namespace CoreOnlineEdu.WebUI.Helpers;
public static class HttpClientInstance
{
    public static HttpClient CreateClient()
    {
        HttpClient client = new();
        client.BaseAddress = new Uri("https://localhost:7283/api/");
        return client;
    }
}