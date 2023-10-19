// Import packages
using RestSharp;
using System.Text.Json;

// Load .env file
DotNetEnv.Env.Load();
DotNetEnv.Env.TraversePath().Load();

// Create a new Rest Client and call the Nylas API endpoint
var client = new RestSharp.RestClient("https://api.us.nylas.com/v3/grants/" +
             Environment.GetEnvironmentVariable("GRANT_ID") + "/calendars");
// We want a GET method
var request = new RestRequest();
// Adding header and authorization
request.AddHeader("Content-Type", "application/json");
request.AddHeader("Authorization", "Bearer " +
                  Environment.GetEnvironmentVariable("API_KEY_V3"));
// We send the request
RestResponse response = client.Execute(request);
// Parse the content as JSON
var content = JsonDocument.Parse(response.Content);
var data = content.RootElement.GetProperty("data");

Console.WriteLine(data);

foreach(var calendar in data.EnumerateArray())
{
    //Console.WriteLine(calendar.GetProperty("id"));
    Console.WriteLine("Id: {0} / Name: {1}",
        calendar.GetProperty("id"), calendar.GetProperty("name"));
    Console.WriteLine("");
}
// Wait for user input before closing the terminal
Console.Read();
