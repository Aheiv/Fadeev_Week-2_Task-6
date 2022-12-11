
namespace ЛАБ6_1_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MasRowCountBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MasColCountBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NineRes2 = new System.Windows.Forms.TextBox();
            this.NineButton2 = new System.Windows.Forms.Button();
            this.TwoArray = new System.Windows.Forms.DataGridView();
            this.AddButton2 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NewMasButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NineRes1 = new System.Windows.Forms.TextBox();
            this.NineButton1 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.OneArray = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.MasCountBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MasRowCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasColCountBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TwoArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasCountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MasRowCountBox
            // 
            this.MasRowCountBox.Location = new System.Drawing.Point(186, 35);
            this.MasRowCountBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.MasRowCountBox.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.MasRowCountBox.Name = "MasRowCountBox";
            this.MasRowCountBox.Size = new System.Drawing.Size(150, 27);
            this.MasRowCountBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во строк массива";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кол-во столбцов массива";
            // 
            // MasColCountBox
            // 
            this.MasColCountBox.Location = new System.Drawing.Point(213, 71);
            this.MasColCountBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.MasColCountBox.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.MasColCountBox.Name = "MasColCountBox";
            this.MasColCountBox.Size = new System.Drawing.Size(150, 27);
            this.MasColCountBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NineRes2);
            this.groupBox1.Controls.Add(this.NineButton2);
            this.groupBox1.Controls.Add(this.TwoArray);
            this.groupBox1.Controls.Add(this.AddButton2);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NewMasButton);
            this.groupBox1.Controls.Add(this.MasColCountBox);
            this.groupBox1.Controls.Add(this.MasRowCountBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(513, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 496);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Двумерный массив";
            // 
            // NineRes2
            // 
            this.NineRes2.Location = new System.Drawing.Point(152, 452);
            this.NineRes2.Name = "NineRes2";
            this.NineRes2.ReadOnly = true;
            this.NineRes2.Size = new System.Drawing.Size(308, 27);
            this.NineRes2.TabIndex = 11;
            // 
            // NineButton2
            // 
            this.NineButton2.Location = new System.Drawing.Point(173, 415);
            this.NineButton2.Name = "NineButton2";
            this.NineButton2.Size = new System.Drawing.Size(267, 32);
            this.NineButton2.TabIndex = 12;
            this.NineButton2.Text = "Сумма элементов, кратных 9";
            this.NineButton2.Click += new System.EventHandler(this.NineButton2_Click);
            // 
            // TwoArray
            // 
            this.TwoArray.AllowUserToAddRows = false;
            this.TwoArray.AllowUserToDeleteRows = false;
            this.TwoArray.AllowUserToResizeColumns = false;
            this.TwoArray.AllowUserToResizeRows = false;
            this.TwoArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TwoArray.Location = new System.Drawing.Point(11, 143);
            this.TwoArray.Name = "TwoArray";
            this.TwoArray.RowHeadersWidth = 51;
            this.TwoArray.Size = new System.Drawing.Size(558, 267);
            this.TwoArray.TabIndex = 5;
            // 
            // AddButton2
            // 
            this.AddButton2.Location = new System.Drawing.Point(427, 107);
            this.AddButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton2.Name = "AddButton2";
            this.AddButton2.Size = new System.Drawing.Size(86, 31);
            this.AddButton2.TabIndex = 4;
            this.AddButton2.Text = "Дальше";
            this.AddButton2.UseVisualStyleBackColor = true;
            this.AddButton2.Visible = false;
            this.AddButton2.Click += new System.EventHandler(this.AddButton2_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(271, 109);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Введите элемент массива [0][0] ";
            this.label5.Visible = false;
            // 
            // NewMasButton
            // 
            this.NewMasButton.Location = new System.Drawing.Point(374, 71);
            this.NewMasButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewMasButton.Name = "NewMasButton";
            this.NewMasButton.Size = new System.Drawing.Size(86, 31);
            this.NewMasButton.TabIndex = 4;
            this.NewMasButton.Text = "Дальше";
            this.NewMasButton.UseVisualStyleBackColor = true;
            this.NewMasButton.Click += new System.EventHandler(this.NewMasButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NineRes1);
            this.groupBox2.Controls.Add(this.NineButton1);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.OneArray);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.MasCountBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 496);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Одномерный массив";
            // 
            // NineRes1
            // 
            this.NineRes1.Location = new System.Drawing.Point(96, 403);
            this.NineRes1.Name = "NineRes1";
            this.NineRes1.ReadOnly = true;
            this.NineRes1.Size = new System.Drawing.Size(301, 27);
            this.NineRes1.TabIndex = 11;
            // 
            // NineButton1
            // 
            this.NineButton1.Location = new System.Drawing.Point(112, 363);
            this.NineButton1.Name = "NineButton1";
            this.NineButton1.Size = new System.Drawing.Size(267, 32);
            this.NineButton1.TabIndex = 12;
            this.NineButton1.Text = "Сумма элементов, кратных 9";
            this.NineButton1.Click += new System.EventHandler(this.NineButton1_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(383, 69);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Дальше";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите элемент массива №0";
            this.label4.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(221, 69);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Дальше";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OneArray
            // 
            this.OneArray.AllowUserToAddRows = false;
            this.OneArray.AllowUserToDeleteRows = false;
            this.OneArray.AllowUserToResizeColumns = false;
            this.OneArray.AllowUserToResizeRows = false;
            this.OneArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OneArray.Location = new System.Drawing.Point(17, 107);
            this.OneArray.Name = "OneArray";
            this.OneArray.RowHeadersWidth = 51;
            this.OneArray.Size = new System.Drawing.Size(459, 245);
            this.OneArray.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кол-во элементов массива";
            // 
            // MasCountBox
            // 
            this.MasCountBox.Location = new System.Drawing.Point(221, 35);
            this.MasCountBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.MasCountBox.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.MasCountBox.Name = "MasCountBox";
            this.MasCountBox.Size = new System.Drawing.Size(150, 27);
            this.MasCountBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MasRowCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasColCountBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TwoArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasCountBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown MasRowCountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MasColCountBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView OneArray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MasCountBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NineRes1;
        private System.Windows.Forms.Button NineButton1;
        private System.Windows.Forms.TextBox NineRes2;
        private System.Windows.Forms.Button NineButton2;
        private System.Windows.Forms.DataGridView TwoArray;
        private System.Windows.Forms.Button AddButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NewMasButton;
    }
}

