
namespace FormCont
{
    partial class RegistrarEntrada
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registrar = new System.Windows.Forms.Button();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.teste = new System.Windows.Forms.Button();
            this.pesquisa = new System.Windows.Forms.GroupBox();
            this.registro = new System.Windows.Forms.GroupBox();
            this.updtTime = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.obsMov = new System.Windows.Forms.TextBox();
            this.dateMov = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.precUnimov = new System.Windows.Forms.TextBox();
            this.quantMov = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdSaida = new System.Windows.Forms.RadioButton();
            this.rdEntrada = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.pesquisa.SuspendLayout();
            this.registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(5, 43);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(132, 20);
            this.txt1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Digite o Codigo do Produto.";
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(408, 119);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(147, 48);
            this.registrar.TabIndex = 2;
            this.registrar.Text = "Registrar Entrada";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(156, 20);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(83, 13);
            this.lbl_2.TabIndex = 7;
            this.lbl_2.Text = "Tipo do Produto";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(332, 43);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(151, 20);
            this.txt3.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt2.Location = new System.Drawing.Point(159, 43);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(151, 20);
            this.txt2.TabIndex = 4;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(329, 20);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(92, 13);
            this.lbl_3.TabIndex = 6;
            this.lbl_3.Text = "Marca do Produto";
            // 
            // cmbForma
            // 
            this.cmbForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            ""});
            this.cmbForma.Location = new System.Drawing.Point(510, 42);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(149, 21);
            this.cmbForma.TabIndex = 5;
            // 
            // tabela
            // 
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(9, 78);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(462, 107);
            this.tabela.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Formato do Produto";
            // 
            // teste
            // 
            this.teste.Location = new System.Drawing.Point(510, 113);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(133, 31);
            this.teste.TabIndex = 12;
            this.teste.Text = "Pesquisa";
            this.teste.UseVisualStyleBackColor = true;
            this.teste.Click += new System.EventHandler(this.teste_Click);
            // 
            // pesquisa
            // 
            this.pesquisa.Controls.Add(this.teste);
            this.pesquisa.Controls.Add(this.label2);
            this.pesquisa.Controls.Add(this.tabela);
            this.pesquisa.Controls.Add(this.cmbForma);
            this.pesquisa.Controls.Add(this.lbl_3);
            this.pesquisa.Controls.Add(this.txt2);
            this.pesquisa.Controls.Add(this.txt3);
            this.pesquisa.Controls.Add(this.lbl_2);
            this.pesquisa.Controls.Add(this.label1);
            this.pesquisa.Controls.Add(this.txt1);
            this.pesquisa.Location = new System.Drawing.Point(12, 12);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(690, 215);
            this.pesquisa.TabIndex = 14;
            this.pesquisa.TabStop = false;
            this.pesquisa.Text = "Campo de Pesquisa";
            // 
            // registro
            // 
            this.registro.Controls.Add(this.updtTime);
            this.registro.Controls.Add(this.label7);
            this.registro.Controls.Add(this.obsMov);
            this.registro.Controls.Add(this.dateMov);
            this.registro.Controls.Add(this.label6);
            this.registro.Controls.Add(this.label5);
            this.registro.Controls.Add(this.precUnimov);
            this.registro.Controls.Add(this.quantMov);
            this.registro.Controls.Add(this.label4);
            this.registro.Controls.Add(this.registrar);
            this.registro.Controls.Add(this.rdSaida);
            this.registro.Controls.Add(this.rdEntrada);
            this.registro.Controls.Add(this.label3);
            this.registro.Location = new System.Drawing.Point(12, 246);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(688, 192);
            this.registro.TabIndex = 15;
            this.registro.TabStop = false;
            this.registro.Text = "Campo de Registro";
            // 
            // updtTime
            // 
            this.updtTime.Location = new System.Drawing.Point(139, 147);
            this.updtTime.Name = "updtTime";
            this.updtTime.Size = new System.Drawing.Size(117, 29);
            this.updtTime.TabIndex = 11;
            this.updtTime.Text = "Atualizar";
            this.updtTime.UseVisualStyleBackColor = true;
            this.updtTime.Click += new System.EventHandler(this.updtTime_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Observacoes";
            // 
            // obsMov
            // 
            this.obsMov.Location = new System.Drawing.Point(269, 51);
            this.obsMov.Multiline = true;
            this.obsMov.Name = "obsMov";
            this.obsMov.Size = new System.Drawing.Size(413, 40);
            this.obsMov.TabIndex = 9;
            // 
            // dateMov
            // 
            this.dateMov.Location = new System.Drawing.Point(138, 119);
            this.dateMov.Name = "dateMov";
            this.dateMov.ReadOnly = true;
            this.dateMov.Size = new System.Drawing.Size(119, 20);
            this.dateMov.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data - Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preco Unitario";
            // 
            // precUnimov
            // 
            this.precUnimov.Location = new System.Drawing.Point(9, 119);
            this.precUnimov.Name = "precUnimov";
            this.precUnimov.Size = new System.Drawing.Size(87, 20);
            this.precUnimov.TabIndex = 5;
            // 
            // quantMov
            // 
            this.quantMov.Location = new System.Drawing.Point(138, 50);
            this.quantMov.Name = "quantMov";
            this.quantMov.Size = new System.Drawing.Size(87, 20);
            this.quantMov.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // rdSaida
            // 
            this.rdSaida.AutoSize = true;
            this.rdSaida.Location = new System.Drawing.Point(9, 74);
            this.rdSaida.Name = "rdSaida";
            this.rdSaida.Size = new System.Drawing.Size(52, 17);
            this.rdSaida.TabIndex = 2;
            this.rdSaida.TabStop = true;
            this.rdSaida.Text = "Saida";
            this.rdSaida.UseVisualStyleBackColor = true;
            // 
            // rdEntrada
            // 
            this.rdEntrada.AutoSize = true;
            this.rdEntrada.Location = new System.Drawing.Point(9, 51);
            this.rdEntrada.Name = "rdEntrada";
            this.rdEntrada.Size = new System.Drawing.Size(62, 17);
            this.rdEntrada.TabIndex = 1;
            this.rdEntrada.TabStop = true;
            this.rdEntrada.Text = "Entrada";
            this.rdEntrada.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de Movimento";
            // 
            // RegistrarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarEntrada";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.pesquisa.ResumeLayout(false);
            this.pesquisa.PerformLayout();
            this.registro.ResumeLayout(false);
            this.registro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button teste;
        private System.Windows.Forms.GroupBox pesquisa;
        private System.Windows.Forms.GroupBox registro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdSaida;
        private System.Windows.Forms.RadioButton rdEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox obsMov;
        private System.Windows.Forms.TextBox dateMov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox precUnimov;
        private System.Windows.Forms.TextBox quantMov;
        private System.Windows.Forms.Button updtTime;
    }
}