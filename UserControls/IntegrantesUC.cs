using FinanceApp.Models;
using FinanceApp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceApp.UserControls
{
    public partial class IntegrantesUC : UserControl
    {
        private int id;
        public IntegrantesUC()
        {
            InitializeComponent();
            AtualizaListView();
            IncrementaCodigo();
        }

        private void btnCriarIntegrante_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCamposVazios())
                {
                    string nome = txtNome.Text;
                    double rendaTotal =  Convert.ToDouble(txtRendaTotal.Text);

                    Integrante integrante = new Integrante(id ,nome, rendaTotal);

                    Global.integrantes.Add(integrante);

                    JsonHandler.SalvarDados(Global.integrantes);

                    AdicionaItemList(integrante);
                    IncrementaCodigo();
                    LimpaCampos();
                }
                else
                    MaterialSkin.Controls.MaterialMessageBox.Show("Preencha todos os atributos desse veiculo!");
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }


        }


        private void IncrementaCodigo()
        {
            if (Global.integrantes.Count > 0)
            {
                id = Global.integrantes.Last().Id + 1;
                txtId.Text = id.ToString();
            }
            else
            {
                id = 1;
                txtId.Text = id.ToString();
            }
        }


        private void AtualizaListView()
        {
            if (!(Global.integrantes == null))
            {
                listViewIntegrantes.Items.Clear();

                foreach (var integrante in Global.integrantes)
                {
                    AdicionaItemList(integrante);
                }
            }

        }

        private void AdicionaItemList(Integrante integrante)
        {
            var row = new string[] { integrante.Id.ToString(), integrante.Nome, integrante.RendaTotal.ToString("f2"), integrante.ValorPCasa.ToString("f2") };

            var lvi = new ListViewItem(row)
            {
                Tag = integrante
            };

            listViewIntegrantes.Items.Add(lvi);
        }

        private bool VerificaCamposVazios()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MaterialSkin.Controls.MaterialTextBox && ctrl.Enabled == true && (string.IsNullOrWhiteSpace(ctrl.Text)))
                {
                    return false;
                }
            }
            return true;
        }

        private void LimpaCampos()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MaterialSkin.Controls.MaterialTextBox && ctrl.Enabled == true)
                {
                    ((MaterialSkin.Controls.MaterialTextBox)(ctrl)).Clear();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Integrante selectedIntegrante = (Integrante)listViewIntegrantes.SelectedItems[0].Tag;
                if (selectedIntegrante != null)
                {
                    Global.integrantes.Remove(selectedIntegrante);

                    JsonHandler.SalvarDados(Global.integrantes);

                    listViewIntegrantes.Items.Remove(listViewIntegrantes.SelectedItems[0]);
                }
            }
            catch (Exception)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show("Selecione pelo menos um Integrante para excluir!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
