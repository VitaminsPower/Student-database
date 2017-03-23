namespace UniversityPart1
{
    partial class RecrutmentForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.errorLFN = new System.Windows.Forms.Label();
            this.errorLLN = new System.Windows.Forms.Label();
            this.errorLSP = new System.Windows.Forms.Label();
            this.SpecialisationCOmboBox1 = new System.Windows.Forms.ComboBox();
            this.LangComboBox1 = new System.Windows.Forms.ComboBox();
            this.errorLL = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new System.Drawing.Point(28, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 13);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new System.Drawing.Point(28, 141);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 13);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new System.Drawing.Point(590, 93);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 13);
            label4.TabIndex = 8;
            label4.Text = "Specialisation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label6.Location = new System.Drawing.Point(590, 137);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 13);
            label6.TabIndex = 18;
            label6.Text = "Language";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label8.Location = new System.Drawing.Point(344, 133);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(76, 13);
            label8.TabIndex = 25;
            label8.Text = "Phone number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label9.Location = new System.Drawing.Point(344, 95);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(39, 13);
            label9.TabIndex = 24;
            label9.Text = "Adress";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add student program";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(126, 90);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTB.TabIndex = 1;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(126, 134);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(100, 20);
            this.LastNameTB.TabIndex = 2;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentButton.Location = new System.Drawing.Point(214, 210);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(147, 36);
            this.AddStudentButton.TabIndex = 9;
            this.AddStudentButton.Text = "Add student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // errorLFN
            // 
            this.errorLFN.AutoSize = true;
            this.errorLFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLFN.ForeColor = System.Drawing.Color.Red;
            this.errorLFN.Location = new System.Drawing.Point(249, 93);
            this.errorLFN.Name = "errorLFN";
            this.errorLFN.Size = new System.Drawing.Size(41, 15);
            this.errorLFN.TabIndex = 10;
            this.errorLFN.Text = "Empty";
            this.errorLFN.Visible = false;
            // 
            // errorLLN
            // 
            this.errorLLN.AutoSize = true;
            this.errorLLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLLN.ForeColor = System.Drawing.Color.Red;
            this.errorLLN.Location = new System.Drawing.Point(249, 135);
            this.errorLLN.Name = "errorLLN";
            this.errorLLN.Size = new System.Drawing.Size(41, 15);
            this.errorLLN.TabIndex = 11;
            this.errorLLN.Text = "Empty";
            this.errorLLN.Visible = false;
            // 
            // errorLSP
            // 
            this.errorLSP.AutoSize = true;
            this.errorLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLSP.ForeColor = System.Drawing.Color.Red;
            this.errorLSP.Location = new System.Drawing.Point(803, 92);
            this.errorLSP.Name = "errorLSP";
            this.errorLSP.Size = new System.Drawing.Size(41, 15);
            this.errorLSP.TabIndex = 13;
            this.errorLSP.Text = "Empty";
            this.errorLSP.Visible = false;
            // 
            // SpecialisationCOmboBox1
            // 
            this.SpecialisationCOmboBox1.FormattingEnabled = true;
            this.SpecialisationCOmboBox1.Location = new System.Drawing.Point(668, 91);
            this.SpecialisationCOmboBox1.Name = "SpecialisationCOmboBox1";
            this.SpecialisationCOmboBox1.Size = new System.Drawing.Size(100, 21);
            this.SpecialisationCOmboBox1.TabIndex = 17;
            // 
            // LangComboBox1
            // 
            this.LangComboBox1.FormattingEnabled = true;
            this.LangComboBox1.Location = new System.Drawing.Point(668, 135);
            this.LangComboBox1.Name = "LangComboBox1";
            this.LangComboBox1.Size = new System.Drawing.Size(100, 21);
            this.LangComboBox1.TabIndex = 20;
            // 
            // errorLL
            // 
            this.errorLL.AutoSize = true;
            this.errorLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLL.ForeColor = System.Drawing.Color.Red;
            this.errorLL.Location = new System.Drawing.Point(803, 136);
            this.errorLL.Name = "errorLL";
            this.errorLL.Size = new System.Drawing.Size(41, 15);
            this.errorLL.TabIndex = 19;
            this.errorLL.Text = "Empty";
            this.errorLL.Visible = false;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(442, 131);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneTextBox.TabIndex = 23;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(442, 92);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdressTextBox.TabIndex = 22;
            // 
            // RecrutmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 337);
            this.Controls.Add(label8);
            this.Controls.Add(label9);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.LangComboBox1);
            this.Controls.Add(this.errorLL);
            this.Controls.Add(label6);
            this.Controls.Add(this.SpecialisationCOmboBox1);
            this.Controls.Add(this.errorLSP);
            this.Controls.Add(this.errorLLN);
            this.Controls.Add(this.errorLFN);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.label1);
            this.Name = "RecrutmentForm";
            this.Text = "Recrutment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Label errorLFN;
        private System.Windows.Forms.Label errorLLN;
        private System.Windows.Forms.Label errorLSP;
        private System.Windows.Forms.ComboBox SpecialisationCOmboBox1;
        private System.Windows.Forms.ComboBox LangComboBox1;
        private System.Windows.Forms.Label errorLL;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox AdressTextBox;
    }
}

