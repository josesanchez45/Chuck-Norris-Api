using Api_Query_work;
using RestSharp;



var key = new ApiKey();
var client = new RestClient("https://spotify23.p.rapidapi.com/search/?q=%3CREQUIRED%3E&type=multi&offset=0&limit=10&numberOfTopResults=5");
var request = new RestRequest();
request.AddHeader("X-RapidAPI-Key", key.ApiKey());
request.AddHeader("X-RapidAPI-Host", "spotify23.p.rapidapi.com");
var response = client.Execute(request).Content;

Console.WriteLine(response);