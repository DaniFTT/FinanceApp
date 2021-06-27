
namespace FinanceApp.UserControls
{
    partial class IntegrantesUC
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
            this.btnLimpar = new MaterialSkin.Controls.MaterialButton();
            this.btnCriarIntegrante = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtId = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRendaTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.listViewIntegrantes = new MaterialSkin.Controls.MaterialListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRendaTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.chValorPCasa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluir = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = false;
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpar.HighEmphasis = true;
            this.btnLimpar.Icon = null;
            this.btnLimpar.Location = new System.Drawing.Point(801, 55);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 36);
            this.btnLimpar.TabIndex = 92;
            this.btnLimpar.Text = "   Limpar    ";
            this.btnLimpar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpar.UseAccentColor = false;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCriarIntegrante
            // 
            this.btnCriarIntegrante.AutoSize = false;
            this.btnCriarIntegrante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCriarIntegrante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarIntegrante.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnCriarIntegrante.Depth = 0;
            this.btnCriarIntegrante.HighEmphasis = true;
            this.btnCriarIntegrante.Icon = null;
            this.btnCriarIntegrante.Location = new System.Drawing.Point(607, 55);
            this.btnCriarIntegrante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCriarIntegrante.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCriarIntegrante.Name = "btnCriarIntegrante";
            this.btnCriarIntegrante.Size = new System.Drawing.Size(168, 36);
            this.btnCriarIntegrante.TabIndex = 91;
            this.btnCriarIntegrante.Text = "Salvar Integrante";
            this.btnCriarIntegrante.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCriarIntegrante.UseAccentColor = false;
            this.btnCriarIntegrante.UseVisualStyleBackColor = true;
            this.btnCriarIntegrante.Click += new System.EventHandler(this.btnCriarIntegrante_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel2.Location = new System.Drawing.Point(33, 27);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(14, 19);
            this.materialLabel2.TabIndex = 73;
            this.materialLabel2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Depth = 0;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(32, 48);
            this.txtId.MaxLength = 50;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(79, 50);
            this.txtId.TabIndex = 72;
            this.txtId.Text = "";
            this.txtId.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel1.Location = new System.Drawing.Point(152, 27);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 96;
            this.materialLabel1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(152, 49);
            this.txtNome.MaxLength = 50;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 50);
            this.txtNome.TabIndex = 95;
            this.txtNome.Text = "";
            this.txtNome.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel4.Location = new System.Drawing.Point(415, 25);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(87, 19);
            this.materialLabel4.TabIndex = 98;
            this.materialLabel4.Text = "Renda Total";
            // 
            // txtRendaTotal
            // 
            this.txtRendaTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRendaTotal.Depth = 0;
            this.txtRendaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRendaTotal.LeadingIcon = null;
            this.txtRendaTotal.Location = new System.Drawing.Point(413, 49);
            this.txtRendaTotal.MaxLength = 50;
            this.txtRendaTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRendaTotal.Multiline = false;
            this.txtRendaTotal.Name = "txtRendaTotal";
            this.txtRendaTotal.Size = new System.Drawing.Size(162, 50);
            this.txtRendaTotal.TabIndex = 97;
            this.txtRendaTotal.Text = "";
            this.txtRendaTotal.TrailingIcon = null;
            // 
            // listViewIntegrantes
            // 
            this.listViewIntegrantes.AutoSizeTable = false;
            this.listViewIntegrantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewIntegrantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewIntegrantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chNome,
            this.chRendaTotal,
            this.chValorPCasa});
            this.listViewIntegrantes.Depth = 0;
            this.listViewIntegrantes.FullRowSelect = true;
            this.listViewIntegrantes.GridLines = true;
            this.listViewIntegrantes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewIntegrantes.HideSelection = false;
            this.listViewIntegrantes.HoverSelection = true;
            this.listViewIntegrantes.Location = new System.Drawing.Point(32, 161);
            this.listViewIntegrantes.MaximumSize = new System.Drawing.Size(743, 312);
            this.listViewIntegrantes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewIntegrantes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewIntegrantes.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewIntegrantes.Name = "listViewIntegrantes";
            this.listViewIntegrantes.OwnerDraw = true;
            this.listViewIntegrantes.Size = new System.Drawing.Size(743, 312);
            this.listViewIntegrantes.TabIndex = 99;
            this.listViewIntegrantes.UseCompatibleStateImageBehavior = false;
            this.listViewIntegrantes.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 65;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 225;
            // 
            // chRendaTotal
            // 
            this.chRendaTotal.Text = "Renda Total";
            this.chRendaTotal.Width = 225;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(31, 129);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(213, 29);
            this.materialLabel3.TabIndex = 100;
            this.materialLabel3.Text = "Lista de Integrantes";
            // 
            // chValorPCasa
            // 
            this.chValorPCasa.Text = "Valor p/ Casa";
            this.chValorPCasa.Width = 225;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = false;
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.Location = new System.Drawing.Point(801, 437);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 36);
            this.btnExcluir.TabIndex = 101;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = true;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // IntegrantesUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.listViewIntegrantes);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtRendaTotal);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCriarIntegrante);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtId);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IntegrantesUC";
            this.Size = new System.Drawing.Size(912, 490);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnLimpar;
        private MaterialSkin.Controls.MaterialButton btnCriarIntegrante;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtRendaTotal;
        private MaterialSkin.Controls.MaterialListView listViewIntegrantes;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chRendaTotal;
        private System.Windows.Forms.ColumnHeader chValorPCasa;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnExcluir;
    }
}
