namespace MySqlDolgozok
{
    partial class formModosit
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.rBFerfi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.nudKor = new System.Windows.Forms.NumericUpDown();
            this.tBKereset = new System.Windows.Forms.TextBox();
            this.btnMódosít = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kereset";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ft";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(108, 11);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(147, 20);
            this.tbNev.TabIndex = 5;
            // 
            // rBFerfi
            // 
            this.rBFerfi.AutoSize = true;
            this.rBFerfi.Location = new System.Drawing.Point(113, 59);
            this.rBFerfi.Name = "rBFerfi";
            this.rBFerfi.Size = new System.Drawing.Size(45, 17);
            this.rBFerfi.TabIndex = 9;
            this.rBFerfi.TabStop = true;
            this.rBFerfi.Text = "Férfi";
            this.rBFerfi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(113, 82);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 7;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "Nő";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // nudKor
            // 
            this.nudKor.Location = new System.Drawing.Point(108, 132);
            this.nudKor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKor.Name = "nudKor";
            this.nudKor.Size = new System.Drawing.Size(90, 20);
            this.nudKor.TabIndex = 8;
            this.nudKor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tBKereset
            // 
            this.tBKereset.Location = new System.Drawing.Point(108, 190);
            this.tBKereset.Name = "tBKereset";
            this.tBKereset.Size = new System.Drawing.Size(120, 20);
            this.tBKereset.TabIndex = 9;
            // 
            // btnMódosít
            // 
            this.btnMódosít.Location = new System.Drawing.Point(15, 232);
            this.btnMódosít.Name = "btnMódosít";
            this.btnMódosít.Size = new System.Drawing.Size(75, 23);
            this.btnMódosít.TabIndex = 10;
            this.btnMódosít.Text = "Módosít";
            this.btnMódosít.UseVisualStyleBackColor = true;
            // 
            // formModosit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 271);
            this.Controls.Add(this.btnMódosít);
            this.Controls.Add(this.tBKereset);
            this.Controls.Add(this.nudKor);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rBFerfi);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formModosit";
            this.Text = "formModosit";
            this.Load += new System.EventHandler(this.formModosit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.RadioButton rBFerfi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.NumericUpDown nudKor;
        private System.Windows.Forms.TextBox tBKereset;
        private System.Windows.Forms.Button btnMódosít;
    }
}