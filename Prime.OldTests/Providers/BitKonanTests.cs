﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Common;
using Prime.Plugins.Services.BitKonan;

namespace Prime.Tests.Providers
{
    [TestClass]
    public class BitKonanTests : ProviderDirectTestsBase
    {
        public BitKonanTests()
        {
            Provider = Networks.I.Providers.OfType<BitKonanProvider>().FirstProvider();
        }

        [TestMethod]
        public override void TestApiPublic()
        {
            base.TestApiPublic();
        }

        [TestMethod]
        public override void TestApiPrivate()
        {
            base.TestApiPrivate();
        }

        [TestMethod]
        public override void TestGetPricing()
        {
            var pairs = new List<AssetPair>()
            {
                "BTC_USD".ToAssetPairRaw(),
                "LTC_USD".ToAssetPairRaw()
            };

            base.TestGetPricing(pairs, false);
        }

        [TestMethod]
        public override void TestGetAssetPairs()
        {
            var requiredPairs = new AssetPairs()
            {
                "BTC_USD".ToAssetPairRaw(),
                "LTC_USD".ToAssetPairRaw()
            };

            base.TestGetAssetPairs(requiredPairs);
        }

        [TestMethod]
        public override void TestGetOrderBook()
        {
            base.TestGetOrderBook("LTC_USD".ToAssetPairRaw(), false);
        }

        [TestMethod]
        public override void TestPlaceOrderLimit()
        {
            //TODO: SC: Not tested with real money
            base.TestPlaceOrderLimit("btc_usd".ToAssetPairRaw(), false, new Money(10m, Asset.Usd), new Money(10m, Asset.Usd));
        }

        [TestMethod]
        public override void TestGetTradeOrderStatus()
        {
            // TODO: SC: Not tested with real money
            var orderId = "21109502";
            base.TestGetTradeOrderStatus(orderId, "btc_usd".ToAssetPairRaw());
        }
    }
}