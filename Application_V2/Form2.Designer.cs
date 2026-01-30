namespace Application_V2
{
    partial class Form2
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.image = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Sstring = new System.Windows.Forms.TextBox();
            this.labelSstring = new System.Windows.Forms.Label();
            this.labelEstring = new System.Windows.Forms.Label();
            this.Estring = new System.Windows.Forms.TextBox();
            this.labelDose = new System.Windows.Forms.Label();
            this.Dose = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DoseForm = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.MedicineName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image.ImageLocation = "";
            this.image.Location = new System.Drawing.Point(823, 14);
            this.image.Margin = new System.Windows.Forms.Padding(6);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(450, 300);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(501, 280);
            this.Button1.Margin = new System.Windows.Forms.Padding(6);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(151, 35);
            this.Button1.TabIndex = 50;
            this.Button1.Text = "Submit";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Sstring
            // 
            this.Sstring.Location = new System.Drawing.Point(207, 15);
            this.Sstring.Margin = new System.Windows.Forms.Padding(6);
            this.Sstring.Name = "Sstring";
            this.Sstring.Size = new System.Drawing.Size(175, 30);
            this.Sstring.TabIndex = 51;
            this.Sstring.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sstring_KeyDown);
            // 
            // labelSstring
            // 
            this.labelSstring.AutoSize = true;
            this.labelSstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSstring.Location = new System.Drawing.Point(12, 15);
            this.labelSstring.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSstring.Name = "labelSstring";
            this.labelSstring.Size = new System.Drawing.Size(136, 25);
            this.labelSstring.TabIndex = 52;
            this.labelSstring.Text = "Starting letters";
            // 
            // labelEstring
            // 
            this.labelEstring.AutoSize = true;
            this.labelEstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstring.Location = new System.Drawing.Point(12, 67);
            this.labelEstring.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEstring.Name = "labelEstring";
            this.labelEstring.Size = new System.Drawing.Size(130, 25);
            this.labelEstring.TabIndex = 54;
            this.labelEstring.Text = "Ending letters";
            // 
            // Estring
            // 
            this.Estring.Location = new System.Drawing.Point(207, 67);
            this.Estring.Margin = new System.Windows.Forms.Padding(6);
            this.Estring.Name = "Estring";
            this.Estring.Size = new System.Drawing.Size(175, 30);
            this.Estring.TabIndex = 53;
            this.Estring.TextChanged += new System.EventHandler(this.Estring_TextChanged);
            this.Estring.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Estring_KeyDown);
            // 
            // labelDose
            // 
            this.labelDose.AutoSize = true;
            this.labelDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDose.Location = new System.Drawing.Point(12, 116);
            this.labelDose.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDose.Name = "labelDose";
            this.labelDose.Size = new System.Drawing.Size(80, 25);
            this.labelDose.TabIndex = 56;
            this.labelDose.Text = "Dosage";
            // 
            // Dose
            // 
            this.Dose.Location = new System.Drawing.Point(207, 116);
            this.Dose.Margin = new System.Windows.Forms.Padding(6);
            this.Dose.Name = "Dose";
            this.Dose.Size = new System.Drawing.Size(175, 30);
            this.Dose.TabIndex = 55;
            this.Dose.TextChanged += new System.EventHandler(this.Dose_TextChanged);
            this.Dose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dose_KeyDown);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(207, 212);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 30);
            this.textBox4.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "Dosage Form";
            // 
            // DoseForm
            // 
            this.DoseForm.Location = new System.Drawing.Point(207, 164);
            this.DoseForm.Margin = new System.Windows.Forms.Padding(6);
            this.DoseForm.Name = "DoseForm";
            this.DoseForm.Size = new System.Drawing.Size(175, 30);
            this.DoseForm.TabIndex = 59;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(207, 261);
            this.Age.Margin = new System.Windows.Forms.Padding(6);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(175, 30);
            this.Age.TabIndex = 57;
            this.Age.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Age_KeyDown);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MedicineName});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = null;
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView2.HideSelection = false;
            this.listView2.LabelEdit = true;
            this.listView2.Location = new System.Drawing.Point(422, 14);
            this.listView2.Margin = new System.Windows.Forms.Padding(6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(299, 260);
            this.listView2.TabIndex = 63;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // MedicineName
            // 
            this.MedicineName.Text = "Medicine Name Suggestions";
            this.MedicineName.Width = 295;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Frequency of Use";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 324);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1261, 291);
            this.listView1.TabIndex = 65;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Medicine Name";
            this.columnHeader1.Width = 152;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Generic Name";
            this.columnHeader2.Width = 164;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dosage";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dosage Form";
            this.columnHeader4.Width = 145;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Frequency";
            this.columnHeader5.Width = 118;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Age";
            this.columnHeader6.Width = 87;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Instructions";
            this.columnHeader7.Width = 478;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Age";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DoseForm);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.labelDose);
            this.Controls.Add(this.Dose);
            this.Controls.Add(this.labelEstring);
            this.Controls.Add(this.Estring);
            this.Controls.Add(this.labelSstring);
            this.Controls.Add(this.Sstring);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.image);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrescReader - Prescription Reading Assistant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox Sstring;
        private System.Windows.Forms.Label labelSstring;
        private System.Windows.Forms.Label labelEstring;
        private System.Windows.Forms.TextBox Estring;
        private System.Windows.Forms.Label labelDose;
        private System.Windows.Forms.TextBox Dose;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DoseForm;
        private System.Windows.Forms.TextBox Age;
        public System.Windows.Forms.ColumnHeader MedicineName;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}