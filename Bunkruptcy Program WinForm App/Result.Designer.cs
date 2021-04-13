
namespace Bunkruptcy_Program_WinForm_App
{
    partial class Result
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
            this.stepIIDataGV = new System.Windows.Forms.DataGridView();
            this.stepIIIDataGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stepIIDataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepIIIDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // stepIIDataGV
            // 
            this.stepIIDataGV.AllowUserToAddRows = false;
            this.stepIIDataGV.AllowUserToDeleteRows = false;
            this.stepIIDataGV.AllowUserToOrderColumns = true;
            this.stepIIDataGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stepIIDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stepIIDataGV.Location = new System.Drawing.Point(7, 71);
            this.stepIIDataGV.Name = "stepIIDataGV";
            this.stepIIDataGV.ReadOnly = true;
            this.stepIIDataGV.RowTemplate.Height = 25;
            this.stepIIDataGV.Size = new System.Drawing.Size(796, 200);
            this.stepIIDataGV.TabIndex = 0;
            // 
            // stepIIIDataGV
            // 
            this.stepIIIDataGV.AllowUserToAddRows = false;
            this.stepIIIDataGV.AllowUserToDeleteRows = false;
            this.stepIIIDataGV.AllowUserToOrderColumns = true;
            this.stepIIIDataGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stepIIIDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stepIIIDataGV.Location = new System.Drawing.Point(7, 286);
            this.stepIIIDataGV.Name = "stepIIIDataGV";
            this.stepIIIDataGV.ReadOnly = true;
            this.stepIIIDataGV.RowTemplate.Height = 25;
            this.stepIIIDataGV.Size = new System.Drawing.Size(552, 194);
            this.stepIIIDataGV.TabIndex = 1;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 593);
            this.Controls.Add(this.stepIIIDataGV);
            this.Controls.Add(this.stepIIDataGV);
            this.Name = "Result";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.stepIIDataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepIIIDataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stepIIDataGV;
        private System.Windows.Forms.DataGridView stepIIIDataGV;
    }
}