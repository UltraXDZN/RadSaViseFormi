namespace RadSaVišeFormi
{
    partial class UnosNovogStudenta
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
            this.nameText = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.secondNameText = new System.Windows.Forms.Label();
            this.secondNameTxtBox = new System.Windows.Forms.TextBox();
            this.indexNumText = new System.Windows.Forms.Label();
            this.indexNumTxtBox = new System.Windows.Forms.TextBox();
            this.typeTxtBox = new System.Windows.Forms.ComboBox();
            this.typeText = new System.Windows.Forms.Label();
            this.dayOfBirthDateTime = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthText = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.abortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Location = new System.Drawing.Point(12, 13);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(27, 13);
            this.nameText.TabIndex = 3;
            this.nameText.Text = "Ime:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(12, 29);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(156, 20);
            this.nameTxtBox.TabIndex = 2;
            // 
            // secondNameText
            // 
            this.secondNameText.AutoSize = true;
            this.secondNameText.Location = new System.Drawing.Point(12, 67);
            this.secondNameText.Name = "secondNameText";
            this.secondNameText.Size = new System.Drawing.Size(44, 13);
            this.secondNameText.TabIndex = 5;
            this.secondNameText.Text = "Prezime";
            // 
            // secondNameTxtBox
            // 
            this.secondNameTxtBox.Location = new System.Drawing.Point(12, 83);
            this.secondNameTxtBox.Name = "secondNameTxtBox";
            this.secondNameTxtBox.Size = new System.Drawing.Size(156, 20);
            this.secondNameTxtBox.TabIndex = 4;
            // 
            // indexNumText
            // 
            this.indexNumText.AutoSize = true;
            this.indexNumText.Location = new System.Drawing.Point(254, 13);
            this.indexNumText.Name = "indexNumText";
            this.indexNumText.Size = new System.Drawing.Size(69, 13);
            this.indexNumText.TabIndex = 7;
            this.indexNumText.Text = "Broj Indeksa:";
            // 
            // indexNumTxtBox
            // 
            this.indexNumTxtBox.Location = new System.Drawing.Point(254, 29);
            this.indexNumTxtBox.Name = "indexNumTxtBox";
            this.indexNumTxtBox.Size = new System.Drawing.Size(200, 20);
            this.indexNumTxtBox.TabIndex = 6;
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.FormattingEnabled = true;
            this.typeTxtBox.Items.AddRange(new object[] {
            "Programer",
            "Mrežni Administrator",
            "Administrator sustava"});
            this.typeTxtBox.Location = new System.Drawing.Point(12, 145);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.Size = new System.Drawing.Size(156, 21);
            this.typeTxtBox.TabIndex = 8;
            // 
            // typeText
            // 
            this.typeText.AutoSize = true;
            this.typeText.Location = new System.Drawing.Point(12, 129);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(36, 13);
            this.typeText.TabIndex = 9;
            this.typeText.Text = "Smjer:";
            // 
            // dayOfBirthDateTime
            // 
            this.dayOfBirthDateTime.Location = new System.Drawing.Point(254, 83);
            this.dayOfBirthDateTime.Name = "dayOfBirthDateTime";
            this.dayOfBirthDateTime.Size = new System.Drawing.Size(200, 20);
            this.dayOfBirthDateTime.TabIndex = 10;
            // 
            // dateOfBirthText
            // 
            this.dateOfBirthText.AutoSize = true;
            this.dateOfBirthText.Location = new System.Drawing.Point(254, 67);
            this.dateOfBirthText.Name = "dateOfBirthText";
            this.dateOfBirthText.Size = new System.Drawing.Size(85, 13);
            this.dateOfBirthText.TabIndex = 11;
            this.dateOfBirthText.Text = "Datum Rođenja:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 197);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Snimi";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // abortButton
            // 
            this.abortButton.Location = new System.Drawing.Point(379, 197);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(75, 23);
            this.abortButton.TabIndex = 13;
            this.abortButton.Text = "Otkaži";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // UnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 239);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateOfBirthText);
            this.Controls.Add(this.dayOfBirthDateTime);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.typeTxtBox);
            this.Controls.Add(this.indexNumText);
            this.Controls.Add(this.indexNumTxtBox);
            this.Controls.Add(this.secondNameText);
            this.Controls.Add(this.secondNameTxtBox);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "UnosNovogStudenta";
            this.Text = "UnosNovogStudenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label secondNameText;
        private System.Windows.Forms.TextBox secondNameTxtBox;
        private System.Windows.Forms.Label indexNumText;
        private System.Windows.Forms.TextBox indexNumTxtBox;
        private System.Windows.Forms.ComboBox typeTxtBox;
        private System.Windows.Forms.Label typeText;
        private System.Windows.Forms.DateTimePicker dayOfBirthDateTime;
        private System.Windows.Forms.Label dateOfBirthText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button abortButton;
    }
}