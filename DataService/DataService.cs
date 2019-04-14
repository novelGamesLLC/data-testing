using System;
using System.IO;
using Newtonsoft.Json;

namespace Data.Service
{
    public class DataService
    {
        // Read the JSON file
        public T ReadJSONData<T>(string fileName)
        {
            string fileLocation = "../../../Data/" + fileName; 
            string contents = File.ReadAllText(fileLocation);
            return JsonConvert.DeserializeObject<T>(contents);
        }
    }
}