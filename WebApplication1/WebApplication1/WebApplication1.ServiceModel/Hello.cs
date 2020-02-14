using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace WebApplication1.ServiceModel
{
    [Route("/hello")]
    public class Hello : IReturn<bool>
    {
        public object Name { get; set; }
    }
}