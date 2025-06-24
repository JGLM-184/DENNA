namespace FormCont
{
    partial class ControleEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleEstoque));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBarraPesquisa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabelaMercadorias = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btBuscarMercFull = new Krypton.Toolkit.KryptonButton();
            this.btEditar = new Krypton.Toolkit.KryptonButton();
            this.btDeletar = new Krypton.Toolkit.KryptonButton();
            this.btBuscarMerc = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLimpar = new Krypton.Toolkit.KryptonButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMercadorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBuscarMerc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.labelTitulo.Location = new System.Drawing.Point(39, 43);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(121, 31);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Estoque";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.groupBox2.Location = new System.Drawing.Point(929, 892);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 80);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alerta de estoque mínimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "0 mercadoria encontrada";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.groupBox3.Location = new System.Drawing.Point(929, 1001);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 80);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alerta de validade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(34, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "0 mercadoria encontrada";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.groupBox4.Location = new System.Drawing.Point(31, 892);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(830, 189);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registrar entrada";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(215)))), ((int)(((byte)(206)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(213)))), ((int)(((byte)(204)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.button3.Location = new System.Drawing.Point(608, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 45);
            this.button3.TabIndex = 33;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(215)))), ((int)(((byte)(206)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(213)))), ((int)(((byte)(204)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(608, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 45);
            this.button2.TabIndex = 32;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.label9.Location = new System.Drawing.Point(324, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Quantidade em estoque";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox6.Location = new System.Drawing.Point(327, 152);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(204, 26);
            this.textBox6.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.label10.Location = new System.Drawing.Point(324, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "Variação";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox7.Location = new System.Drawing.Point(327, 100);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(204, 26);
            this.textBox7.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.label11.Location = new System.Drawing.Point(324, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "Categoria";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox8.Location = new System.Drawing.Point(327, 48);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(204, 26);
            this.textBox8.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(52, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Preço";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.Location = new System.Drawing.Point(55, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 26);
            this.textBox3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.label5.Location = new System.Drawing.Point(52, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(55, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.label4.Location = new System.Drawing.Point(52, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID Mercadoria";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(55, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 26);
            this.textBox1.TabIndex = 2;
            // 
            // txtBarraPesquisa
            // 
            this.txtBarraPesquisa.BackColor = System.Drawing.Color.White;
            this.txtBarraPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarraPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBarraPesquisa.Location = new System.Drawing.Point(26, 121);
            this.txtBarraPesquisa.Name = "txtBarraPesquisa";
            this.txtBarraPesquisa.Size = new System.Drawing.Size(423, 26);
            this.txtBarraPesquisa.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.label7.Location = new System.Drawing.Point(22, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código da mercadoria";
            // 
            // tabelaMercadorias
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tabelaMercadorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaMercadorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaMercadorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaMercadorias.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabelaMercadorias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabelaMercadorias.Location = new System.Drawing.Point(0, 235);
            this.tabelaMercadorias.Name = "tabelaMercadorias";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaMercadorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.tabelaMercadorias.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tabelaMercadorias.Size = new System.Drawing.Size(1200, 553);
            this.tabelaMercadorias.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.panel1.Location = new System.Drawing.Point(17, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 61);
            this.panel1.TabIndex = 75;
            // 
            // btBuscarMercFull
            // 
            this.btBuscarMercFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscarMercFull.Location = new System.Drawing.Point(564, 109);
            this.btBuscarMercFull.Name = "btBuscarMercFull";
            this.btBuscarMercFull.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btBuscarMercFull.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btBuscarMercFull.OverrideDefault.Back.ColorAngle = 45F;
            this.btBuscarMercFull.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btBuscarMercFull.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btBuscarMercFull.OverrideDefault.Border.ColorAngle = 45F;
            this.btBuscarMercFull.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btBuscarMercFull.OverrideDefault.Border.Rounding = 20F;
            this.btBuscarMercFull.OverrideDefault.Border.Width = 1;
            this.btBuscarMercFull.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btBuscarMercFull.Size = new System.Drawing.Size(53, 50);
            this.btBuscarMercFull.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btBuscarMercFull.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btBuscarMercFull.StateCommon.Back.ColorAngle = 45F;
            this.btBuscarMercFull.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btBuscarMercFull.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btBuscarMercFull.StateCommon.Border.ColorAngle = 45F;
            this.btBuscarMercFull.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btBuscarMercFull.StateCommon.Border.Rounding = 20F;
            this.btBuscarMercFull.StateCommon.Border.Width = 1;
            this.btBuscarMercFull.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btBuscarMercFull.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btBuscarMercFull.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarMercFull.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btBuscarMercFull.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btBuscarMercFull.StatePressed.Back.ColorAngle = 135F;
            this.btBuscarMercFull.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btBuscarMercFull.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btBuscarMercFull.StatePressed.Border.ColorAngle = 135F;
            this.btBuscarMercFull.StatePressed.Border.Rounding = 20F;
            this.btBuscarMercFull.StatePressed.Border.Width = 1;
            this.btBuscarMercFull.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btBuscarMercFull.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btBuscarMercFull.StateTracking.Back.ColorAngle = 45F;
            this.btBuscarMercFull.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btBuscarMercFull.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btBuscarMercFull.StateTracking.Border.ColorAngle = 45F;
            this.btBuscarMercFull.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btBuscarMercFull.StateTracking.Border.Rounding = 20F;
            this.btBuscarMercFull.StateTracking.Border.Width = 1;
            this.btBuscarMercFull.TabIndex = 76;
            this.btBuscarMercFull.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btBuscarMercFull.Values.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarMercFull.Values.Image")));
            this.btBuscarMercFull.Values.Text = "";
            this.btBuscarMercFull.Click += new System.EventHandler(this.btListarMercFull_Click);
            // 
            // btEditar
            // 
            this.btEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditar.Location = new System.Drawing.Point(626, 109);
            this.btEditar.Name = "btEditar";
            this.btEditar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btEditar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btEditar.OverrideDefault.Back.ColorAngle = 45F;
            this.btEditar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btEditar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btEditar.OverrideDefault.Border.ColorAngle = 45F;
            this.btEditar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btEditar.OverrideDefault.Border.Rounding = 20F;
            this.btEditar.OverrideDefault.Border.Width = 1;
            this.btEditar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btEditar.Size = new System.Drawing.Size(53, 50);
            this.btEditar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btEditar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btEditar.StateCommon.Back.ColorAngle = 45F;
            this.btEditar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btEditar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btEditar.StateCommon.Border.ColorAngle = 45F;
            this.btEditar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btEditar.StateCommon.Border.Rounding = 20F;
            this.btEditar.StateCommon.Border.Width = 1;
            this.btEditar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btEditar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btEditar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btEditar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btEditar.StatePressed.Back.ColorAngle = 135F;
            this.btEditar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btEditar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btEditar.StatePressed.Border.ColorAngle = 135F;
            this.btEditar.StatePressed.Border.Rounding = 20F;
            this.btEditar.StatePressed.Border.Width = 1;
            this.btEditar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btEditar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btEditar.StateTracking.Back.ColorAngle = 45F;
            this.btEditar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btEditar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btEditar.StateTracking.Border.ColorAngle = 45F;
            this.btEditar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btEditar.StateTracking.Border.Rounding = 20F;
            this.btEditar.StateTracking.Border.Width = 1;
            this.btEditar.TabIndex = 77;
            this.btEditar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btEditar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Values.Image")));
            this.btEditar.Values.Text = "";
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeletar.Location = new System.Drawing.Point(1099, 106);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btDeletar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btDeletar.OverrideDefault.Back.ColorAngle = 45F;
            this.btDeletar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btDeletar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btDeletar.OverrideDefault.Border.ColorAngle = 45F;
            this.btDeletar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btDeletar.OverrideDefault.Border.Rounding = 20F;
            this.btDeletar.OverrideDefault.Border.Width = 1;
            this.btDeletar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btDeletar.Size = new System.Drawing.Size(53, 50);
            this.btDeletar.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.btDeletar.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.btDeletar.StateCommon.Back.ColorAngle = 45F;
            this.btDeletar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btDeletar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btDeletar.StateCommon.Border.ColorAngle = 45F;
            this.btDeletar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btDeletar.StateCommon.Border.Rounding = 20F;
            this.btDeletar.StateCommon.Border.Width = 1;
            this.btDeletar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btDeletar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btDeletar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btDeletar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btDeletar.StatePressed.Back.ColorAngle = 135F;
            this.btDeletar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btDeletar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btDeletar.StatePressed.Border.ColorAngle = 135F;
            this.btDeletar.StatePressed.Border.Rounding = 20F;
            this.btDeletar.StatePressed.Border.Width = 1;
            this.btDeletar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btDeletar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btDeletar.StateTracking.Back.ColorAngle = 45F;
            this.btDeletar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btDeletar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btDeletar.StateTracking.Border.ColorAngle = 45F;
            this.btDeletar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btDeletar.StateTracking.Border.Rounding = 20F;
            this.btDeletar.StateTracking.Border.Width = 1;
            this.btDeletar.TabIndex = 78;
            this.btDeletar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btDeletar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btDeletar.Values.Image")));
            this.btDeletar.Values.Text = "";
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click_1);
            // 
            // btBuscarMerc
            // 
            this.btBuscarMerc.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarMerc.Image")));
            this.btBuscarMerc.Location = new System.Drawing.Point(455, 116);
            this.btBuscarMerc.Name = "btBuscarMerc";
            this.btBuscarMerc.Size = new System.Drawing.Size(41, 36);
            this.btBuscarMerc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btBuscarMerc.TabIndex = 79;
            this.btBuscarMerc.TabStop = false;
            this.btBuscarMerc.Click += new System.EventHandler(this.btBuscarMerc_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btLimpar);
            this.panel2.Controls.Add(this.btBuscarMerc);
            this.panel2.Controls.Add(this.labelTitulo);
            this.panel2.Controls.Add(this.btDeletar);
            this.panel2.Controls.Add(this.txtBarraPesquisa);
            this.panel2.Controls.Add(this.btEditar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btBuscarMercFull);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 184);
            this.panel2.TabIndex = 80;
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpar.Location = new System.Drawing.Point(720, 109);
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
            this.btLimpar.Size = new System.Drawing.Size(53, 50);
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
            this.btLimpar.TabIndex = 81;
            this.btLimpar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btLimpar.Values.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Values.Image")));
            this.btLimpar.Values.Text = "";
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // ControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabelaMercadorias);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControleEstoque";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojaprincipal";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMercadorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBuscarMerc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBarraPesquisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView tabelaMercadorias;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btBuscarMercFull;
        private Krypton.Toolkit.KryptonButton btEditar;
        private Krypton.Toolkit.KryptonButton btDeletar;
        private System.Windows.Forms.PictureBox btBuscarMerc;
        private System.Windows.Forms.Panel panel2;
        private Krypton.Toolkit.KryptonButton btLimpar;
    }
}