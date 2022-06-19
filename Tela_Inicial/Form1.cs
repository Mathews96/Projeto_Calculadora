namespace Tela_Inicial
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            txtBxTela.Enabled = false;
            txtBxTela.BackColor = Color.White;
            
        }
        private Calculadora calcular = new Calculadora();
        private bool limparTela;
        private void clickTeclaNumerica(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (calcular.cliclouNoOperadorAritmetico)
            {
                if (!limparTela)
                {
                    txtBxTela.Text = string.Empty;
                    limparTela = true;
                }
            }
            calcular.setarValor(botao.Text);
            txtBxTela.Text += botao.Text;         
        }

  
        private void clickTeclaSinal(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (botao.Text == "+" || botao.Text == "-" || botao.Text == "/" || botao.Text == "*")
            {
                calcular.operadorAritmetico = botao.Text;
            }
            lblOperador.Text = (string)botao.Text;
            calcular.calcular(botao.Text, calcular.valor1, calcular.valor2);
            lblOperador.Text = botao.Text;
            if (limparTela) limparTela = false;
            calcular.cliclouNoOperadorAritmetico = true;
            txtBxTela.Text = calcular.obterTotal().ToString();
        }
        private void clickTeclaC(object sender, EventArgs e)
        {
            calcular.limparCalculos();
            txtBxTela.Text = string.Empty;
            lblOperador.Text = string.Empty;
            limparTela = false;
        }
    }   
}