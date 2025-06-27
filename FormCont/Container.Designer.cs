namespace FormCont
{
    partial class Container
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.labelSuprimentos = new System.Windows.Forms.Label();
            this.labelRelatorios = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.painelLateral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_deslogar = new System.Windows.Forms.PictureBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.btCurvaABC = new System.Windows.Forms.Button();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.picSuprimentos = new System.Windows.Forms.PictureBox();
            this.bt_controle_estoque = new System.Windows.Forms.Button();
            this.picRelatorios = new System.Windows.Forms.PictureBox();
            this.picCadastro = new System.Windows.Forms.PictureBox();
            this.bt_relEntradaSaida = new System.Windows.Forms.Button();
            this.bt_nt_entrada = new System.Windows.Forms.Button();
            this.bt_cadastro_merc = new System.Windows.Forms.Button();
            this.painelLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_deslogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuprimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSuprimentos
            // 
            this.labelSuprimentos.AutoSize = true;
            this.labelSuprimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuprimentos.ForeColor = System.Drawing.Color.White;
            this.labelSuprimentos.Location = new System.Drawing.Point(64, 229);
            this.labelSuprimentos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSuprimentos.Name = "labelSuprimentos";
            this.labelSuprimentos.Size = new System.Drawing.Size(127, 24);
            this.labelSuprimentos.TabIndex = 0;
            this.labelSuprimentos.Text = "Suprimentos";
            // 
            // labelRelatorios
            // 
            this.labelRelatorios.AutoSize = true;
            this.labelRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelatorios.ForeColor = System.Drawing.Color.White;
            this.labelRelatorios.Location = new System.Drawing.Point(67, 416);
            this.labelRelatorios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRelatorios.Name = "labelRelatorios";
            this.labelRelatorios.Size = new System.Drawing.Size(103, 24);
            this.labelRelatorios.TabIndex = 0;
            this.labelRelatorios.Text = "Relatórios";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(85, 29);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 24);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // painelLateral
            // 
            this.painelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.painelLateral.Controls.Add(this.panel1);
            this.painelLateral.Controls.Add(this.kryptonPictureBox1);
            this.painelLateral.Controls.Add(this.lblUsuario);
            this.painelLateral.Controls.Add(this.btCurvaABC);
            this.painelLateral.Controls.Add(this.labelCadastro);
            this.painelLateral.Controls.Add(this.picSuprimentos);
            this.painelLateral.Controls.Add(this.bt_controle_estoque);
            this.painelLateral.Controls.Add(this.picRelatorios);
            this.painelLateral.Controls.Add(this.picCadastro);
            this.painelLateral.Controls.Add(this.labelRelatorios);
            this.painelLateral.Controls.Add(this.bt_relEntradaSaida);
            this.painelLateral.Controls.Add(this.labelSuprimentos);
            this.painelLateral.Controls.Add(this.bt_nt_entrada);
            this.painelLateral.Controls.Add(this.bt_cadastro_merc);
            this.painelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelLateral.Location = new System.Drawing.Point(0, 0);
            this.painelLateral.Margin = new System.Windows.Forms.Padding(4);
            this.painelLateral.Name = "painelLateral";
            this.painelLateral.Size = new System.Drawing.Size(267, 825);
            this.painelLateral.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_deslogar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 765);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 60);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;

            this.label1.Location = new System.Drawing.Point(74, 15);
            this.label1.Name = "label11";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Logout";
            // 
            // bt_deslogar
            // 
            this.bt_deslogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_deslogar.Image = ((System.Drawing.Image)(resources.GetObject("bt_deslogar.Image")));
            this.bt_deslogar.Location = new System.Drawing.Point(51, 11);
            this.bt_deslogar.Margin = new System.Windows.Forms.Padding(0);
            this.bt_deslogar.Name = "bt_deslogar";
            this.bt_deslogar.Size = new System.Drawing.Size(43, 38);
            this.bt_deslogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_deslogar.TabIndex = 28;
            this.bt_deslogar.TabStop = false;
            this.bt_deslogar.Click += new System.EventHandler(this.bt_deslogar_Click_1);
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox1.Image")));
            this.kryptonPictureBox1.Location = new System.Drawing.Point(-4, 13);
            this.kryptonPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(70, 44);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 27;
            this.kryptonPictureBox1.TabStop = false;
            this.kryptonPictureBox1.Click += new System.EventHandler(this.kryptonPictureBox1_Click);
            // 
            // btCurvaABC
            // 
            this.btCurvaABC.BackColor = System.Drawing.Color.Transparent;
            this.btCurvaABC.FlatAppearance.BorderSize = 0;
            this.btCurvaABC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btCurvaABC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.btCurvaABC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCurvaABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCurvaABC.ForeColor = System.Drawing.Color.White;
            this.btCurvaABC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCurvaABC.Location = new System.Drawing.Point(-4, 519);
            this.btCurvaABC.Margin = new System.Windows.Forms.Padding(0);
            this.btCurvaABC.Name = "btCurvaABC";
            this.btCurvaABC.Size = new System.Drawing.Size(273, 59);
            this.btCurvaABC.TabIndex = 18;
            this.btCurvaABC.Text = "      Curva ABC";
            this.btCurvaABC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCurvaABC.UseVisualStyleBackColor = false;
            this.btCurvaABC.Click += new System.EventHandler(this.btCurvaABC_Click);
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastro.ForeColor = System.Drawing.Color.White;
            this.labelCadastro.Location = new System.Drawing.Point(60, 89);
            this.labelCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(98, 24);
            this.labelCadastro.TabIndex = 17;
            this.labelCadastro.Text = " Cadastro";
            this.labelCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picSuprimentos
            // 
            this.picSuprimentos.Image = ((System.Drawing.Image)(resources.GetObject("picSuprimentos.Image")));
            this.picSuprimentos.Location = new System.Drawing.Point(16, 220);
            this.picSuprimentos.Margin = new System.Windows.Forms.Padding(4);
            this.picSuprimentos.Name = "picSuprimentos";
            this.picSuprimentos.Size = new System.Drawing.Size(43, 39);
            this.picSuprimentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSuprimentos.TabIndex = 15;
            this.picSuprimentos.TabStop = false;
            // 
            // bt_controle_estoque
            // 
            this.bt_controle_estoque.BackColor = System.Drawing.Color.Transparent;
            this.bt_controle_estoque.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_controle_estoque.FlatAppearance.BorderSize = 0;
            this.bt_controle_estoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_controle_estoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.bt_controle_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_controle_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_controle_estoque.ForeColor = System.Drawing.Color.White;
            this.bt_controle_estoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_controle_estoque.Location = new System.Drawing.Point(-3, 263);
            this.bt_controle_estoque.Margin = new System.Windows.Forms.Padding(0);
            this.bt_controle_estoque.Name = "bt_controle_estoque";
            this.bt_controle_estoque.Size = new System.Drawing.Size(273, 59);
            this.bt_controle_estoque.TabIndex = 1;
            this.bt_controle_estoque.Text = "      Controle de estoque";
            this.bt_controle_estoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_controle_estoque.UseVisualStyleBackColor = false;
            this.bt_controle_estoque.Click += new System.EventHandler(this.bt_controle_estoque_Click);
            // 
            // picRelatorios
            // 
            this.picRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("picRelatorios.Image")));
            this.picRelatorios.Location = new System.Drawing.Point(16, 409);
            this.picRelatorios.Margin = new System.Windows.Forms.Padding(4);
            this.picRelatorios.Name = "picRelatorios";
            this.picRelatorios.Size = new System.Drawing.Size(43, 39);
            this.picRelatorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRelatorios.TabIndex = 14;
            this.picRelatorios.TabStop = false;
            // 
            // picCadastro
            // 
            this.picCadastro.Image = ((System.Drawing.Image)(resources.GetObject("picCadastro.Image")));
            this.picCadastro.Location = new System.Drawing.Point(16, 86);
            this.picCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.picCadastro.Name = "picCadastro";
            this.picCadastro.Size = new System.Drawing.Size(37, 34);
            this.picCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCadastro.TabIndex = 13;
            this.picCadastro.TabStop = false;
            // 
            // bt_relEntradaSaida
            // 
            this.bt_relEntradaSaida.BackColor = System.Drawing.Color.Transparent;
            this.bt_relEntradaSaida.FlatAppearance.BorderSize = 0;
            this.bt_relEntradaSaida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_relEntradaSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.bt_relEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_relEntradaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_relEntradaSaida.ForeColor = System.Drawing.Color.White;
            this.bt_relEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_relEntradaSaida.Location = new System.Drawing.Point(-4, 460);
            this.bt_relEntradaSaida.Margin = new System.Windows.Forms.Padding(0);
            this.bt_relEntradaSaida.Name = "bt_relEntradaSaida";
            this.bt_relEntradaSaida.Size = new System.Drawing.Size(273, 59);
            this.bt_relEntradaSaida.TabIndex = 9;
            this.bt_relEntradaSaida.Text = "      Movimentação";
            this.bt_relEntradaSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_relEntradaSaida.UseVisualStyleBackColor = false;
            this.bt_relEntradaSaida.Click += new System.EventHandler(this.bt_relatorios_Click);
            // 
            // bt_nt_entrada
            // 
            this.bt_nt_entrada.BackColor = System.Drawing.Color.Transparent;
            this.bt_nt_entrada.FlatAppearance.BorderSize = 0;
            this.bt_nt_entrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_nt_entrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.bt_nt_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nt_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nt_entrada.ForeColor = System.Drawing.Color.White;
            this.bt_nt_entrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_nt_entrada.Location = new System.Drawing.Point(-3, 322);
            this.bt_nt_entrada.Margin = new System.Windows.Forms.Padding(0);
            this.bt_nt_entrada.Name = "bt_nt_entrada";
            this.bt_nt_entrada.Size = new System.Drawing.Size(273, 59);
            this.bt_nt_entrada.TabIndex = 5;
            this.bt_nt_entrada.Text = "      Registrar entrada";
            this.bt_nt_entrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_nt_entrada.UseVisualStyleBackColor = false;
            this.bt_nt_entrada.Click += new System.EventHandler(this.bt_nt_entrada_Click);
            // 
            // bt_cadastro_merc
            // 
            this.bt_cadastro_merc.BackColor = System.Drawing.Color.Transparent;
            this.bt_cadastro_merc.FlatAppearance.BorderSize = 0;
            this.bt_cadastro_merc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_cadastro_merc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.bt_cadastro_merc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastro_merc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastro_merc.ForeColor = System.Drawing.Color.White;
            this.bt_cadastro_merc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cadastro_merc.Location = new System.Drawing.Point(0, 124);
            this.bt_cadastro_merc.Margin = new System.Windows.Forms.Padding(0);
            this.bt_cadastro_merc.Name = "bt_cadastro_merc";
            this.bt_cadastro_merc.Size = new System.Drawing.Size(273, 59);
            this.bt_cadastro_merc.TabIndex = 2;
            this.bt_cadastro_merc.Text = "      Mercadoria";
            this.bt_cadastro_merc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cadastro_merc.UseVisualStyleBackColor = false;
            this.bt_cadastro_merc.Click += new System.EventHandler(this.bt_cadastro_merc_Click);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1600, 825);
            this.Controls.Add(this.painelLateral);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1594, 814);
            this.Name = "Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DENNA";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.painelLateral.ResumeLayout(false);
            this.painelLateral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_deslogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuprimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_controle_estoque;
        private System.Windows.Forms.Button bt_cadastro_merc;
        private System.Windows.Forms.Button bt_nt_entrada;
        private System.Windows.Forms.Label labelSuprimentos;
        private System.Windows.Forms.Button bt_relEntradaSaida;
        private System.Windows.Forms.Label labelRelatorios;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel painelLateral;
        private System.Windows.Forms.PictureBox picCadastro;
        private System.Windows.Forms.PictureBox picSuprimentos;
        private System.Windows.Forms.PictureBox picRelatorios;
        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.Button btCurvaABC;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private System.Windows.Forms.PictureBox bt_deslogar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

