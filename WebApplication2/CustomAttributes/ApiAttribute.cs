using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Method)]
    public class ApiAttribute:Attribute

    {
        public ApiAttribute()
        {
            var keyvalue = "Test values";
        }
    }
}
