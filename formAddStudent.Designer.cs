namespace anastasia
{
    partial class formAddStudent
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
            this.Txt_numer_book = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_dictinary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add_student_from_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_numer_book
            // 
            this.Txt_numer_book.Location = new System.Drawing.Point(198, 36);
            this.Txt_numer_book.Name = "Txt_numer_book";
            this.Txt_numer_book.Size = new System.Drawing.Size(250, 26);
            this.Txt_numer_book.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(198, 108);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(250, 26);
            this.txt_name.TabIndex = 1;
            // 
            // txt_dictinary
            // 
            this.txt_dictinary.Location = new System.Drawing.Point(198, 177);
            this.txt_dictinary.Name = "txt_dictinary";
            this.txt_dictinary.Size = new System.Drawing.Size(250, 26);
            this.txt_dictinary.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "№ Зачетки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Направление";
            // 
            // btn_add_student_from_form
            // 
            this.btn_add_student_from_form.Location = new System.Drawing.Point(217, 444);
            this.btn_add_student_from_form.Name = "btn_add_student_from_form";
            this.btn_add_student_from_form.Size = new System.Drawing.Size(108, 44);
            this.btn_add_student_from_form.TabIndex = 6;
            this.btn_add_student_from_form.Text = "Добавить";
            this.btn_add_student_from_form.UseVisualStyleBackColor = true;
            this.btn_add_student_from_form.Click += new System.EventHandler(this.btn_add_student_from_form_Click);
            // 
            // formAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 512);
            this.Controls.Add(this.btn_add_student_from_form);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dictinary);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.Txt_numer_book);
            this.Name = "formAddStudent";
            this.Text = "formAddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add_student_from_form;
        public System.Windows.Forms.TextBox Txt_numer_book;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.TextBox txt_dictinary;
    }
}