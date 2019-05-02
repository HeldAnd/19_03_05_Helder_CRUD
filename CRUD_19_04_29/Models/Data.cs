using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUD_19_04_29.Models
{
    public class Data: DbContext
    {
        public DbSet<Register> Registers { get; set; }
    }
}