using KursovaSharp.classes;
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

namespace KursovaSharp {
    public partial class VectorForm : Form {

        private Vector vector;
        public VectorForm() {
            InitializeComponent();
        }

        private void displayVector(Vector vector) {
            vectorGrid.Visible = true;
            vectorGrid.ColumnCount = vector.Size;
            vectorGrid.RowCount = 1;
            for (int i = 0; i < vector.Size; i++) {
                vectorGrid[i, 0].Value = vector[i];
            }
        }

        private void vectorGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
            if (Utils.isValidDoubleNumber(e.FormattedValue.ToString())) {
                vector[e.ColumnIndex] = Convert.ToDouble(e.FormattedValue.ToString());
            }
            else {
                MessageBox.Show("Введене значення не є коректним. Дозволено тільки дійсні числа!");
                vectorGrid.CancelEdit();
                vectorGrid[e.RowIndex, e.ColumnIndex].Value = vector[e.RowIndex];
            }
        }

        private void createBtn_Click(object sender, EventArgs e) {
            errorLabel.Text = "";
            if (sizeEdit.Text.Length == 0) {
                errorLabel.Text = "Вкажіть розмір ветора!";
                return;
            }
            if (!Utils.isValidDoubleNumber(sizeEdit.Text.ToString())) {
                errorLabel.Text = "Дозволено тільки натуральні числа!";
                return;
            }
            int size = int.Parse(sizeEdit.Text.ToString());
            vector = new Vector(size);
            displayVector(vector);
            calcBtn.Visible = true;
            resultLabel.Visible = true;
            resultBox.Visible = true;
        }

        private void calcBtn_Click(object sender, EventArgs e) {
            if (vector != null) {
                resultLabel.Text = "Норма вектора: " + vector.Norm().ToString();
                resultBox.Text = ("Консольне предсавлення вектора: \r\n" + vector.ToString());
            }
        }

    }
}
