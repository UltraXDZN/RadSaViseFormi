namespace RadSaVišeFormi
{
    partial class Studenti
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
            this.AddStudent = new System.Windows.Forms.Button();
            this.RemoveAllStudents = new System.Windows.Forms.Button();
            this.listaStudenata = new System.Windows.Forms.RichTextBox();
            this.RemoveStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(12, 12);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(125, 23);
            this.AddStudent.TabIndex = 0;
            this.AddStudent.Text = "Dodaj novog studenta";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // RemoveAllStudents
            // 
            this.RemoveAllStudents.Location = new System.Drawing.Point(12, 307);
            this.RemoveAllStudents.Name = "RemoveAllStudents";
            this.RemoveAllStudents.Size = new System.Drawing.Size(125, 23);
            this.RemoveAllStudents.TabIndex = 1;
            this.RemoveAllStudents.Text = "Obriši sve studente";
            this.RemoveAllStudents.UseVisualStyleBackColor = true;
            this.RemoveAllStudents.Click += new System.EventHandler(this.RemoveAllStudents_Click);
            // 
            // listaStudenata
            // 
            this.listaStudenata.Location = new System.Drawing.Point(12, 41);
            this.listaStudenata.Name = "listaStudenata";
            this.listaStudenata.Size = new System.Drawing.Size(316, 260);
            this.listaStudenata.TabIndex = 2;
            this.listaStudenata.Text = "";
            // 
            // RemoveStudent
            // 
            this.RemoveStudent.Location = new System.Drawing.Point(349, 154);
            this.RemoveStudent.Name = "RemoveStudent";
            this.RemoveStudent.Size = new System.Drawing.Size(112, 23);
            this.RemoveStudent.TabIndex = 3;
            this.RemoveStudent.Text = "Obriši studenta";
            this.RemoveStudent.UseVisualStyleBackColor = true;
            this.RemoveStudent.Click += new System.EventHandler(this.RemoveStudent_Click);
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 342);
            this.Controls.Add(this.RemoveStudent);
            this.Controls.Add(this.listaStudenata);
            this.Controls.Add(this.RemoveAllStudents);
            this.Controls.Add(this.AddStudent);
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button RemoveAllStudents;
        private System.Windows.Forms.RichTextBox listaStudenata;
        private System.Windows.Forms.Button RemoveStudent;
    }
}

