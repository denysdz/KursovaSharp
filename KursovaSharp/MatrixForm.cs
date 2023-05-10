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
    public partial class MatrixForm : Form {

        private Matrix matrix;
        public MatrixForm() {
            InitializeComponent();
        }

        private void createMatrix_Click(object sender, EventArgs e) {
            if (rowEdit.Text.Length > 0 && colmEdit.Text.Length > 0) {
                if (isValidParam(rowEdit.Text.ToString()) && isValidParam(rowEdit.Text.ToString())) {
                    int rows = int.Parse(rowEdit.Text.ToString());
                    int cols = int.Parse(colmEdit.Text.ToString());
                    matrix = new Matrix(rows, cols);
                    displayMatrix(matrix);
                    calcBtn.Visible= true;
                    resultLabel.Visible= true;
                    resultBox.Visible= true;
                } else {
                    errorLabel.Text = "Дозволено тільки натуральні числа!";
                }
            }
            else {
                errorLabel.Text = "Заповніть всі поля!";
            }
        }

        private void displayMatrix(Matrix matrix) {
            matrixGrid.Visible = true;
            matrixGrid.ColumnCount = matrix.Columns;
            matrixGrid.RowCount = matrix.Rows;
            for (int i = 0; i < matrix.Rows; i++) {
                for (int j = 0; j < matrix.Columns; j++) {
                    matrixGrid[j, i].Value = matrix[i, j];
                }
            }
        }

        private void calcBtn_Click(object sender, EventArgs e) {
            if (matrix != null) {
                resultLabel.Text = "Норма матриці: " + matrix.Norm().ToString();
                resultBox.Text = ("Консольне предсавлення матриці: \r\n" + matrix.ToString());
            }
        }

        private bool isValidNumberDouble(String value) {
            double number;
            if (double.TryParse(value, out number)) {
                return true;
            }
            return false;
        }

        private bool isValidParam(String value) {
            int number;
            if (int.TryParse(value, out number)) {
                return true;
            }
            return false;
        }

        private void matrixGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
            if (isValidNumberDouble(e.FormattedValue.ToString())) {
                matrix[e.RowIndex, e.ColumnIndex] = Convert.ToDouble(e.FormattedValue.ToString());
            } else {
                MessageBox.Show("Введене значення не є коректним. Дозволено тільки дійсні числа!");
                matrixGrid.CancelEdit();
                matrixGrid[e.RowIndex, e.ColumnIndex].Value = matrix[e.RowIndex, e.ColumnIndex];
            }
        }

    }
}
