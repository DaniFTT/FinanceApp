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
    public partial class ListagemMercadoAcougue : UserControl
    {
        private double totalMercado;
        private double totalAcougue;
        public ListagemMercadoAcougue()
        {
            InitializeComponent();
            AtualizaListView();
        }

        public void AtualizaListView()
        {
            if (!(Global.produtos == null))
            {
                listViewMercado.Items.Clear();
                listViewAcougue.Items.Clear();
                totalMercado = 0.0;
                totalAcougue = 0.0;
                foreach (var produto in Global.produtos)
                {
                    string[] row;
                    ListViewItem lvi;
                    if (produto is ProdutoMercado mercado)
                    {
                        row = new string[] { produto.ProdutoId.ToString(), produto.ProdutoNome, mercado.ValorUnidade.ToString("f2"), mercado.Quantidade.ToString(), mercado.ValorTotal.ToString("f2")};
                        lvi = new ListViewItem(row)
                        {
                            Tag = produto
                        };
                        listViewMercado.Items.Add(lvi);
                        totalMercado += mercado.ValorTotal;
                    }
                    else if(produto is ProdutoAcougue acougue)
                    {
                        row = new string[] { produto.ProdutoId.ToString(), produto.ProdutoNome, acougue.ValorDoKilo.ToString("f2"), acougue.QuantidadeEmKG.ToString("f2"), acougue.ValorTotal.ToString("f2") };
                        lvi = new ListViewItem(row)
                        {
                            Tag = produto
                        };
                        listViewAcougue.Items.Add(lvi);
                        totalAcougue += acougue.ValorTotal;
                    }
                }
                lblTotalMercado.Text = totalMercado.ToString("f2");
                lblValorAcougue.Text = totalAcougue.ToString("f2");
            }
        }

        private void btnExcluirMercado_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoMercado produto = (ProdutoMercado)listViewMercado.SelectedItems[0].Tag;
                if (produto != null)
                {
                    Global.produtos.Remove(produto);

                    AtualizaListView();
                    JsonHandler.SalvarDados(Global.produtos);
                }
            }
            catch (Exception)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show("Selecione pelo menos um produto MERCADO para excluir!");
            }
        }

        private void btnExcluirAcougue_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoAcougue produto = (ProdutoAcougue)listViewAcougue.SelectedItems[0].Tag;
                if (produto != null)
                {
                    Global.produtos.Remove(produto);

                    AtualizaListView();
                    JsonHandler.SalvarDados(Global.produtos);
                }
            }
            catch (Exception)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show("Selecione pelo menos um produto AÇOUGUE para excluir!");
            }
        }
    }
}
