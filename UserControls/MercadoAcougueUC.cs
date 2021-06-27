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
    public partial class MercadoAcougueUC : UserControl
    {
        private int id;
        public MercadoAcougueUC()
        {
            InitializeComponent();
            IncrementaCodigo();
        }


        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeProduto = txtNomeProduto.Text;
                string tipo = rbMercado.Checked ? "Mercado" : "Açougue";

                Produto produto;
                if(tipo == "Mercado")
                {
                    int quantidade = Convert.ToInt32(txtQuantidade.Text);
                    double valorUnidade = Convert.ToDouble(txtValorUnidade.Text);
                    produto = new ProdutoMercado(id, nomeProduto, quantidade, valorUnidade);
                }
                else
                {
                    double quantidadeEmKG = Convert.ToDouble(txtQuantidadeEmKg.Text);
                    double valorKg = Convert.ToDouble(txtValorKg.Text);
                    produto = new ProdutoAcougue(id, nomeProduto, quantidadeEmKG, valorKg);
                }

                Global.produtos.Add(produto);

                JsonHandler.SalvarDados(Global.produtos);
                IncrementaCodigo();
                MaterialSkin.Controls.MaterialMessageBox.Show("Produto cadastrado com sucesso!");
                LimpaCampos();

            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }
        }


        private void IncrementaCodigo()
        {
            if (Global.produtos.Count > 0)
            {
                id = Global.produtos.Last().ProdutoId + 1;
                txtId.Text = id.ToString();
            }
            else
            {
                id = 1;
                txtId.Text = id.ToString();
            }
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

        private void rbMercado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMercado.Checked)
            {
                txtQuantidade.Enabled = true;
                txtValorUnidade.Enabled = true;
            }
            else
            {
                txtQuantidade.Enabled = false;
                txtValorUnidade.Enabled = false;
            }
        }

        private void rbAcougue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAcougue.Checked)
            {
                txtQuantidadeEmKg.Enabled = true;
                txtValorKg.Enabled = true;
            }
            else
            {
                txtQuantidadeEmKg.Enabled = false;
                txtValorKg.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

    }
}
