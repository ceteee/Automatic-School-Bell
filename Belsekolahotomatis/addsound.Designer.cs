namespace Belsekolahotomatis
{
    partial class addsound
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deletef = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lists = new System.Windows.Forms.ListBox();
            this.labelk = new System.Windows.Forms.Label();
            this.alamatfile = new System.Windows.Forms.TextBox();
            this.savef = new System.Windows.Forms.Button();
            this.browsef = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.deletef);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelk);
            this.panel1.Controls.Add(this.alamatfile);
            this.panel1.Controls.Add(this.savef);
            this.panel1.Controls.Add(this.browsef);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 305);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "berhenti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Putar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deletef
            // 
            this.deletef.Location = new System.Drawing.Point(363, 268);
            this.deletef.Name = "deletef";
            this.deletef.Size = new System.Drawing.Size(75, 23);
            this.deletef.TabIndex = 5;
            this.deletef.Text = "Hapus";
            this.deletef.UseVisualStyleBackColor = true;
            this.deletef.Click += new System.EventHandler(this.deletef_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.lists);
            this.panel2.Location = new System.Drawing.Point(15, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 201);
            this.panel2.TabIndex = 4;
            // 
            // lists
            // 
            this.lists.FormattingEnabled = true;
            this.lists.Location = new System.Drawing.Point(3, 6);
            this.lists.Name = "lists";
            this.lists.Size = new System.Drawing.Size(420, 186);
            this.lists.TabIndex = 1;
            // 
            // labelk
            // 
            this.labelk.AutoSize = true;
            this.labelk.Location = new System.Drawing.Point(214, 37);
            this.labelk.Name = "labelk";
            this.labelk.Size = new System.Drawing.Size(81, 13);
            this.labelk.TabIndex = 3;
            this.labelk.Text = "KETERANGAN";
            // 
            // alamatfile
            // 
            this.alamatfile.Location = new System.Drawing.Point(15, 6);
            this.alamatfile.Name = "alamatfile";
            this.alamatfile.Size = new System.Drawing.Size(314, 20);
            this.alamatfile.TabIndex = 2;
            // 
            // savef
            // 
            this.savef.Location = new System.Drawing.Point(15, 32);
            this.savef.Name = "savef";
            this.savef.Size = new System.Drawing.Size(75, 23);
            this.savef.TabIndex = 1;
            this.savef.Text = "&Simpan File";
            this.savef.UseVisualStyleBackColor = true;
            this.savef.Click += new System.EventHandler(this.savef_Click);
            // 
            // browsef
            // 
            this.browsef.Location = new System.Drawing.Point(335, 3);
            this.browsef.Name = "browsef";
            this.browsef.Size = new System.Drawing.Size(75, 23);
            this.browsef.TabIndex = 0;
            this.browsef.Text = "&Cari File";
            this.browsef.UseVisualStyleBackColor = true;
            this.browsef.Click += new System.EventHandler(this.browsef_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addsound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 321);
            this.Controls.Add(this.panel1);
            this.Name = "addsound";
            this.Text = "addsound";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox alamatfile;
        private System.Windows.Forms.Button savef;
        private System.Windows.Forms.Button browsef;
        private System.Windows.Forms.Label labelk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lists;
        private System.Windows.Forms.Button deletef;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}