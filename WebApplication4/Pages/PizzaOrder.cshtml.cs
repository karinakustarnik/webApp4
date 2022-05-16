using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class PizzaOrderModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        public int? Sum { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Sum == null)
            {
                Message = "�� �� ��������� ������� �����";
            }
            else
            {
                var NoOfPizza = Sum / 10;
                Message = $"�� �������� {NoOfPizza}";
            }
        }
    }
}
