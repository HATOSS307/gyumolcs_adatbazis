namespace gyumolcs_adatbazis
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
            this.list_adatok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data = new System.Windows.Forms.Button();
            this.numericUpDown1_mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1_egysegar = new System.Windows.Forms.NumericUpDown();
            this.textBox1_nev = new System.Windows.Forms.TextBox();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_mennyiseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_egysegar)).BeginInit();
            this.SuspendLayout();
            // 
            // list_adatok
            // 
            this.list_adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_adatok.FormattingEnabled = true;
            this.list_adatok.Location = new System.Drawing.Point(0, 0);
            this.list_adatok.Name = "list_adatok";
            this.list_adatok.Size = new System.Drawing.Size(182, 314);
            this.list_adatok.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.numericUpDown1_mennyiseg);
            this.groupBox1.Controls.Add(this.numericUpDown1_egysegar);
            this.groupBox1.Controls.Add(this.textBox1_nev);
            this.groupBox1.Controls.Add(this.textBox1_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(182, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Az adatok";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(32, 193);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(165, 34);
            this.data.TabIndex = 8;
            this.data.Text = "Rögzítés";
            this.data.UseVisualStyleBackColor = true;
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // numericUpDown1_mennyiseg
            // 
            this.numericUpDown1_mennyiseg.Location = new System.Drawing.Point(97, 154);
            this.numericUpDown1_mennyiseg.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1_mennyiseg.Name = "numericUpDown1_mennyiseg";
            this.numericUpDown1_mennyiseg.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1_mennyiseg.TabIndex = 7;
            // 
            // numericUpDown1_egysegar
            // 
            this.numericUpDown1_egysegar.Location = new System.Drawing.Point(97, 114);
            this.numericUpDown1_egysegar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1_egysegar.Name = "numericUpDown1_egysegar";
            this.numericUpDown1_egysegar.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1_egysegar.TabIndex = 6;
            // 
            // textBox1_nev
            // 
            this.textBox1_nev.Location = new System.Drawing.Point(96, 81);
            this.textBox1_nev.Name = "textBox1_nev";
            this.textBox1_nev.Size = new System.Drawing.Size(84, 20);
            this.textBox1_nev.TabIndex = 5;
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(96, 52);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(84, 20);
            this.textBox1_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mennyiség:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Egységár:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neve:";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(32, 233);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(165, 33);
            this.update.TabIndex = 9;
            this.update.Text = "Módosítás";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(32, 272);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(165, 36);
            this.delete.TabIndex = 10;
            this.delete.Text = "Törlés";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.list_adatok);
            this.Name = "Form1";
            this.Text = "Gyümölcsök";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_mennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_egysegar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_adatok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1_mennyiseg;
        private System.Windows.Forms.NumericUpDown numericUpDown1_egysegar;
        private System.Windows.Forms.TextBox textBox1_nev;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button data;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
    }
}

