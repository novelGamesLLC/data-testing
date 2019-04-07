using System;
using Json.Net;

namespace Data.Service
{
    public class DataService
    {
        // add a thing
        public int Add(int a, int b) 
        {
            Json.Net.JsonParser parser = new JsonParser();
           return a + b;
        }

        // Read the JSON file
        public string ReadJSONData(string fileName)
        {
            throw new NotImplementedException("Please create a test first");
        }
    }
}