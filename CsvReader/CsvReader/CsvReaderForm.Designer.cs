namespace CsvReader
{
    partial class CsvReaderForm
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
            this.gbFileData = new System.Windows.Forms.GroupBox();
            this.dgvCsvData = new System.Windows.Forms.DataGridView();
            this.btnLoadCsv = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.OpenCSVFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbFileData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFileData
            // 
            this.gbFileData.Controls.Add(this.dgvCsvData);
            this.gbFileData.Location = new System.Drawing.Point(14, 6);
            this.gbFileData.Name = "gbFileData";
            this.gbFileData.Size = new System.Drawing.Size(632, 378);
            this.gbFileData.TabIndex = 0;
            this.gbFileData.TabStop = false;
            this.gbFileData.Text = "CSV File data";
            // 
            // dgvCsvData
            // 
            this.dgvCsvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCsvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCsvData.Location = new System.Drawing.Point(3, 19);
            this.dgvCsvData.Name = "dgvCsvData";
            this.dgvCsvData.Size = new System.Drawing.Size(626, 356);
            this.dgvCsvData.TabIndex = 0;
            // 
            // btnLoadCsv
            // 
            this.btnLoadCsv.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCsv.Location = new System.Drawing.Point(661, 12);
            this.btnLoadCsv.Name = "btnLoadCsv";
            this.btnLoadCsv.Size = new System.Drawing.Size(75, 27);
            this.btnLoadCsv.TabIndex = 1;
            this.btnLoadCsv.Text = "Load CSV";
            this.btnLoadCsv.UseVisualStyleBackColor = true;
            this.btnLoadCsv.Click += new System.EventHandler(this.btnLoadCsv_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(661, 103);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.Location = new System.Drawing.Point(661, 56);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(75, 27);
            this.btnClearData.TabIndex = 3;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // CsvReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 396);
            this.ControlBox = false;
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoadCsv);
            this.Controls.Add(this.gbFileData);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CsvReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Csv Reader";
            this.gbFileData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFileData;
        private System.Windows.Forms.DataGridView dgvCsvData;
        private System.Windows.Forms.Button btnLoadCsv;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.OpenFileDialog OpenCSVFileDialog;
    }
}

