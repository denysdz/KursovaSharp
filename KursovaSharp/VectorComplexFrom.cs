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
    public partial class VectorComplexFrom : Form {

        private VectorComplex vectorComplex;

        public VectorComplexFrom() {
            InitializeComponent();
            vectorComplex = new VectorComplex();
        }

        private void addBtn_Click(object sender, EventArgs e) {
            errorLabel.Text = "";
            if (realEdit.Text.Length == 0 && imageEdit.Text.Length == 0) {
                errorLabel.Text = "Заповніть всі поля!";
                return;
            }
            if (!Utils.isValidIntNumber(realEdit.Text.ToString()) || !Utils.isValidIntNumber(imageEdit.Text.ToString())) {
                errorLabel.Text = "Дозволено тільки дійсні числа!";
                return;
            }
            errorLabel.Text = "";
            double realNumber = Convert.ToDouble(realEdit.Text);
            double imageNumber = Convert.ToDouble(imageEdit.Text);
            ComplexNumber complexNumber = new ComplexNumber(realNumber, imageNumber);
            vectorComplex.PushBack(complexNumber);
            realEdit.Text = "";
            imageEdit.Text = "";
            updateComplexList();
            calcBtn.Visible = true;
            resultBox.Visible = true;
            maxModuleLabel.Visible = true;
        }

        private void updateComplexList () {
            vectorListBox.Items.Clear();
            VectorCustomIterator customIterator = new VectorCustomIterator(vectorComplex.Data);
            while (customIterator.MoveNext()) {
                vectorListBox.Items.Add(customIterator.Current.ToString());
            }
        }

        private void calcBtn_Click(object sender, EventArgs e) {
            maxModuleLabel.Text = "Комплексне число з найбільшим модулем: " + vectorComplex.GetMaxModule().ToString();
            resultBox.Text = "Консольне предсавлення матриці: \r\n" + vectorComplex.ToString();
        }

    }
}
