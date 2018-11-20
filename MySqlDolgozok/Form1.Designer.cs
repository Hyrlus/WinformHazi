namespace MySqlDolgozok
{
    partial class Form1
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
            this.tbDolgozok = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCsokkeno = new System.Windows.Forms.RadioButton();
            this.rbNovekvo = new System.Windows.Forms.RadioButton();
            this.cbSzempont = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudDolgozok = new System.Windows.Forms.NumericUpDown();
            this.nudKezdo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.nudTorolSorszam = new System.Windows.Forms.NumericUpDown();
            this.btnTorol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDolgozok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKezdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTorolSorszam)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDolgozok
            // 
            this.tbDolgozok.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDolgozok.Location = new System.Drawing.Point(13, 13);
            this.tbDolgozok.Multiline = true;
            this.tbDolgozok.Name = "tbDolgozok";
            this.tbDolgozok.ReadOnly = true;
            this.tbDolgozok.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDolgozok.Size = new System.Drawing.Size(482, 274);
            this.tbDolgozok.TabIndex = 0;
            
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCsokkeno);
            this.groupBox1.Controls.Add(this.rbNovekvo);
            this.groupBox1.Controls.Add(this.cbSzempont);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendezés";
            // 
            // rbCsokkeno
            // 
            this.rbCsokkeno.AutoSize = true;
            this.rbCsokkeno.Location = new System.Drawing.Point(105, 97);
            this.rbCsokkeno.Name = "rbCsokkeno";
            this.rbCsokkeno.Size = new System.Drawing.Size(73, 17);
            this.rbCsokkeno.TabIndex = 4;
            this.rbCsokkeno.TabStop = true;
            this.rbCsokkeno.Text = "Csökkenő";
            this.rbCsokkeno.UseVisualStyleBackColor = true;
            this.rbCsokkeno.CheckedChanged += new System.EventHandler(this.rbCsokkeno_CheckedChanged);
            // 
            // rbNovekvo
            // 
            this.rbNovekvo.AutoSize = true;
            this.rbNovekvo.Location = new System.Drawing.Point(105, 73);
            this.rbNovekvo.Name = "rbNovekvo";
            this.rbNovekvo.Size = new System.Drawing.Size(69, 17);
            this.rbNovekvo.TabIndex = 3;
            this.rbNovekvo.TabStop = true;
            this.rbNovekvo.Text = "Növekvő";
            this.rbNovekvo.UseVisualStyleBackColor = true;
            this.rbNovekvo.CheckedChanged += new System.EventHandler(this.rbNovekvo_CheckedChanged);
            // 
            // cbSzempont
            // 
            this.cbSzempont.FormattingEnabled = true;
            this.cbSzempont.Items.AddRange(new object[] {
            "Név",
            "Életkor",
            "Fizetés"});
            this.cbSzempont.Location = new System.Drawing.Point(105, 31);
            this.cbSzempont.Name = "cbSzempont";
            this.cbSzempont.Size = new System.Drawing.Size(121, 21);
            this.cbSzempont.TabIndex = 2;
            this.cbSzempont.SelectedIndexChanged += new System.EventHandler(this.cbSzempont_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelleg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szempont";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudDolgozok);
            this.groupBox2.Controls.Add(this.nudKezdo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(260, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tartomány";
            // 
            // nudDolgozok
            // 
            this.nudDolgozok.Location = new System.Drawing.Point(106, 88);
            this.nudDolgozok.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDolgozok.Name = "nudDolgozok";
            this.nudDolgozok.Size = new System.Drawing.Size(120, 20);
            this.nudDolgozok.TabIndex = 3;
            this.nudDolgozok.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDolgozok.ValueChanged += new System.EventHandler(this.nudDolgozok_ValueChanged);
            // 
            // nudKezdo
            // 
            this.nudKezdo.Location = new System.Drawing.Point(106, 40);
            this.nudKezdo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudKezdo.Name = "nudKezdo";
            this.nudKezdo.Size = new System.Drawing.Size(120, 20);
            this.nudKezdo.TabIndex = 2;
            this.nudKezdo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKezdo.ValueChanged += new System.EventHandler(this.nudKezdo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dolgozók száma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kezdő Sorszám";
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(12, 450);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(129, 23);
            this.btnHozzaad.TabIndex = 3;
            this.btnHozzaad.Text = "Dolgozó hozzáadása";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(420, 450);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 4;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            // 
            // nudTorolSorszam
            // 
            this.nudTorolSorszam.Location = new System.Drawing.Point(160, 453);
            this.nudTorolSorszam.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTorolSorszam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTorolSorszam.Name = "nudTorolSorszam";
            this.nudTorolSorszam.Size = new System.Drawing.Size(48, 20);
            this.nudTorolSorszam.TabIndex = 5;
            this.nudTorolSorszam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(214, 453);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 6;
            this.btnTorol.Text = "Törlés";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 501);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.nudTorolSorszam);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDolgozok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDolgozok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKezdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTorolSorszam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDolgozok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCsokkeno;
        private System.Windows.Forms.RadioButton rbNovekvo;
        private System.Windows.Forms.ComboBox cbSzempont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDolgozok;
        private System.Windows.Forms.NumericUpDown nudKezdo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.NumericUpDown nudTorolSorszam;
        private System.Windows.Forms.Button btnTorol;
    }
}

