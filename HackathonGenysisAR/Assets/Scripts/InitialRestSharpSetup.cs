using UnityEngine;
using RestSharp;
using System.Net;
using System.Collections.Generic;
using System;
using RestSharp.Deserializers;
using QuickType;
using Newtonsoft.Json;

public class InitialRestSharpSetup :MonoBehaviour
{
    private JsonDeserializer _deserialJSON;
    // Start is called before the first frame update
    void Start()
    {
        _deserialJSON = new JsonDeserializer();
        SearchKeyWord();
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

    KnowledgeBaseMessage SearchKeyWord()
    {
        var client = new RestClient("https://api.genesysappliedresearch.com/v2/knowledge/knowledgebases/ee587552-cbfe-4ed1-8e4d-57ef93f567a1/search");
        var request = new RestRequest(Method.POST);
        request.AddHeader("cache-control", "no-cache");
        //request.AddHeader("Postman-Token", "72ae5c06-ab5a-408e-941d-1ffe55e0fe27,52c09958-c8a9-4d45-8acf-cf1ac6efcfe7");
        request.AddHeader("Accept", "*/*");
        request.AddHeader("token", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJvcmdJZCI6IjhiYjA0OTFjLTY5ZTAtNDY4My1iZTExLTcxN2Y4OTlhYzY0NyIsImV4cCI6MTU3MTUzODU1OCwiaWF0IjoxNTcxNTM0OTU4fQ.81jrxosFVdhix2wmVDe9A3BhaSWWhaB8QTFHBavzzf8");
        request.AddHeader("secretkey", "1438b2d3-e652-41ee-9010-564e16ae645c");
        request.AddHeader("organizationid", "8bb0491c-69e0-4683-be11-717f899ac647");
        request.AddParameter("application/json", "{\r\n  \"query\": \"What is BeerTender\"\r\n  ,\r\n  \r\n  \"pageSize\": 5,\r\n  \"pageNumber\": 1,\r\n  \"sortOrder\": \"string\",\r\n  \"sortBy\": \"string\",\r\n  \"languageCode\":\"en-US\",\r\n  \"documentType\": \"Faq\"\r\n}", ParameterType.RequestBody);
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
