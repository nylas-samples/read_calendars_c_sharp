// Import packages
using RestSharp;
using System;

// Load .env file
DotNetEnv.Env.Load();
DotNetEnv.Env.TraversePath().Load();

// Create a new Rest Client and call the Nylas API endpoint
var client = new RestSharp.RestClient("https://api.nylas.com/calendars");
// Wait until the connection is done
client.Timeout = -1;
// We want a GET method
var request = new RestSharp.RestRequest(Method.GET);
// Adding header and authorization
request.AddHeader("Content-Type", "application/json");
request.AddHeader("Authorization", "Bearer " + System.Environment.GetEnvironmentVariable("ACCESS_TOKEN"));
// We send the request
IRestResponse response = client.Execute(request);
// Print the response
Console.WriteLine(response.Content);
// Wait for user input before closing the terminal
Console.Read();
