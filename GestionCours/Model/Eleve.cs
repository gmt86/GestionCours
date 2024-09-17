using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCours.Model
{
    internal class Eleve
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string Email { get; set; }   
               
        public string Address { get; set; } 

        public string Ville { get; set; }

        public string CodePostal { get; set; }  

        public Promotion Promotion { get; set; }

        public override string ToString()
        {
            return $"{Prenom} {Nom} ";
        }
    }
}
