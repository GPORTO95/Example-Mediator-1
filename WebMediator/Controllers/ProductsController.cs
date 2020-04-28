using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMediator.Domain.Commands.Request;
using WebMediator.Domain.Commands.Response;

namespace WebMediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public async Task<ResponsesProduct> Register
            ([FromServices] IMediator mediator, [FromBody] RequestsProduct request)
        {
            return await mediator.Send(request);
        }
    }
}