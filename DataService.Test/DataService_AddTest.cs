using System;
using NUnit.Framework;
using Data.Service;

namespace Tests
{
    [TestFixture]
    public class DataService_ShouldAdd
    {
        private readonly DataService _dataService;

        public DataService_ShouldAdd()
        {
            _dataService = new DataService();
        }

        [Test]
        public void ReturnSumGivenValueOf1and2()
        {
            var result = _dataService.Add(1, 2);

            Assert.AreEqual(result, 3);
        }
    }
}