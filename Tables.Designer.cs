namespace anastasia
{
    partial class Tables
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фАЙЛToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_file = new System.Windows.Forms.ToolStripMenuItem();
            this.удToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_view = new System.Windows.Forms.ToolStripMenuItem();
            this.visable_name = new System.Windows.Forms.ToolStripMenuItem();
            this.visable_object = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_Disciplaine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фАЙЛToolStripMenuItem,
            this.справочникToolStripMenuItem,
            this.menu_view});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фАЙЛToolStripMenuItem
            // 
            this.фАЙЛToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_file,
            this.удToolStripMenuItem});
            this.фАЙЛToolStripMenuItem.Name = "фАЙЛToolStripMenuItem";
            this.фАЙЛToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.фАЙЛToolStripMenuItem.Text = "Файл";
            // 
            // Save_file
            // 
            this.Save_file.Name = "Save_file";
            this.Save_file.Size = new System.Drawing.Size(206, 34);
            this.Save_file.Text = "Сохранить";
            this.Save_file.Click += new System.EventHandler(this.Save_file_Click);
            // 
            // удToolStripMenuItem
            // 
            this.удToolStripMenuItem.Name = "удToolStripMenuItem";
            this.удToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.удToolStripMenuItem.Text = "Загрузить";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(133, 27);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // menu_view
            // 
            this.menu_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visable_name,
            this.visable_object});
            this.menu_view.Name = "menu_view";
            this.menu_view.Size = new System.Drawing.Size(61, 27);
            this.menu_view.Text = "Вид";
            // 
            // visable_name
            // 
            this.visable_name.Name = "visable_name";
            this.visable_name.Size = new System.Drawing.Size(279, 34);
            this.visable_name.Text = "Показать имена";
            this.visable_name.Click += new System.EventHandler(this.visable_name_Click_1);
            // 
            // visable_object
            // 
            this.visable_object.Name = "visable_object";
            this.visable_object.Size = new System.Drawing.Size(279, 34);
            this.visable_object.Text = "Показать Предмет";
            this.visable_object.Click += new System.EventHandler(this.visable_object_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Add, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 388);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 62);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(663, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Add
            // 
            this.button_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Add.Location = new System.Drawing.Point(533, 3);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(124, 56);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.Code_Disciplaine,
            this.id_book,
            this.Score});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 357);
            this.dataGridView1.TabIndex = 3;
            // 
            // number
            // 
            this.number.HeaderText = "№ Записи";
            this.number.MinimumWidth = 8;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // Code_Disciplaine
            // 
            this.Code_Disciplaine.HeaderText = "Код дисциплины";
            this.Code_Disciplaine.MinimumWidth = 8;
            this.Code_Disciplaine.Name = "Code_Disciplaine";
            this.Code_Disciplaine.ReadOnly = true;
            // 
            // id_book
            // 
            this.id_book.HeaderText = "№ зачетки";
            this.id_book.MinimumWidth = 8;
            this.id_book.Name = "id_book";
            this.id_book.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Оценка";
            this.Score.MinimumWidth = 8;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tables";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фАЙЛToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_file;
        private System.Windows.Forms.ToolStripMenuItem удToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Disciplaine;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.ToolStripMenuItem menu_view;
        private System.Windows.Forms.ToolStripMenuItem visable_name;
        private System.Windows.Forms.ToolStripMenuItem visable_object;
    }
}

