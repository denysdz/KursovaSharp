using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaSharp.classes {
    public partial class ComplexNumberForm : Form {

        public ComplexNumberForm() {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e) {
            resultBox.Items.Clear();
            if (realEdit.Text.Length == 0 || imageEdit.Text.Length == 0) {
                errorLabel.Text = "Заповніть всі поля!";
                return;
            }
            if (!Utils.isValidDoubleNumber(realEdit.Text.ToString()) || !Utils.isValidDoubleNumber(imageEdit.Text.ToString())) {
                errorLabel.Text = "Дозволено тільки дійсні числа!";
                return;
            }
            errorLabel.Text = "";
            double realNumber = Convert.ToDouble(realEdit.Text);
            double imageNumber = Convert.ToDouble(imageEdit.Text);
            ComplexNumber complexNumber = new ComplexNumber(realNumber, imageNumber);
            resultBox.Items.Add("Задане число: " + complexNumber.ToString());
            resultBox.Items.Add("Норма заданого числа: " + complexNumber.Norm().ToString());
        }        

    }
}
