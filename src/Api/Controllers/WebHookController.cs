namespace Api.Controllers
{
  using System.Threading;

  using Api.Models;

  using Microsoft.AspNetCore.Mvc;
  
  public sealed class WebHookController : Controller
  {
    [HttpPost("/")]
    public IActionResult ReceiveMessageAsync([FromBody] Message message,
                                             CancellationToken cancellationToken)
    {
      return this.NoContent();
    }
  }
}  