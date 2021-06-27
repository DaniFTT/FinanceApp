
namespace FinanceApp.UserControls
{
    partial class MercadoAcougueUC
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
            this.txtNomeProduto = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLimpar = new MaterialSkin.Controls.MaterialButton();
            this.btnAddProduto = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtId = new MaterialSkin.Controls.MaterialTextBox();
            this.rbMercado = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbAcougue = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQuantidade = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtValorUnidade = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtValorKg = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQuantidadeEmKg = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.Depth = 0;
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeProduto.LeadingIcon = null;
            this.txtNomeProduto.Location = new System.Drawing.Point(234, 142);
            this.txtNomeProduto.MaxLength = 50;
            this.txtNomeProduto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomeProduto.Multiline = false;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(586, 50);
            this.txtNomeProduto.TabIndex = 56;
            this.txtNomeProduto.Text = "";
            this.txtNomeProduto.TrailingIcon = null;
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpar.HighEmphasis = true;
            this.btnLimpar.Icon = null;
            this.btnLimpar.Location = new System.Drawing.Point(735, 433);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 36);
            this.btnLimpar.TabIndex = 55;
            this.btnLimpar.Text = "   Limpar    ";
            this.btnLimpar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpar.UseAccentColor = false;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.AutoSize = false;
            this.btnAddProduto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddProduto.Depth = 0;
            this.btnAddProduto.HighEmphasis = true;
            this.btnAddProduto.Icon = null;
            this.btnAddProduto.Location = new System.Drawing.Point(96, 433);
            this.btnAddProduto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(172, 36);
            this.btnAddProduto.TabIndex = 54;
            this.btnAddProduto.Text = "Adicionar Produto";
            this.btnAddProduto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddProduto.UseAccentColor = false;
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel4.Location = new System.Drawing.Point(235, 121);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(125, 19);
            this.materialLabel4.TabIndex = 53;
            this.materialLabel4.Text = "Nome do Produto";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel2.Location = new System.Drawing.Point(97, 120);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(14, 19);
            this.materialLabel2.TabIndex = 52;
            this.materialLabel2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Depth = 0;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(93, 142);
            this.txtId.MaxLength = 50;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(124, 50);
            this.txtId.TabIndex = 51;
            this.txtId.Text = "";
            this.txtId.TrailingIcon = null;
            // 
            // rbMercado
            // 
            this.rbMercado.AutoSize = true;
            this.rbMercado.Checked = true;
            this.rbMercado.Depth = 0;
            this.rbMercado.Location = new System.Drawing.Point(3, 22);
            this.rbMercado.Margin = new System.Windows.Forms.Padding(0);
            this.rbMercado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMercado.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMercado.Name = "rbMercado";
            this.rbMercado.Ripple = true;
            this.rbMercado.Size = new System.Drawing.Size(97, 37);
            this.rbMercado.TabIndex = 60;
            this.rbMercado.TabStop = true;
            this.rbMercado.Text = "Mercado";
            this.rbMercado.UseVisualStyleBackColor = true;
            this.rbMercado.CheckedChanged += new System.EventHandler(this.rbMercado_CheckedChanged);
            // 
            // rbAcougue
            // 
            this.rbAcougue.AutoSize = true;
            this.rbAcougue.Depth = 0;
            this.rbAcougue.Location = new System.Drawing.Point(613, 22);
            this.rbAcougue.Margin = new System.Windows.Forms.Padding(0);
            this.rbAcougue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbAcougue.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbAcougue.Name = "rbAcougue";
            this.rbAcougue.Ripple = true;
            this.rbAcougue.Size = new System.Drawing.Size(97, 37);
            this.rbAcougue.TabIndex = 61;
            this.rbAcougue.TabStop = true;
            this.rbAcougue.Text = "Açougue";
            this.rbAcougue.UseVisualStyleBackColor = true;
            this.rbAcougue.CheckedChanged += new System.EventHandler(this.rbAcougue_CheckedChanged);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.rbAcougue);
            this.materialCard2.Controls.Add(this.rbMercado);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(96, 36);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(724, 63);
            this.materialCard2.TabIndex = 62;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel3.Location = new System.Drawing.Point(305, 5);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Tipo do Produto";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Depth = 0;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantidade.LeadingIcon = null;
            this.txtQuantidade.Location = new System.Drawing.Point(93, 234);
            this.txtQuantidade.MaxLength = 50;
            this.txtQuantidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(355, 50);
            this.txtQuantidade.TabIndex = 63;
            this.txtQuantidade.Text = "";
            this.txtQuantidade.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel6.Location = new System.Drawing.Point(93, 212);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(83, 19);
            this.materialLabel6.TabIndex = 66;
            this.materialLabel6.Text = "Quantidade";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel5.Location = new System.Drawing.Point(466, 212);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(100, 19);
            this.materialLabel5.TabIndex = 74;
            this.materialLabel5.Text = "Valor Unidade";
            // 
            // txtValorUnidade
            // 
            this.txtValorUnidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorUnidade.Depth = 0;
            this.txtValorUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorUnidade.LeadingIcon = null;
            this.txtValorUnidade.Location = new System.Drawing.Point(465, 234);
            this.txtValorUnidade.MaxLength = 50;
            this.txtValorUnidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValorUnidade.Multiline = false;
            this.txtValorUnidade.Name = "txtValorUnidade";
            this.txtValorUnidade.Size = new System.Drawing.Size(355, 50);
            this.txtValorUnidade.TabIndex = 73;
            this.txtValorUnidade.Text = "";
            this.txtValorUnidade.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel1.Location = new System.Drawing.Point(466, 313);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 19);
            this.materialLabel1.TabIndex = 78;
            this.materialLabel1.Text = "Valor do KG";
            // 
            // txtValorKg
            // 
            this.txtValorKg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorKg.Depth = 0;
            this.txtValorKg.Enabled = false;
            this.txtValorKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorKg.LeadingIcon = null;
            this.txtValorKg.Location = new System.Drawing.Point(465, 336);
            this.txtValorKg.MaxLength = 50;
            this.txtValorKg.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValorKg.Multiline = false;
            this.txtValorKg.Name = "txtValorKg";
            this.txtValorKg.Size = new System.Drawing.Size(355, 50);
            this.txtValorKg.TabIndex = 77;
            this.txtValorKg.Text = "";
            this.txtValorKg.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel7.Location = new System.Drawing.Point(93, 313);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(134, 19);
            this.materialLabel7.TabIndex = 76;
            this.materialLabel7.Text = "Quantidade em KG";
            // 
            // txtQuantidadeEmKg
            // 
            this.txtQuantidadeEmKg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidadeEmKg.Depth = 0;
            this.txtQuantidadeEmKg.Enabled = false;
            this.txtQuantidadeEmKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantidadeEmKg.LeadingIcon = null;
            this.txtQuantidadeEmKg.Location = new System.Drawing.Point(93, 336);
            this.txtQuantidadeEmKg.MaxLength = 50;
            this.txtQuantidadeEmKg.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantidadeEmKg.Multiline = false;
            this.txtQuantidadeEmKg.Name = "txtQuantidadeEmKg";
            this.txtQuantidadeEmKg.Size = new System.Drawing.Size(355, 50);
            this.txtQuantidadeEmKg.TabIndex = 75;
            this.txtQuantidadeEmKg.Text = "";
            this.txtQuantidadeEmKg.TrailingIcon = null;
            // 
            // MercadoAcougueUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtValorKg);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtQuantidadeEmKg);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtValorUnidade);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtId);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MercadoAcougueUC";
            this.Size = new System.Drawing.Size(912, 490);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtNomeProduto;
        private MaterialSkin.Controls.MaterialButton btnLimpar;
        private MaterialSkin.Controls.MaterialButton btnAddProduto;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialRadioButton rbMercado;
        private MaterialSkin.Controls.MaterialRadioButton rbAcougue;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtQuantidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtValorUnidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtValorKg;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox txtQuantidadeEmKg;
    }
}
