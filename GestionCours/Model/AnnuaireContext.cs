using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCours.Model
{
        
    internal class AnnuaireContext
    {
        public List<Diplome> Diplomes { get; } = new List<Diplome>();
        public List<Promotion> Promotions { get; } = new List<Promotion>();
        public List<Eleve> Eleves { get; } = new List<Eleve>();

        public AnnuaireContext() 
        { 
            Diplome TSSR = new Diplome { Code="TSSR",Nom="Technicien Supérieur Système et Réseau ",Niveau=5 };
            Diplome D2WM = new Diplome { Code = "D2WM", Nom = "Développeur Web et Web Mobile ", Niveau = 5 };
            Diplome ASR = new Diplome { Code = "ASR", Nom = "Administrateur Système et Réseau ", Niveau = 6 };
            Diplome CDA = new Diplome { Code = "CDA", Nom = "Concepteur Développeur d'Application ", Niveau = 6 };
            Diplome ESD = new Diplome { Code = "ESD", Nom = "Expert en Sécurité Digitale ", Niveau = 7 };
            Diplome MS2D = new Diplome { Code = "MS2D", Nom = "Manager de Solutions Digitales et Data ", Niveau = 7 };
            Diplomes.Add(TSSR);
            Diplomes.Add(D2WM);
            Diplomes.Add(ASR);
            Diplomes.Add(CDA);
            Diplomes.Add(ESD);  
            Diplomes.Add(MS2D);

            Promotion NCDA_006 = new Promotion { Id = 1, Nom = "NCDA_006", DateDebut = DateTime.Parse("17/10/2019", new CultureInfo("fr-FR")), DateFin = DateTime.Parse("27/08/2021", new CultureInfo("fr-FR")),Diplome=CDA };
            Promotion NCDA_007 = new Promotion { Id = 2, Nom = "NCDA_007", DateDebut = DateTime.Parse("12/10/2020", new CultureInfo("fr-FR")), DateFin = DateTime.Parse("26/08/2022", new CultureInfo("fr-FR")), Diplome = CDA };
            Promotion NCDA_008 = new Promotion { Id = 3, Nom = "NCDA_008", DateDebut = DateTime.Parse("11/10/2021", new CultureInfo("fr-FR")), DateFin = DateTime.Parse("14/07/2023", new CultureInfo("fr-FR")), Diplome = CDA };
            Promotion NASR_008 = new Promotion { Id = 4, Nom = "NASR_008", DateDebut = DateTime.Parse("11/10/2021", new CultureInfo("fr-FR")), DateFin = DateTime.Parse("14/07/2023", new CultureInfo("fr-FR")), Diplome = ASR };
            Promotion MS2D_001 = new Promotion { Id = 5, Nom = "MS2D_001", DateDebut = DateTime.Parse("11/10/2021", new CultureInfo("fr-FR")), DateFin = DateTime.Parse("15/10/2022", new CultureInfo("fr-FR")), Diplome = MS2D };
            Promotion NESD_001 = new Promotion { Id = 6, Nom = "NESD_001", DateDebut = DateTime.Parse("04/10/2021", new CultureInfo("fr-FR")), DateFin = DateTime.Parse("7/10/2022", new CultureInfo("fr-FR")), Diplome = ESD };
            Promotions.Add(NCDA_006);
            Promotions.Add(NCDA_007);
            Promotions.Add(NCDA_008);
            Promotions.Add(NASR_008);
            Promotions.Add (NESD_001 );
            Promotions.Add(MS2D_001);
            ASR.Promotions.AddRange( Promotions.Where(p => p.Diplome.Equals(ASR)).ToList());
            CDA.Promotions.AddRange(Promotions.Where(p => p.Diplome.Equals(CDA)).ToList());
            ESD.Promotions.AddRange(Promotions.Where(p => p.Diplome.Equals(ESD)).ToList());
            MS2D.Promotions.AddRange(Promotions.Where(p => p.Diplome.Equals(MS2D)).ToList());


            Eleve AMartin = new Eleve { Id = 1, Nom = "Martin", Prenom = "Alexis", Address = "19 Avenue Leo", CodePostal = "79000", Ville = "Paris", Promotion = NCDA_007 };
            Eleve BDupont = new Eleve { Id = 2, Nom = "Dupont", Prenom = "javier", Address = "19 Avenue Leo", CodePostal = "79000", Ville = "Lion", Promotion = NCDA_007 };
            Eleve CColin = new Eleve { Id = 3, Nom = "Colin", Prenom = "Claire", Address = "19 Avenue Leo", CodePostal = "79000", Ville = "marseille", Promotion = NCDA_008 };
            Eleve DAubin = new Eleve { Id = 4, Nom = "Aubin", Prenom = "Tonn", Address = "192 Avenue vienne", CodePostal = "79000", Ville = "Paris", Promotion = NCDA_008 };
            Eleve ECarelle = new Eleve { Id = 5, Nom = "Carelle", Prenom = "Chess", Address = "119 Avenue rom", CodePostal = "79000", Ville = "Sens", Promotion = NCDA_008 };
            Eleve FEsther = new Eleve { Id = 6, Nom = "Esther", Prenom = "Maelle", Address = "18 Avenue man", CodePostal = "79000", Ville = "Paris", Promotion = NESD_001 };
            Eleve GMax = new Eleve { Id = 7, Nom = "Max", Prenom = "Xavier", Address = "18 Avenue texas", CodePostal = "79000", Ville = "Paris", Promotion = MS2D_001 };


            NCDA_007.Eleves.Add(AMartin);
            NCDA_007.Eleves.Add(BDupont);
            NCDA_008.Eleves.Add(CColin);
            NCDA_008.Eleves.Add(DAubin);
            NCDA_008.Eleves.Add(ECarelle);
            NESD_001.Eleves.Add(FEsther);
            MS2D_001.Eleves.Add(GMax);

            Eleves.Add(AMartin);
            Eleves.Add(BDupont);
            Eleves.Add(CColin);
            Eleves.Add(DAubin);
            Eleves.Add(ECarelle);
            Eleves.Add(FEsther);
            Eleves.Add(GMax);

        }    

    }
}
