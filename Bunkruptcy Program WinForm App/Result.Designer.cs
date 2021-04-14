
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
            this.resultLabel = new MaterialSkin.Controls.MaterialLabel();
            this.resultMultiLineTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
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
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Depth = 0;
            this.resultLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resultLabel.Location = new System.Drawing.Point(7, 504);
            this.resultLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(107, 19);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "materialLabel1";
            // 
            // resultMultiLineTextBox
            // 
            this.resultMultiLineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultMultiLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultMultiLineTextBox.Depth = 0;
            this.resultMultiLineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resultMultiLineTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultMultiLineTextBox.Hint = "";
            this.resultMultiLineTextBox.Location = new System.Drawing.Point(7, 544);
            this.resultMultiLineTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultMultiLineTextBox.Name = "resultMultiLineTextBox";
            this.resultMultiLineTextBox.Size = new System.Drawing.Size(1005, 229);
            this.resultMultiLineTextBox.TabIndex = 4;
            this.resultMultiLineTextBox.Text = "";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.resultMultiLineTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.stepIIIDataGV);
            this.Controls.Add(this.stepIIDataGV);
            this.Name = "Result";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.stepIIDataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepIIIDataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stepIIDataGV;
        private System.Windows.Forms.DataGridView stepIIIDataGV;
        private MaterialSkin.Controls.MaterialLabel resultLabel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox resultMultiLineTextBox;
    }
}