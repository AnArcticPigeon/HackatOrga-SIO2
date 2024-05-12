namespace HackatOrga
{
    partial class Statistique
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
            dgvStats = new DataGridView();
            btnMenu = new Button();
            btnAttelier = new Button();
            dgvAtelier = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAtelier).BeginInit();
            SuspendLayout();
            // 
            // dgvStats
            // 
            dgvStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStats.Location = new Point(2, 40);
            dgvStats.Name = "dgvStats";
            dgvStats.RowTemplate.Height = 25;
            dgvStats.Size = new Size(330, 409);
            dgvStats.TabIndex = 0;
            dgvStats.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(2, 11);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnAttelier
            // 
            btnAttelier.Location = new Point(83, 12);
            btnAttelier.Name = "btnAttelier";
            btnAttelier.Size = new Size(75, 23);
            btnAttelier.TabIndex = 2;
            btnAttelier.Text = "Ateliers";
            btnAttelier.UseVisualStyleBackColor = true;
            btnAttelier.Click += btnAttelier_Click;
            // 
            // dgvAtelier
            // 
            dgvAtelier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtelier.Location = new Point(351, 40);
            dgvAtelier.Name = "dgvAtelier";
            dgvAtelier.RowTemplate.Height = 25;
            dgvAtelier.Size = new Size(643, 421);
            dgvAtelier.TabIndex = 3;
            // 
            // Statistique
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 450);
            Controls.Add(dgvAtelier);
            Controls.Add(btnAttelier);
            Controls.Add(btnMenu);
            Controls.Add(dgvStats);
            Name = "Statistique";
            Text = "Form1";
            Load += Statistique_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStats).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAtelier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStats;
        private Button btnMenu;
        private Button btnAttelier;
        private Button button3;
        private Button button4;
        private DataGridView dgvAtelier;
    }
}