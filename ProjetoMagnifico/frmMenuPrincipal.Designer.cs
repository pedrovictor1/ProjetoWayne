namespace ProjetoMagnifico
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerenciarUsuario = new System.Windows.Forms.Button();
            this.btnGerenciarFornecedores = new System.Windows.Forms.Button();
            this.btnGerenciarProdutos = new System.Windows.Forms.Button();
            this.btnGerenciarFuncionarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-64, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerenciarUsuario
            // 
            this.btnGerenciarUsuario.BackColor = System.Drawing.Color.White;
            this.btnGerenciarUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarUsuario.Location = new System.Drawing.Point(94, 75);
            this.btnGerenciarUsuario.Name = "btnGerenciarUsuario";
            this.btnGerenciarUsuario.Size = new System.Drawing.Size(125, 26);
            this.btnGerenciarUsuario.TabIndex = 2;
            this.btnGerenciarUsuario.Text = "Gerenciar Usuário";
            this.btnGerenciarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarFornecedores
            // 
            this.btnGerenciarFornecedores.BackColor = System.Drawing.Color.White;
            this.btnGerenciarFornecedores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarFornecedores.Location = new System.Drawing.Point(83, 291);
            this.btnGerenciarFornecedores.Name = "btnGerenciarFornecedores";
            this.btnGerenciarFornecedores.Size = new System.Drawing.Size(155, 27);
            this.btnGerenciarFornecedores.TabIndex = 3;
            this.btnGerenciarFornecedores.Text = "Gerenciar Fornecedores";
            this.btnGerenciarFornecedores.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarProdutos
            // 
            this.btnGerenciarProdutos.BackColor = System.Drawing.Color.White;
            this.btnGerenciarProdutos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarProdutos.Location = new System.Drawing.Point(94, 31);
            this.btnGerenciarProdutos.Name = "btnGerenciarProdutos";
            this.btnGerenciarProdutos.Size = new System.Drawing.Size(128, 28);
            this.btnGerenciarProdutos.TabIndex = 1;
            this.btnGerenciarProdutos.Text = "Gerenciar Produtos";
            this.btnGerenciarProdutos.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarFuncionarios
            // 
            this.btnGerenciarFuncionarios.BackColor = System.Drawing.Color.White;
            this.btnGerenciarFuncionarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarFuncionarios.Location = new System.Drawing.Point(83, 335);
            this.btnGerenciarFuncionarios.Name = "btnGerenciarFuncionarios";
            this.btnGerenciarFuncionarios.Size = new System.Drawing.Size(155, 28);
            this.btnGerenciarFuncionarios.TabIndex = 4;
            this.btnGerenciarFuncionarios.Text = "Gerenciar Funcionários";
            this.btnGerenciarFuncionarios.UseVisualStyleBackColor = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 368);
            this.Controls.Add(this.btnGerenciarUsuario);
            this.Controls.Add(this.btnGerenciarFornecedores);
            this.Controls.Add(this.btnGerenciarProdutos);
            this.Controls.Add(this.btnGerenciarFuncionarios);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGerenciarUsuario;
        private System.Windows.Forms.Button btnGerenciarFornecedores;
        private System.Windows.Forms.Button btnGerenciarProdutos;
        private System.Windows.Forms.Button btnGerenciarFuncionarios;
    }
}