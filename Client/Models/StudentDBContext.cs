using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class StudentDBContext: DbContext
    {
        public StudentDBContext(string connString)
           : base(connString)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}