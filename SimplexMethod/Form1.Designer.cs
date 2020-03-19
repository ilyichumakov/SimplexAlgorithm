namespace SimplexMethod
{
    partial class Form1
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bread1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bread2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bread3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bread4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessDataMode = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Bread1,
            this.Bread2,
            this.Bread3,
            this.Bread4});
            this.dataTable.Location = new System.Drawing.Point(177, 71);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(594, 228);
            this.dataTable.TabIndex = 0;
            // 
            // Product
            // 
            this.Product.HeaderText = "Наименование продукта";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Product.Width = 150;
            // 
            // Bread1
            // 
            this.Bread1.HeaderText = "Хлеб 1";
            this.Bread1.Name = "Bread1";
            // 
            // Bread2
            // 
            this.Bread2.HeaderText = "Хлеб 2";
            this.Bread2.Name = "Bread2";
            // 
            // Bread3
            // 
            this.Bread3.HeaderText = "Хлеб 3";
            this.Bread3.Name = "Bread3";
            // 
            // Bread4
            // 
            this.Bread4.HeaderText = "Хлеб 4";
            this.Bread4.Name = "Bread4";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(420, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(390, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Нормы расхода на 1 кг хлеба (по видам)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataMode,
            this.ProcessDataMode});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem1.Text = "Вид";
            // 
            // inputDataMode
            // 
            this.inputDataMode.Checked = true;
            this.inputDataMode.CheckOnClick = true;
            this.inputDataMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inputDataMode.Enabled = false;
            this.inputDataMode.Name = "inputDataMode";
            this.inputDataMode.Size = new System.Drawing.Size(173, 22);
            this.inputDataMode.Text = "Исходные данные";
            this.inputDataMode.Click += new System.EventHandler(this.inputDataMode_Click);
            // 
            // ProcessDataMode
            // 
            this.ProcessDataMode.CheckOnClick = true;
            this.ProcessDataMode.Name = "ProcessDataMode";
            this.ProcessDataMode.Size = new System.Drawing.Size(173, 22);
            this.ProcessDataMode.Text = "Шаги";
            this.ProcessDataMode.Click += new System.EventHandler(this.ProcessDataMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(768, 480);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simplex Method";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bread1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bread2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bread3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bread4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inputDataMode;
        private System.Windows.Forms.ToolStripMenuItem ProcessDataMode;
    }
}

