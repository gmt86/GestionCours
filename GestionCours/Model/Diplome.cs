using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCours.Model
{
    internal class Diplome
    {
        public string Code { get; set; }
        public string Nom { get; set; }   
        public int Niveau { get; set; } 
       
        public List<Promotion> Promotions { get; set; } = new List<Promotion>();

        public override string ToString()
        {
            return $"{Nom} ({Code})";
        }

    }
}
