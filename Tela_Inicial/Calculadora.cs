using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*><><><><><><><> - [ BUGS -CONHECIDOS ] - <><><><><><><><*
 * 1- Usuário consegue digitar quantas vírgulas quiser!   *
 * Exemplo: ,,,,,,,,,,...                                 * 
 * 2- Adicionar, quando casa decimal for = 0, mostrar     *
 * somente o inteiro.                                     * 
 *                                                        *
 *><><><><><><><><><><><><><><><><><><><><><><><><><><><><*/
namespace Tela_Inicial
{
    internal class Calculadora
    {
        public Calculadora()
        {
            valor2 = string.Empty;
        }
        public bool cliclouNoOperadorAritmetico { get; set; }
        public string operadorAritmetico { get; set; }
        public string valor1 { get; set; }
        public string valor2 { get; set; }
        public decimal total { get; set; }
        public void limparCalculos()
        {
            this.cliclouNoOperadorAritmetico = false;
            this.valor1 = "0";
            this.valor2 = string.Empty;
            this.total = 0;
        }
        public void setarValor(string valor)
        {            
            if (cliclouNoOperadorAritmetico == false)
            {
                this.valor1 += valor;
            }
            else if (cliclouNoOperadorAritmetico == true)
            {
                this.valor2 += valor;
            }
        }
        public void setarTotal(string valor)
        {
            this.valor1 = valor;
        }
        public decimal obterTotal()
        {
            return this.total;
        }
        public void calcular(string sinalAritmetico, string valor1, string valor2)
        {
            switch(sinalAritmetico)
            {
                case "+":
                    {
                        this.total = string.IsNullOrEmpty(valor2) ? string.IsNullOrEmpty(valor1) ? 0 : decimal.Parse(valor1) : decimal.Parse(valor1) + decimal.Parse(valor2);
                        setarTotal(this.total.ToString());
                        this.valor2 = string.Empty;
                        break;
                    }
                case "-":
                    {
                        this.total = string.IsNullOrEmpty(valor2) ? string.IsNullOrEmpty(valor1) ? 0 : decimal.Parse(valor1) : decimal.Parse(valor1) - decimal.Parse(valor2);
                        setarTotal(this.total.ToString());
                        this.valor2 = string.Empty;
                        break;
                    }
                case "/":
                    {
                        this.total = string.IsNullOrEmpty(valor2) ? string.IsNullOrEmpty(valor1) ? 0 : decimal.Parse(valor1) : decimal.Parse(valor1) / decimal.Parse(valor2);
                        setarTotal(this.total.ToString());
                        this.valor2 = string.Empty;
                        break;
                    }
                case "*":
                    {
                        this.total = string.IsNullOrEmpty(valor2) ? string.IsNullOrEmpty(valor1) ? 0 : decimal.Parse(valor1) : decimal.Parse(valor1) * decimal.Parse(valor2);
                        setarTotal(this.total.ToString());
                        this.valor2 = string.Empty;
                        break;
                    }
                case "=":
                    {
                        if (string.IsNullOrEmpty(this.operadorAritmetico))
                        {
                            this.total = decimal.Parse(this.valor1);
                            break;
                        }
                        this.calcular(this.operadorAritmetico, this.valor1, this.valor2);
                        break;
                    }            
                default:
                    {
                        this.total = 3770;
                        break;
                    }
            }
        }
    }
}
