
namespace Gestion_de_commande_GUI
{
    partial class FormulaireCréationClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputNomClient = new System.Windows.Forms.TextBox();
            this.inputPrenomClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputVille = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputAdresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputCodeClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputCodePostale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // inputNomClient
            // 
            this.inputNomClient.Location = new System.Drawing.Point(133, 23);
            this.inputNomClient.Name = "inputNomClient";
            this.inputNomClient.Size = new System.Drawing.Size(100, 20);
            this.inputNomClient.TabIndex = 1;
            // 
            // inputPrenomClient
            // 
            this.inputPrenomClient.Location = new System.Drawing.Point(133, 63);
            this.inputPrenomClient.Name = "inputPrenomClient";
            this.inputPrenomClient.Size = new System.Drawing.Size(100, 20);
            this.inputPrenomClient.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom";
            // 
            // inputVille
            // 
            this.inputVille.Location = new System.Drawing.Point(269, 111);
            this.inputVille.Name = "inputVille";
            this.inputVille.Size = new System.Drawing.Size(100, 20);
            this.inputVille.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ville";
            // 
            // inputAdresse
            // 
            this.inputAdresse.Location = new System.Drawing.Point(74, 111);
            this.inputAdresse.Name = "inputAdresse";
            this.inputAdresse.Size = new System.Drawing.Size(100, 20);
            this.inputAdresse.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse";
            // 
            // inputCodeClient
            // 
            this.inputCodeClient.Location = new System.Drawing.Point(133, 192);
            this.inputCodeClient.Name = "inputCodeClient";
            this.inputCodeClient.Size = new System.Drawing.Size(100, 20);
            this.inputCodeClient.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Code Client";
            // 
            // inputCodePostale
            // 
            this.inputCodePostale.Location = new System.Drawing.Point(133, 155);
            this.inputCodePostale.Name = "inputCodePostale";
            this.inputCodePostale.Size = new System.Drawing.Size(100, 20);
            this.inputCodePostale.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Code Postale";
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(158, 229);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 12;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // FormulaireCréationClient
            // 
            this.AcceptButton = this.Valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 264);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.inputCodeClient);
            this.Controls.Add(this.label5);
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
            this.Name = "FormulaireCréationClient";
            this.Text = "FormulaireCréationClient";
            this.Load += new System.EventHandler(this.FormulaireCréationClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNomClient;
        private System.Windows.Forms.TextBox inputPrenomClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputVille;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputAdresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputCodeClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputCodePostale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Valider;
    }
}