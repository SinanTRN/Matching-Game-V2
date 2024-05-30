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
            btnTek = new Button();
            btnIki = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
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
            // 
            // btnIki
            // 
            btnIki.BackColor = Color.PaleTurquoise;
            btnIki.Location = new Point(369, 122);
            btnIki.Name = "btnIki";
            btnIki.Size = new Size(187, 143);
            btnIki.TabIndex = 0;
            btnIki.Text = "İki Oyunculu";
            btnIki.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(79, 268);
            label1.Name = "label1";
            label1.Size = new Size(115, 45);
            label1.TabIndex = 1;
            label1.Text = "Score: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(189, 268);
            label2.Name = "label2";
            label2.Size = new Size(37, 45);
            label2.TabIndex = 2;
            label2.Text = "0";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.MintCream;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kolay", "Orta", "Zor" });
            comboBox1.Location = new Point(554, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
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
            // Ana_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(728, 392);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIki);
            Controls.Add(btnTek);
            Name = "Ana_menu";
            Text = "Aana Menü";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTek;
        private Button btnIki;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
    }
}
