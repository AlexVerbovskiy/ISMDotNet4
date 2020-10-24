namespace WindowsFormsApp2
{
    partial class FormArray
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
            this.buttonKElements = new System.Windows.Forms.Button();
            this.labelKElements = new System.Windows.Forms.Label();
            this.textBoxKElements = new System.Windows.Forms.TextBox();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.labelSumNegativesElements = new System.Windows.Forms.Label();
            this.labelMaxElement = new System.Windows.Forms.Label();
            this.labelIndexMaxElement = new System.Windows.Forms.Label();
            this.labelMaxAbs = new System.Windows.Forms.Label();
            this.labelKPositiveElements = new System.Windows.Forms.Label();
            this.labelKIntElements = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.labelDelNegElements = new System.Windows.Forms.Label();
            this.MaxAbs = new System.Windows.Forms.Label();
            this.SumNegativesElements = new System.Windows.Forms.Label();
            this.MaxElement = new System.Windows.Forms.Label();
            this.IndexMaxElement = new System.Windows.Forms.Label();
            this.KPositiveElements = new System.Windows.Forms.Label();
            this.KIntElements = new System.Windows.Forms.Label();
            this.Sort = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.dataGridViewSortArray = new System.Windows.Forms.DataGridView();
            this.dataGridViewDeleterNegetiveElements = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSortArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleterNegetiveElements)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKElements
            // 
            this.buttonKElements.Location = new System.Drawing.Point(202, 12);
            this.buttonKElements.Name = "buttonKElements";
            this.buttonKElements.Size = new System.Drawing.Size(106, 28);
            this.buttonKElements.TabIndex = 0;
            this.buttonKElements.Text = "Зчитати";
            this.buttonKElements.UseVisualStyleBackColor = true;
            this.buttonKElements.Click += new System.EventHandler(this.buttonKElements_Click);
            // 
            // labelKElements
            // 
            this.labelKElements.AutoSize = true;
            this.labelKElements.Location = new System.Drawing.Point(12, 20);
            this.labelKElements.Name = "labelKElements";
            this.labelKElements.Size = new System.Drawing.Size(150, 13);
            this.labelKElements.TabIndex = 1;
            this.labelKElements.Text = "Введіть кількість елементів:";
            // 
            // textBoxKElements
            // 
            this.textBoxKElements.Location = new System.Drawing.Point(168, 17);
            this.textBoxKElements.Name = "textBoxKElements";
            this.textBoxKElements.Size = new System.Drawing.Size(28, 20);
            this.textBoxKElements.TabIndex = 2;
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.AllowUserToDeleteRows = false;
            this.dataGridViewArray.AllowUserToResizeColumns = false;
            this.dataGridViewArray.AllowUserToResizeRows = false;
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(15, 48);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.Size = new System.Drawing.Size(773, 96);
            this.dataGridViewArray.TabIndex = 3;
            // 
            // labelSumNegativesElements
            // 
            this.labelSumNegativesElements.AutoSize = true;
            this.labelSumNegativesElements.Location = new System.Drawing.Point(18, 177);
            this.labelSumNegativesElements.Name = "labelSumNegativesElements";
            this.labelSumNegativesElements.Size = new System.Drawing.Size(190, 13);
            this.labelSumNegativesElements.TabIndex = 4;
            this.labelSumNegativesElements.Text = "Cума негативних елементів масиву:";
            this.labelSumNegativesElements.Visible = false;
            // 
            // labelMaxElement
            // 
            this.labelMaxElement.AutoSize = true;
            this.labelMaxElement.Location = new System.Drawing.Point(18, 199);
            this.labelMaxElement.Name = "labelMaxElement";
            this.labelMaxElement.Size = new System.Drawing.Size(173, 13);
            this.labelMaxElement.TabIndex = 5;
            this.labelMaxElement.Text = "Максимальний елемент масиву:";
            this.labelMaxElement.Visible = false;
            // 
            // labelIndexMaxElement
            // 
            this.labelIndexMaxElement.AutoSize = true;
            this.labelIndexMaxElement.Location = new System.Drawing.Point(18, 220);
            this.labelIndexMaxElement.Name = "labelIndexMaxElement";
            this.labelIndexMaxElement.Size = new System.Drawing.Size(219, 13);
            this.labelIndexMaxElement.TabIndex = 4;
            this.labelIndexMaxElement.Text = "Індекс максимального елементу масива:";
            this.labelIndexMaxElement.Visible = false;
            // 
            // labelMaxAbs
            // 
            this.labelMaxAbs.AutoSize = true;
            this.labelMaxAbs.Location = new System.Drawing.Point(18, 242);
            this.labelMaxAbs.Name = "labelMaxAbs";
            this.labelMaxAbs.Size = new System.Drawing.Size(236, 13);
            this.labelMaxAbs.TabIndex = 5;
            this.labelMaxAbs.Text = "Максимальний елемент масиву за модулем:";
            this.labelMaxAbs.Visible = false;
            // 
            // labelKPositiveElements
            // 
            this.labelKPositiveElements.AutoSize = true;
            this.labelKPositiveElements.Location = new System.Drawing.Point(18, 265);
            this.labelKPositiveElements.Name = "labelKPositiveElements";
            this.labelKPositiveElements.Size = new System.Drawing.Size(178, 13);
            this.labelKPositiveElements.TabIndex = 4;
            this.labelKPositiveElements.Text = "Сума індексів додатніх елементів:";
            this.labelKPositiveElements.Visible = false;
            // 
            // labelKIntElements
            // 
            this.labelKIntElements.AutoSize = true;
            this.labelKIntElements.Location = new System.Drawing.Point(18, 287);
            this.labelKIntElements.Name = "labelKIntElements";
            this.labelKIntElements.Size = new System.Drawing.Size(138, 13);
            this.labelKIntElements.TabIndex = 5;
            this.labelKIntElements.Text = "Кількість цілих елементів:";
            this.labelKIntElements.Visible = false;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(18, 308);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(183, 13);
            this.labelSort.TabIndex = 4;
            this.labelSort.Text = "Cортування масиву за спаданням:";
            this.labelSort.Visible = false;
            // 
            // labelDelNegElements
            // 
            this.labelDelNegElements.AutoSize = true;
            this.labelDelNegElements.Location = new System.Drawing.Point(18, 426);
            this.labelDelNegElements.Name = "labelDelNegElements";
            this.labelDelNegElements.Size = new System.Drawing.Size(179, 13);
            this.labelDelNegElements.TabIndex = 5;
            this.labelDelNegElements.Text = "Видалення негативних елементів:";
            this.labelDelNegElements.Visible = false;
            // 
            // MaxAbs
            // 
            this.MaxAbs.AutoSize = true;
            this.MaxAbs.Location = new System.Drawing.Point(260, 242);
            this.MaxAbs.Name = "MaxAbs";
            this.MaxAbs.Size = new System.Drawing.Size(13, 13);
            this.MaxAbs.TabIndex = 6;
            this.MaxAbs.Text = "4";
            this.MaxAbs.Visible = false;
            // 
            // SumNegativesElements
            // 
            this.SumNegativesElements.AutoSize = true;
            this.SumNegativesElements.Location = new System.Drawing.Point(214, 177);
            this.SumNegativesElements.Name = "SumNegativesElements";
            this.SumNegativesElements.Size = new System.Drawing.Size(13, 13);
            this.SumNegativesElements.TabIndex = 7;
            this.SumNegativesElements.Text = "1";
            this.SumNegativesElements.Visible = false;
            // 
            // MaxElement
            // 
            this.MaxElement.AutoSize = true;
            this.MaxElement.Location = new System.Drawing.Point(197, 199);
            this.MaxElement.Name = "MaxElement";
            this.MaxElement.Size = new System.Drawing.Size(13, 13);
            this.MaxElement.TabIndex = 7;
            this.MaxElement.Text = "2";
            this.MaxElement.Visible = false;
            // 
            // IndexMaxElement
            // 
            this.IndexMaxElement.AutoSize = true;
            this.IndexMaxElement.Location = new System.Drawing.Point(243, 220);
            this.IndexMaxElement.Name = "IndexMaxElement";
            this.IndexMaxElement.Size = new System.Drawing.Size(13, 13);
            this.IndexMaxElement.TabIndex = 7;
            this.IndexMaxElement.Text = "3";
            this.IndexMaxElement.Visible = false;
            // 
            // KPositiveElements
            // 
            this.KPositiveElements.AutoSize = true;
            this.KPositiveElements.Location = new System.Drawing.Point(202, 265);
            this.KPositiveElements.Name = "KPositiveElements";
            this.KPositiveElements.Size = new System.Drawing.Size(13, 13);
            this.KPositiveElements.TabIndex = 7;
            this.KPositiveElements.Text = "5";
            this.KPositiveElements.Visible = false;
            // 
            // KIntElements
            // 
            this.KIntElements.AutoSize = true;
            this.KIntElements.Location = new System.Drawing.Point(162, 287);
            this.KIntElements.Name = "KIntElements";
            this.KIntElements.Size = new System.Drawing.Size(13, 13);
            this.KIntElements.TabIndex = 7;
            this.KIntElements.Text = "6";
            this.KIntElements.Visible = false;
            // 
            // Sort
            // 
            this.Sort.AutoSize = true;
            this.Sort.Location = new System.Drawing.Point(207, 308);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(0, 13);
            this.Sort.TabIndex = 7;
            this.Sort.Visible = false;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(336, 150);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(103, 27);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Обрахування";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Visible = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // dataGridViewSortArray
            // 
            this.dataGridViewSortArray.AllowUserToAddRows = false;
            this.dataGridViewSortArray.AllowUserToDeleteRows = false;
            this.dataGridViewSortArray.AllowUserToResizeColumns = false;
            this.dataGridViewSortArray.AllowUserToResizeRows = false;
            this.dataGridViewSortArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSortArray.Location = new System.Drawing.Point(21, 324);
            this.dataGridViewSortArray.Name = "dataGridViewSortArray";
            this.dataGridViewSortArray.Size = new System.Drawing.Size(767, 99);
            this.dataGridViewSortArray.TabIndex = 9;
            this.dataGridViewSortArray.Visible = false;
            // 
            // dataGridViewDeleterNegetiveElements
            // 
            this.dataGridViewDeleterNegetiveElements.AllowUserToAddRows = false;
            this.dataGridViewDeleterNegetiveElements.AllowUserToDeleteRows = false;
            this.dataGridViewDeleterNegetiveElements.AllowUserToResizeColumns = false;
            this.dataGridViewDeleterNegetiveElements.AllowUserToResizeRows = false;
            this.dataGridViewDeleterNegetiveElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleterNegetiveElements.Location = new System.Drawing.Point(21, 442);
            this.dataGridViewDeleterNegetiveElements.Name = "dataGridViewDeleterNegetiveElements";
            this.dataGridViewDeleterNegetiveElements.Size = new System.Drawing.Size(767, 99);
            this.dataGridViewDeleterNegetiveElements.TabIndex = 9;
            this.dataGridViewDeleterNegetiveElements.Visible = false;
            // 
            // FormArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.dataGridViewDeleterNegetiveElements);
            this.Controls.Add(this.dataGridViewSortArray);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.KIntElements);
            this.Controls.Add(this.KPositiveElements);
            this.Controls.Add(this.IndexMaxElement);
            this.Controls.Add(this.MaxElement);
            this.Controls.Add(this.SumNegativesElements);
            this.Controls.Add(this.MaxAbs);
            this.Controls.Add(this.labelDelNegElements);
            this.Controls.Add(this.labelMaxAbs);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.labelIndexMaxElement);
            this.Controls.Add(this.labelKIntElements);
            this.Controls.Add(this.labelMaxElement);
            this.Controls.Add(this.labelKPositiveElements);
            this.Controls.Add(this.labelSumNegativesElements);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.textBoxKElements);
            this.Controls.Add(this.labelKElements);
            this.Controls.Add(this.buttonKElements);
            this.Name = "FormArray";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormArray";
            this.Load += new System.EventHandler(this.FormArray_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSortArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleterNegetiveElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKElements;
        private System.Windows.Forms.Label labelKElements;
        private System.Windows.Forms.TextBox textBoxKElements;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Label labelSumNegativesElements;
        private System.Windows.Forms.Label labelMaxElement;
        private System.Windows.Forms.Label labelIndexMaxElement;
        private System.Windows.Forms.Label labelMaxAbs;
        private System.Windows.Forms.Label labelKPositiveElements;
        private System.Windows.Forms.Label labelKIntElements;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Label labelDelNegElements;
        private System.Windows.Forms.Label MaxAbs;
        private System.Windows.Forms.Label SumNegativesElements;
        private System.Windows.Forms.Label MaxElement;
        private System.Windows.Forms.Label IndexMaxElement;
        private System.Windows.Forms.Label KPositiveElements;
        private System.Windows.Forms.Label KIntElements;
        private System.Windows.Forms.Label Sort;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.DataGridView dataGridViewSortArray;
        private System.Windows.Forms.DataGridView dataGridViewDeleterNegetiveElements;
    }
}

