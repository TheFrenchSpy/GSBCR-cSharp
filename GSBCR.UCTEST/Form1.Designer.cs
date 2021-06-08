namespace GSBCR.UCTEST
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CBXmedoc = new System.Windows.Forms.ComboBox();
            this.BTNquitter = new System.Windows.Forms.Button();
            this.TB_prix = new System.Windows.Forms.TextBox();
            this.TB_contre = new System.Windows.Forms.TextBox();
            this.TB_effets = new System.Windows.Forms.TextBox();
            this.TB_composition = new System.Windows.Forms.TextBox();
            this.TB_nom = new System.Windows.Forms.TextBox();
            this.TB_depot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_familleB = new System.Windows.Forms.TextBox();
            this.TB_familleA = new System.Windows.Forms.TextBox();
            this.BSmedoc = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSmedoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir un medicament";
            // 
            // CBXmedoc
            // 
            this.CBXmedoc.FormattingEnabled = true;
            this.CBXmedoc.Location = new System.Drawing.Point(181, 30);
            this.CBXmedoc.Name = "CBXmedoc";
            this.CBXmedoc.Size = new System.Drawing.Size(121, 21);
            this.CBXmedoc.TabIndex = 1;
            this.CBXmedoc.SelectedIndexChanged += new System.EventHandler(this.CBXmedoc_SelectedIndexChanged);
            // 
            // BTNquitter
            // 
            this.BTNquitter.Location = new System.Drawing.Point(374, 30);
            this.BTNquitter.Name = "BTNquitter";
            this.BTNquitter.Size = new System.Drawing.Size(75, 23);
            this.BTNquitter.TabIndex = 2;
            this.BTNquitter.Text = "Quitter";
            this.BTNquitter.UseVisualStyleBackColor = true;
            // 
            // TB_prix
            // 
            this.TB_prix.Location = new System.Drawing.Point(120, 566);
            this.TB_prix.Name = "TB_prix";
            this.TB_prix.Size = new System.Drawing.Size(100, 20);
            this.TB_prix.TabIndex = 29;
            // 
            // TB_contre
            // 
            this.TB_contre.Location = new System.Drawing.Point(120, 460);
            this.TB_contre.Multiline = true;
            this.TB_contre.Name = "TB_contre";
            this.TB_contre.Size = new System.Drawing.Size(363, 77);
            this.TB_contre.TabIndex = 28;
            // 
            // TB_effets
            // 
            this.TB_effets.Location = new System.Drawing.Point(120, 358);
            this.TB_effets.Multiline = true;
            this.TB_effets.Name = "TB_effets";
            this.TB_effets.Size = new System.Drawing.Size(363, 79);
            this.TB_effets.TabIndex = 27;
            // 
            // TB_composition
            // 
            this.TB_composition.Location = new System.Drawing.Point(120, 262);
            this.TB_composition.Multiline = true;
            this.TB_composition.Name = "TB_composition";
            this.TB_composition.Size = new System.Drawing.Size(363, 78);
            this.TB_composition.TabIndex = 26;
            // 
            // TB_nom
            // 
            this.TB_nom.Location = new System.Drawing.Point(120, 137);
            this.TB_nom.Name = "TB_nom";
            this.TB_nom.Size = new System.Drawing.Size(100, 20);
            this.TB_nom.TabIndex = 25;
            // 
            // TB_depot
            // 
            this.TB_depot.Location = new System.Drawing.Point(120, 105);
            this.TB_depot.Name = "TB_depot";
            this.TB_depot.Size = new System.Drawing.Size(100, 20);
            this.TB_depot.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Prix échantillion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Contre indications";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Effets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Compostition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Famille";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nom commercial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Dépot légal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TB_familleB);
            this.panel1.Controls.Add(this.TB_familleA);
            this.panel1.Location = new System.Drawing.Point(120, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 66);
            this.panel1.TabIndex = 16;
            // 
            // TB_familleB
            // 
            this.TB_familleB.Location = new System.Drawing.Point(111, 4);
            this.TB_familleB.Multiline = true;
            this.TB_familleB.Name = "TB_familleB";
            this.TB_familleB.Size = new System.Drawing.Size(237, 59);
            this.TB_familleB.TabIndex = 1;
            // 
            // TB_familleA
            // 
            this.TB_familleA.Location = new System.Drawing.Point(4, 4);
            this.TB_familleA.Name = "TB_familleA";
            this.TB_familleA.Size = new System.Drawing.Size(100, 20);
            this.TB_familleA.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNquitter);
            this.Controls.Add(this.CBXmedoc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSmedoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBXmedoc;
        private System.Windows.Forms.Button BTNquitter;
        private System.Windows.Forms.TextBox TB_prix;
        private System.Windows.Forms.TextBox TB_contre;
        private System.Windows.Forms.TextBox TB_effets;
        private System.Windows.Forms.TextBox TB_composition;
        private System.Windows.Forms.TextBox TB_nom;
        private System.Windows.Forms.TextBox TB_depot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_familleB;
        private System.Windows.Forms.TextBox TB_familleA;
        private System.Windows.Forms.BindingSource BSmedoc;
    }
}

