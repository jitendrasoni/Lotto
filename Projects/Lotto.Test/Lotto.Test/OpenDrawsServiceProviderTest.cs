using Business.Dto;
using Business.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;

namespace Lotto.Test
{
    [TestClass]
    public class OpenDrawsServiceProviderTest
    {
        private IOpenDrawsServiceProvider _openDrawsServiceProvider;

    [TestInitialize]
    public void Setup()
    {
        var httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://data.api.thelott.com")
        };

        _openDrawsServiceProvider = new OpenDrawsServiceProvider(httpClient);
    }

    [TestMethod]
    public void AssertSuccessFlag_IsTrue()
    {
        var drawRequest = new OpenDrawsRequest()
        {
            CompanyId = "GoldenCasket",
            MaxDrawCount = 20,
            OptionalProductFilter = new[] { "TattsLotto", "MonWedLotto", "OzLotto", "MonWedLotto", "Powerball", "Super66" }
        };

        var results = _openDrawsServiceProvider.GetOpenDraws(drawRequest).Result;

        // Assert
        Assert.IsTrue(results.Success);
    }

    [TestMethod]
    public void AssertErrorInfo_IsNull()
    {
        var drawRequest = new OpenDrawsRequest()
        {
            CompanyId = "GoldenCasket",
            MaxDrawCount = 20,
            OptionalProductFilter = new[] { "TattsLotto", "MonWedLotto", "OzLotto", "MonWedLotto", "Powerball", "Super66" }
        };

        var results = _openDrawsServiceProvider.GetOpenDraws(drawRequest).Result;

        // Assert
        Assert.IsNull(results.ErrorInfo);
    }
}
}
