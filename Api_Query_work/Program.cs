using Api_Query_work;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Text.Json.Nodes;

var key = new ApiKey();

var client = new RestClient("https://matchilling-chuck-norris-jokes-v1.p.rapidapi.com/jokes/random");
var request = new RestRequest();
request.AddHeader("accept", "application/json");
request.AddHeader("X-RapidAPI-Key", key.Api());
var response = client.Execute(request).Content;

var root = JsonConvert.DeserializeObject<List<Chuck_Root>>(response);


foreach(var item in root) 
{
    Console.WriteLine(item.id);


}

