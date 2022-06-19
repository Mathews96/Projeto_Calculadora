namespace Tela_Inicial
{
    public partial class Form1 : Form
    {
        bool sinal = false;
        public Form1()
        {
            InitializeComponent();
            this.operacao(" ");
        }
        public string valor1 { get; set; }
        public string valor2 { get; set; }
        public string operador { get; set; }
        public void operacao(string sinal)
        {
            operador = sinal;
        }
        public void setarValores(string valor)
        {
            if (sinal == false)
            {
                valor1 += valor;
            }
            else if (sinal == true)
            {
                valor2 += valor;
            }
        }
        public string resultado(string valorUm, string valorDois, string operacao)
        {
            decimal total;            
            switch(operacao)
            {
                case "+":
                    {
                        total = decimal.Parse(valorUm) + decimal.Parse(valorDois);
                        return total.ToString();
                    }
                case "-":
                    {
                        total = decimal.Parse(valorUm) - decimal.Parse(valorDois);
                        return total.ToString();
                    }
                case "*":
                    {
                        total = decimal.Parse(valorUm) * decimal.Parse(valorDois);
                        return total.ToString();
                    }
                case "/":
                    {
                        total = decimal.Parse(valorUm) / decimal.Parse(valorDois);
                        return total.ToString();
                    }
                default:
                    {
                        return "Erro no operador.";
                    }
            }
        }
        private void clickTecla(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            this.lblOperacao.Text = botao.Text;
            txtBxTela.Text += (string)this.lblOperacao.Text;   
            switch (botao.Text)
            {
                case "0":
                    {
                        this.setarValores("0");
                        break;
                    }
                case "1":
                    {
                        this.setarValores("1");
                        break;
                    }
                case "2":
                    {
                        this.setarValores("2");
                        break;
                    }
                case "3":
                    {
                        this.setarValores("3");
                        break;
                    }
                case "4":
                    {
                        this.setarValores("4");
                        break;
                    }
                case "5":
                    {
                        this.setarValores("5");
                        break;
                    }
                case "6":
                    {
                        this.setarValores("6");
                        break;
                    }
                case "7":
                    {
                        this.setarValores("7");
                        break;
                    }
                case "8":
                    {
                        this.setarValores("8");
                        break;
                    }
                case "9":
                    {
                        this.setarValores("9");
                        break;
                    }
                case ",":
                    {
                        this.setarValores(",");
                        break;
                    }
                case "+":
                    {
                        this.operacao(botao.Text);
                        this.sinal = true;
                        break;
                    }
                case "-":
                    {
                        this.operacao(botao.Text);
                        this.sinal = true;
                        break;
                    }
                case "*":
                    {
                        this.operacao(botao.Text);
                        this.sinal = true;
                        break;
                    }
                case "/":
                    {
                        this.operacao(botao.Text);
                        this.sinal = true;
                        break;
                    }
                case "=":
                    {                        
                        this.txtBxTela.Text = this.resultado(this.valor1, this.valor2, this.operador);                        
                        valor1 = this.resultado(this.valor1, this.valor2, this.operador);
                        valor2 = string.Empty;
                        this.sinal = false;
                        break;
                    }
                case "C":
                    {
                        this.valor1 = string.Empty; this.valor2 = string.Empty;
                        this.txtBxTela.Text = string.Empty;
                        this.operacao(" ");
                        this.sinal = false;
                        break;
                    }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}