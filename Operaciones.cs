using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora {
    internal class Operaciones {

        public double operacion(string operador, string num1, string num2) {
            double result;

            switch (operador) {

                case "+":
                    result = Sumar(num1, num2);
                    break;
                case "-":
                    result = Restar(num1, num2);

                    break;
                case "x":
                    result = Multiplicar(num1, num2);
                    break;
                case "÷":
                    result = Dividir(num1, num2);
                    break;
                case "√":
                    result = Raiz(num1);
                    break;
                case "x²":
                    result = Elevar(num1);
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }


        private double Sumar(string txt1, string txt2) {
            return Convert.ToDouble(txt1) + Convert.ToDouble(txt2);
        }
        private double Restar(string txt1, string txt2) {
            return Convert.ToDouble(txt1) - Convert.ToDouble(txt2);
        }
        private double Multiplicar(string txt1, string txt2) {
            return Convert.ToDouble(txt1) * Convert.ToDouble(txt2);
        }
        private double Dividir(string txt1, string txt2) {
            return Convert.ToDouble(txt1) / Convert.ToDouble(txt2);
        }
        private double Raiz(string txt1) {
            return Math.Sqrt(Convert.ToDouble(txt1));
        }
        private double Elevar(string txt1) {
            return Math.Pow(Convert.ToDouble(txt1),2);
        }
    }
}
