using System;

namespace Orionik.NbuExchangeApi
{
    public static class ExchangeClient
    {
        public static bool ExchangeRateToday(string currency, out double result, bool suppressError = false)
        {
            try
            {
                var str = Client.SendGet(GenerateUrl.GetUrlByCurrencyToday(currency)).Result;
                var obj = Deserializer.DeserializeExchangeOne(str);
                result = double.Parse(obj.Currency.Rate);
                return true;
            }
            catch (Exception e)
            {
                if (suppressError)
                {
                    result = -1;
                    return false;
                }
                throw new ExchangeException("ExchangeRateToday method", e);
            }
        }

        public static bool ExchangeRateToday(CurrencyName currency, out double result, bool suppressError = false)
        {
            return ExchangeRateToday(currency.ToString(), out result, suppressError);
        }
    }
}
