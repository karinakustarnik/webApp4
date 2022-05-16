using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }

        //

        public void OnPost(string? login, string? password)
        {
            if (login != null && password != null)
            {
                Message = "Вы авторизовались";
            } else
            {
                Message = "Вы не ввели никаких данных!";
            }
        }
    }
}
