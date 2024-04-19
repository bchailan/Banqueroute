
namespace AppWindoBanque
{
    partial class FrmBanque
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_cr_Message = new System.Windows.Forms.Label();
            this.tab_OngletsApplication = new System.Windows.Forms.TabControl();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.lbl_ac_liste = new System.Windows.Forms.Label();
            this.lbl_ac_Title = new System.Windows.Forms.Label();
            this.dgv_ListeComptes = new System.Windows.Forms.DataGridView();
            this.tabConsulation = new System.Windows.Forms.TabPage();
            this.lbl_co_Tit = new System.Windows.Forms.Label();
            this.lbl_co_Solde = new System.Windows.Forms.Label();
            this.lbl_co_Num = new System.Windows.Forms.Label();
            this.lbl_co_Choix = new System.Windows.Forms.Label();
            this.tbx_co_SoldeActuel = new System.Windows.Forms.TextBox();
            this.tbx_co_Numero = new System.Windows.Forms.TextBox();
            this.tbx_co_Tiulaire = new System.Windows.Forms.TextBox();
            this.cbx_co_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.lbl_co_Title = new System.Windows.Forms.Label();
            this.tabCréation = new System.Windows.Forms.TabPage();
            this.lbl_cr_Title = new System.Windows.Forms.Label();
            this.btn_cr_Annuler = new System.Windows.Forms.Button();
            this.btn_Creer = new System.Windows.Forms.Button();
            this.tbx_cr_SoldeInitial = new System.Windows.Forms.TextBox();
            this.tbx_cr_Titulaire = new System.Windows.Forms.TextBox();
            this.tbx_cr_Numero = new System.Windows.Forms.TextBox();
            this.lbl_cr_Solde = new System.Windows.Forms.Label();
            this.lbl_cr_Numero = new System.Windows.Forms.Label();
            this.lbl_cr_Titulaire = new System.Windows.Forms.Label();
            this.tabVersement = new System.Windows.Forms.TabPage();
            this.lbl_ve_Compte_Crediter = new System.Windows.Forms.Label();
            this.lbl_ve_Message = new System.Windows.Forms.Label();
            this.btn_ve_Annuler = new System.Windows.Forms.Button();
            this.btn_ve_Enregsitrer = new System.Windows.Forms.Button();
            this.tbx_ve_Montant_Crediter = new System.Windows.Forms.TextBox();
            this.cbx_ve_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.lbl_ve_Montant_Crediter = new System.Windows.Forms.Label();
            this.lbl_ve_Title = new System.Windows.Forms.Label();
            this.tabRetrait = new System.Windows.Forms.TabPage();
            this.lbl_re_Message = new System.Windows.Forms.Label();
            this.btn_re_Annuler = new System.Windows.Forms.Button();
            this.btn_re_Enregistrer = new System.Windows.Forms.Button();
            this.cbx_re_Choix_Compte = new System.Windows.Forms.ComboBox();
            this.tbx_re_Debiter = new System.Windows.Forms.TextBox();
            this.lbl_re_Montant_Débiter = new System.Windows.Forms.Label();
            this.lbl_re_Choix_Compte = new System.Windows.Forms.Label();
            this.lbl_re_Title = new System.Windows.Forms.Label();
            this.tabVirement = new System.Windows.Forms.TabPage();
            this.btn_vi_Annuler = new System.Windows.Forms.Button();
            this.btn_vi_Enregistrer = new System.Windows.Forms.Button();
            this.tbx_vi_Montant_Virement = new System.Windows.Forms.TextBox();
            this.cbx_vi_Créditer = new System.Windows.Forms.ComboBox();
            this.cbx_vi_Débiter = new System.Windows.Forms.ComboBox();
            this.lbl_vi_Message = new System.Windows.Forms.Label();
            this.lbl_vi_Montant_Virement = new System.Windows.Forms.Label();
            this.lbl_vi_Créditer = new System.Windows.Forms.Label();
            this.lbl_vi_Débiter = new System.Windows.Forms.Label();
            this.lbl_vi_Title = new System.Windows.Forms.Label();
            this.tab_OngletsApplication.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeComptes)).BeginInit();
            this.tabConsulation.SuspendLayout();
            this.tabCréation.SuspendLayout();
            this.tabVersement.SuspendLayout();
            this.tabRetrait.SuspendLayout();
            this.tabVirement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cr_Message
            // 
            this.lbl_cr_Message.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_cr_Message.Location = new System.Drawing.Point(81, 313);
            this.lbl_cr_Message.Name = "lbl_cr_Message";
            this.lbl_cr_Message.Size = new System.Drawing.Size(0, 17);
            this.lbl_cr_Message.TabIndex = 0;
            this.lbl_cr_Message.Text = "                                  ";
            this.lbl_cr_Message.Click += new System.EventHandler(this.lbl_cr_Message_Click);
            // 
            // tab_OngletsApplication
            // 
            this.tab_OngletsApplication.Controls.Add(this.tabAccueil);
            this.tab_OngletsApplication.Controls.Add(this.tabConsulation);
            this.tab_OngletsApplication.Controls.Add(this.tabCréation);
            this.tab_OngletsApplication.Controls.Add(this.tabVersement);
            this.tab_OngletsApplication.Controls.Add(this.tabRetrait);
            this.tab_OngletsApplication.Controls.Add(this.tabVirement);
            this.tab_OngletsApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_OngletsApplication.Location = new System.Drawing.Point(0, 0);
            this.tab_OngletsApplication.Name = "tab_OngletsApplication";
            this.tab_OngletsApplication.SelectedIndex = 0;
            this.tab_OngletsApplication.Size = new System.Drawing.Size(800, 450);
            this.tab_OngletsApplication.TabIndex = 0;
            // 
            // tabAccueil
            // 
            this.tabAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabAccueil.Controls.Add(this.lbl_ac_liste);
            this.tabAccueil.Controls.Add(this.lbl_ac_Title);
            this.tabAccueil.Controls.Add(this.dgv_ListeComptes);
            this.tabAccueil.Location = new System.Drawing.Point(4, 25);
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccueil.Size = new System.Drawing.Size(792, 421);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            this.tabAccueil.UseVisualStyleBackColor = true;
            this.tabAccueil.Click += new System.EventHandler(this.tabAccueil_Click);
            // 
            // lbl_ac_liste
            // 
            this.lbl_ac_liste.AutoSize = true;
            this.lbl_ac_liste.Location = new System.Drawing.Point(8, 141);
            this.lbl_ac_liste.Name = "lbl_ac_liste";
            this.lbl_ac_liste.Size = new System.Drawing.Size(203, 17);
            this.lbl_ac_liste.TabIndex = 5;
            this.lbl_ac_liste.Text = "Liste des comptes de l’agence ";
            this.lbl_ac_liste.Click += new System.EventHandler(this.lbl_ac_liste_Click);
            // 
            // lbl_ac_Title
            // 
            this.lbl_ac_Title.AutoSize = true;
            this.lbl_ac_Title.Location = new System.Drawing.Point(355, 55);
            this.lbl_ac_Title.Name = "lbl_ac_Title";
            this.lbl_ac_Title.Size = new System.Drawing.Size(0, 17);
            this.lbl_ac_Title.TabIndex = 4;
            this.lbl_ac_Title.Click += new System.EventHandler(this.lbl_ac_Title_Click);
            // 
            // dgv_ListeComptes
            // 
            this.dgv_ListeComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeComptes.Location = new System.Drawing.Point(11, 172);
            this.dgv_ListeComptes.Name = "dgv_ListeComptes";
            this.dgv_ListeComptes.RowHeadersWidth = 51;
            this.dgv_ListeComptes.RowTemplate.Height = 24;
            this.dgv_ListeComptes.Size = new System.Drawing.Size(773, 228);
            this.dgv_ListeComptes.TabIndex = 3;
            this.dgv_ListeComptes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListeComptes_CellContentClick);
            // 
            // tabConsulation
            // 
            this.tabConsulation.Controls.Add(this.lbl_co_Tit);
            this.tabConsulation.Controls.Add(this.lbl_co_Solde);
            this.tabConsulation.Controls.Add(this.lbl_co_Num);
            this.tabConsulation.Controls.Add(this.lbl_co_Choix);
            this.tabConsulation.Controls.Add(this.tbx_co_SoldeActuel);
            this.tabConsulation.Controls.Add(this.tbx_co_Numero);
            this.tabConsulation.Controls.Add(this.tbx_co_Tiulaire);
            this.tabConsulation.Controls.Add(this.cbx_co_ChoixCompte);
            this.tabConsulation.Controls.Add(this.lbl_co_Title);
            this.tabConsulation.Location = new System.Drawing.Point(4, 25);
            this.tabConsulation.Name = "tabConsulation";
            this.tabConsulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulation.Size = new System.Drawing.Size(792, 421);
            this.tabConsulation.TabIndex = 1;
            this.tabConsulation.Text = "Consultation";
            this.tabConsulation.UseVisualStyleBackColor = true;
            // 
            // lbl_co_Tit
            // 
            this.lbl_co_Tit.AutoSize = true;
            this.lbl_co_Tit.Location = new System.Drawing.Point(95, 247);
            this.lbl_co_Tit.Name = "lbl_co_Tit";
            this.lbl_co_Tit.Size = new System.Drawing.Size(131, 17);
            this.lbl_co_Tit.TabIndex = 8;
            this.lbl_co_Tit.Text = "Titulaire du Compte";
            this.lbl_co_Tit.Click += new System.EventHandler(this.lbl_co_Tit_Click);
            // 
            // lbl_co_Solde
            // 
            this.lbl_co_Solde.AutoSize = true;
            this.lbl_co_Solde.Location = new System.Drawing.Point(95, 275);
            this.lbl_co_Solde.Name = "lbl_co_Solde";
            this.lbl_co_Solde.Size = new System.Drawing.Size(156, 17);
            this.lbl_co_Solde.TabIndex = 7;
            this.lbl_co_Solde.Text = "Solde actuel du compte";
            this.lbl_co_Solde.Click += new System.EventHandler(this.lbl_co_Solde_Click);
            // 
            // lbl_co_Num
            // 
            this.lbl_co_Num.AutoSize = true;
            this.lbl_co_Num.Location = new System.Drawing.Point(96, 219);
            this.lbl_co_Num.Name = "lbl_co_Num";
            this.lbl_co_Num.Size = new System.Drawing.Size(130, 17);
            this.lbl_co_Num.TabIndex = 6;
            this.lbl_co_Num.Text = "Numéro du Compte";
            this.lbl_co_Num.Click += new System.EventHandler(this.lbl_co_Num_Click);
            // 
            // lbl_co_Choix
            // 
            this.lbl_co_Choix.AutoSize = true;
            this.lbl_co_Choix.Location = new System.Drawing.Point(96, 143);
            this.lbl_co_Choix.Name = "lbl_co_Choix";
            this.lbl_co_Choix.Size = new System.Drawing.Size(121, 17);
            this.lbl_co_Choix.TabIndex = 5;
            this.lbl_co_Choix.Text = "Choisir un compte";
            this.lbl_co_Choix.Click += new System.EventHandler(this.lbl_co_Choix_Click);
            // 
            // tbx_co_SoldeActuel
            // 
            this.tbx_co_SoldeActuel.Location = new System.Drawing.Point(257, 272);
            this.tbx_co_SoldeActuel.Name = "tbx_co_SoldeActuel";
            this.tbx_co_SoldeActuel.Size = new System.Drawing.Size(376, 22);
            this.tbx_co_SoldeActuel.TabIndex = 4;
            // 
            // tbx_co_Numero
            // 
            this.tbx_co_Numero.Location = new System.Drawing.Point(257, 216);
            this.tbx_co_Numero.Name = "tbx_co_Numero";
            this.tbx_co_Numero.Size = new System.Drawing.Size(376, 22);
            this.tbx_co_Numero.TabIndex = 3;
            // 
            // tbx_co_Tiulaire
            // 
            this.tbx_co_Tiulaire.Location = new System.Drawing.Point(257, 244);
            this.tbx_co_Tiulaire.Name = "tbx_co_Tiulaire";
            this.tbx_co_Tiulaire.Size = new System.Drawing.Size(376, 22);
            this.tbx_co_Tiulaire.TabIndex = 2;
            // 
            // cbx_co_ChoixCompte
            // 
            this.cbx_co_ChoixCompte.FormattingEnabled = true;
            this.cbx_co_ChoixCompte.Location = new System.Drawing.Point(257, 143);
            this.cbx_co_ChoixCompte.Name = "cbx_co_ChoixCompte";
            this.cbx_co_ChoixCompte.Size = new System.Drawing.Size(121, 24);
            this.cbx_co_ChoixCompte.TabIndex = 1;
            this.cbx_co_ChoixCompte.SelectedIndexChanged += new System.EventHandler(this.cbx_co_ChoixCompte_SelectedIndexChanged);
            this.cbx_co_ChoixCompte.Enter += new System.EventHandler(this.tabConsulation_Enter);
            // 
            // lbl_co_Title
            // 
            this.lbl_co_Title.AutoSize = true;
            this.lbl_co_Title.Location = new System.Drawing.Point(254, 68);
            this.lbl_co_Title.Name = "lbl_co_Title";
            this.lbl_co_Title.Size = new System.Drawing.Size(156, 17);
            this.lbl_co_Title.TabIndex = 0;
            this.lbl_co_Title.Text = "Consultation de compte";
            // 
            // tabCréation
            // 
            this.tabCréation.Controls.Add(this.lbl_cr_Title);
            this.tabCréation.Controls.Add(this.btn_cr_Annuler);
            this.tabCréation.Controls.Add(this.btn_Creer);
            this.tabCréation.Controls.Add(this.tbx_cr_SoldeInitial);
            this.tabCréation.Controls.Add(this.tbx_cr_Titulaire);
            this.tabCréation.Controls.Add(this.tbx_cr_Numero);
            this.tabCréation.Controls.Add(this.lbl_cr_Solde);
            this.tabCréation.Controls.Add(this.lbl_cr_Numero);
            this.tabCréation.Controls.Add(this.lbl_cr_Titulaire);
            this.tabCréation.Controls.Add(this.lbl_cr_Message);
            this.tabCréation.Location = new System.Drawing.Point(4, 25);
            this.tabCréation.Name = "tabCréation";
            this.tabCréation.Size = new System.Drawing.Size(792, 421);
            this.tabCréation.TabIndex = 2;
            this.tabCréation.Text = "Création";
            this.tabCréation.UseVisualStyleBackColor = true;
            this.tabCréation.Click += new System.EventHandler(this.tabCréation_Click);
            // 
            // lbl_cr_Title
            // 
            this.lbl_cr_Title.AutoSize = true;
            this.lbl_cr_Title.Location = new System.Drawing.Point(240, 69);
            this.lbl_cr_Title.Name = "lbl_cr_Title";
            this.lbl_cr_Title.Size = new System.Drawing.Size(144, 17);
            this.lbl_cr_Title.TabIndex = 9;
            this.lbl_cr_Title.Text = "Création d\'un Compte";
            // 
            // btn_cr_Annuler
            // 
            this.btn_cr_Annuler.BackColor = System.Drawing.Color.Red;
            this.btn_cr_Annuler.Location = new System.Drawing.Point(654, 339);
            this.btn_cr_Annuler.Name = "btn_cr_Annuler";
            this.btn_cr_Annuler.Size = new System.Drawing.Size(85, 29);
            this.btn_cr_Annuler.TabIndex = 8;
            this.btn_cr_Annuler.Text = "Annuler";
            this.btn_cr_Annuler.UseVisualStyleBackColor = false;
            this.btn_cr_Annuler.Click += new System.EventHandler(this.btn_cr_Annuler_Click);
            // 
            // btn_Creer
            // 
            this.btn_Creer.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_Creer.ForeColor = System.Drawing.Color.Black;
            this.btn_Creer.Location = new System.Drawing.Point(654, 292);
            this.btn_Creer.Name = "btn_Creer";
            this.btn_Creer.Size = new System.Drawing.Size(85, 28);
            this.btn_Creer.TabIndex = 7;
            this.btn_Creer.Text = "Créer";
            this.btn_Creer.UseVisualStyleBackColor = false;
            this.btn_Creer.Click += new System.EventHandler(this.btn_Creer_Click);
            // 
            // tbx_cr_SoldeInitial
            // 
            this.tbx_cr_SoldeInitial.Location = new System.Drawing.Point(243, 251);
            this.tbx_cr_SoldeInitial.Name = "tbx_cr_SoldeInitial";
            this.tbx_cr_SoldeInitial.Size = new System.Drawing.Size(376, 22);
            this.tbx_cr_SoldeInitial.TabIndex = 6;
            this.tbx_cr_SoldeInitial.TextChanged += new System.EventHandler(this.tbx_cr_SoldeInitial_TextChanged);
            // 
            // tbx_cr_Titulaire
            // 
            this.tbx_cr_Titulaire.Location = new System.Drawing.Point(243, 209);
            this.tbx_cr_Titulaire.Name = "tbx_cr_Titulaire";
            this.tbx_cr_Titulaire.Size = new System.Drawing.Size(376, 22);
            this.tbx_cr_Titulaire.TabIndex = 5;
            this.tbx_cr_Titulaire.TextChanged += new System.EventHandler(this.tbx_cr_Titulaire_TextChanged);
            // 
            // tbx_cr_Numero
            // 
            this.tbx_cr_Numero.Location = new System.Drawing.Point(243, 160);
            this.tbx_cr_Numero.Name = "tbx_cr_Numero";
            this.tbx_cr_Numero.Size = new System.Drawing.Size(376, 22);
            this.tbx_cr_Numero.TabIndex = 4;
            this.tbx_cr_Numero.TextChanged += new System.EventHandler(this.tbx_cr_Numero_TextChanged);
            // 
            // lbl_cr_Solde
            // 
            this.lbl_cr_Solde.AutoSize = true;
            this.lbl_cr_Solde.Location = new System.Drawing.Point(81, 251);
            this.lbl_cr_Solde.Name = "lbl_cr_Solde";
            this.lbl_cr_Solde.Size = new System.Drawing.Size(150, 17);
            this.lbl_cr_Solde.TabIndex = 3;
            this.lbl_cr_Solde.Text = "Solde initial du compte";
            // 
            // lbl_cr_Numero
            // 
            this.lbl_cr_Numero.AutoSize = true;
            this.lbl_cr_Numero.Location = new System.Drawing.Point(81, 160);
            this.lbl_cr_Numero.Name = "lbl_cr_Numero";
            this.lbl_cr_Numero.Size = new System.Drawing.Size(128, 17);
            this.lbl_cr_Numero.TabIndex = 2;
            this.lbl_cr_Numero.Text = "Numéro du compte";
            // 
            // lbl_cr_Titulaire
            // 
            this.lbl_cr_Titulaire.AutoSize = true;
            this.lbl_cr_Titulaire.Location = new System.Drawing.Point(81, 209);
            this.lbl_cr_Titulaire.Name = "lbl_cr_Titulaire";
            this.lbl_cr_Titulaire.Size = new System.Drawing.Size(129, 17);
            this.lbl_cr_Titulaire.TabIndex = 1;
            this.lbl_cr_Titulaire.Text = "Titulaire du compte";
            // 
            // tabVersement
            // 
            this.tabVersement.Controls.Add(this.lbl_ve_Compte_Crediter);
            this.tabVersement.Controls.Add(this.lbl_ve_Message);
            this.tabVersement.Controls.Add(this.btn_ve_Annuler);
            this.tabVersement.Controls.Add(this.btn_ve_Enregsitrer);
            this.tabVersement.Controls.Add(this.tbx_ve_Montant_Crediter);
            this.tabVersement.Controls.Add(this.cbx_ve_ChoixCompte);
            this.tabVersement.Controls.Add(this.lbl_ve_Montant_Crediter);
            this.tabVersement.Controls.Add(this.lbl_ve_Title);
            this.tabVersement.Location = new System.Drawing.Point(4, 25);
            this.tabVersement.Name = "tabVersement";
            this.tabVersement.Size = new System.Drawing.Size(792, 421);
            this.tabVersement.TabIndex = 3;
            this.tabVersement.Text = "Versement";
            this.tabVersement.UseVisualStyleBackColor = true;
            this.tabVersement.Click += new System.EventHandler(this.tabVersement_Click);
            // 
            // lbl_ve_Compte_Crediter
            // 
            this.lbl_ve_Compte_Crediter.AutoSize = true;
            this.lbl_ve_Compte_Crediter.Location = new System.Drawing.Point(75, 143);
            this.lbl_ve_Compte_Crediter.Name = "lbl_ve_Compte_Crediter";
            this.lbl_ve_Compte_Crediter.Size = new System.Drawing.Size(187, 17);
            this.lbl_ve_Compte_Crediter.TabIndex = 8;
            this.lbl_ve_Compte_Crediter.Text = "Choisir un Compte à créditer";
            this.lbl_ve_Compte_Crediter.Click += new System.EventHandler(this.lbl_ve_Compte_Crediter_Click);
            // 
            // lbl_ve_Message
            // 
            this.lbl_ve_Message.AutoSize = true;
            this.lbl_ve_Message.Location = new System.Drawing.Point(75, 304);
            this.lbl_ve_Message.Name = "lbl_ve_Message";
            this.lbl_ve_Message.Size = new System.Drawing.Size(140, 17);
            this.lbl_ve_Message.TabIndex = 7;
            this.lbl_ve_Message.Text = "                                 ";
            this.lbl_ve_Message.Click += new System.EventHandler(this.lbl_ve_Message_Click);
            // 
            // btn_ve_Annuler
            // 
            this.btn_ve_Annuler.BackColor = System.Drawing.Color.Red;
            this.btn_ve_Annuler.Location = new System.Drawing.Point(521, 304);
            this.btn_ve_Annuler.Name = "btn_ve_Annuler";
            this.btn_ve_Annuler.Size = new System.Drawing.Size(94, 34);
            this.btn_ve_Annuler.TabIndex = 6;
            this.btn_ve_Annuler.Text = "Annuler";
            this.btn_ve_Annuler.UseVisualStyleBackColor = false;
            this.btn_ve_Annuler.Click += new System.EventHandler(this.btn_ve_Annuler_Click);
            // 
            // btn_ve_Enregsitrer
            // 
            this.btn_ve_Enregsitrer.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_ve_Enregsitrer.Location = new System.Drawing.Point(521, 244);
            this.btn_ve_Enregsitrer.Name = "btn_ve_Enregsitrer";
            this.btn_ve_Enregsitrer.Size = new System.Drawing.Size(94, 36);
            this.btn_ve_Enregsitrer.TabIndex = 5;
            this.btn_ve_Enregsitrer.Text = "Enregistrer";
            this.btn_ve_Enregsitrer.UseVisualStyleBackColor = false;
            this.btn_ve_Enregsitrer.Click += new System.EventHandler(this.btn_ve_Enregsitrer_Click);
            // 
            // tbx_ve_Montant_Crediter
            // 
            this.tbx_ve_Montant_Crediter.Location = new System.Drawing.Point(270, 177);
            this.tbx_ve_Montant_Crediter.Name = "tbx_ve_Montant_Crediter";
            this.tbx_ve_Montant_Crediter.Size = new System.Drawing.Size(199, 22);
            this.tbx_ve_Montant_Crediter.TabIndex = 4;
            this.tbx_ve_Montant_Crediter.TextChanged += new System.EventHandler(this.tbx_ve_Montant_Crediter_TextChanged);
            // 
            // cbx_ve_ChoixCompte
            // 
            this.cbx_ve_ChoixCompte.FormattingEnabled = true;
            this.cbx_ve_ChoixCompte.Location = new System.Drawing.Point(270, 143);
            this.cbx_ve_ChoixCompte.Name = "cbx_ve_ChoixCompte";
            this.cbx_ve_ChoixCompte.Size = new System.Drawing.Size(199, 24);
            this.cbx_ve_ChoixCompte.TabIndex = 3;
            this.cbx_ve_ChoixCompte.SelectedIndexChanged += new System.EventHandler(this.cbx_ve_ChoixCompte_SelectedIndexChanged);
            this.cbx_ve_ChoixCompte.Enter += new System.EventHandler(this.tabVersement_Click);
            // 
            // lbl_ve_Montant_Crediter
            // 
            this.lbl_ve_Montant_Crediter.AutoSize = true;
            this.lbl_ve_Montant_Crediter.Location = new System.Drawing.Point(75, 177);
            this.lbl_ve_Montant_Crediter.Name = "lbl_ve_Montant_Crediter";
            this.lbl_ve_Montant_Crediter.Size = new System.Drawing.Size(123, 17);
            this.lbl_ve_Montant_Crediter.TabIndex = 2;
            this.lbl_ve_Montant_Crediter.Text = "Montant à créditer";
            this.lbl_ve_Montant_Crediter.Click += new System.EventHandler(this.lbl_ve_Montant_Crediter_Click);
            // 
            // lbl_ve_Title
            // 
            this.lbl_ve_Title.AutoSize = true;
            this.lbl_ve_Title.Location = new System.Drawing.Point(284, 64);
            this.lbl_ve_Title.Name = "lbl_ve_Title";
            this.lbl_ve_Title.Size = new System.Drawing.Size(207, 17);
            this.lbl_ve_Title.TabIndex = 0;
            this.lbl_ve_Title.Text = "Enregistrement d\'un Versement";
            this.lbl_ve_Title.Click += new System.EventHandler(this.lbl_ve_Title_Click);
            // 
            // tabRetrait
            // 
            this.tabRetrait.Controls.Add(this.lbl_re_Message);
            this.tabRetrait.Controls.Add(this.btn_re_Annuler);
            this.tabRetrait.Controls.Add(this.btn_re_Enregistrer);
            this.tabRetrait.Controls.Add(this.cbx_re_Choix_Compte);
            this.tabRetrait.Controls.Add(this.tbx_re_Debiter);
            this.tabRetrait.Controls.Add(this.lbl_re_Montant_Débiter);
            this.tabRetrait.Controls.Add(this.lbl_re_Choix_Compte);
            this.tabRetrait.Controls.Add(this.lbl_re_Title);
            this.tabRetrait.Location = new System.Drawing.Point(4, 25);
            this.tabRetrait.Name = "tabRetrait";
            this.tabRetrait.Size = new System.Drawing.Size(792, 421);
            this.tabRetrait.TabIndex = 4;
            this.tabRetrait.Text = "Retrait";
            this.tabRetrait.UseVisualStyleBackColor = true;
            this.tabRetrait.Click += new System.EventHandler(this.tabRetrait_Click);
            // 
            // lbl_re_Message
            // 
            this.lbl_re_Message.AutoSize = true;
            this.lbl_re_Message.Location = new System.Drawing.Point(130, 295);
            this.lbl_re_Message.Name = "lbl_re_Message";
            this.lbl_re_Message.Size = new System.Drawing.Size(104, 17);
            this.lbl_re_Message.TabIndex = 7;
            this.lbl_re_Message.Text = "                        ";
            this.lbl_re_Message.Click += new System.EventHandler(this.lbl_re_Message_Click);
            // 
            // btn_re_Annuler
            // 
            this.btn_re_Annuler.BackColor = System.Drawing.Color.Red;
            this.btn_re_Annuler.Location = new System.Drawing.Point(551, 295);
            this.btn_re_Annuler.Name = "btn_re_Annuler";
            this.btn_re_Annuler.Size = new System.Drawing.Size(90, 28);
            this.btn_re_Annuler.TabIndex = 6;
            this.btn_re_Annuler.Text = "Annuler";
            this.btn_re_Annuler.UseVisualStyleBackColor = false;
            this.btn_re_Annuler.Click += new System.EventHandler(this.btn_re_Annuler_Click);
            // 
            // btn_re_Enregistrer
            // 
            this.btn_re_Enregistrer.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_re_Enregistrer.Location = new System.Drawing.Point(551, 242);
            this.btn_re_Enregistrer.Name = "btn_re_Enregistrer";
            this.btn_re_Enregistrer.Size = new System.Drawing.Size(90, 28);
            this.btn_re_Enregistrer.TabIndex = 5;
            this.btn_re_Enregistrer.Text = "Enregistrer";
            this.btn_re_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_re_Enregistrer.Click += new System.EventHandler(this.btn_re_Enregistrer_Click);
            // 
            // cbx_re_Choix_Compte
            // 
            this.cbx_re_Choix_Compte.FormattingEnabled = true;
            this.cbx_re_Choix_Compte.Location = new System.Drawing.Point(284, 116);
            this.cbx_re_Choix_Compte.Name = "cbx_re_Choix_Compte";
            this.cbx_re_Choix_Compte.Size = new System.Drawing.Size(194, 24);
            this.cbx_re_Choix_Compte.TabIndex = 4;
            this.cbx_re_Choix_Compte.SelectedIndexChanged += new System.EventHandler(this.cbx_re_Choix_Compte_SelectedIndexChanged);
            this.cbx_re_Choix_Compte.Enter += new System.EventHandler(this.tabRetrait_Click);
            // 
            // tbx_re_Debiter
            // 
            this.tbx_re_Debiter.Location = new System.Drawing.Point(284, 179);
            this.tbx_re_Debiter.Name = "tbx_re_Debiter";
            this.tbx_re_Debiter.Size = new System.Drawing.Size(194, 22);
            this.tbx_re_Debiter.TabIndex = 3;
            this.tbx_re_Debiter.TextChanged += new System.EventHandler(this.tbx_re_Debiter_TextChanged);
            // 
            // lbl_re_Montant_Débiter
            // 
            this.lbl_re_Montant_Débiter.AutoSize = true;
            this.lbl_re_Montant_Débiter.Location = new System.Drawing.Point(130, 179);
            this.lbl_re_Montant_Débiter.Name = "lbl_re_Montant_Débiter";
            this.lbl_re_Montant_Débiter.Size = new System.Drawing.Size(119, 17);
            this.lbl_re_Montant_Débiter.TabIndex = 2;
            this.lbl_re_Montant_Débiter.Text = "Montant à débiter";
            this.lbl_re_Montant_Débiter.Click += new System.EventHandler(this.lbl_re_Montant_Débiter_Click);
            // 
            // lbl_re_Choix_Compte
            // 
            this.lbl_re_Choix_Compte.AutoSize = true;
            this.lbl_re_Choix_Compte.Location = new System.Drawing.Point(130, 116);
            this.lbl_re_Choix_Compte.Name = "lbl_re_Choix_Compte";
            this.lbl_re_Choix_Compte.Size = new System.Drawing.Size(125, 17);
            this.lbl_re_Choix_Compte.TabIndex = 1;
            this.lbl_re_Choix_Compte.Text = "Choisir un compte ";
            this.lbl_re_Choix_Compte.Click += new System.EventHandler(this.lbl_re_Choix_Compte_Click);
            // 
            // lbl_re_Title
            // 
            this.lbl_re_Title.AutoSize = true;
            this.lbl_re_Title.Location = new System.Drawing.Point(298, 60);
            this.lbl_re_Title.Name = "lbl_re_Title";
            this.lbl_re_Title.Size = new System.Drawing.Size(180, 17);
            this.lbl_re_Title.TabIndex = 0;
            this.lbl_re_Title.Text = "Enregistrement d\'un retrait ";
            // 
            // tabVirement
            // 
            this.tabVirement.Controls.Add(this.btn_vi_Annuler);
            this.tabVirement.Controls.Add(this.btn_vi_Enregistrer);
            this.tabVirement.Controls.Add(this.tbx_vi_Montant_Virement);
            this.tabVirement.Controls.Add(this.cbx_vi_Créditer);
            this.tabVirement.Controls.Add(this.cbx_vi_Débiter);
            this.tabVirement.Controls.Add(this.lbl_vi_Message);
            this.tabVirement.Controls.Add(this.lbl_vi_Montant_Virement);
            this.tabVirement.Controls.Add(this.lbl_vi_Créditer);
            this.tabVirement.Controls.Add(this.lbl_vi_Débiter);
            this.tabVirement.Controls.Add(this.lbl_vi_Title);
            this.tabVirement.Location = new System.Drawing.Point(4, 25);
            this.tabVirement.Name = "tabVirement";
            this.tabVirement.Size = new System.Drawing.Size(792, 421);
            this.tabVirement.TabIndex = 5;
            this.tabVirement.Text = "Virement";
            this.tabVirement.UseVisualStyleBackColor = true;
            this.tabVirement.Click += new System.EventHandler(this.tabVirement_Click);
            // 
            // btn_vi_Annuler
            // 
            this.btn_vi_Annuler.BackColor = System.Drawing.Color.Red;
            this.btn_vi_Annuler.Location = new System.Drawing.Point(599, 275);
            this.btn_vi_Annuler.Name = "btn_vi_Annuler";
            this.btn_vi_Annuler.Size = new System.Drawing.Size(87, 30);
            this.btn_vi_Annuler.TabIndex = 9;
            this.btn_vi_Annuler.Text = "Annuler";
            this.btn_vi_Annuler.UseVisualStyleBackColor = false;
            this.btn_vi_Annuler.Click += new System.EventHandler(this.btn_vi_Annuler_Click);
            // 
            // btn_vi_Enregistrer
            // 
            this.btn_vi_Enregistrer.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_vi_Enregistrer.Location = new System.Drawing.Point(599, 227);
            this.btn_vi_Enregistrer.Name = "btn_vi_Enregistrer";
            this.btn_vi_Enregistrer.Size = new System.Drawing.Size(87, 30);
            this.btn_vi_Enregistrer.TabIndex = 8;
            this.btn_vi_Enregistrer.Text = "Enregistrer";
            this.btn_vi_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_vi_Enregistrer.Click += new System.EventHandler(this.btn_vi_Enregistrer_Click);
            // 
            // tbx_vi_Montant_Virement
            // 
            this.tbx_vi_Montant_Virement.Location = new System.Drawing.Point(281, 183);
            this.tbx_vi_Montant_Virement.Name = "tbx_vi_Montant_Virement";
            this.tbx_vi_Montant_Virement.Size = new System.Drawing.Size(178, 22);
            this.tbx_vi_Montant_Virement.TabIndex = 7;
            this.tbx_vi_Montant_Virement.TextChanged += new System.EventHandler(this.tbx_vi_Montant_Virement_TextChanged);
            // 
            // cbx_vi_Créditer
            // 
            this.cbx_vi_Créditer.FormattingEnabled = true;
            this.cbx_vi_Créditer.Location = new System.Drawing.Point(281, 145);
            this.cbx_vi_Créditer.Name = "cbx_vi_Créditer";
            this.cbx_vi_Créditer.Size = new System.Drawing.Size(178, 24);
            this.cbx_vi_Créditer.TabIndex = 6;
            this.cbx_vi_Créditer.SelectedIndexChanged += new System.EventHandler(this.tabVirement_Click);
            // 
            // cbx_vi_Débiter
            // 
            this.cbx_vi_Débiter.FormattingEnabled = true;
            this.cbx_vi_Débiter.Location = new System.Drawing.Point(281, 111);
            this.cbx_vi_Débiter.Name = "cbx_vi_Débiter";
            this.cbx_vi_Débiter.Size = new System.Drawing.Size(178, 24);
            this.cbx_vi_Débiter.TabIndex = 5;
            this.cbx_vi_Débiter.SelectedIndexChanged += new System.EventHandler(this.tabVirement_Click);
            // 
            // lbl_vi_Message
            // 
            this.lbl_vi_Message.AutoSize = true;
            this.lbl_vi_Message.Location = new System.Drawing.Point(67, 282);
            this.lbl_vi_Message.Name = "lbl_vi_Message";
            this.lbl_vi_Message.Size = new System.Drawing.Size(96, 17);
            this.lbl_vi_Message.TabIndex = 4;
            this.lbl_vi_Message.Text = "                      ";
            this.lbl_vi_Message.Click += new System.EventHandler(this.lbl_vi_Message_Click);
            // 
            // lbl_vi_Montant_Virement
            // 
            this.lbl_vi_Montant_Virement.AutoSize = true;
            this.lbl_vi_Montant_Virement.Location = new System.Drawing.Point(67, 183);
            this.lbl_vi_Montant_Virement.Name = "lbl_vi_Montant_Virement";
            this.lbl_vi_Montant_Virement.Size = new System.Drawing.Size(137, 17);
            this.lbl_vi_Montant_Virement.TabIndex = 3;
            this.lbl_vi_Montant_Virement.Text = "Montant du virement";
            this.lbl_vi_Montant_Virement.Click += new System.EventHandler(this.lbl_vi_Montant_Virement_Click);
            // 
            // lbl_vi_Créditer
            // 
            this.lbl_vi_Créditer.AutoSize = true;
            this.lbl_vi_Créditer.Location = new System.Drawing.Point(67, 145);
            this.lbl_vi_Créditer.Name = "lbl_vi_Créditer";
            this.lbl_vi_Créditer.Size = new System.Drawing.Size(189, 17);
            this.lbl_vi_Créditer.TabIndex = 2;
            this.lbl_vi_Créditer.Text = "Choisir un compte à créditer ";
            this.lbl_vi_Créditer.Click += new System.EventHandler(this.lbl_vi_Créditer_Click);
            // 
            // lbl_vi_Débiter
            // 
            this.lbl_vi_Débiter.AutoSize = true;
            this.lbl_vi_Débiter.Location = new System.Drawing.Point(67, 114);
            this.lbl_vi_Débiter.Name = "lbl_vi_Débiter";
            this.lbl_vi_Débiter.Size = new System.Drawing.Size(180, 17);
            this.lbl_vi_Débiter.TabIndex = 1;
            this.lbl_vi_Débiter.Text = "Choisir le compte à débiter ";
            this.lbl_vi_Débiter.Click += new System.EventHandler(this.lbl_vi_Débiter_Click);
            // 
            // lbl_vi_Title
            // 
            this.lbl_vi_Title.AutoSize = true;
            this.lbl_vi_Title.Location = new System.Drawing.Point(287, 51);
            this.lbl_vi_Title.Name = "lbl_vi_Title";
            this.lbl_vi_Title.Size = new System.Drawing.Size(193, 17);
            this.lbl_vi_Title.TabIndex = 0;
            this.lbl_vi_Title.Text = "Enregistrement d\'un virement";
            // 
            // FrmBanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_OngletsApplication);
            this.Name = "FrmBanque";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmBanque_Load);
            this.tab_OngletsApplication.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeComptes)).EndInit();
            this.tabConsulation.ResumeLayout(false);
            this.tabConsulation.PerformLayout();
            this.tabCréation.ResumeLayout(false);
            this.tabCréation.PerformLayout();
            this.tabVersement.ResumeLayout(false);
            this.tabVersement.PerformLayout();
            this.tabRetrait.ResumeLayout(false);
            this.tabRetrait.PerformLayout();
            this.tabVirement.ResumeLayout(false);
            this.tabVirement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_OngletsApplication;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.TabPage tabConsulation;
        private System.Windows.Forms.TabPage tabCréation;
        private System.Windows.Forms.TabPage tabVersement;
        private System.Windows.Forms.TabPage tabRetrait;
        private System.Windows.Forms.TabPage tabVirement;
        private System.Windows.Forms.DataGridView dgv_ListeComptes;
        private System.Windows.Forms.Label lbl_ac_Title;
        private System.Windows.Forms.Label lbl_ac_liste;
        private System.Windows.Forms.Label lbl_co_Tit;
        private System.Windows.Forms.Label lbl_co_Solde;
        private System.Windows.Forms.Label lbl_co_Num;
        private System.Windows.Forms.Label lbl_co_Choix;
        private System.Windows.Forms.TextBox tbx_co_SoldeActuel;
        private System.Windows.Forms.TextBox tbx_co_Numero;
        private System.Windows.Forms.TextBox tbx_co_Tiulaire;
        private System.Windows.Forms.ComboBox cbx_co_ChoixCompte;
        private System.Windows.Forms.Label lbl_co_Title;
        private System.Windows.Forms.Button btn_cr_Annuler;
        private System.Windows.Forms.Button btn_Creer;
        private System.Windows.Forms.TextBox tbx_cr_SoldeInitial;
        private System.Windows.Forms.TextBox tbx_cr_Titulaire;
        private System.Windows.Forms.TextBox tbx_cr_Numero;
        private System.Windows.Forms.Label lbl_cr_Solde;
        private System.Windows.Forms.Label lbl_cr_Numero;
        private System.Windows.Forms.Label lbl_cr_Titulaire;
        private System.Windows.Forms.Label lbl_cr_Title;
        private System.Windows.Forms.Label lbl_cr_Message;
        private System.Windows.Forms.Label lbl_ve_Title;
        private System.Windows.Forms.Label lbl_ve_Montant_Crediter;
        private System.Windows.Forms.ComboBox cbx_ve_ChoixCompte;
        private System.Windows.Forms.Button btn_ve_Annuler;
        private System.Windows.Forms.Button btn_ve_Enregsitrer;
        private System.Windows.Forms.TextBox tbx_ve_Montant_Crediter;
        private System.Windows.Forms.Label lbl_ve_Message;
        private System.Windows.Forms.Label lbl_ve_Compte_Crediter;
        private System.Windows.Forms.Label lbl_re_Title;
        private System.Windows.Forms.Label lbl_re_Montant_Débiter;
        private System.Windows.Forms.Label lbl_re_Choix_Compte;
        private System.Windows.Forms.TextBox tbx_re_Debiter;
        private System.Windows.Forms.ComboBox cbx_re_Choix_Compte;
        private System.Windows.Forms.Button btn_re_Enregistrer;
        private System.Windows.Forms.Button btn_re_Annuler;
        private System.Windows.Forms.Label lbl_re_Message;
        private System.Windows.Forms.Label lbl_vi_Title;
        private System.Windows.Forms.Label lbl_vi_Débiter;
        private System.Windows.Forms.Label lbl_vi_Créditer;
        private System.Windows.Forms.Label lbl_vi_Montant_Virement;
        private System.Windows.Forms.Label lbl_vi_Message;
        private System.Windows.Forms.TextBox tbx_vi_Montant_Virement;
        private System.Windows.Forms.ComboBox cbx_vi_Créditer;
        private System.Windows.Forms.ComboBox cbx_vi_Débiter;
        private System.Windows.Forms.Button btn_vi_Annuler;
        private System.Windows.Forms.Button btn_vi_Enregistrer;
    }
}

