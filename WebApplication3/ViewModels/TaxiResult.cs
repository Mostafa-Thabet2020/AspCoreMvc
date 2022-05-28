using System.ComponentModel;

namespace WebApplication3.ViewModels
{
    public class TaxiResult
    {
        [DisplayName("Taxi name")]
        public string TaxiName { get; set; }
        public double Cost { get; set; }
    }
}
