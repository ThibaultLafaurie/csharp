using BusinessLayer;
using MonTp;
using MonTp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tp1
            try
            {
                MonContexte monContexte = new MonContexte();
                monContexte.Eleves.ToList();
                monContexte.Notes.ToList();
                monContexte.Absences.ToList();
                monContexte.Classes.ToList();

                /*Classe classe = new Classe();
                classe.NomEtablissement = "Lycee Jules Renard";
                classe.Niveau = "STI2D Terminale";
                classe.Eleves = new List<Eleve>();

                Eleve eleve = new Eleve();
                eleve.Nom = "Lafaurie";
                eleve.Prenom = "Thibault";
                eleve.DateNaissance = new DateTime(1998, 10, 24);
                eleve.Classe = classe;
                eleve.ClasseId = classe.ClasseId;

                classe.Eleves.Add(eleve);

                monContexte.Classes.Add(classe);
                monContexte.Eleves.Add(eleve);
                monContexte.SaveChanges();*/
            }
            catch(Exception e)
            {
                throw e;
            }
            #endregion

            #region tp2

            BusinessManager bm = BusinessManager.GetInstance();
            List<Eleve> eleves = bm.GetEleves();

            #endregion
        }
    }
}
