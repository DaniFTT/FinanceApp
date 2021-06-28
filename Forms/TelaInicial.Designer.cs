
namespace FinanceApp
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.tbControlmenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tbInicial = new System.Windows.Forms.TabPage();
            this.tbIntegrantes = new System.Windows.Forms.TabPage();
            this.tbRegistrosPagamentos = new System.Windows.Forms.TabPage();
            this.tbCadastroProdutoCompras = new System.Windows.Forms.TabPage();
            this.tbMercado = new System.Windows.Forms.TabPage();
            this.tbGastosCaseiros = new System.Windows.Forms.TabPage();
            this.tbGastosPessoais = new System.Windows.Forms.TabPage();
            this.tbControlmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlmenu
            // 
            this.tbControlmenu.Controls.Add(this.tbInicial);
            this.tbControlmenu.Controls.Add(this.tbIntegrantes);
            this.tbControlmenu.Controls.Add(this.tbRegistrosPagamentos);
            this.tbControlmenu.Controls.Add(this.tbCadastroProdutoCompras);
            this.tbControlmenu.Controls.Add(this.tbMercado);
            this.tbControlmenu.Controls.Add(this.tbGastosCaseiros);
            this.tbControlmenu.Controls.Add(this.tbGastosPessoais);
            this.tbControlmenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbControlmenu.Depth = 0;
            this.tbControlmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlmenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlmenu.ItemSize = new System.Drawing.Size(150, 18);
            this.tbControlmenu.Location = new System.Drawing.Point(3, 64);
            this.tbControlmenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbControlmenu.Multiline = true;
            this.tbControlmenu.Name = "tbControlmenu";
            this.tbControlmenu.SelectedIndex = 0;
            this.tbControlmenu.Size = new System.Drawing.Size(920, 516);
            this.tbControlmenu.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbControlmenu.TabIndex = 1;
            this.tbControlmenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbControlmenu_Selected);
            // 
            // tbInicial
            // 
            this.tbInicial.BackColor = System.Drawing.Color.White;
            this.tbInicial.ImageKey = "botao-home-para-interface.png";
            this.tbInicial.Location = new System.Drawing.Point(4, 22);
            this.tbInicial.Name = "tbInicial";
            this.tbInicial.Padding = new System.Windows.Forms.Padding(3);
            this.tbInicial.Size = new System.Drawing.Size(912, 490);
            this.tbInicial.TabIndex = 7;
            this.tbInicial.Text = "Pagina Inicial";
            // 
            // tbIntegrantes
            // 
            this.tbIntegrantes.BackColor = System.Drawing.Color.White;
            this.tbIntegrantes.ImageKey = "adicionar.png";
            this.tbIntegrantes.Location = new System.Drawing.Point(4, 22);
            this.tbIntegrantes.Name = "tbIntegrantes";
            this.tbIntegrantes.Padding = new System.Windows.Forms.Padding(3);
            this.tbIntegrantes.Size = new System.Drawing.Size(912, 490);
            this.tbIntegrantes.TabIndex = 0;
            this.tbIntegrantes.Text = "Integrantes";
            // 
            // tbRegistrosPagamentos
            // 
            this.tbRegistrosPagamentos.BackColor = System.Drawing.Color.White;
            this.tbRegistrosPagamentos.ImageKey = "veiculo-eletrico.png";
            this.tbRegistrosPagamentos.Location = new System.Drawing.Point(4, 22);
            this.tbRegistrosPagamentos.Name = "tbRegistrosPagamentos";
            this.tbRegistrosPagamentos.Size = new System.Drawing.Size(912, 490);
            this.tbRegistrosPagamentos.TabIndex = 4;
            this.tbRegistrosPagamentos.Text = "Registros de Pagamentos";
            // 
            // tbCadastroProdutoCompras
            // 
            this.tbCadastroProdutoCompras.Location = new System.Drawing.Point(4, 22);
            this.tbCadastroProdutoCompras.Name = "tbCadastroProdutoCompras";
            this.tbCadastroProdutoCompras.Size = new System.Drawing.Size(912, 490);
            this.tbCadastroProdutoCompras.TabIndex = 10;
            this.tbCadastroProdutoCompras.Text = "Cadastrar Produto";
            this.tbCadastroProdutoCompras.UseVisualStyleBackColor = true;
            // 
            // tbMercado
            // 
            this.tbMercado.BackColor = System.Drawing.Color.White;
            this.tbMercado.ImageKey = "lista-de-veiculos.png";
            this.tbMercado.Location = new System.Drawing.Point(4, 22);
            this.tbMercado.Name = "tbMercado";
            this.tbMercado.Size = new System.Drawing.Size(912, 490);
            this.tbMercado.TabIndex = 5;
            this.tbMercado.Text = "Lista Mercado/Açougue";
            // 
            // tbGastosCaseiros
            // 
            this.tbGastosCaseiros.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbGastosCaseiros.Location = new System.Drawing.Point(4, 22);
            this.tbGastosCaseiros.Name = "tbGastosCaseiros";
            this.tbGastosCaseiros.Size = new System.Drawing.Size(912, 490);
            this.tbGastosCaseiros.TabIndex = 8;
            this.tbGastosCaseiros.Text = "Gastos Caseiros";
            this.tbGastosCaseiros.UseVisualStyleBackColor = true;
            // 
            // tbGastosPessoais
            // 
            this.tbGastosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tbGastosPessoais.Name = "tbGastosPessoais";
            this.tbGastosPessoais.Size = new System.Drawing.Size(912, 490);
            this.tbGastosPessoais.TabIndex = 9;
            this.tbGastosPessoais.Text = "Gastos Pessoais";
            this.tbGastosPessoais.UseVisualStyleBackColor = true;
            // 
            // TelaInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(926, 583);
            this.Controls.Add(this.tbControlmenu);
            this.DrawerTabControl = this.tbControlmenu;
            this.DrawerWidth = 275;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.tbControlmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbControlmenu;
        private System.Windows.Forms.TabPage tbInicial;
        private System.Windows.Forms.TabPage tbIntegrantes;
        private System.Windows.Forms.TabPage tbRegistrosPagamentos;
        private System.Windows.Forms.TabPage tbMercado;
        private System.Windows.Forms.TabPage tbGastosCaseiros;
        private System.Windows.Forms.TabPage tbGastosPessoais;
        private System.Windows.Forms.TabPage tbCadastroProdutoCompras;
    }
}

