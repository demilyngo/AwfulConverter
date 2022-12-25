namespace CurrencyConverter
{
    public class Root
    {
        public DateTime Date { get; set; }
        public DateTime PreviousDate { get; set; }
        public string PreviousURL { get; set; }
        public DateTime Timestamp { get; set; }
        public Dictionary<string, ValuteItem> Valute { get; set; }
    }

    public class Valute
    {
        public ValuteItem AUD { get; set; }
        public ValuteItem AZN { get; set; }
        public ValuteItem GBP { get; set; }
        public ValuteItem AMD { get; set; }
        public ValuteItem BYN { get; set; }
        public ValuteItem BGN { get; set; }
        public ValuteItem BRL { get; set; }
        public ValuteItem HUF { get; set; }
        public ValuteItem HKD { get; set; }
        public ValuteItem DKK { get; set; }
        public ValuteItem USD { get; set; }
        public ValuteItem EUR { get; set; }
        public ValuteItem INR { get; set; }
        public ValuteItem KZT { get; set; }
        public ValuteItem CAD { get; set; }
        public ValuteItem KGS { get; set; }
        public ValuteItem CNY { get; set; }
        public ValuteItem MDL { get; set; }
        public ValuteItem NOK { get; set; }
        public ValuteItem PLN { get; set; }
        public ValuteItem RON { get; set; }
        public ValuteItem XDR { get; set; }
        public ValuteItem SGD { get; set; }
        public ValuteItem TJS { get; set; }
        public ValuteItem TRY { get; set; }
        public ValuteItem TMT { get; set; }
        public ValuteItem UZS { get; set; }
        public ValuteItem UAH { get; set; }
        public ValuteItem CZK { get; set; }
        public ValuteItem SEK { get; set; }
        public ValuteItem CHF { get; set; }
        public ValuteItem ZAR { get; set; }
        public ValuteItem KRW { get; set; }
        public ValuteItem JPY { get; set; }
    }

    public class ValuteItem
    {
        public string ID { get; set; }
        public string NumCode { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double Previous { get; set; }
    }
}
