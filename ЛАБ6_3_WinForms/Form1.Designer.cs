
namespace ЛАБ6_3_WinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MasGridView = new System.Windows.Forms.DataGridView();
            this.MasRowCountBox = new System.Windows.Forms.NumericUpDown();
            this.MasColCountBox = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.AddMasButton = new System.Windows.Forms.Button();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FinalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MasGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasRowCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasColCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите кол-во строк массива";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите кол-во столбцов массива";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Элемент массива [0][0]";
            this.label3.Visible = false;
            // 
            // MasGridView
            // 
            this.MasGridView.AllowUserToAddRows = false;
            this.MasGridView.AllowUserToDeleteRows = false;
            this.MasGridView.AllowUserToResizeColumns = false;
            this.MasGridView.AllowUserToResizeRows = false;
            this.MasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasGridView.Location = new System.Drawing.Point(13, 135);
            this.MasGridView.Name = "MasGridView";
            this.MasGridView.RowHeadersWidth = 51;
            this.MasGridView.RowTemplate.Height = 29;
            this.MasGridView.Size = new System.Drawing.Size(578, 251);
            this.MasGridView.TabIndex = 3;
            // 
            // MasRowCountBox
            // 
            this.MasRowCountBox.Location = new System.Drawing.Point(239, 13);
            this.MasRowCountBox.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.MasRowCountBox.Minimum = new decimal(new int[] {
            276447231,
            23283,
            0,
            -2147483648});
            this.MasRowCountBox.Name = "MasRowCountBox";
            this.MasRowCountBox.Size = new System.Drawing.Size(150, 27);
            this.MasRowCountBox.TabIndex = 4;
            // 
            // MasColCountBox
            // 
            this.MasColCountBox.Location = new System.Drawing.Point(266, 46);
            this.MasColCountBox.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.MasColCountBox.Minimum = new decimal(new int[] {
            276447231,
            23283,
            0,
            -2147483648});
            this.MasColCountBox.Name = "MasColCountBox";
            this.MasColCountBox.Size = new System.Drawing.Size(150, 27);
            this.MasColCountBox.TabIndex = 5;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(189, 89);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.Visible = false;
            // 
            // AddMasButton
            // 
            this.AddMasButton.Location = new System.Drawing.Point(433, 45);
            this.AddMasButton.Name = "AddMasButton";
            this.AddMasButton.Size = new System.Drawing.Size(94, 29);
            this.AddMasButton.TabIndex = 7;
            this.AddMasButton.Text = "Дальше";
            this.AddMasButton.UseVisualStyleBackColor = true;
            this.AddMasButton.Click += new System.EventHandler(this.AddMasButton_Click);
            // 
            // AddElementButton
            // 
            this.AddElementButton.Location = new System.Drawing.Point(354, 88);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(94, 29);
            this.AddElementButton.TabIndex = 8;
            this.AddElementButton.Text = "Дальше";
            this.AddElementButton.UseVisualStyleBackColor = true;
            this.AddElementButton.Visible = false;
            this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(503, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "В массиве нечётное кол-во столбцов, изменения проведены не будут!";
            this.label4.Visible = false;
            // 
            // FinalButton
            // 
            this.FinalButton.Location = new System.Drawing.Point(189, 425);
            this.FinalButton.Name = "FinalButton";
            this.FinalButton.Size = new System.Drawing.Size(227, 29);
            this.FinalButton.TabIndex = 10;
            this.FinalButton.Text = "Поменять столбцы местами";
            this.FinalButton.UseVisualStyleBackColor = true;
            this.FinalButton.Visible = false;
            this.FinalButton.Click += new System.EventHandler(this.FinalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 483);
            this.Controls.Add(this.FinalButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddElementButton);
            this.Controls.Add(this.AddMasButton);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.MasColCountBox);
            this.Controls.Add(this.MasRowCountBox);
            this.Controls.Add(this.MasGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MasGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasRowCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasColCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView MasGridView;
        private System.Windows.Forms.NumericUpDown MasRowCountBox;
        private System.Windows.Forms.NumericUpDown MasColCountBox;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button AddMasButton;
        private System.Windows.Forms.Button AddElementButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FinalButton;
    }
}

