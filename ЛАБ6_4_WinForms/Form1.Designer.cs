
namespace ЛАБ6_4_WinForms
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
            this.Add1 = new System.Windows.Forms.NumericUpDown();
            this.FirstButton = new System.Windows.Forms.Button();
            this.Add2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondButton = new System.Windows.Forms.Button();
            this.OldMas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.NewMas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Add1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldMas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewMas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размерность массива";
            // 
            // Add1
            // 
            this.Add1.Location = new System.Drawing.Point(241, 11);
            this.Add1.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.Add1.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(150, 27);
            this.Add1.TabIndex = 1;
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(397, 9);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(94, 29);
            this.FirstButton.TabIndex = 2;
            this.FirstButton.Text = "Дальше";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // Add2
            // 
            this.Add2.Location = new System.Drawing.Point(189, 50);
            this.Add2.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.Add2.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.Add2.Name = "Add2";
            this.Add2.Size = new System.Drawing.Size(150, 27);
            this.Add2.TabIndex = 3;
            this.Add2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Элемент массива [0][0]";
            this.label2.Visible = false;
            // 
            // SecondButton
            // 
            this.SecondButton.Location = new System.Drawing.Point(345, 48);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(94, 29);
            this.SecondButton.TabIndex = 5;
            this.SecondButton.Text = "Дальше";
            this.SecondButton.UseVisualStyleBackColor = true;
            this.SecondButton.Visible = false;
            this.SecondButton.Click += new System.EventHandler(this.SecondButton_Click);
            // 
            // OldMas
            // 
            this.OldMas.AllowUserToAddRows = false;
            this.OldMas.AllowUserToDeleteRows = false;
            this.OldMas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OldMas.Location = new System.Drawing.Point(12, 89);
            this.OldMas.Name = "OldMas";
            this.OldMas.ReadOnly = true;
            this.OldMas.RowHeadersWidth = 51;
            this.OldMas.RowTemplate.Height = 29;
            this.OldMas.Size = new System.Drawing.Size(601, 253);
            this.OldMas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Новый массив";
            // 
            // NewMas
            // 
            this.NewMas.AllowUserToAddRows = false;
            this.NewMas.AllowUserToDeleteRows = false;
            this.NewMas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewMas.Location = new System.Drawing.Point(13, 384);
            this.NewMas.Name = "NewMas";
            this.NewMas.ReadOnly = true;
            this.NewMas.RowHeadersWidth = 51;
            this.NewMas.RowTemplate.Height = 29;
            this.NewMas.Size = new System.Drawing.Size(600, 98);
            this.NewMas.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 494);
            this.Controls.Add(this.NewMas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OldMas);
            this.Controls.Add(this.SecondButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add2);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.Add1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Add1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldMas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewMas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Add1;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.NumericUpDown Add2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SecondButton;
        private System.Windows.Forms.DataGridView OldMas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView NewMas;
    }
}

