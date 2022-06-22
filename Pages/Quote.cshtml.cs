using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class QuoteModel : PageModel
{
    private readonly ILogger<QuoteModel> _logger;

    public QuoteModel(ILogger<QuoteModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

