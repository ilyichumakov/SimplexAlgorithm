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
            this.button1 = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bread1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bread2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bread3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bread4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Bread1,
            this.Bread2,
            this.Bread3,
            this.Bread4});
            this.dataTable.Location = new System.Drawing.Point(123, 55);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(594, 228);
            this.dataTable.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(434, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(313, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Нормы расхода на 1 кг хлеба (по видам)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTable);
            this.MinimumSize = new System.Drawing.Size(768, 480);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simplex Method";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

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
    }
}

