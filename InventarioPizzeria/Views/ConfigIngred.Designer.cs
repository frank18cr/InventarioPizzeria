﻿namespace InventarioPizzeria.Views
{
    partial class ConfigIngred
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.cheeseGramsTbx = new System.Windows.Forms.TextBox();
            this.doughGramsTbx = new System.Windows.Forms.TextBox();
            this.codeTbx = new System.Windows.Forms.TextBox();
            this.nameTbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.ProductoGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoughGrams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheeseGrams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCell = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteCell = new System.Windows.Forms.DataGridViewImageColumn();
            this.detailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.cheeseGramsTbx);
            this.detailPanel.Controls.Add(this.doughGramsTbx);
            this.detailPanel.Controls.Add(this.codeTbx);
            this.detailPanel.Controls.Add(this.nameTbx);
            this.detailPanel.Controls.Add(this.label6);
            this.detailPanel.Controls.Add(this.label5);
            this.detailPanel.Controls.Add(this.label4);
            this.detailPanel.Controls.Add(this.label3);
            this.detailPanel.Controls.Add(this.cancelBtn);
            this.detailPanel.Controls.Add(this.saveBtn);
            this.detailPanel.Controls.Add(this.label2);
            this.detailPanel.Location = new System.Drawing.Point(37, 361);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(709, 188);
            this.detailPanel.TabIndex = 3;
            this.detailPanel.Visible = false;
            // 
            // cheeseGramsTbx
            // 
            this.cheeseGramsTbx.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cheeseGramsTbx.Location = new System.Drawing.Point(341, 129);
            this.cheeseGramsTbx.Name = "cheeseGramsTbx";
            this.cheeseGramsTbx.Size = new System.Drawing.Size(142, 20);
            this.cheeseGramsTbx.TabIndex = 15;
            this.cheeseGramsTbx.Text = "0";
            this.cheeseGramsTbx.TextChanged += new System.EventHandler(this.numericTexbox_TextChanged);
            // 
            // doughGramsTbx
            // 
            this.doughGramsTbx.Location = new System.Drawing.Point(143, 129);
            this.doughGramsTbx.Name = "doughGramsTbx";
            this.doughGramsTbx.Size = new System.Drawing.Size(142, 20);
            this.doughGramsTbx.TabIndex = 14;
            this.doughGramsTbx.Text = "0";
            this.doughGramsTbx.TextChanged += new System.EventHandler(this.numericTexbox_TextChanged);
            // 
            // codeTbx
            // 
            this.codeTbx.Location = new System.Drawing.Point(341, 64);
            this.codeTbx.Name = "codeTbx";
            this.codeTbx.Size = new System.Drawing.Size(142, 20);
            this.codeTbx.TabIndex = 13;
            // 
            // nameTbx
            // 
            this.nameTbx.Location = new System.Drawing.Point(143, 64);
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(142, 20);
            this.nameTbx.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gramos de Queso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gramos de Masa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(516, 152);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 33);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(619, 152);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 33);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(590, 63);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(156, 36);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Agregar Producto";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ProductoGridView
            // 
            this.ProductoGridView.AllowUserToAddRows = false;
            this.ProductoGridView.AllowUserToDeleteRows = false;
            this.ProductoGridView.AllowUserToResizeRows = false;
            this.ProductoGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.ProductName,
            this.DoughGrams,
            this.CheeseGrams,
            this.ID,
            this.EditCell,
            this.DeleteCell});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductoGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductoGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductoGridView.Location = new System.Drawing.Point(36, 105);
            this.ProductoGridView.MultiSelect = false;
            this.ProductoGridView.Name = "ProductoGridView";
            this.ProductoGridView.ReadOnly = true;
            this.ProductoGridView.RowHeadersVisible = false;
            this.ProductoGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ProductoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ProductoGridView.ShowCellErrors = false;
            this.ProductoGridView.ShowCellToolTips = false;
            this.ProductoGridView.ShowEditingIcon = false;
            this.ProductoGridView.ShowRowErrors = false;
            this.ProductoGridView.Size = new System.Drawing.Size(710, 224);
            this.ProductoGridView.TabIndex = 17;
            this.ProductoGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductoGridView_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::InventarioPizzeria.Resources.edit_interface_sign;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::InventarioPizzeria.Resources.trash;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Codigo";
            this.Code.MinimumWidth = 155;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 155;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Nombre";
            this.ProductName.MinimumWidth = 155;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 155;
            // 
            // DoughGrams
            // 
            this.DoughGrams.DataPropertyName = "DoughGrams";
            this.DoughGrams.HeaderText = "Gramos de Masa";
            this.DoughGrams.MinimumWidth = 150;
            this.DoughGrams.Name = "DoughGrams";
            this.DoughGrams.ReadOnly = true;
            this.DoughGrams.Width = 150;
            // 
            // CheeseGrams
            // 
            this.CheeseGrams.DataPropertyName = "CheeseGrams";
            this.CheeseGrams.HeaderText = "Gramos de Queso";
            this.CheeseGrams.MinimumWidth = 150;
            this.CheeseGrams.Name = "CheeseGrams";
            this.CheeseGrams.ReadOnly = true;
            this.CheeseGrams.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // EditCell
            // 
            this.EditCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EditCell.HeaderText = "";
            this.EditCell.Image = global::InventarioPizzeria.Resources.edit_interface_sign;
            this.EditCell.MinimumWidth = 50;
            this.EditCell.Name = "EditCell";
            this.EditCell.ReadOnly = true;
            this.EditCell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditCell.Width = 50;
            // 
            // DeleteCell
            // 
            this.DeleteCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteCell.HeaderText = "";
            this.DeleteCell.Image = global::InventarioPizzeria.Resources.trash;
            this.DeleteCell.MinimumWidth = 50;
            this.DeleteCell.Name = "DeleteCell";
            this.DeleteCell.ReadOnly = true;
            this.DeleteCell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteCell.Width = 50;
            // 
            // ConfigIngred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ProductoGridView);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ConfigIngred";
            this.Text = "ConfigIngred";
            this.Load += new System.EventHandler(this.ConfigIngred_Load);
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cheeseGramsTbx;
        private System.Windows.Forms.TextBox doughGramsTbx;
        private System.Windows.Forms.TextBox codeTbx;
        private System.Windows.Forms.TextBox nameTbx;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView ProductoGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoughGrams;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheeseGrams;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn EditCell;
        private System.Windows.Forms.DataGridViewImageColumn DeleteCell;
    }
}