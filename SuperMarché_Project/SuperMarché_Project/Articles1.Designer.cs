﻿namespace SuperMarché_Project
{
    partial class Articles1
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
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ArticlesListe = new System.Windows.Forms.DataGridView();
            this.ActualiserBtn = new System.Windows.Forms.Button();
            this.FiltrerCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.ExTb = new System.Windows.Forms.DateTimePicker();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.StockTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrixTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NomTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(718, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Date d\'expiration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 550);
            this.panel1.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Déconnexion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Facturation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Vendeurs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Categories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Articles";
            // 
            // ArticlesListe
            // 
            this.ArticlesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArticlesListe.Location = new System.Drawing.Point(180, 259);
            this.ArticlesListe.Name = "ArticlesListe";
            this.ArticlesListe.Size = new System.Drawing.Size(830, 233);
            this.ArticlesListe.TabIndex = 36;
            this.ArticlesListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArticlesListe_CellContentClick);
            // 
            // ActualiserBtn
            // 
            this.ActualiserBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ActualiserBtn.Location = new System.Drawing.Point(454, 217);
            this.ActualiserBtn.Name = "ActualiserBtn";
            this.ActualiserBtn.Size = new System.Drawing.Size(128, 36);
            this.ActualiserBtn.TabIndex = 35;
            this.ActualiserBtn.Text = "Actualiser";
            this.ActualiserBtn.UseVisualStyleBackColor = false;
            this.ActualiserBtn.Click += new System.EventHandler(this.ActualiserBtn_Click);
            // 
            // FiltrerCb
            // 
            this.FiltrerCb.FormattingEnabled = true;
            this.FiltrerCb.Location = new System.Drawing.Point(296, 217);
            this.FiltrerCb.Name = "FiltrerCb";
            this.FiltrerCb.Size = new System.Drawing.Size(133, 21);
            this.FiltrerCb.TabIndex = 34;
            this.FiltrerCb.SelectedIndexChanged += new System.EventHandler(this.FiltrerCb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Liste des articles";
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SupprimerBtn.Location = new System.Drawing.Point(561, 140);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(125, 36);
            this.SupprimerBtn.TabIndex = 32;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // EnregistrerBtn
            // 
            this.EnregistrerBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EnregistrerBtn.Location = new System.Drawing.Point(431, 140);
            this.EnregistrerBtn.Name = "EnregistrerBtn";
            this.EnregistrerBtn.Size = new System.Drawing.Size(124, 36);
            this.EnregistrerBtn.TabIndex = 31;
            this.EnregistrerBtn.Text = "Enregistrer";
            this.EnregistrerBtn.UseVisualStyleBackColor = false;
            this.EnregistrerBtn.Click += new System.EventHandler(this.EnregistrerBtn_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ModifierBtn.Location = new System.Drawing.Point(297, 140);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(128, 36);
            this.ModifierBtn.TabIndex = 30;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // ExTb
            // 
            this.ExTb.Location = new System.Drawing.Point(710, 81);
            this.ExTb.Name = "ExTb";
            this.ExTb.Size = new System.Drawing.Size(296, 20);
            this.ExTb.TabIndex = 29;
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Location = new System.Drawing.Point(478, 81);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(133, 21);
            this.CatCb.TabIndex = 28;
            // 
            // StockTb
            // 
            this.StockTb.Location = new System.Drawing.Point(617, 81);
            this.StockTb.Name = "StockTb";
            this.StockTb.Size = new System.Drawing.Size(87, 20);
            this.StockTb.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(617, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Categories";
            // 
            // PrixTb
            // 
            this.PrixTb.Location = new System.Drawing.Point(331, 84);
            this.PrixTb.Name = "PrixTb";
            this.PrixTb.Size = new System.Drawing.Size(138, 20);
            this.PrixTb.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prix de l\'article";
            // 
            // NomTb
            // 
            this.NomTb.Location = new System.Drawing.Point(177, 84);
            this.NomTb.Name = "NomTb";
            this.NomTb.Size = new System.Drawing.Size(138, 20);
            this.NomTb.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nom de l\'article";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Gestion des Articles";
            // 
            // Articles1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 513);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ArticlesListe);
            this.Controls.Add(this.ActualiserBtn);
            this.Controls.Add(this.FiltrerCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.EnregistrerBtn);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.ExTb);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.StockTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrixTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Articles1";
            this.Text = "Articles1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ArticlesListe;
        private System.Windows.Forms.Button ActualiserBtn;
        private System.Windows.Forms.ComboBox FiltrerCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.Button EnregistrerBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.DateTimePicker ExTb;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.TextBox StockTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrixTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}