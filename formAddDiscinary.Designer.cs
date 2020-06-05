namespace anastasia
{
    partial class formAddDiscinary
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
            this.txt_name_dictinary = new System.Windows.Forms.TextBox();
            this.btn_Add_discinary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название дисциплины";
            // 
            // txt_name_dictinary
            // 
            this.txt_name_dictinary.Location = new System.Drawing.Point(239, 27);
            this.txt_name_dictinary.Name = "txt_name_dictinary";
            this.txt_name_dictinary.Size = new System.Drawing.Size(286, 26);
            this.txt_name_dictinary.TabIndex = 1;
            // 
            // btn_Add_discinary
            // 
            this.btn_Add_discinary.Location = new System.Drawing.Point(204, 125);
            this.btn_Add_discinary.Name = "btn_Add_discinary";
            this.btn_Add_discinary.Size = new System.Drawing.Size(199, 53);
            this.btn_Add_discinary.TabIndex = 2;
            this.btn_Add_discinary.Text = "Добавить";
            this.btn_Add_discinary.UseVisualStyleBackColor = true;
            this.btn_Add_discinary.Click += new System.EventHandler(this.btn_Add_discinary_Click);
            // 
            // formAddDiscinary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 190);
            this.Controls.Add(this.btn_Add_discinary);
            this.Controls.Add(this.txt_name_dictinary);
            this.Controls.Add(this.label1);
            this.Name = "formAddDiscinary";
            this.Text = "formAddDiscinary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_name_dictinary;
        private System.Windows.Forms.Button btn_Add_discinary;
    }
}