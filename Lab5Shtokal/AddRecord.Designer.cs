namespace Lab5Shtokal
{
    partial class AddRecord
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.secondName = new System.Windows.Forms.TextBox();
            this.educationCombo = new System.Windows.Forms.ComboBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.expCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.languageList = new System.Windows.Forms.CheckedListBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Form:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Second Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Education";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Experience";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(128, 55);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(178, 26);
            this.name.TabIndex = 10;
            // 
            // secondName
            // 
            this.secondName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondName.Location = new System.Drawing.Point(128, 87);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(178, 26);
            this.secondName.TabIndex = 11;
            // 
            // educationCombo
            // 
            this.educationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.educationCombo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educationCombo.FormattingEnabled = true;
            this.educationCombo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.educationCombo.Items.AddRange(new object[] {
            "elementary education",
            "higher education",
            "no education",
            "secondary education"});
            this.educationCombo.Location = new System.Drawing.Point(128, 119);
            this.educationCombo.Name = "educationCombo";
            this.educationCombo.Size = new System.Drawing.Size(177, 27);
            this.educationCombo.Sorted = true;
            this.educationCombo.TabIndex = 14;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(128, 152);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(178, 26);
            this.phone.TabIndex = 15;
            // 
            // expCombo
            // 
            this.expCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expCombo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expCombo.FormattingEnabled = true;
            this.expCombo.Items.AddRange(new object[] {
            "less than 1 year",
            "from 1 to 2 years",
            "from 2 to 5 years",
            "more than 5 years"});
            this.expCombo.Location = new System.Drawing.Point(129, 184);
            this.expCombo.Name = "expCombo";
            this.expCombo.Size = new System.Drawing.Size(177, 27);
            this.expCombo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(327, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Language knowledge";
            // 
            // languageList
            // 
            this.languageList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languageList.FormattingEnabled = true;
            this.languageList.Items.AddRange(new object[] {
            "C#",
            "C++",
            "Java",
            "JavaScript",
            "PHP",
            "Python",
            "Ruby on Rails",
            "SQL",
            "Swift"});
            this.languageList.Location = new System.Drawing.Point(521, 55);
            this.languageList.Name = "languageList";
            this.languageList.Size = new System.Drawing.Size(120, 151);
            this.languageList.Sorted = true;
            this.languageList.TabIndex = 18;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(430, 212);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 40);
            this.ok.TabIndex = 19;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(617, 212);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 40);
            this.cancel.TabIndex = 20;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save and add new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddRecord
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(704, 264);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.languageList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.expCombo);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.educationCombo);
            this.Controls.Add(this.secondName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRecord";
            this.Text = "Add Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox secondName;
        private System.Windows.Forms.ComboBox educationCombo;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox expCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox languageList;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button button1;
    }
}