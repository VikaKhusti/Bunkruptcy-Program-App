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
    public partial class Result : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Result()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Grey800,
                MaterialSkin.Primary.DeepOrange300,
                MaterialSkin.Primary.DeepOrange400,
                MaterialSkin.Accent.DeepOrange700,
                MaterialSkin.TextShade.WHITE
                );
        }
    }
}
