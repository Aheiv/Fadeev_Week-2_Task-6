namespace ЛАБ6_2_WinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.MasCountDown = new System.Windows.Forms.NumericUpDown();
            this.AddArray = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ElemCountDown = new System.Windows.Forms.NumericUpDown();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.Array = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstMaxButton = new System.Windows.Forms.Button();
            this.FirstMaxBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MasCountDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElemCountDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Array)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число элементов массива";
            // 
            // MasCountDown
            // 
            this.MasCountDown.Location = new System.Drawing.Point(258, 18);
            this.MasCountDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.MasCountDown.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.MasCountDown.Name = "MasCountDown";
            this.MasCountDown.Size = new System.Drawing.Size(122, 22);
            this.MasCountDown.TabIndex = 1;
            // 
            // AddArray
            // 
            this.AddArray.Location = new System.Drawing.Point(396, 17);
            this.AddArray.Name = "AddArray";
            this.AddArray.Size = new System.Drawing.Size(75, 23);
            this.AddArray.TabIndex = 2;
            this.AddArray.Text = "Дальше";
            this.AddArray.UseVisualStyleBackColor = true;
            this.AddArray.Click += new System.EventHandler(this.AddArray_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Элемент массива №0";
            this.label2.Visible = false;
            // 
            // ElemCountDown
            // 
            this.ElemCountDown.Location = new System.Drawing.Point(174, 50);
            this.ElemCountDown.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.ElemCountDown.Minimum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            -2147483648});
            this.ElemCountDown.Name = "ElemCountDown";
            this.ElemCountDown.Size = new System.Drawing.Size(161, 22);
            this.ElemCountDown.TabIndex = 4;
            this.ElemCountDown.Visible = false;
            // 
            // AddElementButton
            // 
            this.AddElementButton.Location = new System.Drawing.Point(349, 50);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(75, 23);
            this.AddElementButton.TabIndex = 5;
            this.AddElementButton.Text = "Дальше";
            this.AddElementButton.UseVisualStyleBackColor = true;
            this.AddElementButton.Visible = false;
            this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
            // 
            // Array
            // 
            this.Array.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Array.Location = new System.Drawing.Point(12, 82);
            this.Array.Name = "Array";
            this.Array.RowHeadersWidth = 51;
            this.Array.RowTemplate.Height = 24;
            this.Array.Size = new System.Drawing.Size(562, 228);
            this.Array.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер первого максимального элемента";
            // 
            // FirstMaxButton
            // 
            this.FirstMaxButton.Location = new System.Drawing.Point(244, 319);
            this.FirstMaxButton.Name = "FirstMaxButton";
            this.FirstMaxButton.Size = new System.Drawing.Size(120, 23);
            this.FirstMaxButton.TabIndex = 8;
            this.FirstMaxButton.Text = "Вариант 9";
            this.FirstMaxButton.UseVisualStyleBackColor = true;
            this.FirstMaxButton.Click += new System.EventHandler(this.FirstMaxButton_Click);
            // 
            // FirstMaxBox
            // 
            this.FirstMaxBox.Location = new System.Drawing.Point(327, 350);
            this.FirstMaxBox.Name = "FirstMaxBox";
            this.FirstMaxBox.ReadOnly = true;
            this.FirstMaxBox.Size = new System.Drawing.Size(223, 22);
            this.FirstMaxBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 386);
            this.Controls.Add(this.FirstMaxBox);
            this.Controls.Add(this.FirstMaxButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Array);
            this.Controls.Add(this.AddElementButton);
            this.Controls.Add(this.ElemCountDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddArray);
            this.Controls.Add(this.MasCountDown);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MasCountDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElemCountDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Array)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MasCountDown;
        private System.Windows.Forms.Button AddArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ElemCountDown;
        private System.Windows.Forms.Button AddElementButton;
        private System.Windows.Forms.DataGridView Array;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FirstMaxButton;
        private System.Windows.Forms.TextBox FirstMaxBox;
    }
}

