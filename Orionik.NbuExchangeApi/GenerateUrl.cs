namespace Orionik.NbuExchangeApi
{
    internal static class GenerateUrl
    {
        private const string UrlByCurrencyToday = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode={0}";

        public static string GetUrlByCurrencyToday(string currency) => string.Format(UrlByCurrencyToday, currency);
    }
}
