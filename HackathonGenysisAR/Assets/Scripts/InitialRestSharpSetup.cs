using UnityEngine;
using RestSharp;
using System.Net;
using System.Collections.Generic;
using System;
using RestSharp.Deserializers;
using QuickType;
using Newtonsoft.Json;
using RequestMessage;

public class InitialRestSharpSetup :MonoBehaviour
{
    private JsonDeserializer _deserialJSON;
    // Start is called before the first frame update
    void Start()
    {
        _deserialJSON = new JsonDeserializer();
        var messageRequestSerialized = SetupRequestMessage("What is BeerTender?");
        SearchKeyWord(messageRequestSerialized);
    }

    private void GettingKeyToken()
    {
        var client = new RestClient("https://api.genesysappliedresearch.com/v2/knowledge/generatetoken");
        var request = new RestRequest(Method.POST);
        request.AddHeader("cache-control", "no-cache");
        request.AddHeader("Accept", "*/*");
        request.AddHeader("secretkey", "1438b2d3-e652-41ee-9010-564e16ae645c");
        request.AddHeader("organizationid", "8bb0491c-69e0-4683-be11-717f899ac647");
        IRestResponse response = client.Execute(request);
        Debug.Log(response.Content);
    }

    private string SetupRequestMessage(string messageRequest)
    {
        var result  = new RequestMessageRestAPI();
        result.Query = messageRequest;
        result.PageSize = 5;
        result.PageNumber = 1;
        result.SortOrder = "string";
        result.SortBy = "string";
        result.LanguageCode = "en-US";
        result.DocumentType = "Faq";
        var resultSerialized=  JsonConvert.SerializeObject(result, QuickType.Converter.Settings);
        return resultSerialized;
    }

      KnowledgeBaseMessage SearchKeyWord(string messageRequestSerialized)
    {
        var client = new RestClient("https://api.genesysappliedresearch.com/v2/knowledge/knowledgebases/ee587552-cbfe-4ed1-8e4d-57ef93f567a1/search");
        var request = new RestRequest(Method.POST);
        request.AddHeader("cache-control", "no-cache");
        //request.AddHeader("Postman-Token", "72ae5c06-ab5a-408e-941d-1ffe55e0fe27,52c09958-c8a9-4d45-8acf-cf1ac6efcfe7");
        request.AddHeader("Accept", "*/*");
        request.AddHeader("token", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJvcmdJZCI6IjhiYjA0OTFjLTY5ZTAtNDY4My1iZTExLTcxN2Y4OTlhYzY0NyIsImV4cCI6MTU3MTUzODU1OCwiaWF0IjoxNTcxNTM0OTU4fQ.81jrxosFVdhix2wmVDe9A3BhaSWWhaB8QTFHBavzzf8");
        request.AddHeader("secretkey", "1438b2d3-e652-41ee-9010-564e16ae645c");
        request.AddHeader("organizationid", "8bb0491c-69e0-4683-be11-717f899ac647");
        request.AddParameter("application/json", messageRequestSerialized, ParameterType.RequestBody);
        IRestResponse response = client.Execute(request);
        Debug.Log(response.Content);

        if (response.StatusCode == HttpStatusCode.OK)
        {

            var rootObject= JsonConvert.DeserializeObject<KnowledgeBaseMessage>(response.Content, QuickType.Converter.Settings);
            return rootObject;
        }
        else
        {
            return null;
        }
    }

  
}
