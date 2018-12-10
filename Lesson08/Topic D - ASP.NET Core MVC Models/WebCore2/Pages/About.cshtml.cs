using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebCore2.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public string CurrentTime { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
            CurrentTime = DateTime.Now.ToLongTimeString();
        }
    }
}
