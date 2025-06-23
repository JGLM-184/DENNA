namespace FormCont
{
    partial class CurvaABC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurvaABC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartReal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIdeal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.btGerarCurva = new Krypton.Toolkit.KryptonButton();
            this.tabelaCurvaABC = new System.Windows.Forms.DataGridView();
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
            this.btLimpar = new Krypton.Toolkit.KryptonButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIdeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCurvaABC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btLimpar);
            this.groupBox1.Controls.Add(this.chartReal);
            this.groupBox1.Controls.Add(this.chartIdeal);
            this.groupBox1.Controls.Add(this.kryptonButton2);
            this.groupBox1.Controls.Add(this.btGerarCurva);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 283);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório - Curva ABC";
            // 
            // chartReal
            // 
            this.chartReal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chartArea3.Name = "ChartArea1";
            this.chartReal.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartReal.Legends.Add(legend3);
            this.chartReal.Location = new System.Drawing.Point(441, 47);
            this.chartReal.Name = "chartReal";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartReal.Series.Add(series3);
            this.chartReal.Size = new System.Drawing.Size(329, 214);
            this.chartReal.TabIndex = 79;
            this.chartReal.Text = "chart1";
            // 
            // chartIdeal
            // 
            this.chartIdeal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chartArea4.Name = "ChartArea1";
            this.chartIdeal.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartIdeal.Legends.Add(legend4);
            this.chartIdeal.Location = new System.Drawing.Point(24, 47);
            this.chartIdeal.Name = "chartIdeal";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartIdeal.Series.Add(series4);
            this.chartIdeal.Size = new System.Drawing.Size(329, 214);
            this.chartIdeal.TabIndex = 78;
            this.chartIdeal.Text = "chart1";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton2.Location = new System.Drawing.Point(817, 47);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonButton2.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton2.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton2.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.OverrideDefault.Border.Rounding = 20F;
            this.kryptonButton2.OverrideDefault.Border.Width = 1;
            this.kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton2.Size = new System.Drawing.Size(105, 43);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonButton2.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateCommon.Border.Rounding = 20F;
            this.kryptonButton2.StateCommon.Border.Width = 1;
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton2.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton2.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton2.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton2.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton2.StatePressed.Border.Rounding = 20F;
            this.kryptonButton2.StatePressed.Border.Width = 1;
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton2.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton2.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton2.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateTracking.Border.Rounding = 20F;
            this.kryptonButton2.StateTracking.Border.Width = 1;
            this.kryptonButton2.TabIndex = 77;
            this.kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton2.Values.Text = "Exportar";
            // 
            // btGerarCurva
            // 
            this.btGerarCurva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGerarCurva.Location = new System.Drawing.Point(942, 47);
            this.btGerarCurva.Name = "btGerarCurva";
            this.btGerarCurva.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarCurva.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarCurva.OverrideDefault.Back.ColorAngle = 45F;
            this.btGerarCurva.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarCurva.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarCurva.OverrideDefault.Border.ColorAngle = 45F;
            this.btGerarCurva.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btGerarCurva.OverrideDefault.Border.Rounding = 20F;
            this.btGerarCurva.OverrideDefault.Border.Width = 1;
            this.btGerarCurva.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btGerarCurva.Size = new System.Drawing.Size(170, 43);
            this.btGerarCurva.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarCurva.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarCurva.StateCommon.Back.ColorAngle = 45F;
            this.btGerarCurva.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarCurva.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarCurva.StateCommon.Border.ColorAngle = 45F;
            this.btGerarCurva.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btGerarCurva.StateCommon.Border.Rounding = 20F;
            this.btGerarCurva.StateCommon.Border.Width = 1;
            this.btGerarCurva.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btGerarCurva.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btGerarCurva.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarCurva.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btGerarCurva.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btGerarCurva.StatePressed.Back.ColorAngle = 135F;
            this.btGerarCurva.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btGerarCurva.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btGerarCurva.StatePressed.Border.ColorAngle = 135F;
            this.btGerarCurva.StatePressed.Border.Rounding = 20F;
            this.btGerarCurva.StatePressed.Border.Width = 1;
            this.btGerarCurva.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarCurva.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarCurva.StateTracking.Back.ColorAngle = 45F;
            this.btGerarCurva.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btGerarCurva.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btGerarCurva.StateTracking.Border.ColorAngle = 45F;
            this.btGerarCurva.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btGerarCurva.StateTracking.Border.Rounding = 20F;
            this.btGerarCurva.StateTracking.Border.Width = 1;
            this.btGerarCurva.TabIndex = 76;
            this.btGerarCurva.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btGerarCurva.Values.Text = "Gerar Relatório";
            // 
            // tabelaCurvaABC
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.tabelaCurvaABC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tabelaCurvaABC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaCurvaABC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tabelaCurvaABC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCurvaABC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.tabelaCurvaABC.DefaultCellStyle = dataGridViewCellStyle8;
            this.tabelaCurvaABC.Location = new System.Drawing.Point(25, 329);
            this.tabelaCurvaABC.Name = "tabelaCurvaABC";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaCurvaABC.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.tabelaCurvaABC.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tabelaCurvaABC.Size = new System.Drawing.Size(1133, 338);
            this.tabelaCurvaABC.TabIndex = 68;
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
            // btLimpar
            // 
            this.btLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpar.Location = new System.Drawing.Point(1048, 205);
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
            this.btLimpar.Size = new System.Drawing.Size(64, 56);
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
            this.btLimpar.TabIndex = 82;
            this.btLimpar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btLimpar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Values.Image")));
            this.btLimpar.Values.Text = "";
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // CurvaABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 679);
            this.Controls.Add(this.tabelaCurvaABC);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CurvaABC";
            this.Text = "CurvaABC";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIdeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCurvaABC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton btGerarCurva;
        private System.Windows.Forms.DataGridView tabelaCurvaABC;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIdeal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReal;
        private Krypton.Toolkit.KryptonButton btLimpar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}