using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBanque
{
    public class AgenceBancaire
    {
        private List<CompteBancaire> lesComptes;
        private string nomAgence;
        public List<CompteBancaire> LesComptes
        {
            get { return lesComptes; }
        }
        public string NomAgence
        {
            get { return nomAgence; }
            set { nomAgence = value; }
        }
        public int NombreComptes
        {
            get { return lesComptes.Count; }
        }
        public AgenceBancaire (string sonNom)
        {
            lesComptes = new List<CompteBancaire>();
            nomAgence = sonNom;
        }
        public void AjouterCompte(CompteBancaire unCompte)
        {
            lesComptes.Add(unCompte);
        }
        public void Supprimer(CompteBancaire unCompte)
        {
            lesComptes.Remove(unCompte);
        }
    }
}
