using FinanceApp.UserControls;
using FinanceApp.Utilities;
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
            AtualizaTodasListas();
        }


        private void tbControlmenu_Selected(object sender, TabControlEventArgs e)
        {
            _objForm?.Dispose();
            _objForm?.Controls.Remove(_objForm);


            if (tbControlmenu.SelectedTab == tbIntegrantes)
            {
                Text = "Integrantes";
                _objForm = new IntegrantesUC
                {
                    Dock = DockStyle.Fill
                };

                tbControlmenu.SelectedTab.Controls.Add(_objForm);
                _objForm.Show();
            }


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

        public void AtualizaTodasListas()
        {
            Global.integrantes = JsonHandler.ListaDeIntegrantes();

        }

    }
}
