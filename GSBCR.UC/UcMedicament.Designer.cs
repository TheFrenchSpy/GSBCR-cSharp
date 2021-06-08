namespace GSBCR.UC
{
    partial class UcMedicament
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_depot = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TB_nom = new System.Windows.Forms.TextBox();
            this.TB_familleA = new System.Windows.Forms.TextBox();
            this.TB_familleB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TB_composition = new System.Windows.Forms.TextBox();
            this.TB_effets = new System.Windows.Forms.TextBox();
            this.TB_contre = new System.Windows.Forms.TextBox();
            this.TB_prix = new System.Windows.Forms.TextBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TB_familleB);
            this.panel1.Controls.Add(this.TB_familleA);
            this.panel1.Location = new System.Drawing.Point(129, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dépot légal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom commercial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Famille";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Compostition";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Effets";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contre indications";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Prix échantillion";
            // 
            // TB_depot
            // 
            this.TB_depot.Location = new System.Drawing.Point(129, 19);
            this.TB_depot.Name = "TB_depot";
            this.TB_depot.Size = new System.Drawing.Size(100, 20);
            this.TB_depot.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TB_nom
            // 
            this.TB_nom.Location = new System.Drawing.Point(129, 51);
            this.TB_nom.Name = "TB_nom";
            this.TB_nom.Size = new System.Drawing.Size(100, 20);
            this.TB_nom.TabIndex = 10;
            // 
            // TB_familleA
            // 
            this.TB_familleA.Location = new System.Drawing.Point(4, 4);
            this.TB_familleA.Name = "TB_familleA";
            this.TB_familleA.Size = new System.Drawing.Size(100, 20);
            this.TB_familleA.TabIndex = 0;
            // 
            // TB_familleB
            // 
            this.TB_familleB.Location = new System.Drawing.Point(111, 4);
            this.TB_familleB.Multiline = true;
            this.TB_familleB.Name = "TB_familleB";
            this.TB_familleB.Size = new System.Drawing.Size(237, 59);
            this.TB_familleB.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // TB_composition
            // 
            this.TB_composition.Location = new System.Drawing.Point(129, 176);
            this.TB_composition.Multiline = true;
            this.TB_composition.Name = "TB_composition";
            this.TB_composition.Size = new System.Drawing.Size(363, 78);
            this.TB_composition.TabIndex = 12;
            // 
            // TB_effets
            // 
            this.TB_effets.Location = new System.Drawing.Point(129, 272);
            this.TB_effets.Multiline = true;
            this.TB_effets.Name = "TB_effets";
            this.TB_effets.Size = new System.Drawing.Size(363, 79);
            this.TB_effets.TabIndex = 13;
            // 
            // TB_contre
            // 
            this.TB_contre.Location = new System.Drawing.Point(129, 374);
            this.TB_contre.Multiline = true;
            this.TB_contre.Name = "TB_contre";
            this.TB_contre.Size = new System.Drawing.Size(363, 77);
            this.TB_contre.TabIndex = 14;
            // 
            // TB_prix
            // 
            this.TB_prix.Location = new System.Drawing.Point(129, 480);
            this.TB_prix.Name = "TB_prix";
            this.TB_prix.Size = new System.Drawing.Size(100, 20);
            this.TB_prix.TabIndex = 15;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // UcMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_prix);
            this.Controls.Add(this.TB_contre);
            this.Controls.Add(this.TB_effets);
            this.Controls.Add(this.TB_composition);
            this.Controls.Add(this.TB_nom);
            this.Controls.Add(this.TB_depot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UcMedicament";
            this.Size = new System.Drawing.Size(504, 560);
            this.Load += new System.EventHandler(this.UcMedicament_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_familleB;
        private System.Windows.Forms.TextBox TB_familleA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_depot;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TB_nom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox TB_composition;
        private System.Windows.Forms.TextBox TB_effets;
        private System.Windows.Forms.TextBox TB_contre;
        private System.Windows.Forms.TextBox TB_prix;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
    }
}
