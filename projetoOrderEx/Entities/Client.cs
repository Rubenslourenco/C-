using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoOrderEx.Entities
{
    public class Client
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public Date birthDate { get; set; }

        public Client() { }

        public Client(String name, String email, Date birthDate)
        {
            Name = name;
            Email = email;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return
                "Client: "
                + Name
                + " ("
                + birthDate
                + ") - "
                + Email;
        }
    }
}