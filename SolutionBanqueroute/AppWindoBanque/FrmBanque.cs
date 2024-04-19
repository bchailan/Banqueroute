using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libBanque;

namespace AppWindoBanque
{
    public partial class FrmBanque : Form
    {
        private AgenceBancaire MonAgence;
        public FrmBanque()
        {
            InitializeComponent();
            InitialiserLaBanque();
        }

        private void InitialiserLaBanque()
        {
            MonAgence = new AgenceBancaire("MENTA");
            lbl_ac_Title.Text = "Agence de " + MonAgence.NomAgence;
            GenererJeuDessai();
           

        }
        
        private void RemplirListeComptes()
        {
            dgv_ListeComptes.DataSource = null;
            dgv_ListeComptes.DataSource = MonAgence.LesComptes;
            
        }
        private void tabAccueil_Enter(object sender, EventArgs e)
        {
            RemplirListeComptes();
        }
        private void GenererJeuDessai()
        {
            CompteBancaire cbPatrick = new CompteBancaire("0211651079JP","M.JANE Patrick",2650.00m);
            CompteBancaire cbTeresa = new CompteBancaire("1231212312LT", "Mle LISBON Teresa", 1500.00m);
            CompteBancaire cbCho = new CompteBancaire("9173826431KC", "M. KIMBALL Cho", 5050.00m);

            MonAgence.AjouterCompte(cbPatrick);
            MonAgence.AjouterCompte(cbTeresa);
            MonAgence.AjouterCompte(cbCho);

        }

       

