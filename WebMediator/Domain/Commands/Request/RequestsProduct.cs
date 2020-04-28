using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMediator.Domain.Commands.Response;

namespace WebMediator.Domain.Commands.Request
{
    public class RequestsProduct : IRequest<ResponsesProduct>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
