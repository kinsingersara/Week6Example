using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OurFirstApp_skinsinger.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

       

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string? Message { get; set; }
        public string? Learn { get; set; }

        public void OnGet()
        {
            Message = $"Hello World {DateTime.Now.ToLongTimeString()}";
            Learn ="I don't really feel like I know a specific thing I'd like to learn " +
                "about Active Server Page Development, just continue to learn and become more fluent."
        }
    }
}