        private void cbx_co_ChoixCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iCompte = cbx_co_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;
            if (iCompte >= 0)
            {
                leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                tbx_co_Numero.Text = leCompte.NumCompte.ToString();
                tbx_co_Tiulaire.Text = leCompte.NomTitulaire;
                tbx_co_SoldeActuel.Text = leCompte.SoldeCompte.ToString();
            }
        }
        private void cbx_ve_ChoixCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iCompte = cbx_ve_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;
            if (iCompte >= 0)
            {
                leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                tbx_ve_Montant_Crediter.Text = leCompte.SoldeCompte.ToString();
            }
        }
        private void cbx_re_Choix_Compte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iCompte = cbx_re_Choix_Compte.SelectedIndex;
            CompteBancaire leCompte;
            if (iCompte >= 0)
            {
                leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                tbx_re_Debiter.Text = leCompte.SoldeCompte.ToString();
            }
        }
        private void cbx_vi_Choix_Compte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iCompte = cbx_vi_Créditer.SelectedIndex;
            CompteBancaire leCompte;
            if (iCompte >= 0)
            {
                leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                tbx_vi_Montant_Virement.Text = leCompte.SoldeCompte.ToString();
            }
            int iDébiter = cbx_vi_Débiter.SelectedIndex;
            CompteBancaire leDébit;
            if (iDébiter >= 0)
            {
                leDébit = MonAgence.LesComptes.ElementAt(iDébiter);
                tbx_vi_Montant_Virement.Text = leDébit.SoldeCompte.ToString();
            }

        }

        private void tabConsulation_Enter(object sender, EventArgs e)
        {
            RemplirCombobox(cbx_co_ChoixCompte);
        }

        private void RemplirCombobox(ComboBox laCombo)
        {
            laCombo.Items.Clear();
            foreach (CompteBancaire unCompte in MonAgence.LesComptes)
            {
                laCombo.Items.Add(unCompte.NumCompte + "(" + unCompte.NomTitulaire + ")");
            }
        }

        private void tabAccueil_Click(object sender, EventArgs e)
        {

        }

        private void tabVirement_Click(object sender, EventArgs e)
        {

        }

        private void btn_Creer_Click(object sender, EventArgs e)
        {
            string numero = tbx_cr_Numero.Text;
            string titulaire = tbx_cr_Titulaire.Text;
            string soldeString = tbx_cr_SoldeInitial.Text;
            decimal soldeDecimal;
            
            if(Decimal.TryParse(soldeString, out soldeDecimal))
            {
                CompteBancaire cb = new CompteBancaire(numero, titulaire, soldeDecimal);
                MonAgence.AjouterCompte(cb);
                lbl_cr_Message.Text = "Le compte de" + titulaire + "a bien été créé !";
                lbl_cr_Message.ForeColor = Color.Green;
            }
            else
            {
                lbl_cr_Message.Text = "Valeur incorect pour le solde initial";
                lbl_cr_Message.ForeColor = Color.Red;
            }
           
        }
        private decimal RecupererMontant(TextBox leTextBox)
        {
            decimal montant;
            try
            {
                montant = decimal.Parse(leTextBox.Text);
            }
            catch
            {
                montant = -1.0m;
            }
            return (montant);
        }

        private void btn_re_Enregistrer_Click(object sender, EventArgs e)
        {
            string message = "Le versement a bien été enregistré !";
            int iCompte = cbx_re_Choix_Compte.SelectedIndex;
            CompteBancaire leCompte;
            decimal montant = RecupererMontant(tbx_re_Debiter);
            if (iCompte >= 0)
            {
                if (montant > 0)
                {
                    leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                    if (!leCompte.CrediterCompte(montant))
                        message = "le débit n'a pas pu s'effectuer pour cause de montant incorrect.";
                }
            }
            else
            {
                message = "Le débit n'a pas pu être effectué parce que vous n'avez pas sélectionné le compte à créditer ! ";
            }
            lbl_ve_Message.Text = message;
            if (message == "Le débit a bien été enregistré !")
                lbl_re_Message.ForeColor = Color.Green;
            else
                lbl_re_Message.ForeColor = Color.Red;
        }

        private void btn_ve_Enregsitrer_Click(object sender, EventArgs e)
        {
            string message = "Le versement a bien été enregistré !";
            int iCompte = cbx_co_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;
            decimal montant = RecupererMontant(tbx_ve_Montant_Crediter);
            if (iCompte >= 0)
            {
                if (montant > 0)
                {
                    leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                    if (!leCompte.CrediterCompte(montant))
                        message = "le virement n'a pas pu s'effectuer pour cause de montant incorrect.";
                }
            }
            else
            {
                message = "Le virement n'a pas pu être effectué parce que vous n'avez pas sélectionné le compte à créditer ! ";
            }
            lbl_ve_Message.Text = message;
            if (message == "Le versement a bien été enregistré !")
                lbl_ve_Message.ForeColor = Color.Green;
            else
                lbl_ve_Message.ForeColor = Color.Red;
        }

        private void btn_vi_Enregistrer_Click(object sender, EventArgs e)
        {
            string message = "Le crédit a bien été enregistré !";
            int iCompte = cbx_vi_Créditer.SelectedIndex;
            CompteBancaire leCompte;
            decimal montant = RecupererMontant(tbx_ve_Montant_Crediter);
            if (iCompte >= 0)
            {
                if (montant > 0)
                {
                    leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                    if (!leCompte.CrediterCompte(montant))
                        message = "le Crédit n'a pas pu s'effectuer pour cause de montant incorrect.";
                }
            }
            else
            {
                message = "Le Crédit n'a pas pu être effectué parce que vous n'avez pas sélectionné le compte à créditer ! ";
            }
            lbl_ve_Message.Text = message;
            if (message == "Le versement a bien été enregistré !")
                lbl_vi_Message.ForeColor = Color.Green;
            else
                lbl_vi_Message.ForeColor = Color.Red;
        }

        private void NettoyerOnglet(TabPage unOnglet)
        {
            switch (unOnglet.Name)
            {
                case "tabCreation":
                    tbx_cr_Numero.Text = ""; tbx_cr_SoldeInitial.Text = "";
                    tbx_cr_Titulaire.Text = ""; lbl_cr_Message.Text = "";
                    break;

                case "tabConsultation":
                    cbx_co_ChoixCompte.Text = ""; tbx_co_Numero.Text = "";
                    tbx_co_Tiulaire.Text = ""; tbx_co_SoldeActuel.Text = "";
                    break;

                case "tabVersement":
                    tbx_ve_Montant_Crediter.Text = ""; cbx_ve_ChoixCompte.Text = "";
                    lbl_ve_Message.Text = "";
                    break;

                case "tabRetrait":
                    tbx_re_Debiter.Text = ""; cbx_re_Choix_Compte.Text = "";
                    lbl_re_Message.Text = "";
                    break;

                case "tabVirement":
                    tbx_vi_Montant_Virement.Text = "";
                    cbx_vi_Créditer.Text = "";
                    cbx_vi_Débiter.Text = "";
                    lbl_vi_Message.Text = "";
                    break;
            }
        }








        //Méthode Vide générale
        private void FrmBanque_Load(object sender, EventArgs e)
        {

        }

        //Méthode Vide Accueil
        private void lbl_ac_Title_Click(object sender, EventArgs e)
        {

        }
        private void lbl_ac_liste_Click(object sender, EventArgs e)
        {

        }


        //Méthode Vide Consultation 
        private void lbl_co_Choix_Click(object sender, EventArgs e)
        {

        }

        private void lbl_co_Num_Click(object sender, EventArgs e)
        {

        }

        private void lbl_co_Tit_Click(object sender, EventArgs e)
        {

        }

        private void lbl_co_Solde_Click(object sender, EventArgs e)
        {

        }

        private void tbx_co_Numero_TextChanged(object sender, EventArgs e)
        {

        }



        //Méthode Vide Création
        private void tabCréation_Click(object sender, EventArgs e)
        {

        }
        private void tbx_cr_Numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_cr_Titulaire_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbx_cr_SoldeInitial_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbl_cr_Message_Click(object sender, EventArgs e)
        {

        }
        private void btn_cr_Annuler_Click(object sender, EventArgs e)
        {

        }




        //Méthode Vide Versement
        private void tabVersement_Click(object sender, EventArgs e)
        {
        }
        private void lbl_ve_Title_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ve_Montant_Crediter_Click(object sender, EventArgs e)
        {

        }

        private void tbx_ve_Montant_Crediter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ve_Annuler_Click(object sender, EventArgs e)
        {
   
        }

        private void lbl_ve_Message_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ve_Compte_Crediter_Click(object sender, EventArgs e)
        {

        }




        //Méthode Vide Retrait
        private void tabRetrait_Click(object sender, EventArgs e)
        {

        }

        private void lbl_re_Choix_Compte_Click(object sender, EventArgs e)
        {

        }

        private void lbl_re_Montant_Débiter_Click(object sender, EventArgs e)
        {

        }

        private void tbx_re_Debiter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_re_Annuler_Click(object sender, EventArgs e)
        {

        }

        private void lbl_re_Message_Click(object sender, EventArgs e)
        {

        }


        //Méthode Vide Virement

        private void lbl_vi_Message_Click(object sender, EventArgs e)
        {

        }

        private void lbl_vi_Débiter_Click(object sender, EventArgs e)
        {

        }

        private void lbl_vi_Créditer_Click(object sender, EventArgs e)
        {

        }

        private void lbl_vi_Montant_Virement_Click(object sender, EventArgs e)
        {

        }

        private void btn_vi_Annuler_Click(object sender, EventArgs e)
        {

        }

        private void tbx_vi_Montant_Virement_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_ListeComptes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
