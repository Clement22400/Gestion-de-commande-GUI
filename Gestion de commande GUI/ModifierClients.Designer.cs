
namespace Gestion_de_commande_GUI
{
    partial class ModifierClients
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
            this.Valider = new System.Windows.Forms.Button();
            this.inputCodePostale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputVille = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputAdresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPrenomClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNomClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(144, 190);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 25;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // inputCodePostale
            // 
            this.inputCodePostale.Location = new System.Drawing.Point(132, 149);
            this.inputCodePostale.Name = "inputCodePostale";
            this.inputCodePostale.Size = new System.Drawing.Size(100, 20);
            this.inputCodePostale.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Code Postale";
            // 
            // inputVille
            // 
            this.inputVille.Location = new System.Drawing.Point(268, 105);
            this.inputVille.Name = "inputVille";
            this.inputVille.Size = new System.Drawing.Size(100, 20);
            this.inputVille.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ville";
            // 
            // inputAdresse
            // 
            this.inputAdresse.Location = new System.Drawing.Point(73, 105);
            this.inputAdresse.Name = "inputAdresse";
            this.inputAdresse.Size = new System.Drawing.Size(100, 20);
            this.inputAdresse.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Adresse";
            // 
            // inputPrenomClient
            // 
            this.inputPrenomClient.Location = new System.Drawing.Point(132, 57);
            this.inputPrenomClient.Name = "inputPrenomClient";
            this.inputPrenomClient.Size = new System.Drawing.Size(100, 20);
            this.inputPrenomClient.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prénom";
            // 
            // inputNomClient
            // 
            this.inputNomClient.Location = new System.Drawing.Point(132, 17);
            this.inputNomClient.Name = "inputNomClient";
            this.inputNomClient.Size = new System.Drawing.Size(100, 20);
            this.inputNomClient.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom";
            // 
            // ModifierClients
            // 
            this.AcceptButton = this.Valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 235);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.inputCodePostale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputVille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputAdresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputPrenomClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNomClient);
            this.Controls.Add(this.label1);
            this.Name = "ModifierClients";
            this.Text = "ModifierClients";
            this.Load += new System.EventHandler(this.ModifierClients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.TextBox inputCodePostale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputVille;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputAdresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputPrenomClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNomClient;
        private System.Windows.Forms.Label label1;
    }
}