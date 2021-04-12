using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bunkruptcy_Program_WinForm_App
{
    class ExcelHelper
    {
        public static DataTableCollection tableCollection;
        public static void OpenExcelFile(MaterialSkin.Controls.MaterialTextBox tb, ComboBox cb)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = ("*.xls|*xlsx") })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tb.Text = openFileDialog.FileName;
                    try
                    {
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet data = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = data.Tables;
                                cb.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                    cb.Items.Add(table.TableName);
                            }
                        }
                    } catch (Exception e)
                    {
                        MessageBox.Show(
                        "Не можливо відкрити файл",
                        "Помилка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    }
                }
            }
        }
    }
}
