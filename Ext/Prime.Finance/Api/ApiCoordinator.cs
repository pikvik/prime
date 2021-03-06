﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Nito.AsyncEx;
using Prime.Core;

namespace Prime.Finance
{
    public static partial class ApiCoordinator
    {
        public static ApiResponse<MarketPrices> GetPricing(IPublicPricingProvider provider, PublicPricesContext context)
        {
            return AsyncContext.Run(() => GetPricingAsync(provider, context));
        }

        public static ApiResponse<bool> TestApi(INetworkProviderPrivate provider, ApiPrivateTestContext context)
        {
            return AsyncContext.Run(() => TestApiAsync(provider, context));
        }

        public static ApiResponse<AssetPairs> GetAssetPairs(IAssetPairsProvider provider, NetworkProviderContext context = null)
        {
            return AsyncContext.Run(() => GetAssetPairsAsync(provider, context));
        }
        
        public static ApiResponse<OhlcDataResponse> GetOhlc(IOhlcProvider provider, OhlcContext context)
        {
            return AsyncContext.Run(() => GetOhlcAsync(provider, context));
        }

        public static ApiResponse<TransferSuspensions> GetTransferSuspensions(IDepositProvider provider, NetworkProviderContext context = null)
        {
            return AsyncContext.Run(() => GetTransferSuspensionsAsync(provider, context));
        }

        public static ApiResponse<WalletAddressesResult> GetDepositAddresses(IDepositProvider provider, WalletAddressAssetContext context)
        {
            return AsyncContext.Run(() => GetDepositAddressesAsync(provider, context));
        }

        public static ApiResponse<WalletAddressesResult> FetchAllDepositAddresses(IDepositProvider provider, WalletAddressContext context)
        {
            return AsyncContext.Run(() => GetAllDepositAddressesAsync(provider, context));
        }

        public static ApiResponse<BalanceResults> GetBalances(IBalanceProvider provider, NetworkProviderPrivateContext context)
        {
            return AsyncContext.Run(() => GetBalancesAsync(provider, context));
        }

        public static ApiResponse<List<AssetInfo>> GetCoinInformation(ICoinInformationProvider provider, NetworkProviderContext context = null)
        {
            return AsyncContext.Run(() => GetCoinInformationAsync(provider, context));
        }

        public static ApiResponse<AggregatedAssetPairData> GetCoinSnapshot(ICoinSnapshotAggregationProvider provider, AssetPairDataContext context)
        {
            return AsyncContext.Run(() => GetCoinSnapshotAsync(provider, context));
        }

        public static ApiResponse<PublicVolumeResponse> GetAggVolumeData(IAggVolumeDataProvider provider, AggVolumeDataContext context)
        {
            return AsyncContext.Run(() => GetAggVolumeDataAsync(provider, context));
        }

        public static ApiResponse<PublicVolumeResponse> GetPublicVolume(IPublicVolumeProvider provider, PublicVolumesContext context)
        {
            return AsyncContext.Run(() => GetPublicVolumeAsync(provider, context));
        }

        public static ApiResponse<OrderBook> GetOrderBook(IOrderBookProvider provider, OrderBookContext context)
        {
            return AsyncContext.Run(() => GetOrderBookAsync(provider, context));
        }
    }
}
