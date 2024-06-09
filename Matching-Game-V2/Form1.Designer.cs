namespace Matching_Game_V2
{
    partial class Ana_menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnTek = new Button();
            btnIki = new Button();
            label1 = new Label();
            lblScore = new Label();
            txtZorluk = new ComboBox();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnTek
            // 
            btnTek.BackColor = Color.PaleTurquoise;
            btnTek.Location = new Point(79, 122);
            btnTek.Name = "btnTek";
            btnTek.Size = new Size(187, 143);
            btnTek.TabIndex = 0;
            btnTek.Text = "Tek Oyunculu";
            btnTek.UseVisualStyleBackColor = false;
            btnTek.Click += btnTek_Click;
            // 
            // btnIki
            // 
            btnIki.BackColor = Color.PaleTurquoise;
            btnIki.Location = new Point(369, 122);
            btnIki.Name = "btnIki";
            btnIki.Size = new Size(187, 143);
            btnIki.TabIndex = 0;
            btnIki.Text = "Çift Oyunculu";
            btnIki.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(79, 268);
            label1.Name = "label1";
            label1.Size = new Size(166, 45);
            label1.TabIndex = 1;
            label1.Text = "Best Time:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblScore.Location = new Point(241, 268);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(37, 45);
            lblScore.TabIndex = 2;
            lblScore.Text = "0";
            // 
            // txtZorluk
            // 
            txtZorluk.BackColor = Color.MintCream;
            txtZorluk.FormattingEnabled = true;
            txtZorluk.Items.AddRange(new object[] { "Kolay", "Orta", "Zor" });
            txtZorluk.Location = new Point(554, 72);
            txtZorluk.Name = "txtZorluk";
            txtZorluk.Size = new Size(121, 23);
            txtZorluk.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(477, 65);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 4;
            label3.Text = "Zorluk";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // Ana_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(728, 392);
            Controls.Add(label3);
            Controls.Add(txtZorluk);
            Controls.Add(lblScore);
            Controls.Add(label1);
            Controls.Add(btnIki);
            Controls.Add(btnTek);
            Name = "Ana_menu";
            Text = "Ana Menü";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTek;
        private Button btnIki;
        private Label label1;
        private Label lblScore;
        private ComboBox txtZorluk;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
