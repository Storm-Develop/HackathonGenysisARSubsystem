using UnityEngine;
using RestSharp;
public class InitialRestSharpSetup :MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetupTokin();
    }

    /// <summary>
    /// Initial setup tokin for RestSharp Client 
    /// </summary>
    void SetupTokin()
    {
        var client = new RestClient("https://api.genesysappliedresearch.com/v2/knowledge/generatetoken");
        var request = new RestRequest(Method.POST);
        request.AddHeader("cache-control", "no-cache");
        request.AddHeader("Connection", "keep-alive");
        request.AddHeader("Content-Length", "0");
        request.AddHeader("Accept-Encoding", "gzip, deflate");
        request.AddHeader("Host", "api.genesysappliedresearch.com");
        request.AddHeader("Postman-Token", "624a1203-9c46-4f31-8e3a-9af4c5b9a746,7adb229a-35ec-493d-b271-30371c5fcae3");
        request.AddHeader("Cache-Control", "no-cache");
        request.AddHeader("Accept", "*/*");
        request.AddHeader("User-Agent", "PostmanRuntime/7.18.0");
        request.AddHeader("secretkey", "1438b2d3-e652-41ee-9010-564e16ae645c");
        request.AddHeader("organizationid", "8bb0491c-69e0-4683-be11-717f899ac647");
        IRestResponse response = client.Execute(request);
    }
}
