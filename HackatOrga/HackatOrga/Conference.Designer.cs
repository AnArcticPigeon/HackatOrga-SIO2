namespace HackatOrga
{
    partial class Conference
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
            btnMenu = new Button();
            btnEmail = new Button();
            dgvConference = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvConference).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(12, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(93, 12);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(117, 23);
            btnEmail.TabIndex = 1;
            btnEmail.Text = "Envoyer Email";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += button2_Click;
            // 
            // dgvConference
            // 
            dgvConference.AllowUserToResizeColumns = false;
            dgvConference.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConference.Location = new Point(23, 52);
            dgvConference.Name = "dgvConference";
            dgvConference.RowTemplate.Height = 25;
            dgvConference.RowTemplate.ReadOnly = true;
            dgvConference.Size = new Size(765, 386);
            dgvConference.TabIndex = 2;
            dgvConference.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(304, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 43);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Yellow;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(268, 20);
            label6.MinimumSize = new Size(15, 15);
            label6.Name = "label6";
            label6.Size = new Size(15, 17);
            label6.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Red;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(156, 18);
            label5.MinimumSize = new Size(15, 15);
            label5.Name = "label5";
            label5.Size = new Size(15, 17);
            label5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 192, 0);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(45, 18);
            label4.MinimumSize = new Size(15, 15);
            label4.Name = "label4";
            label4.Size = new Size(15, 17);
            label4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 20);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 8;
            label3.Text = "Dans - 7 jours";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 20);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Terminer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 20);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "En Cours";
            // 
            // Conference
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvConference);
            Controls.Add(btnEmail);
            Controls.Add(btnMenu);
            Name = "Conference";
            Text = "Conference";
            Load += Conference_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConference).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenu;
        private Button btnEmail;
        private DataGridView dgvConference;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}