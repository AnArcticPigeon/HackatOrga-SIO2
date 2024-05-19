namespace HackatOrga
{
    partial class Event
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnMenu = new Button();
            btnValider = new Button();
            Type = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labIntervenant = new Label();
            labThNb = new Label();
            cbIntervenant = new ComboBox();
            nudPlace = new NumericUpDown();
            txbTheme = new TextBox();
            dtpFin = new DateTimePicker();
            dtpDeb = new DateTimePicker();
            txbSalle = new TextBox();
            cbType = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPlace).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(302, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 21);
            label1.TabIndex = 15;
            label1.Text = "Ajouter un événement";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMenu);
            groupBox1.Controls.Add(btnValider);
            groupBox1.Controls.Add(Type);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labIntervenant);
            groupBox1.Controls.Add(labThNb);
            groupBox1.Controls.Add(cbIntervenant);
            groupBox1.Controls.Add(nudPlace);
            groupBox1.Controls.Add(txbTheme);
            groupBox1.Controls.Add(dtpFin);
            groupBox1.Controls.Add(dtpDeb);
            groupBox1.Controls.Add(txbSalle);
            groupBox1.Controls.Add(cbType);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 396);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(422, 359);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 29;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(319, 359);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(75, 23);
            btnValider.TabIndex = 28;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Location = new Point(305, 16);
            Type.Name = "Type";
            Type.Size = new Size(37, 15);
            Type.TabIndex = 27;
            Type.Text = "Type :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 68);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 26;
            label5.Text = "Salle :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 170);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 25;
            label4.Text = "Début :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 172);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 24;
            label3.Text = "Fin :";
            // 
            // labIntervenant
            // 
            labIntervenant.AutoSize = true;
            labIntervenant.Location = new Point(269, 318);
            labIntervenant.Name = "labIntervenant";
            labIntervenant.Size = new Size(73, 15);
            labIntervenant.TabIndex = 23;
            labIntervenant.Text = "Intervenant :";
            // 
            // labThNb
            // 
            labThNb.AutoSize = true;
            labThNb.Location = new Point(301, 231);
            labThNb.Name = "labThNb";
            labThNb.Size = new Size(38, 15);
            labThNb.TabIndex = 22;
            labThNb.Text = "label1";
            // 
            // cbIntervenant
            // 
            cbIntervenant.FormattingEnabled = true;
            cbIntervenant.Location = new Point(349, 310);
            cbIntervenant.Name = "cbIntervenant";
            cbIntervenant.Size = new Size(121, 23);
            cbIntervenant.TabIndex = 21;
            // 
            // nudPlace
            // 
            nudPlace.Location = new Point(350, 224);
            nudPlace.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudPlace.Name = "nudPlace";
            nudPlace.Size = new Size(120, 23);
            nudPlace.TabIndex = 20;
            // 
            // txbTheme
            // 
            txbTheme.Location = new Point(359, 223);
            txbTheme.Name = "txbTheme";
            txbTheme.Size = new Size(100, 23);
            txbTheme.TabIndex = 19;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(484, 164);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 18;
            // 
            // dtpDeb
            // 
            dtpDeb.Location = new Point(161, 164);
            dtpDeb.Name = "dtpDeb";
            dtpDeb.Size = new Size(200, 23);
            dtpDeb.TabIndex = 17;
            // 
            // txbSalle
            // 
            txbSalle.Location = new Point(359, 60);
            txbSalle.Name = "txbSalle";
            txbSalle.Size = new Size(100, 23);
            txbSalle.TabIndex = 16;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(349, 8);
            cbType.Name = "cbType";
            cbType.Size = new Size(121, 23);
            cbType.TabIndex = 15;
            // 
            // Event
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Event";
            Text = "Evenement";
            Load += Evenement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPlace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private Button btnMenu;
        private Button btnValider;
        private Label Type;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labIntervenant;
        private Label labThNb;
        private ComboBox cbIntervenant;
        private NumericUpDown nudPlace;
        private TextBox txbTheme;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpDeb;
        private TextBox txbSalle;
        private ComboBox cbType;
    }
}