﻿
namespace Gestion_de_commande_GUI
{
    partial class ModifierProduits
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputPrix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputLibelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputPrix
            // 
            this.inputPrix.Location = new System.Drawing.Point(87, 70);
            this.inputPrix.Name = "inputPrix";
            this.inputPrix.Size = new System.Drawing.Size(100, 20);
            this.inputPrix.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prix";
            // 
            // inputLibelle
            // 
            this.inputLibelle.Location = new System.Drawing.Point(87, 28);
            this.inputLibelle.Name = "inputLibelle";
            this.inputLibelle.Size = new System.Drawing.Size(100, 20);
            this.inputLibelle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Libelle";
            // 
            // ModifierProduits
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 153);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputPrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputLibelle);
            this.Controls.Add(this.label1);
            this.Name = "ModifierProduits";
            this.Text = "ModifierProduits";
            this.Load += new System.EventHandler(this.ModifierProduits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputPrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputLibelle;
        private System.Windows.Forms.Label label1;
    }
}