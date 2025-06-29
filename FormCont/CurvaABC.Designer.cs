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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurvaABC));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.chartReal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIdeal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btExportar = new Krypton.Toolkit.KryptonButton();
            this.btGerarCurva = new Krypton.Toolkit.KryptonButton();
            this.tabelaCurvaABC = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.chartReal);
            this.groupBox1.Controls.Add(this.chartIdeal);
            this.groupBox1.Controls.Add(this.btExportar);
            this.groupBox1.Controls.Add(this.btGerarCurva);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 270);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório - Curva ABC";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(1083, 214);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(44, 50);
            this.btnLimpar.TabIndex = 89;
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chartReal
            // 
            this.chartReal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chartArea1.Name = "ChartArea1";
            this.chartReal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReal.Legends.Add(legend1);
            this.chartReal.Location = new System.Drawing.Point(417, 41);
            this.chartReal.Name = "chartReal";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartReal.Series.Add(series1);
            this.chartReal.Size = new System.Drawing.Size(329, 214);
            this.chartReal.TabIndex = 79;
            this.chartReal.Text = "chart1";
            // 
            // chartIdeal
            // 
            this.chartIdeal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chartArea2.Name = "ChartArea1";
            this.chartIdeal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartIdeal.Legends.Add(legend2);
            this.chartIdeal.Location = new System.Drawing.Point(24, 41);
            this.chartIdeal.Name = "chartIdeal";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartIdeal.Series.Add(series2);
            this.chartIdeal.Size = new System.Drawing.Size(329, 214);
            this.chartIdeal.TabIndex = 78;
            this.chartIdeal.Text = "chart1";
            // 
            // btExportar
            // 
            this.btExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExportar.Location = new System.Drawing.Point(817, 47);
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
            this.btExportar.Size = new System.Drawing.Size(105, 43);
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
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tabelaCurvaABC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaCurvaABC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaCurvaABC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaCurvaABC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaCurvaABC.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabelaCurvaABC.Location = new System.Drawing.Point(25, 288);
            this.tabelaCurvaABC.Name = "tabelaCurvaABC";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaCurvaABC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.tabelaCurvaABC.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tabelaCurvaABC.Size = new System.Drawing.Size(1133, 353);
            this.tabelaCurvaABC.TabIndex = 68;
            // 
            // CurvaABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
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
        private Krypton.Toolkit.KryptonButton btExportar;
        private Krypton.Toolkit.KryptonButton btGerarCurva;
        private System.Windows.Forms.DataGridView tabelaCurvaABC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIdeal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLimpar;
    }
}