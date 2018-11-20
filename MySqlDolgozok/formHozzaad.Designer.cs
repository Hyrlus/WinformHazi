namespace MySqlDolgozok
{
    partial class formHozzaad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbKereset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFerfi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.nudKor = new System.Windows.Forms.NumericUpDown();
            this.btnHozzáad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kereset";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(108, 13);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(130, 20);
            this.tbNev.TabIndex = 4;
            this.tbNev.TextChanged += new System.EventHandler(this.tbNev_TextChanged);
            // 
            // tbKereset
            // 
            this.tbKereset.Location = new System.Drawing.Point(108, 175);
            this.tbKereset.Name = "tbKereset";
            this.tbKereset.Size = new System.Drawing.Size(100, 20);
            this.tbKereset.TabIndex = 5;
            this.tbKereset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKereset_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ft";
            // 
            // rbFerfi
            // 
            this.rbFerfi.AutoSize = true;
            this.rbFerfi.Location = new System.Drawing.Point(108, 61);
            this.rbFerfi.Name = "rbFerfi";
            this.rbFerfi.Size = new System.Drawing.Size(45, 17);
            this.rbFerfi.TabIndex = 7;
            this.rbFerfi.TabStop = true;
            this.rbFerfi.Text = "Férfi";
            this.rbFerfi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(108, 85);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 8;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "Nő";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // nudKor
            // 
            this.nudKor.Location = new System.Drawing.Point(108, 131);
            this.nudKor.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudKor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKor.Name = "nudKor";
            this.nudKor.Size = new System.Drawing.Size(100, 20);
            this.nudKor.TabIndex = 9;
            this.nudKor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            
            // 
            // btnHozzáad
            // 
            this.btnHozzáad.Location = new System.Drawing.Point(13, 222);
            this.btnHozzáad.Name = "btnHozzáad";
            this.btnHozzáad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzáad.TabIndex = 10;
            this.btnHozzáad.Text = "Hozzáadás";
            this.btnHozzáad.UseVisualStyleBackColor = true;
            this.btnHozzáad.Click += new System.EventHandler(this.btnHozzáad_Click);
            // 
            // formHozzaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnHozzáad);
            this.Controls.Add(this.nudKor);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbFerfi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbKereset);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formHozzaad";
            this.Text = "formHozzaad";
            ((System.ComponentModel.ISupportInitialize)(this.nudKor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbKereset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbFerfi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.NumericUpDown nudKor;
        private System.Windows.Forms.Button btnHozzáad;
    }
}