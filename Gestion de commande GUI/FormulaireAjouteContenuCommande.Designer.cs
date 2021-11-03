
namespace Gestion_de_commande_GUI
{
    partial class FormulaireAjouteContenuCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbProduits = new System.Windows.Forms.ComboBox();
            this.inputQuantité = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbProduits
            // 
            this.cbProduits.FormattingEnabled = true;
            this.cbProduits.Location = new System.Drawing.Point(71, 36);
            this.cbProduits.Name = "cbProduits";
            this.cbProduits.Size = new System.Drawing.Size(292, 21);
            this.cbProduits.TabIndex = 0;
            // 
            // inputQuantité
            // 
            this.inputQuantité.Location = new System.Drawing.Point(71, 63);
            this.inputQuantité.Name = "inputQuantité";
            this.inputQuantité.Size = new System.Drawing.Size(100, 20);
            this.inputQuantité.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormulaireAjouteContenuCommande
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 144);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputQuantité);
            this.Controls.Add(this.cbProduits);
            this.Name = "FormulaireAjouteContenuCommande";
            this.Text = "FormulaireAjouteContenuCommande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProduits;
        private System.Windows.Forms.TextBox inputQuantité;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}