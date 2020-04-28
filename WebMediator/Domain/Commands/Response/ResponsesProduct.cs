using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMediator.Domain.Commands.Response
{
    public class ResponsesProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
