﻿namespace ViewFormWindowsForms
{
    partial class AddForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddFigureOK = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.ComboBoxChoiceFigure = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAdd = new System.Windows.Forms.DataGridView();
#if DEBUG
            this.CreateRandomData = new System.Windows.Forms.Button();
#endif
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFigureOK
            // 
            this.AddFigureOK.BackColor = System.Drawing.Color.White;
            this.AddFigureOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFigureOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddFigureOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddFigureOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.AddFigureOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFigureOK.Location = new System.Drawing.Point(12, 166);
            this.AddFigureOK.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.AddFigureOK.Name = "AddFigureOK";
            this.AddFigureOK.Size = new System.Drawing.Size(112, 32);
            this.AddFigureOK.TabIndex = 1;
            this.AddFigureOK.Text = "OK";
            this.AddFigureOK.UseVisualStyleBackColor = false;
            this.AddFigureOK.Click += new System.EventHandler(this.AddFigureOKClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 62);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(142, 166);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 32);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // ComboBoxChoiceFigure
            // 
            this.ComboBoxChoiceFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxChoiceFigure.FormattingEnabled = true;
            this.ComboBoxChoiceFigure.Items.AddRange(new object[] {
            "Круг",
            "Прямоугольник",
            "Треугольник"});
            this.ComboBoxChoiceFigure.Location = new System.Drawing.Point(6, 29);
            this.ComboBoxChoiceFigure.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxChoiceFigure.Name = "ComboBoxChoiceFigure";
            this.ComboBoxChoiceFigure.Size = new System.Drawing.Size(165, 31);
            this.ComboBoxChoiceFigure.TabIndex = 2;
            this.ComboBoxChoiceFigure.SelectedIndexChanged += new System.EventHandler(this.ChoiceFigureSelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBoxChoiceFigure);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(185, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор фигуры";
            // 
            // dataGridViewAdd
            // 
            this.dataGridViewAdd.AllowUserToAddRows = false;
            this.dataGridViewAdd.AllowUserToDeleteRows = false;
            this.dataGridViewAdd.AllowUserToResizeColumns = false;
            this.dataGridViewAdd.AllowUserToResizeRows = false;
            this.dataGridViewAdd.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdd.GridColor = System.Drawing.Color.Black;
            this.dataGridViewAdd.Location = new System.Drawing.Point(245, 12);
            this.dataGridViewAdd.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAdd.Name = "dataGridViewAdd";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdd.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAdd.RowHeadersVisible = false;
            this.dataGridViewAdd.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewAdd.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAdd.RowTemplate.Height = 24;
            this.dataGridViewAdd.Size = new System.Drawing.Size(386, 98);
            this.dataGridViewAdd.TabIndex = 4;
            this.dataGridViewAdd.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAddCellValueChanged);
            // 
            // CreateRandomData
            // 
#if DEBUG
            this.CreateRandomData.BackColor = System.Drawing.Color.White;
            this.CreateRandomData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateRandomData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CreateRandomData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CreateRandomData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.CreateRandomData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateRandomData.Location = new System.Drawing.Point(376, 166);
            this.CreateRandomData.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CreateRandomData.Name = "CreateRandomData";
            this.CreateRandomData.Size = new System.Drawing.Size(255, 32);
            this.CreateRandomData.TabIndex = 1;
            this.CreateRandomData.Text = "Ввод случайных данных";
            this.CreateRandomData.UseVisualStyleBackColor = false;
            this.CreateRandomData.Click += new System.EventHandler(this.CreateRandomDataClick);
#endif
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(654, 212);
            this.Controls.Add(this.dataGridViewAdd);
            this.Controls.Add(this.groupBox1);
#if DEBUG
            this.Controls.Add(this.CreateRandomData);
#endif
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddFigureOK);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFormClosing);
            this.Load += new System.EventHandler(this.AddFormLoad);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd)).EndInit();
            this.ResumeLayout(false);

        }

#endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox ComboBoxChoiceFigure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAdd;
        private System.Windows.Forms.Button AddFigureOK;
#if DEBUG
        private System.Windows.Forms.Button CreateRandomData;
#endif
    }
}