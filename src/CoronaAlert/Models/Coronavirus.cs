namespace CoronaAlert.Models
{
    public class Coronavirus
    {
        public string Country { get; set; }
        public long ConfirmedCases { get; set; }
        public long TotalDeaths { get; set; }
        public long TotalRecovered { get; set; }

        public float GetDeathRate() => TotalDeaths*100.0f / ConfirmedCases;
        public float GetRecoveryRate() => TotalRecovered*100.0f / ConfirmedCases;
    }
}
