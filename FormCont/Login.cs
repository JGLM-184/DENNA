using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace FormCont
{
    public partial class Login : KryptonForm
    {
        // private Login login; // Instância do formulário de login
        private Container container; // Instância do formulário container

        private Size formOriginalSize;
        private Rectangle recImg1;
        private Rectangle recImg2;

        private Rectangle recLbl1;
        private Rectangle recLbl2;
        private Rectangle recLbl3;

        private Rectangle recTxt1;
        private Rectangle recTxt2;

        private Rectangle recBtn1;
        private Rectangle recBtn2;

        private const float MIN_FONT_SIZE = 8f; // Tamanho mínimo da fonte
        private const float MAX_FONT_SIZE = 20f; // Tamanho máximo da fonte (ajuste conforme necessário)
        private Dictionary<Control, float> originalFontSizes; // Armazenar os tamanhos de fonte originais
        private Dictionary<Control, Size> originalImageSizes; // Armazenar os tamanhos das imagens originais
        private Dictionary<Control, Point> originalControlPositions; // Armazenar as posições originais dos controles
        private Dictionary<Control, Size> originalControlSizes; // Armazenar os tamanhos originais dos controles

        public Login()
        {
            InitializeComponent();
            this.Resize += Form1_Resiz;
            formOriginalSize = this.Size;

            // Inicializar os dicionários para armazenar o tamanho original das fontes, imagens e posições dos controles
            originalFontSizes = new Dictionary<Control, float>();
            originalImageSizes = new Dictionary<Control, Size>();
            originalControlPositions = new Dictionary<Control, Point>();
            originalControlSizes = new Dictionary<Control, Size>(); // Inicializar o dicionário de tamanhos

            // Inicializando os retângulos para os controles
            recImg2 = new Rectangle(pictureBox1.Location, pictureBox1.Size);

            recLbl1 = new Rectangle(linkLabel1.Location, linkLabel1.Size);
            recLbl2 = new Rectangle(label2.Location, label2.Size);
            recLbl3 = new Rectangle(label3.Location, label3.Size);

            recTxt1 = new Rectangle(kryptonTextBox1.Location, kryptonTextBox1.Size);
            recTxt2 = new Rectangle(kryptonTextBox2.Location, kryptonTextBox2.Size);

            recBtn1 = new Rectangle(kryptonButton1.Location, kryptonButton1.Size);

            // Armazenar os tamanhos de fontes originais
            StoreOriginalFontSizes();

            // Armazenar os tamanhos das imagens originais
            StoreOriginalImageSizes();

            // Armazenar as posições originais dos controles
            StoreOriginalControlPositions();

            // Armazenar os tamanhos originais dos controles (botões e caixas de texto)
            StoreOriginalControlSizes();


        }

        private void StoreOriginalFontSizes()
        {
            // Armazenar os tamanhos de fontes originais dos controles
            originalFontSizes[linkLabel1] = linkLabel1.Font.Size;
            originalFontSizes[label2] = label2.Font.Size;
            originalFontSizes[label3] = label3.Font.Size;
            originalFontSizes[kryptonTextBox1] = kryptonTextBox1.Font.Size;
            originalFontSizes[kryptonTextBox2] = kryptonTextBox2.Font.Size;
            originalFontSizes[kryptonButton1] = kryptonButton1.Font.Size;// Adicionado para os botões
        }

        private void StoreOriginalImageSizes()
        {
            // Armazenar os tamanhos originais das imagens
            originalImageSizes[pictureBox1] = pictureBox1.Size;
        }

        private void StoreOriginalControlPositions()
        {
            // Armazenar as posições originais dos controles
            originalControlPositions[linkLabel1] = linkLabel1.Location;
            originalControlPositions[label2] = label2.Location;
            originalControlPositions[label3] = label3.Location;
            originalControlPositions[kryptonTextBox1] = kryptonTextBox1.Location;
            originalControlPositions[kryptonTextBox2] = kryptonTextBox2.Location;
            originalControlPositions[kryptonButton1] = kryptonButton1.Location;
            originalControlPositions[pictureBox1] = pictureBox1.Location;
        }

        private void StoreOriginalControlSizes()
        {
            // Armazenar os tamanhos originais dos controles (botões e caixas de texto)
            originalControlSizes[kryptonTextBox1] = kryptonTextBox1.Size;
            originalControlSizes[kryptonTextBox2] = kryptonTextBox2.Size;
            originalControlSizes[kryptonButton1] = kryptonButton1.Size;
        }

        private void Form1_Resiz(object sender, EventArgs e)
        {
            // Verificar se a janela foi restaurada ao tamanho original
            if (this.Size == formOriginalSize)
            {
                // Se a janela estiver de volta ao tamanho original, redefinir as fontes, imagens e posições
                ResetFontSizesToOriginal();
                ResetImageSizesToOriginal();
                ResetControlPositionsToOriginal();
                ResetControlSizesToOriginal(); // Restaurar os tamanhos originais dos controles
            }
            else
            {
                // Caso contrário, redimensionar os controles, fontes e espaçamentos conforme necessário
                resize_Control(pictureBox1, recImg2);

                resize_Control(linkLabel1, recLbl1);
                resize_Control(label2, recLbl2);
                resize_Control(label3, recLbl3);

                resize_Control(kryptonTextBox1, recTxt1);
                resize_Control(kryptonTextBox2, recTxt2);

                resize_Control(kryptonButton1, recBtn1);

                // Redimensionar as fontes dos controles de texto e botões
                resize_Font(linkLabel1);
                resize_Font(label2);
                resize_Font(label3);
                resize_Font(kryptonTextBox1);
                resize_Font(kryptonTextBox2);
                resize_Font(kryptonButton1); // Redimensionar o botão 1
            }
        }

        // Função para redefinir os tamanhos de fonte para os valores originais
        private void ResetFontSizesToOriginal()
        {
            foreach (var control in originalFontSizes.Keys)
            {
                // Obter o tamanho original da fonte
                float originalFontSize = originalFontSizes[control];

                // Redefinir o tamanho da fonte para o valor original
                control.Font = new Font(control.Font.FontFamily, originalFontSize, control.Font.Style);
            }
        }

        // Função para redefinir os tamanhos das imagens para os valores originais
        private void ResetImageSizesToOriginal()
        {
            foreach (var control in originalImageSizes.Keys)
            {
                // Obter o tamanho original da imagem
                Size originalSize = originalImageSizes[control];

                // Redefinir o tamanho da imagem para o valor original
                control.Size = originalSize;
            }
        }

        // Função para redefinir as posições dos controles para os valores originais
        private void ResetControlPositionsToOriginal()
        {
            foreach (var control in originalControlPositions.Keys)
            {
                // Obter a posição original do controle
                Point originalPosition = originalControlPositions[control];

                // Redefinir a posição do controle para o valor original
                control.Location = originalPosition;
            }
        }

        // Função para redefinir os tamanhos dos controles (botões e caixas de texto) para os valores originais
        private void ResetControlSizesToOriginal()
        {
            foreach (var control in originalControlSizes.Keys)
            {
                // Obter o tamanho original do controle
                Size originalSize = originalControlSizes[control];

                // Redefinir o tamanho do controle para o valor original
                control.Size = originalSize;
            }
        }

        // Função para redimensionar controles (posição e tamanho)
        private void resize_Control(Control c, Rectangle r)
        {
            // Cálculo da proporção para o redimensionamento dos controles
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            float ratio = Math.Min(xRatio, yRatio);  // Usar a menor proporção para garantir que o controle não ultrapasse limites

            // Redimensionar a posição do controle proporcionalmente
            int newX = (int)(r.X * ratio);
            int newY = (int)(r.Y * ratio);

            // Redimensionar o tamanho do controle proporcionalmente
            int newWidth = (int)(r.Width * ratio);
            int newHeight = (int)(r.Height * ratio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        // Função para redimensionar a fonte dos controles de texto
        private void resize_Font(Control c)
        {
            // Usar a proporção entre a largura e altura da janela
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            float ratio = Math.Min(xRatio, yRatio);  // Usar a menor proporção para ajustar a fonte de forma mais controlada

            if (c.Font != null)
            {
                // Calcula o novo tamanho da fonte com base na proporção
                float newFontSize = c.Font.Size * ratio;

                // Estabelece um limite mínimo e máximo para o tamanho da fonte
                newFontSize = Math.Max(MIN_FONT_SIZE, newFontSize);  // Impede que a fonte fique muito pequena
                newFontSize = Math.Min(MAX_FONT_SIZE, newFontSize);  // Impede que a fonte fique muito grande

                // Redefine o tamanho da fonte
                c.Font = new Font(c.Font.FontFamily, newFontSize, c.Font.Style);
            }
        }



        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Senha")
            {
                kryptonTextBox2.Text = "";
                kryptonTextBox2.StateCommon.Content.Color1 = System.Drawing.Color.Black; // Cor do texto ao digitar
            }
        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBox2.Text))
            {
                kryptonTextBox2.Text = "Senha";
                kryptonTextBox2.StateCommon.Content.Color1 = System.Drawing.Color.Gray; // Cor do texto padrão
            }
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Usuário")
            {
                kryptonTextBox1.Text = "";
                kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.Black; // Cor do texto ao digitar
            }
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryptonTextBox1.Text))
            {
                kryptonTextBox1.Text = "Usuário";
                kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.Gray; // Cor do texto padrão
            }
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            // Verifica se a instância do container já foi criada
            if (container == null || container.IsDisposed)
            {
                container = new Container();
                container.FormClosing += (s, args) => this.Show(); // Mostra o login novamente quando o container é fechado
            }

            // Esconde o formulário de login e mostra o container
            this.Hide(); // Esconde o formulário de login
            container.Show(); // Mostra o formulário container
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
