namespace FormCont
{
    partial class RelatoriosES
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatoriosES));
            this.label2 = new System.Windows.Forms.Label();
            this.rdbMes = new System.Windows.Forms.RadioButton();
            this.rdbPeriodo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btExportar = new Krypton.Toolkit.KryptonButton();
            this.btGerarRelatorio = new Krypton.Toolkit.KryptonButton();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoBusca = new System.Windows.Forms.TextBox();
            this.tabelaRelatorio = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volumes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso_Liquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso_Bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profundidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itens_Caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarAtributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarOpcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTIN_Tributario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque_Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque_Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crossdocking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDesmarcar = new Krypton.Toolkit.KryptonButton();
            this.btLimpar = new Krypton.Toolkit.KryptonButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaRelatorio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(128, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Data inicial";
            // 
            // rdbMes
            // 
            this.rdbMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbMes.AutoSize = true;
            this.rdbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.rdbMes.Location = new System.Drawing.Point(15, 38);
            this.rdbMes.Name = "rdbMes";
            this.rdbMes.Size = new System.Drawing.Size(79, 22);
            this.rdbMes.TabIndex = 55;
            this.rdbMes.TabStop = true;
            this.rdbMes.Text = "Do mês";
            this.rdbMes.UseVisualStyleBackColor = true;
            // 
            // rdbPeriodo
            // 
            this.rdbPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbPeriodo.AutoSize = true;
            this.rdbPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.rdbPeriodo.Location = new System.Drawing.Point(198, 38);
            this.rdbPeriodo.Name = "rdbPeriodo";
            this.rdbPeriodo.Size = new System.Drawing.Size(124, 22);
            this.rdbPeriodo.TabIndex = 56;
            this.rdbPeriodo.TabStop = true;
            this.rdbPeriodo.Text = "De um período";
            this.rdbPeriodo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btLimpar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btExportar);
            this.groupBox1.Controls.Add(this.btGerarRelatorio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigoBusca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 270);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório - Entrada e Saída";
            // 
            // btExportar
            // 
            this.btExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExportar.Location = new System.Drawing.Point(816, 59);
            this.btExportar.Name = "btExportar";
            this.btExportar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btExportar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btExportar.OverrideDefault.Back.ColorAngle = 45F;
            this.btExportar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btExportar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btExportar.OverrideDefault.Border.ColorAngle = 45F;
            this.btExportar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btExportar.OverrideDefault.Border.Rounding = 20F;
            this.btExportar.OverrideDefault.Border.Width = 1;
            this.btExportar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btExportar.Size = new System.Drawing.Size(98, 43);
            this.btExportar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btExportar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btExportar.StateCommon.Back.ColorAngle = 45F;
            this.btExportar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btExportar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btExportar.StateCommon.Border.ColorAngle = 45F;
            this.btExportar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btExportar.StateCommon.Border.Rounding = 20F;
            this.btExportar.StateCommon.Border.Width = 1;
            this.btExportar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btExportar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btExportar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btExportar.StatePressed.Back.ColorAngle = 135F;
            this.btExportar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btExportar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btExportar.StatePressed.Border.ColorAngle = 135F;
            this.btExportar.StatePressed.Border.Rounding = 20F;
            this.btExportar.StatePressed.Border.Width = 1;
            this.btExportar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btExportar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btExportar.StateTracking.Back.ColorAngle = 45F;
            this.btExportar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btExportar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btExportar.StateTracking.Border.ColorAngle = 45F;
            this.btExportar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btExportar.StateTracking.Border.Rounding = 20F;
            this.btExportar.StateTracking.Border.Width = 1;
            this.btExportar.TabIndex = 77;
            this.btExportar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btExportar.Values.Text = "Exportar";
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGerarRelatorio.Location = new System.Drawing.Point(936, 59);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarRelatorio.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarRelatorio.OverrideDefault.Back.ColorAngle = 45F;
            this.btGerarRelatorio.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarRelatorio.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarRelatorio.OverrideDefault.Border.ColorAngle = 45F;
            this.btGerarRelatorio.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btGerarRelatorio.OverrideDefault.Border.Rounding = 20F;
            this.btGerarRelatorio.OverrideDefault.Border.Width = 1;
            this.btGerarRelatorio.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btGerarRelatorio.Size = new System.Drawing.Size(170, 43);
            this.btGerarRelatorio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarRelatorio.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarRelatorio.StateCommon.Back.ColorAngle = 45F;
            this.btGerarRelatorio.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarRelatorio.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarRelatorio.StateCommon.Border.ColorAngle = 45F;
            this.btGerarRelatorio.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btGerarRelatorio.StateCommon.Border.Rounding = 20F;
            this.btGerarRelatorio.StateCommon.Border.Width = 1;
            this.btGerarRelatorio.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btGerarRelatorio.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btGerarRelatorio.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btGerarRelatorio.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btGerarRelatorio.StatePressed.Back.ColorAngle = 135F;
            this.btGerarRelatorio.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btGerarRelatorio.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btGerarRelatorio.StatePressed.Border.ColorAngle = 135F;
            this.btGerarRelatorio.StatePressed.Border.Rounding = 20F;
            this.btGerarRelatorio.StatePressed.Border.Width = 1;
            this.btGerarRelatorio.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarRelatorio.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarRelatorio.StateTracking.Back.ColorAngle = 45F;
            this.btGerarRelatorio.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarRelatorio.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarRelatorio.StateTracking.Border.ColorAngle = 45F;
            this.btGerarRelatorio.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btGerarRelatorio.StateTracking.Border.Rounding = 20F;
            this.btGerarRelatorio.StateTracking.Border.Width = 1;
            this.btGerarRelatorio.TabIndex = 76;
            this.btGerarRelatorio.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btGerarRelatorio.Values.Text = "Gerar Relatório";
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click_1);
            // 
            // dtFinal
            // 
            this.dtFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinal.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(207, 111);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(124, 26);
            this.dtFinal.TabIndex = 75;
            this.dtFinal.Value = new System.DateTime(2024, 10, 13, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(138, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Data final";
            // 
            // dtInicio
            // 
            this.dtInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(207, 76);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(124, 26);
            this.dtInicio.TabIndex = 66;
            this.dtInicio.Value = new System.DateTime(2024, 10, 13, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Código do produto";
            // 
            // txtCodigoBusca
            // 
            this.txtCodigoBusca.BackColor = System.Drawing.Color.White;
            this.txtCodigoBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.txtCodigoBusca.Location = new System.Drawing.Point(19, 59);
            this.txtCodigoBusca.Name = "txtCodigoBusca";
            this.txtCodigoBusca.Size = new System.Drawing.Size(343, 26);
            this.txtCodigoBusca.TabIndex = 64;
            // 
            // tabelaRelatorio
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.tabelaRelatorio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tabelaRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tabelaRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Unidade,
            this.Formato,
            this.Condicao,
            this.Tipo,
            this.Situacao,
            this.Preco_Venda,
            this.Marca,
            this.Producao,
            this.Data_Validade,
            this.Frete,
            this.Volumes,
            this.Peso_Liquido,
            this.Peso_Bruto,
            this.Largura,
            this.Altura,
            this.Profundidade,
            this.Itens_Caixa,
            this.Unidade_Medida,
            this.VarAtributo,
            this.VarOpcao,
            this.GTIN,
            this.GTIN_Tributario,
            this.Departamento,
            this.Estoque_Minimo,
            this.Estoque_Maximo,
            this.Crossdocking,
            this.Localizacao});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaRelatorio.DefaultCellStyle = dataGridViewCellStyle8;
            this.tabelaRelatorio.Location = new System.Drawing.Point(27, 300);
            this.tabelaRelatorio.Name = "tabelaRelatorio";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaRelatorio.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.tabelaRelatorio.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tabelaRelatorio.Size = new System.Drawing.Size(1133, 353);
            this.tabelaRelatorio.TabIndex = 67;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Unidade
            // 
            this.Unidade.HeaderText = "Unidade";
            this.Unidade.Name = "Unidade";
            this.Unidade.Visible = false;
            // 
            // Formato
            // 
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.Visible = false;
            // 
            // Condicao
            // 
            this.Condicao.HeaderText = "Condição";
            this.Condicao.Name = "Condicao";
            this.Condicao.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Visible = false;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.Visible = false;
            // 
            // Preco_Venda
            // 
            this.Preco_Venda.HeaderText = "Preço de venda";
            this.Preco_Venda.Name = "Preco_Venda";
            this.Preco_Venda.Visible = false;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Visible = false;
            // 
            // Producao
            // 
            this.Producao.HeaderText = "Produção";
            this.Producao.Name = "Producao";
            this.Producao.Visible = false;
            // 
            // Data_Validade
            // 
            this.Data_Validade.HeaderText = "Data de validade";
            this.Data_Validade.Name = "Data_Validade";
            this.Data_Validade.Visible = false;
            // 
            // Frete
            // 
            this.Frete.HeaderText = "Frete grátis";
            this.Frete.Name = "Frete";
            this.Frete.Visible = false;
            // 
            // Volumes
            // 
            this.Volumes.HeaderText = "Volumes";
            this.Volumes.Name = "Volumes";
            this.Volumes.Visible = false;
            // 
            // Peso_Liquido
            // 
            this.Peso_Liquido.HeaderText = "Peso líquido";
            this.Peso_Liquido.Name = "Peso_Liquido";
            this.Peso_Liquido.Visible = false;
            // 
            // Peso_Bruto
            // 
            this.Peso_Bruto.HeaderText = "Peso bruto";
            this.Peso_Bruto.Name = "Peso_Bruto";
            this.Peso_Bruto.Visible = false;
            // 
            // Largura
            // 
            this.Largura.HeaderText = "Largura";
            this.Largura.Name = "Largura";
            this.Largura.Visible = false;
            // 
            // Altura
            // 
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.Visible = false;
            // 
            // Profundidade
            // 
            this.Profundidade.HeaderText = "Profundidade";
            this.Profundidade.Name = "Profundidade";
            this.Profundidade.Visible = false;
            // 
            // Itens_Caixa
            // 
            this.Itens_Caixa.HeaderText = "Itens p/ caixa";
            this.Itens_Caixa.Name = "Itens_Caixa";
            this.Itens_Caixa.Visible = false;
            // 
            // Unidade_Medida
            // 
            this.Unidade_Medida.HeaderText = "Unidade de medida";
            this.Unidade_Medida.Name = "Unidade_Medida";
            this.Unidade_Medida.Visible = false;
            // 
            // VarAtributo
            // 
            this.VarAtributo.HeaderText = "Variação atributo";
            this.VarAtributo.Name = "VarAtributo";
            this.VarAtributo.Visible = false;
            // 
            // VarOpcao
            // 
            this.VarOpcao.HeaderText = "Variação opção";
            this.VarOpcao.Name = "VarOpcao";
            this.VarOpcao.Visible = false;
            // 
            // GTIN
            // 
            this.GTIN.HeaderText = "GTIN/EAN";
            this.GTIN.Name = "GTIN";
            this.GTIN.Visible = false;
            // 
            // GTIN_Tributario
            // 
            this.GTIN_Tributario.HeaderText = "GTIN/EAN Tributário";
            this.GTIN_Tributario.Name = "GTIN_Tributario";
            this.GTIN_Tributario.Visible = false;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.Visible = false;
            // 
            // Estoque_Minimo
            // 
            this.Estoque_Minimo.HeaderText = "Estoque mínimo";
            this.Estoque_Minimo.Name = "Estoque_Minimo";
            this.Estoque_Minimo.Visible = false;
            // 
            // Estoque_Maximo
            // 
            this.Estoque_Maximo.HeaderText = "Estoque máximo";
            this.Estoque_Maximo.Name = "Estoque_Maximo";
            this.Estoque_Maximo.Visible = false;
            // 
            // Crossdocking
            // 
            this.Crossdocking.HeaderText = "Crossdocking";
            this.Crossdocking.Name = "Crossdocking";
            this.Crossdocking.Visible = false;
            // 
            // Localizacao
            // 
            this.Localizacao.HeaderText = "Localização";
            this.Localizacao.Name = "Localizacao";
            this.Localizacao.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDesmarcar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdbPeriodo);
            this.groupBox2.Controls.Add(this.dtFinal);
            this.groupBox2.Controls.Add(this.rdbMes);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtInicio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 150);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Por Data";
            // 
            // btDesmarcar
            // 
            this.btDesmarcar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDesmarcar.Location = new System.Drawing.Point(15, 89);
            this.btDesmarcar.Name = "btDesmarcar";
            this.btDesmarcar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btDesmarcar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btDesmarcar.OverrideDefault.Back.ColorAngle = 45F;
            this.btDesmarcar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btDesmarcar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btDesmarcar.OverrideDefault.Border.ColorAngle = 45F;
            this.btDesmarcar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btDesmarcar.OverrideDefault.Border.Rounding = 20F;
            this.btDesmarcar.OverrideDefault.Border.Width = 1;
            this.btDesmarcar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btDesmarcar.Size = new System.Drawing.Size(85, 38);
            this.btDesmarcar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btDesmarcar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btDesmarcar.StateCommon.Back.ColorAngle = 45F;
            this.btDesmarcar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btDesmarcar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btDesmarcar.StateCommon.Border.ColorAngle = 45F;
            this.btDesmarcar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btDesmarcar.StateCommon.Border.Rounding = 20F;
            this.btDesmarcar.StateCommon.Border.Width = 1;
            this.btDesmarcar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btDesmarcar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesmarcar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btDesmarcar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btDesmarcar.StatePressed.Back.ColorAngle = 135F;
            this.btDesmarcar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btDesmarcar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btDesmarcar.StatePressed.Border.ColorAngle = 135F;
            this.btDesmarcar.StatePressed.Border.Rounding = 20F;
            this.btDesmarcar.StatePressed.Border.Width = 1;
            this.btDesmarcar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btDesmarcar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btDesmarcar.StateTracking.Back.ColorAngle = 45F;
            this.btDesmarcar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btDesmarcar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btDesmarcar.StateTracking.Border.ColorAngle = 45F;
            this.btDesmarcar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btDesmarcar.StateTracking.Border.Rounding = 20F;
            this.btDesmarcar.StateTracking.Border.Width = 1;
            this.btDesmarcar.TabIndex = 79;
            this.btDesmarcar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btDesmarcar.Values.Text = "Desmarcar";
            this.btDesmarcar.Click += new System.EventHandler(this.btDesmarcar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpar.Location = new System.Drawing.Point(1042, 190);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btLimpar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btLimpar.OverrideDefault.Back.ColorAngle = 45F;
            this.btLimpar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btLimpar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btLimpar.OverrideDefault.Border.ColorAngle = 45F;
            this.btLimpar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btLimpar.OverrideDefault.Border.Rounding = 20F;
            this.btLimpar.OverrideDefault.Border.Width = 1;
            this.btLimpar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btLimpar.Size = new System.Drawing.Size(64, 61);
            this.btLimpar.StateCommon.Back.Color1 = System.Drawing.Color.DarkBlue;
            this.btLimpar.StateCommon.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.btLimpar.StateCommon.Back.ColorAngle = 45F;
            this.btLimpar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btLimpar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btLimpar.StateCommon.Border.ColorAngle = 45F;
            this.btLimpar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btLimpar.StateCommon.Border.Rounding = 20F;
            this.btLimpar.StateCommon.Border.Width = 1;
            this.btLimpar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btLimpar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btLimpar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btLimpar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btLimpar.StatePressed.Back.ColorAngle = 135F;
            this.btLimpar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btLimpar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btLimpar.StatePressed.Border.ColorAngle = 135F;
            this.btLimpar.StatePressed.Border.Rounding = 20F;
            this.btLimpar.StatePressed.Border.Width = 1;
            this.btLimpar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btLimpar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btLimpar.StateTracking.Back.ColorAngle = 45F;
            this.btLimpar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btLimpar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btLimpar.StateTracking.Border.ColorAngle = 45F;
            this.btLimpar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btLimpar.StateTracking.Border.Rounding = 20F;
            this.btLimpar.StateTracking.Border.Width = 1;
            this.btLimpar.TabIndex = 80;
            this.btLimpar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btLimpar.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.btLimpar.Values.Text = "";
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // RelatoriosES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 679);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabelaRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatoriosES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaRelatorio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMes;
        private System.Windows.Forms.RadioButton rdbPeriodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoBusca;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabelaRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volumes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso_Liquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso_Bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profundidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itens_Caixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade_Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarAtributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarOpcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTIN_Tributario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque_Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque_Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crossdocking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localizacao;
        private Krypton.Toolkit.KryptonButton btGerarRelatorio;
        private Krypton.Toolkit.KryptonButton btExportar;
        private System.Windows.Forms.GroupBox groupBox2;
        private Krypton.Toolkit.KryptonButton btDesmarcar;
        private Krypton.Toolkit.KryptonButton btLimpar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}