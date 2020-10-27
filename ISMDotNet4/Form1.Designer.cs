namespace ISMDotNet4
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
            this.labelCount = new System.Windows.Forms.Label();
            this.button1generate = new System.Windows.Forms.Button();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSumofnegative = new System.Windows.Forms.Label();
            this.labelMaximumelement = new System.Windows.Forms.Label();
            this.labelMaximumelementnumber = new System.Windows.Forms.Label();
            this.labelMaximumelementmodulo = new System.Windows.Forms.Label();
            this.labelSumofindices = new System.Windows.Forms.Label();
            this.labelNumberofintegers = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewSortedarray = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewPositivearray = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSortedarray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositivearray)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(13, 25);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(107, 17);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "К-ть елементів ";
            // 
            // button1generate
            // 
            this.button1generate.Location = new System.Drawing.Point(232, 17);
            this.button1generate.Margin = new System.Windows.Forms.Padding(4);
            this.button1generate.Name = "button1generate";
            this.button1generate.Size = new System.Drawing.Size(100, 38);
            this.button1generate.TabIndex = 1;
            this.button1generate.Text = "Генерувати";
            this.button1generate.UseVisualStyleBackColor = true;
            this.button1generate.Click += new System.EventHandler(this.button1generate_Click);
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.AllowUserToDeleteRows = false;
            this.dataGridViewArray.AllowUserToResizeRows = false;
            this.dataGridViewArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(13, 63);
            this.dataGridViewArray.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.Size = new System.Drawing.Size(760, 65);
            this.dataGridViewArray.TabIndex = 2;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(129, 25);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(73, 25);
            this.textBoxCount.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(13, 137);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 38);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сума від’ємних елементів:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Максимальний елемент:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер (індекс) максимального елемента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Максимальний за модулем елемент:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Сума індексів додатних елементів:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 339);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Кількість цілих чисел:";
            // 
            // labelSumofnegative
            // 
            this.labelSumofnegative.AutoSize = true;
            this.labelSumofnegative.Location = new System.Drawing.Point(301, 190);
            this.labelSumofnegative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSumofnegative.Name = "labelSumofnegative";
            this.labelSumofnegative.Size = new System.Drawing.Size(0, 17);
            this.labelSumofnegative.TabIndex = 11;
            // 
            // labelMaximumelement
            // 
            this.labelMaximumelement.AutoSize = true;
            this.labelMaximumelement.Location = new System.Drawing.Point(301, 218);
            this.labelMaximumelement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaximumelement.Name = "labelMaximumelement";
            this.labelMaximumelement.Size = new System.Drawing.Size(0, 17);
            this.labelMaximumelement.TabIndex = 12;
            // 
            // labelMaximumelementnumber
            // 
            this.labelMaximumelementnumber.AutoSize = true;
            this.labelMaximumelementnumber.Location = new System.Drawing.Point(301, 246);
            this.labelMaximumelementnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaximumelementnumber.Name = "labelMaximumelementnumber";
            this.labelMaximumelementnumber.Size = new System.Drawing.Size(0, 17);
            this.labelMaximumelementnumber.TabIndex = 13;
            // 
            // labelMaximumelementmodulo
            // 
            this.labelMaximumelementmodulo.AutoSize = true;
            this.labelMaximumelementmodulo.Location = new System.Drawing.Point(301, 279);
            this.labelMaximumelementmodulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaximumelementmodulo.Name = "labelMaximumelementmodulo";
            this.labelMaximumelementmodulo.Size = new System.Drawing.Size(0, 17);
            this.labelMaximumelementmodulo.TabIndex = 14;
            // 
            // labelSumofindices
            // 
            this.labelSumofindices.AutoSize = true;
            this.labelSumofindices.Location = new System.Drawing.Point(301, 309);
            this.labelSumofindices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSumofindices.Name = "labelSumofindices";
            this.labelSumofindices.Size = new System.Drawing.Size(0, 17);
            this.labelSumofindices.TabIndex = 15;
            // 
            // labelNumberofintegers
            // 
            this.labelNumberofintegers.AutoSize = true;
            this.labelNumberofintegers.Location = new System.Drawing.Point(301, 339);
            this.labelNumberofintegers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberofintegers.Name = "labelNumberofintegers";
            this.labelNumberofintegers.Size = new System.Drawing.Size(0, 17);
            this.labelNumberofintegers.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Сортований масив";
            // 
            // dataGridViewSortedarray
            // 
            this.dataGridViewSortedarray.AllowUserToAddRows = false;
            this.dataGridViewSortedarray.AllowUserToDeleteRows = false;
            this.dataGridViewSortedarray.AllowUserToResizeRows = false;
            this.dataGridViewSortedarray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSortedarray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSortedarray.Location = new System.Drawing.Point(390, 170);
            this.dataGridViewSortedarray.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSortedarray.Name = "dataGridViewSortedarray";
            this.dataGridViewSortedarray.Size = new System.Drawing.Size(382, 65);
            this.dataGridViewSortedarray.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 253);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Масив позитивних чисел";
            // 
            // dataGridViewPositivearray
            // 
            this.dataGridViewPositivearray.AllowUserToAddRows = false;
            this.dataGridViewPositivearray.AllowUserToDeleteRows = false;
            this.dataGridViewPositivearray.AllowUserToResizeRows = false;
            this.dataGridViewPositivearray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPositivearray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPositivearray.Location = new System.Drawing.Point(390, 274);
            this.dataGridViewPositivearray.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPositivearray.Name = "dataGridViewPositivearray";
            this.dataGridViewPositivearray.Size = new System.Drawing.Size(382, 65);
            this.dataGridViewPositivearray.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dataGridViewPositivearray);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewSortedarray);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelNumberofintegers);
            this.Controls.Add(this.labelSumofindices);
            this.Controls.Add(this.labelMaximumelementmodulo);
            this.Controls.Add(this.labelMaximumelementnumber);
            this.Controls.Add(this.labelMaximumelement);
            this.Controls.Add(this.labelSumofnegative);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.button1generate);
            this.Controls.Add(this.labelCount);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "ISMDotNet4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSortedarray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositivearray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button button1generate;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSumofnegative;
        private System.Windows.Forms.Label labelMaximumelement;
        private System.Windows.Forms.Label labelMaximumelementnumber;
        private System.Windows.Forms.Label labelMaximumelementmodulo;
        private System.Windows.Forms.Label labelSumofindices;
        private System.Windows.Forms.Label labelNumberofintegers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewSortedarray;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewPositivearray;
    }
}

