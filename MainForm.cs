using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Calculadora {
    public partial class MainForm : Form {
        private double num1 = 0, num2 = 0, result = 0;
        bool realizado = false, borrar, entrar = false;
        string[] operador = new string[2];

        private Operaciones operacion = new Operaciones();

        public MainForm() {
            InitializeComponent();
        }

        private void getNumbers() {

            if (num1 == 0) {
                num1 = double.Parse(txtResult.Text);
            } else if (num2 == 0) {
                num2 = double.Parse(txtResult.Text);
            }
            borrar = true;
        }

        private void alertError(string txt, string title) {
            MessageBox.Show(txt, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addNumber(object sender, EventArgs e) {
            Button btn = ((Button)sender);
            if (txtResult.Text == "0") {
                txtResult.Text = "";
                txtResult.Text += btn.Text;
                borrar = false;
                entrar= true;
            } else {
                if (txtResult.Text.Length > 16) {
                    alertError("Has excedido el limite de caracteres, no puedes introducir mas de 17 numeros", "Limite de Caracteres");
                } else if (borrar) {
                    txtResult.Text = "";
                    txtResult.Text += btn.Text;
                    borrar = false;
                    entrar = true;

                } else {
                    txtResult.Text += btn.Text;
                    borrar = false;
                    entrar = true; 
                }
            }

        }

        private void click_Operador(object sender, EventArgs e) {
            getNumbers();
            Button btn = ((Button)sender);
            operador[1] = btn.Text;

            if (entrar) {
                llamarOperacion(btn, sender, e);
            }


        }

        private void llamarOperacion(Button btn, object sender, EventArgs e) {
            operador[1] = btn.Text;
            if (operador[1] == "√" || operador[1] == "x²") {
                result = operacion.operacion(operador[1], Convert.ToString(num1), Convert.ToString(num2));
                txtResult.Text = result.ToString();
            } else if (num1 != 0 && num2 != 0) {
                realizarOperacion(sender, e);
            }
            entrar = false;

        }


        private void realizarOperacion(object sender, EventArgs e) {
            result = operacion.operacion(operador[1], Convert.ToString(num1), Convert.ToString(num2));
            txtResult.Text = result.ToString();
            num2 = 0;
            num1 = result;
        }



        private void equalClick(object sender, EventArgs e) {
            getNumbers();
            result = Convert.ToDouble(txtResult.Text);
            result = operacion.operacion(operador[1], Convert.ToString(num1), Convert.ToString(result));
            txtResult.Text = result.ToString();
            num1 = result;
            num2 = 0;
            borrar = true;
        }

        private void btnCambioSigno_Click(object sender, EventArgs e) {
            if (txtResult.Text != "0") {
                if (txtResult.Text.Substring(0, 1) == "-") {
                    txtResult.Text = txtResult.Text.Remove(0, 1);
                } else {
                    txtResult.Text = "-" + txtResult.Text;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            num2 = 0;
            txtResult.Text = "0";
        }
        private void btnClearAll_Click(object sender, EventArgs e) {
            num1 = 0;
            num2 = 0;
            result = 0;
            txtResult.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e) {
            int len = txtResult.Text.Length - 1;
            if (len == 0) {
                txtResult.Text = "0";

            } else {
                txtResult.Text = txtResult.Text.Remove(len);
            }
        }
    }
}
