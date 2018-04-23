﻿using System.Collections.Generic;
using System.Linq;
using Prime.Common;
using Prime.Finance.Services.Services.Vaultoro;
using Xunit;
using Xunit.Abstractions;

namespace Prime.Tests.Providers
{
    public class VaultoroTests : ProviderDirectTestsBase
    {
        public VaultoroTests(ITestOutputHelper outputWriter) : base(outputWriter)
        {
            Provider = Networks.I.Providers.OfType<VaultoroProvider>().FirstProvider();
        }

        [Fact]
        public override void TestApiPublic()
        {
            base.TestApiPublic();
        }

        [Fact]
        public override void TestGetPricing()
        {
            var pairs = new List<AssetPair>()
            {
                "BTC_GLD".ToAssetPairRaw()
            };

            base.PretestGetPricing(pairs, false);
        }

        [Fact]
        public override void TestGetAssetPairs()
        {
            var requiredPairs = new AssetPairs()
            {
                "BTC_GLD".ToAssetPairRaw()
            };

            base.PretestGetAssetPairs(requiredPairs);
        }

        [Fact]
        public override void TestGetOrderBook()
        {
            base.PretestGetOrderBook("BTC_GLD".ToAssetPairRaw(), false);
        }
    }
}
