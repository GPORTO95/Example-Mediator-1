using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebMediator.Domain.Commands.Request;
using WebMediator.Domain.Commands.Response;

namespace WebMediator.Domain.Handlers
{
    public class RegisterProductHandler : IRequestHandler<RequestsProduct, ResponsesProduct>
    {
        public Task<ResponsesProduct> Handle(RequestsProduct request, CancellationToken cancellationToken)
        {
            var result = new ResponsesProduct
            {
                Id = Guid.NewGuid(),
                Name = "Iphone XR",
                Price = 4000,
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
