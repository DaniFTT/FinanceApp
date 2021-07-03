
namespace FinanceApp.UserControls
{
    partial class ListagemMercadoAcougue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewMercado = new MaterialSkin.Controls.MaterialListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValorUnidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnExcluirMercado = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalMercado = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.listViewAcougue = new MaterialSkin.Controls.MaterialListView();
            this.chaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chaNomeProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chaValorKg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chaQuantidadeEmKg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chaTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluirAcougue = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblValorAcougue = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMercado
            // 
            this.listViewMercado.AutoSizeTable = false;
            this.listViewMercado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewMercado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMercado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chNome,
            this.chValorUnidade,
            this.chQuantidade,
            this.chTotal});
            this.listViewMercado.Depth = 0;
            this.listViewMercado.FullRowSelect = true;
            this.listViewMercado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMercado.HideSelection = false;
            this.listViewMercado.HoverSelection = true;
            this.listViewMercado.Location = new System.Drawing.Point(29, 39);
            this.listViewMercado.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewMercado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewMercado.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewMercado.MultiSelect = false;
            this.listViewMercado.Name = "listViewMercado";
            this.listViewMercado.OwnerDraw = true;
            this.listViewMercado.Size = new System.Drawing.Size(638, 193);
            this.listViewMercado.TabIndex = 2;
            this.listViewMercado.UseCompatibleStateImageBehavior = false;
            this.listViewMercado.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 50;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome do Produto";
            this.chNome.Width = 250;
            // 
            // chValorUnidade
            // 
            this.chValorUnidade.Text = "Valor Unidade";
            this.chValorUnidade.Width = 125;
            // 
            // chQuantidade
            // 
            this.chQuantidade.Text = "Quantidade";
            this.chQuantidade.Width = 110;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.Width = 103;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(26, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(102, 19);
            this.materialLabel1.TabIndex = 50;
            this.materialLabel1.Text = "Lista Mercado";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 248);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(102, 19);
            this.materialLabel2.TabIndex = 51;
            this.materialLabel2.Text = "Lista Açougue";
            // 
            // btnExcluirMercado
            // 
            this.btnExcluirMercado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluirMercado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirMercado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluirMercado.Depth = 0;
            this.btnExcluirMercado.HighEmphasis = true;
            this.btnExcluirMercado.Icon = null;
            this.btnExcluirMercado.Location = new System.Drawing.Point(674, 196);
            this.btnExcluirMercado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluirMercado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluirMercado.Name = "btnExcluirMercado";
            this.btnExcluirMercado.Size = new System.Drawing.Size(80, 36);
            this.btnExcluirMercado.TabIndex = 53;
            this.btnExcluirMercado.Text = "Excluir";
            this.btnExcluirMercado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluirMercado.UseAccentColor = true;
            this.btnExcluirMercado.UseVisualStyleBackColor = true;
            this.btnExcluirMercado.Click += new System.EventHandler(this.btnExcluirMercado_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.lblTotalMercado);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(674, 39);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(210, 121);
            this.materialCard1.TabIndex = 54;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.Location = new System.Drawing.Point(14, 66);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(41, 41);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "R$";
            // 
            // lblTotalMercado
            // 
            this.lblTotalMercado.AutoSize = true;
            this.lblTotalMercado.Depth = 0;
            this.lblTotalMercado.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalMercado.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblTotalMercado.Location = new System.Drawing.Point(61, 66);
            this.lblTotalMercado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalMercado.Name = "lblTotalMercado";
            this.lblTotalMercado.Size = new System.Drawing.Size(122, 41);
            this.lblTotalMercado.TabIndex = 1;
            this.lblTotalMercado.Text = "1288,75";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(24, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(159, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Valor no Mercado";
            // 
            // listViewAcougue
            // 
            this.listViewAcougue.AutoSizeTable = false;
            this.listViewAcougue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewAcougue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAcougue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chaID,
            this.chaNomeProduto,
            this.chaValorKg,
            this.chaQuantidadeEmKg,
            this.chaTotal});
            this.listViewAcougue.Depth = 0;
            this.listViewAcougue.FullRowSelect = true;
            this.listViewAcougue.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAcougue.HideSelection = false;
            this.listViewAcougue.HoverSelection = true;
            this.listViewAcougue.Location = new System.Drawing.Point(29, 271);
            this.listViewAcougue.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewAcougue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewAcougue.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewAcougue.MultiSelect = false;
            this.listViewAcougue.Name = "listViewAcougue";
            this.listViewAcougue.OwnerDraw = true;
            this.listViewAcougue.Size = new System.Drawing.Size(638, 193);
            this.listViewAcougue.TabIndex = 55;
            this.listViewAcougue.UseCompatibleStateImageBehavior = false;
            this.listViewAcougue.View = System.Windows.Forms.View.Details;
            // 
            // chaID
            // 
            this.chaID.Text = "ID";
            this.chaID.Width = 50;
            // 
            // chaNomeProduto
            // 
            this.chaNomeProduto.Text = "Nome do Produto";
            this.chaNomeProduto.Width = 250;
            // 
            // chaValorKg
            // 
            this.chaValorKg.Text = "Valor em KG";
            this.chaValorKg.Width = 110;
            // 
            // chaQuantidadeEmKg
            // 
            this.chaQuantidadeEmKg.Text = "Quant em KG";
            this.chaQuantidadeEmKg.Width = 120;
            // 
            // chaTotal
            // 
            this.chaTotal.Text = "Total";
            this.chaTotal.Width = 108;
            // 
            // btnExcluirAcougue
            // 
            this.btnExcluirAcougue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluirAcougue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirAcougue.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluirAcougue.Depth = 0;
            this.btnExcluirAcougue.HighEmphasis = true;
            this.btnExcluirAcougue.Icon = null;
            this.btnExcluirAcougue.Location = new System.Drawing.Point(674, 428);
            this.btnExcluirAcougue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluirAcougue.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluirAcougue.Name = "btnExcluirAcougue";
            this.btnExcluirAcougue.Size = new System.Drawing.Size(80, 36);
            this.btnExcluirAcougue.TabIndex = 56;
            this.btnExcluirAcougue.Text = "Excluir";
            this.btnExcluirAcougue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluirAcougue.UseAccentColor = true;
            this.btnExcluirAcougue.UseVisualStyleBackColor = true;
            this.btnExcluirAcougue.Click += new System.EventHandler(this.btnExcluirAcougue_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.lblValorAcougue);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(674, 271);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(210, 121);
            this.materialCard2.TabIndex = 57;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel5.Location = new System.Drawing.Point(14, 66);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(41, 41);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "R$";
            // 
            // lblValorAcougue
            // 
            this.lblValorAcougue.AutoSize = true;
            this.lblValorAcougue.Depth = 0;
            this.lblValorAcougue.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblValorAcougue.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblValorAcougue.Location = new System.Drawing.Point(61, 66);
            this.lblValorAcougue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblValorAcougue.Name = "lblValorAcougue";
            this.lblValorAcougue.Size = new System.Drawing.Size(122, 41);
            this.lblValorAcougue.TabIndex = 1;
            this.lblValorAcougue.Text = "1288,75";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(24, 14);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(158, 24);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Valor no Açougue";
            // 
            // ListagemMercadoAcougue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.btnExcluirAcougue);
            this.Controls.Add(this.listViewAcougue);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnExcluirMercado);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listViewMercado);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListagemMercadoAcougue";
            this.Size = new System.Drawing.Size(912, 490);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewMercado;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chValorUnidade;
        private System.Windows.Forms.ColumnHeader chQuantidade;
        private System.Windows.Forms.ColumnHeader chTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnExcluirMercado;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblTotalMercado;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialListView listViewAcougue;
        private System.Windows.Forms.ColumnHeader chaID;
        private System.Windows.Forms.ColumnHeader chaNomeProduto;
        private System.Windows.Forms.ColumnHeader chaValorKg;
        private System.Windows.Forms.ColumnHeader chaQuantidadeEmKg;
        private System.Windows.Forms.ColumnHeader chaTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnExcluirAcougue;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblValorAcougue;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}
