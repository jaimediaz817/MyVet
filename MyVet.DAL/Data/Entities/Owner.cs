using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using MyVet.Web.Data.Entities;

namespace MyVet.DAL.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        public User User { get; set; }

        public ICollection<Pet> Pets { get; set; }

        public ICollection<Agenda> Agendas { get; set; }

        // campos calculados o propiedades de lectura
        /*public string FullNameOld {
            get {
                return $"{FirstName} {LastName}";
            }
        }*/

    }
}
