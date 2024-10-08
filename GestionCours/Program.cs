﻿using GestionCours.Model;
using System.Threading.Channels;

namespace GestionCours
{
    internal class Program
    {
        static void Main(string[] args)
        {
          AnnuaireContext context = new AnnuaireContext();
            Console.WriteLine("Liste des diplômes sans promotion...");
            context.Diplomes.Where(d=>d.Promotions.Count() == 0).ToList().ForEach(d=>Console.WriteLine($"- {d}"));
            Console.WriteLine("Nombre d'élève par promotion...");
            context.Promotions.ForEach(p=>Console.WriteLine($"- {p.Nom} : {p.Eleves.Count()} élève(s)"));

            Console.WriteLine("Liste promotion ayant au moins un élève");
            context.Promotions.Where(p =>p.Eleves.Count() >0).ToList().ForEach(p => Console.WriteLine($"- {p.Nom} : {p.Eleves.Count()} élève(s)"));

            Promotion promotionAvecPlusEleve = context.Promotions.OrderByDescending(p =>p.Eleves.Count).FirstOrDefault();
            Console.WriteLine($"Promotion avec plus d'élève : {promotionAvecPlusEleve}");

            Console.WriteLine("Elèves qui ont passé les titre CDA : ");
            //Nb: un élève est rattahé à un diplome et le Diplome est rattaché à une promotion
            context.Eleves.Where(e => e.Promotion.Diplome.Code.Equals("CDA")).ToList().ForEach(e => Console.WriteLine($"- {e}"));


        }
    }
}
