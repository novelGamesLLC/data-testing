using System;
using NUnit.Framework;
using Data.Service;

namespace Tests
{
    [TestFixture]
    public class DataService_ShouldReadJSONData
    {
        private readonly DataService _dataService;

        public DataService_ShouldReadJSONData()
        {
            _dataService = new DataService();
        }

        [Test]
        public void ReturnJsonObject()
        {
            var result = _dataService.ReadJSONData<JSONPlayground>("PlaygroundData.json");

            Assert.AreEqual(result.Word, "shears");
            Assert.AreEqual(result.Rank, 0);
            Assert.AreEqual(result.Synonyms, new string[]{ "scissors", "knives" });
        }
    }
}