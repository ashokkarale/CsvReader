using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvReader
{
    public partial class CsvReaderForm : Form
    {
        public CsvReaderForm()
        {
            InitializeComponent();
        }

        private void btnLoadCsv_Click(object sender, EventArgs e)
        {
            DataLoader();
        }

        private void DataLoader()
        {
            string filePath = string.Empty;
            OpenCSVFileDialog.Filter = "CSV files (*.csv)|*.csv";
            OpenCSVFileDialog.InitialDirectory = @"D:\";
            OpenCSVFileDialog.Title = "Please select Report CSV file.";
            OpenCSVFileDialog.FileName = "";
            if (OpenCSVFileDialog.ShowDialog() == DialogResult.OK)
            {
                var start = DateTime.Now;
                string dialogPath = OpenCSVFileDialog.FileName;
                if (dialogPath.Contains(".csv"))
                {
                    //Do your work
                    filePath = dialogPath;
                    try
                    {
                        using (var csv = new CachedCsvReader(new StreamReader(filePath), true))
                        {
                            dgvCsvData.DataSource = csv;
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message + " occred while reading csv file data.");
                    }
                }
                else
                {
                    MessageBox.Show("File is not in correct format. Please select again.");
                }
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            dgvCsvData.DataSource = null;
            dgvCsvData.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
