using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp_Concepts.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        _logger.LogInformation("Hello World page accessed at {Time}", DateTime.UtcNow);
    }
}
