namespace Tugas_week_15
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttoninput = new System.Windows.Forms.Button();
            this.buttoncopy = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.radiobuttonMakanan = new System.Windows.Forms.RadioButton();
            this.radiobuttonMinuman = new System.Windows.Forms.RadioButton();
            this.checkBoxMakanan = new System.Windows.Forms.CheckBox();
            this.checkBoxMinuman = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxSimpan = new System.Windows.Forms.ListBox();
            this.listBoxPilih = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(166, 19);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 2;
            // 
            // buttoninput
            // 
            this.buttoninput.Location = new System.Drawing.Point(166, 120);
            this.buttoninput.Name = "buttoninput";
            this.buttoninput.Size = new System.Drawing.Size(75, 23);
            this.buttoninput.TabIndex = 3;
            this.buttoninput.Text = "Input";
            this.buttoninput.UseVisualStyleBackColor = true;
            this.buttoninput.Click += new System.EventHandler(this.buttoninput_Click);
            // 
            // buttoncopy
            // 
            this.buttoncopy.Location = new System.Drawing.Point(291, 178);
            this.buttoncopy.Name = "buttoncopy";
            this.buttoncopy.Size = new System.Drawing.Size(75, 23);
            this.buttoncopy.TabIndex = 4;
            this.buttoncopy.Text = ">";
            this.buttoncopy.UseVisualStyleBackColor = true;
            this.buttoncopy.Click += new System.EventHandler(this.buttoncopy_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(291, 223);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 5;
            this.buttondelete.Text = "X";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // radiobuttonMakanan
            // 
            this.radiobuttonMakanan.AutoSize = true;
            this.radiobuttonMakanan.Location = new System.Drawing.Point(10, 16);
            this.radiobuttonMakanan.Name = "radiobuttonMakanan";
            this.radiobuttonMakanan.Size = new System.Drawing.Size(70, 17);
            this.radiobuttonMakanan.TabIndex = 6;
            this.radiobuttonMakanan.TabStop = true;
            this.radiobuttonMakanan.Text = "Makanan";
            this.radiobuttonMakanan.UseVisualStyleBackColor = true;
            // 
            // radiobuttonMinuman
            // 
            this.radiobuttonMinuman.AutoSize = true;
            this.radiobuttonMinuman.Location = new System.Drawing.Point(112, 16);
            this.radiobuttonMinuman.Name = "radiobuttonMinuman";
            this.radiobuttonMinuman.Size = new System.Drawing.Size(68, 17);
            this.radiobuttonMinuman.TabIndex = 7;
            this.radiobuttonMinuman.TabStop = true;
            this.radiobuttonMinuman.Text = "Minuman";
            this.radiobuttonMinuman.UseVisualStyleBackColor = true;
            // 
            // checkBoxMakanan
            // 
            this.checkBoxMakanan.AutoSize = true;
            this.checkBoxMakanan.Location = new System.Drawing.Point(11, 30);
            this.checkBoxMakanan.Name = "checkBoxMakanan";
            this.checkBoxMakanan.Size = new System.Drawing.Size(71, 17);
            this.checkBoxMakanan.TabIndex = 8;
            this.checkBoxMakanan.Text = "Makanan";
            this.checkBoxMakanan.UseVisualStyleBackColor = true;
            this.checkBoxMakanan.CheckedChanged += new System.EventHandler(this.checkBoxMakanan_CheckedChanged);
            // 
            // checkBoxMinuman
            // 
            this.checkBoxMinuman.AutoSize = true;
            this.checkBoxMinuman.Location = new System.Drawing.Point(11, 48);
            this.checkBoxMinuman.Name = "checkBoxMinuman";
            this.checkBoxMinuman.Size = new System.Drawing.Size(69, 17);
            this.checkBoxMinuman.TabIndex = 9;
            this.checkBoxMinuman.Text = "Minuman";
            this.checkBoxMinuman.UseVisualStyleBackColor = true;
            this.checkBoxMinuman.CheckedChanged += new System.EventHandler(this.checkBoxMinuman_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filter";
            // 
            // listBoxSimpan
            // 
            this.listBoxSimpan.FormattingEnabled = true;
            this.listBoxSimpan.Items.AddRange(new object[] {
            "Mie Instan",
            "Telor",
            "Susu Sapi",
            "Kopi",
            "Roti",
            "Keju",
            "Daging Giling",
            "Teh ",
            "Bir"});
            this.listBoxSimpan.Location = new System.Drawing.Point(36, 159);
            this.listBoxSimpan.Name = "listBoxSimpan";
            this.listBoxSimpan.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSimpan.Size = new System.Drawing.Size(159, 186);
            this.listBoxSimpan.TabIndex = 11;
            this.listBoxSimpan.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxPilih
            // 
            this.listBoxPilih.FormattingEnabled = true;
            this.listBoxPilih.Location = new System.Drawing.Point(481, 159);
            this.listBoxPilih.Name = "listBoxPilih";
            this.listBoxPilih.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxPilih.Size = new System.Drawing.Size(148, 173);
            this.listBoxPilih.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radiobuttonMakanan);
            this.panel1.Controls.Add(this.radiobuttonMinuman);
            this.panel1.Location = new System.Drawing.Point(166, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 39);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxMakanan);
            this.panel2.Controls.Add(this.checkBoxMinuman);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(291, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 82);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxPilih);
            this.Controls.Add(this.listBoxSimpan);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttoncopy);
            this.Controls.Add(this.buttoninput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttoninput;
        private System.Windows.Forms.Button buttoncopy;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.RadioButton radiobuttonMakanan;
        private System.Windows.Forms.RadioButton radiobuttonMinuman;
        private System.Windows.Forms.CheckBox checkBoxMakanan;
        private System.Windows.Forms.CheckBox checkBoxMinuman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxSimpan;
        private System.Windows.Forms.ListBox listBoxPilih;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

