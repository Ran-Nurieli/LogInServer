using LogInServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogInServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private LoginDemoDbContext context;


        public LogInController(LoginDemoDbContext context)
        {
            this.context = context;
        }

    }
}
