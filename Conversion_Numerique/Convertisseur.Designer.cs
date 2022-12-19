
namespace Conversion_Numerique
{
    partial class Convertisseur
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
            this.entete = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.choix1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inverseBtn = new System.Windows.Forms.Button();
            this.choix2 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.champEntrer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.champResultat = new System.Windows.Forms.TextBox();
            this.entete.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // entete
            // 
            this.entete.BackColor = System.Drawing.Color.Gainsboro;
            this.entete.Controls.Add(this.label3);
            this.entete.Controls.Add(this.closeBtn);
            this.entete.Dock = System.Windows.Forms.DockStyle.Top;
            this.entete.Location = new System.Drawing.Point(0, 0);
            this.entete.Name = "entete";
            this.entete.Size = new System.Drawing.Size(800, 49);
            this.entete.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(22, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Convertisseur Numerique";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(735, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(65, 49);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // choix1
            // 
            this.choix1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choix1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choix1.FormattingEnabled = true;
            this.choix1.Items.AddRange(new object[] {
            "Binaire",
            "Octal",
            "Décimal",
            "Héxadécimal"});
            this.choix1.Location = new System.Drawing.Point(12, 20);
            this.choix1.Name = "choix1";
            this.choix1.Size = new System.Drawing.Size(253, 33);
            this.choix1.TabIndex = 1;
            this.choix1.Text = "Décimal";
            this.choix1.SelectedValueChanged += new System.EventHandler(this.choix1_SelectedValueChanged);
            this.choix1.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.choix1_ChangeUICues);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inverseBtn);
            this.panel2.Controls.Add(this.choix2);
            this.panel2.Controls.Add(this.choix1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 72);
            this.panel2.TabIndex = 2;
            // 
            // inverseBtn
            // 
            this.inverseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inverseBtn.FlatAppearance.BorderSize = 0;
            this.inverseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.inverseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.inverseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inverseBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inverseBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.inverseBtn.Location = new System.Drawing.Point(355, 20);
            this.inverseBtn.Name = "inverseBtn";
            this.inverseBtn.Size = new System.Drawing.Size(94, 33);
            this.inverseBtn.TabIndex = 4;
            this.inverseBtn.Text = "<=>";
            this.inverseBtn.UseVisualStyleBackColor = true;
            this.inverseBtn.Click += new System.EventHandler(this.inverseBtn_Click);
            // 
            // choix2
            // 
            this.choix2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choix2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choix2.FormattingEnabled = true;
            this.choix2.Items.AddRange(new object[] {
            "Binaire",
            "Octal",
            "Décimal",
            "Héxadécimal"});
            this.choix2.Location = new System.Drawing.Point(535, 20);
            this.choix2.Name = "choix2";
            this.choix2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.choix2.Size = new System.Drawing.Size(253, 33);
            this.choix2.TabIndex = 3;
            this.choix2.Text = "Binaire";
            this.choix2.SelectedIndexChanged += new System.EventHandler(this.choix2_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.champEntrer);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 147);
            this.panel3.TabIndex = 3;
            // 
            // champEntrer
            // 
            this.champEntrer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.champEntrer.Location = new System.Drawing.Point(42, 56);
            this.champEntrer.Multiline = true;
            this.champEntrer.Name = "champEntrer";
            this.champEntrer.Size = new System.Drawing.Size(720, 91);
            this.champEntrer.TabIndex = 1;
            this.champEntrer.TextChanged += new System.EventHandler(this.champEntrer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez le nombre";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.champResultat);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 268);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 532);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(42, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultat";
            // 
            // champResultat
            // 
            this.champResultat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.champResultat.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.champResultat.Location = new System.Drawing.Point(40, 49);
            this.champResultat.Multiline = true;
            this.champResultat.Name = "champResultat";
            this.champResultat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.champResultat.Size = new System.Drawing.Size(734, 441);
            this.champResultat.TabIndex = 2;
            // 
            // Convertisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.entete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Convertisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertisseur";
            this.Load += new System.EventHandler(this.Convertisseur_Load);
            this.entete.ResumeLayout(false);
            this.entete.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel entete;
        private System.Windows.Forms.ComboBox choix1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox choix2;
        private System.Windows.Forms.Button inverseBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox champEntrer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox champResultat;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}