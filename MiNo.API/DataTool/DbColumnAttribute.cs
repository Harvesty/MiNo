using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiNo.API
{
    public class DbColumnAttribute:Attribute
    {
        public string Name { get; private set; }
        public DbColumnAttribute(string name)
        {
            this.Name = name;
        }
    }
}