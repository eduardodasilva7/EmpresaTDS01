using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto
{
    public class Calculadora
    {
        public double Somar(double num1, double num2)
        {
            return (num1 + num2); 
        }

        public double Subtrair(double n1, double n2)
        {
            return (n1 - n2);
        }

        public double Mutiplicar(double n1, double n2)
        {
            return (n1 * n2);
        }

        public double Dividir(double n1, double n2)
        {
            return (n1 / n2);
        }
    }
}
