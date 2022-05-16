using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class HomeModel : PageModel
    {
        public string MobilePhone { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public void OnGet(string mobilePhone, string address, string cityName)
        {
            MobilePhone = mobilePhone;
            Address = address;
            CityName = cityName;
        }
    }
}
