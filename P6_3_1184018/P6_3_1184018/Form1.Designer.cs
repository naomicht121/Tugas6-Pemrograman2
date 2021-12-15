namespace P6_3_1184018
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbProstud = new System.Windows.Forms.ComboBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.rbCewe = new System.Windows.Forms.RadioButton();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.dTanggal = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNPM = new NumericCharControl.NumericTextBox();
            this.txtName = new NumericCharControl.CharTextBox();
            this.txtNumber = new NumericCharControl.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(380, 726);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(187, 726);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbProstud
            // 
            this.cbProstud.FormattingEnabled = true;
            this.cbProstud.Location = new System.Drawing.Point(244, 634);
            this.cbProstud.Margin = new System.Windows.Forms.Padding(4);
            this.cbProstud.Name = "cbProstud";
            this.cbProstud.Size = new System.Drawing.Size(197, 24);
            this.cbProstud.TabIndex = 30;
            this.cbProstud.Text = "--Pilih Program Studi--";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(244, 497);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(265, 67);
            this.txtAlamat.TabIndex = 29;
            this.txtAlamat.Leave += new System.EventHandler(this.txtAlamat_Leave);
            // 
            // rbCewe
            // 
            this.rbCewe.AutoSize = true;
            this.rbCewe.Location = new System.Drawing.Point(397, 461);
            this.rbCewe.Margin = new System.Windows.Forms.Padding(4);
            this.rbCewe.Name = "rbCewe";
            this.rbCewe.Size = new System.Drawing.Size(102, 21);
            this.rbCewe.TabIndex = 28;
            this.rbCewe.TabStop = true;
            this.rbCewe.Text = "Perempuan";
            this.rbCewe.UseVisualStyleBackColor = true;
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(244, 461);
            this.rbLaki.Margin = new System.Windows.Forms.Padding(4);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(80, 21);
            this.rbLaki.TabIndex = 27;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // dTanggal
            // 
            this.dTanggal.Location = new System.Drawing.Point(244, 216);
            this.dTanggal.Margin = new System.Windows.Forms.Padding(4);
            this.dTanggal.Name = "dTanggal";
            this.dTanggal.Size = new System.Drawing.Size(265, 22);
            this.dTanggal.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 634);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Program Studi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 589);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "No Telepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 501);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 464);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tanggal Lahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "NPM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "FORM INPUT MAHASISWA";
            // 
            // txtNPM
            // 
            this.txtNPM.Location = new System.Drawing.Point(244, 134);
            this.txtNPM.Name = "txtNPM";
            this.txtNPM.Size = new System.Drawing.Size(265, 22);
            this.txtNPM.TabIndex = 33;
            this.txtNPM.Leave += new System.EventHandler(this.txtNPM_Leave);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 176);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 22);
            this.txtName.TabIndex = 34;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(244, 589);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(243, 22);
            this.txtNumber.TabIndex = 35;
            this.txtNumber.Leave += new System.EventHandler(this.txtNumber_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 824);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNPM);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbProstud);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.rbCewe);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.dTanggal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epWrong;
        private NumericCharControl.CharTextBox txtName;
        private NumericCharControl.NumericTextBox txtNPM;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbProstud;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.RadioButton rbCewe;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.DateTimePicker dTanggal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private NumericCharControl.NumericTextBox txtNumber;
    }
}

