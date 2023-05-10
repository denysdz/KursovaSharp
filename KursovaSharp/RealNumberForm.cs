using KursovaSharp.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaSharp {
    public partial class RealNumberForm : Form {
        public RealNumberForm() {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e) {
            resultBox.Items.Clear();
            if (real1.Text.Length > 0 && real2.Text.Length > 0) {
                if (isValidNumber(real1.Text.ToString()) && isValidNumber(real2.Text.ToString())) {
                    errorLabel.Text = "";
                    RealNumber first= new RealNumber(Convert.ToDouble(real1.Text.ToString()));
                    RealNumber second = new RealNumber(Convert.ToDouble(real2.Text.ToString()));
                    RealNumber add = first + second;
                    RealNumber minus = first - second;
                    RealNumber multiply = first * second;
                    resultBox.Items.Add("Операція +:" + add.ToString());
                    resultBox.Items.Add("Операція -:" + minus.ToString());
                    resultBox.Items.Add("Операція *:" + multiply.ToString());
                    try {
                        RealNumber divide = first / second;
                        resultBox.Items.Add("Операція /:" + divide.ToString());
                    } catch (ArgumentException ex) {
                        errorLabel.Text = ex.Message;
                    }
                    resultBox.Items.Add("Норма першого числа: " + first.Norm().ToString());
                    resultBox.Items.Add("Норма Другого числа: " + second.Norm().ToString());
                } else {
                    errorLabel.Text = "Дозволено тільки дійсні числа!";
                }
            } else {
                errorLabel.Text = "Заповніть всі поля!";
            }
        }

        private bool isValidNumber(String value) {
            double number;
            if (double.TryParse(value, out number)) {
                return true;
            }
            return false;
        }

    }
}
