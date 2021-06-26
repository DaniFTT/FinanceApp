using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceApp
{
    public partial class TelaInicial : MaterialForm
    {

        public MaterialSkin.MaterialSkinManager materialSkinManager;
        private UserControl _objForm;

        public TelaInicial()
        {
            InitializeComponent();
            InicializaTema();
        }

        public void InicializaTema()
        {
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,
                                                                           MaterialSkin.Primary.Indigo700,
                                                                           MaterialSkin.Primary.Indigo100,
                                                                           MaterialSkin.Accent.Blue100,
                                                                           MaterialSkin.TextShade.WHITE);

        }

    }
}
