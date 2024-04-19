using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBanque
{
    public class CompteBancaire
    {
        #region Propriétés privées de la classe
        private string numCompte;
        private string nomTitulaire;
        public Decimal soldeCompte;
        #endregion
        #region Property = Accesseurs (publiques) aux propriétés
        /// <summary>
        /// Obtient ou définit le numéro du compte bancaire
        /// </summary>
        public string NumCompte 
        { 
            get => numCompte; set => numCompte = value; 
        }
        /// <summary>
        /// Obtient ou définit le nom du titulaire du compte
        /// </summary>
        public string NomTitulaire 
        { 
            get => nomTitulaire; set => nomTitulaire = value; 
        }
        /// <summary>
        /// Obtient le solde du compte bancaire 
        /// </summary>
        public Decimal SoldeCompte 
        {
            get => soldeCompte; 
        }
        #endregion

        #region Constructeurs de la classe
        /// <summary>
        /// Initialise une nouvelle instance de la classe libBanque.CompteBancaire
        /// </summary>
        /// <param name="sonNumero">Le numéro de compte bancaire</param>
        /// <param name="sonTitulaire">Le nom du titulaire du compte : nom + prénom</param>
        /// <remarks>Le solde du compte sera initialisé à 0 </remarks>
        public CompteBancaire(string sonNumero, string sonTitulaire)
        {
            numCompte = sonNumero;
            nomTitulaire = sonTitulaire;
            soldeCompte = 0;
        }
        public CompteBancaire(string sonNumero, string sonTitulaire, Decimal sonsoldeInitial)
        {
            numCompte = sonNumero;
            nomTitulaire = sonTitulaire;
            soldeCompte = sonsoldeInitial;
        }
        public CompteBancaire()
        {

        }

        public bool CrediterCompte(decimal montant)
        {
            throw new NotImplementedException();
        }


        #endregion

    }
}
