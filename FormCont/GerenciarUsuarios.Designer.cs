namespace FormCont
{
    partial class GerenciarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarUsuarios));
            this.label4 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNovoUsuario = new Krypton.Toolkit.KryptonButton();
            this.btnEditarUsuario = new Krypton.Toolkit.KryptonButton();
            this.btnExcluirUsuario = new Krypton.Toolkit.KryptonButton();
            this.chkAdminGerir = new Krypton.Toolkit.KryptonCheckBox();
            this.txtNomeGerir = new Krypton.Toolkit.KryptonTextBox();
            this.txtEmailGerir = new Krypton.Toolkit.KryptonTextBox();
            this.txtSenhaGerir = new Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(131, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(462, 42);
            this.label4.TabIndex = 33;
            this.label4.Text = "Gerencimento de Usuários";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 91);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(581, 414);
            this.dgvUsuarios.TabIndex = 34;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(213, 533);
            this.btnNovoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnNovoUsuario.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnNovoUsuario.OverrideDefault.Back.ColorAngle = 45F;
            this.btnNovoUsuario.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnNovoUsuario.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnNovoUsuario.OverrideDefault.Border.ColorAngle = 45F;
            this.btnNovoUsuario.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNovoUsuario.OverrideDefault.Border.Rounding = 20F;
            this.btnNovoUsuario.OverrideDefault.Border.Width = 1;
            this.btnNovoUsuario.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnNovoUsuario.Size = new System.Drawing.Size(157, 40);
            this.btnNovoUsuario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnNovoUsuario.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnNovoUsuario.StateCommon.Back.ColorAngle = 45F;
            this.btnNovoUsuario.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnNovoUsuario.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnNovoUsuario.StateCommon.Border.ColorAngle = 45F;
            this.btnNovoUsuario.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNovoUsuario.StateCommon.Border.Rounding = 20F;
            this.btnNovoUsuario.StateCommon.Border.Width = 1;
            this.btnNovoUsuario.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNovoUsuario.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNovoUsuario.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoUsuario.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnNovoUsuario.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnNovoUsuario.StatePressed.Back.ColorAngle = 135F;
            this.btnNovoUsuario.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnNovoUsuario.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnNovoUsuario.StatePressed.Border.ColorAngle = 135F;
            this.btnNovoUsuario.StatePressed.Border.Rounding = 20F;
            this.btnNovoUsuario.StatePressed.Border.Width = 1;
            this.btnNovoUsuario.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnNovoUsuario.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnNovoUsuario.StateTracking.Back.ColorAngle = 45F;
            this.btnNovoUsuario.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnNovoUsuario.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnNovoUsuario.StateTracking.Border.ColorAngle = 45F;
            this.btnNovoUsuario.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNovoUsuario.StateTracking.Border.Rounding = 20F;
            this.btnNovoUsuario.StateTracking.Border.Width = 1;
            this.btnNovoUsuario.TabIndex = 35;
            this.btnNovoUsuario.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnNovoUsuario.Values.Text = "Novo Usuário";
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(621, 545);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEditarUsuario.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEditarUsuario.OverrideDefault.Back.ColorAngle = 45F;
            this.btnEditarUsuario.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEditarUsuario.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEditarUsuario.OverrideDefault.Border.ColorAngle = 45F;
            this.btnEditarUsuario.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEditarUsuario.OverrideDefault.Border.Rounding = 20F;
            this.btnEditarUsuario.OverrideDefault.Border.Width = 1;
            this.btnEditarUsuario.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnEditarUsuario.Size = new System.Drawing.Size(110, 28);
            this.btnEditarUsuario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEditarUsuario.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEditarUsuario.StateCommon.Back.ColorAngle = 45F;
            this.btnEditarUsuario.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEditarUsuario.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEditarUsuario.StateCommon.Border.ColorAngle = 45F;
            this.btnEditarUsuario.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEditarUsuario.StateCommon.Border.Rounding = 20F;
            this.btnEditarUsuario.StateCommon.Border.Width = 1;
            this.btnEditarUsuario.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEditarUsuario.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEditarUsuario.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEditarUsuario.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEditarUsuario.StatePressed.Back.ColorAngle = 135F;
            this.btnEditarUsuario.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnEditarUsuario.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnEditarUsuario.StatePressed.Border.ColorAngle = 135F;
            this.btnEditarUsuario.StatePressed.Border.Rounding = 20F;
            this.btnEditarUsuario.StatePressed.Border.Width = 1;
            this.btnEditarUsuario.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEditarUsuario.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEditarUsuario.StateTracking.Back.ColorAngle = 45F;
            this.btnEditarUsuario.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnEditarUsuario.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnEditarUsuario.StateTracking.Border.ColorAngle = 45F;
            this.btnEditarUsuario.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEditarUsuario.StateTracking.Border.Rounding = 20F;
            this.btnEditarUsuario.StateTracking.Border.Width = 1;
            this.btnEditarUsuario.TabIndex = 36;
            this.btnEditarUsuario.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEditarUsuario.Values.Text = "Editar";
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Location = new System.Drawing.Point(752, 544);
            this.btnExcluirUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcluirUsuario.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcluirUsuario.OverrideDefault.Back.ColorAngle = 45F;
            this.btnExcluirUsuario.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcluirUsuario.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcluirUsuario.OverrideDefault.Border.ColorAngle = 45F;
            this.btnExcluirUsuario.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExcluirUsuario.OverrideDefault.Border.Rounding = 20F;
            this.btnExcluirUsuario.OverrideDefault.Border.Width = 1;
            this.btnExcluirUsuario.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnExcluirUsuario.Size = new System.Drawing.Size(110, 29);
            this.btnExcluirUsuario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcluirUsuario.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcluirUsuario.StateCommon.Back.ColorAngle = 45F;
            this.btnExcluirUsuario.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcluirUsuario.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcluirUsuario.StateCommon.Border.ColorAngle = 45F;
            this.btnExcluirUsuario.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExcluirUsuario.StateCommon.Border.Rounding = 20F;
            this.btnExcluirUsuario.StateCommon.Border.Width = 1;
            this.btnExcluirUsuario.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExcluirUsuario.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnExcluirUsuario.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUsuario.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnExcluirUsuario.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnExcluirUsuario.StatePressed.Back.ColorAngle = 135F;
            this.btnExcluirUsuario.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnExcluirUsuario.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnExcluirUsuario.StatePressed.Border.ColorAngle = 135F;
            this.btnExcluirUsuario.StatePressed.Border.Rounding = 20F;
            this.btnExcluirUsuario.StatePressed.Border.Width = 1;
            this.btnExcluirUsuario.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcluirUsuario.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcluirUsuario.StateTracking.Back.ColorAngle = 45F;
            this.btnExcluirUsuario.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcluirUsuario.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcluirUsuario.StateTracking.Border.ColorAngle = 45F;
            this.btnExcluirUsuario.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExcluirUsuario.StateTracking.Border.Rounding = 20F;
            this.btnExcluirUsuario.StateTracking.Border.Width = 1;
            this.btnExcluirUsuario.TabIndex = 37;
            this.btnExcluirUsuario.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExcluirUsuario.Values.Text = "Excluir";
            // 
            // chkAdminGerir
            // 
            this.chkAdminGerir.Location = new System.Drawing.Point(615, 433);
            this.chkAdminGerir.Name = "chkAdminGerir";
            this.chkAdminGerir.Size = new System.Drawing.Size(270, 24);
            this.chkAdminGerir.TabIndex = 38;
            this.chkAdminGerir.Values.Text = "Ativar permissões de Administrador";
            // 
            // txtNomeGerir
            // 
            this.txtNomeGerir.Location = new System.Drawing.Point(631, 125);
            this.txtNomeGerir.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeGerir.Name = "txtNomeGerir";
            this.txtNomeGerir.Size = new System.Drawing.Size(231, 36);
            this.txtNomeGerir.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtNomeGerir.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNomeGerir.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNomeGerir.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtNomeGerir.StateCommon.Border.Rounding = 20F;
            this.txtNomeGerir.StateCommon.Border.Width = 1;
            this.txtNomeGerir.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtNomeGerir.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGerir.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtNomeGerir.TabIndex = 39;
            // 
            // txtEmailGerir
            // 
            this.txtEmailGerir.Location = new System.Drawing.Point(631, 233);
            this.txtEmailGerir.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailGerir.Name = "txtEmailGerir";
            this.txtEmailGerir.Size = new System.Drawing.Size(231, 36);
            this.txtEmailGerir.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtEmailGerir.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmailGerir.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmailGerir.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtEmailGerir.StateCommon.Border.Rounding = 20F;
            this.txtEmailGerir.StateCommon.Border.Width = 1;
            this.txtEmailGerir.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtEmailGerir.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailGerir.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtEmailGerir.TabIndex = 40;
            // 
            // txtSenhaGerir
            // 
            this.txtSenhaGerir.Location = new System.Drawing.Point(631, 342);
            this.txtSenhaGerir.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaGerir.Name = "txtSenhaGerir";
            this.txtSenhaGerir.PasswordChar = '●';
            this.txtSenhaGerir.Size = new System.Drawing.Size(231, 36);
            this.txtSenhaGerir.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSenhaGerir.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSenhaGerir.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSenhaGerir.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSenhaGerir.StateCommon.Border.Rounding = 20F;
            this.txtSenhaGerir.StateCommon.Border.Width = 1;
            this.txtSenhaGerir.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSenhaGerir.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaGerir.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSenhaGerir.TabIndex = 41;
            this.txtSenhaGerir.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(701, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(701, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(701, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Senha";
            // 
            // GerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaGerir);
            this.Controls.Add(this.txtEmailGerir);
            this.Controls.Add(this.txtNomeGerir);
            this.Controls.Add(this.chkAdminGerir);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Name = "GerenciarUsuarios";
            this.Text = "GerenciarUsuarios";
            this.Load += new System.EventHandler(this.GerenciarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private Krypton.Toolkit.KryptonButton btnNovoUsuario;
        private Krypton.Toolkit.KryptonButton btnEditarUsuario;
        private Krypton.Toolkit.KryptonButton btnExcluirUsuario;
        private Krypton.Toolkit.KryptonCheckBox chkAdminGerir;
        private Krypton.Toolkit.KryptonTextBox txtNomeGerir;
        private Krypton.Toolkit.KryptonTextBox txtEmailGerir;
        private Krypton.Toolkit.KryptonTextBox txtSenhaGerir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}