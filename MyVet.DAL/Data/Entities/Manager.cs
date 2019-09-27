using System;
using System.Collections.Generic;
using System.Text;

namespace MyVet.DAL.Data.Entities
{
    public class Manager
    {
        public int Id { get; set; }

        public User User { get; set; }
    }
}
