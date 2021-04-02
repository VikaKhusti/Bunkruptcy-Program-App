using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bunkruptcy_Program_WinForm_App 
{
    public partial class Main : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Main()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE
                );
        }

        public static DataTable dt;

        private void openBtn_Click(object sender, EventArgs e)
        {
            ExcelHelper.OpenExcelFile(fileTextBox, sheetComboBox);
        }

        private void sheetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = ExcelHelper.tableCollection[sheetComboBox.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }
    }
}
