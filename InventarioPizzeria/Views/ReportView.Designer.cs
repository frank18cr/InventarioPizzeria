﻿namespace InventarioPizzeria.Views
{
    partial class ReportView
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
            this.initialDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.generateReportBtn = new System.Windows.Forms.Button();
            this.finalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // initialDatePicker
            // 
            this.initialDatePicker.CustomFormat = "";
            this.initialDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.initialDatePicker.Location = new System.Drawing.Point(252, 200);
            this.initialDatePicker.Name = "initialDatePicker";
            this.initialDatePicker.Size = new System.Drawing.Size(112, 20);
            this.initialDatePicker.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha";
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportBtn.Location = new System.Drawing.Point(309, 258);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(144, 81);
            this.generateReportBtn.TabIndex = 18;
            this.generateReportBtn.Text = "Generar Reporte";
            this.generateReportBtn.UseVisualStyleBackColor = true;
            this.generateReportBtn.Click += new System.EventHandler(this.generateReportBtn_Click);
            // 
            // finalDatePicker
            // 
            this.finalDatePicker.CustomFormat = "";
            this.finalDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finalDatePicker.Location = new System.Drawing.Point(391, 200);
            this.finalDatePicker.Name = "finalDatePicker";
            this.finalDatePicker.Size = new System.Drawing.Size(112, 20);
            this.finalDatePicker.TabIndex = 19;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.finalDatePicker);
            this.Controls.Add(this.generateReportBtn);
            this.Controls.Add(this.initialDatePicker);
            this.Controls.Add(this.label5);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker initialDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generateReportBtn;
        private System.Windows.Forms.DateTimePicker finalDatePicker;
    }
}