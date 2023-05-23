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
            errorLabel.Text = "";
            if (rowEdit.Text.Length == 0 && colmEdit.Text.Length == 0) {
                errorLabel.Text = "Заповніть всі поля!"; 
                return;
            }
            if (!Utils.isValidIntNumber(rowEdit.Text.ToString()) || !Utils.isValidIntNumber(rowEdit.Text.ToString())) {
                errorLabel.Text = "Дозволено тільки натуральні числа!";
                return;
            }
            int rows = int.Parse(rowEdit.Text.ToString());
            int cols = int.Parse(colmEdit.Text.ToString());
            matrix = new Matrix(rows, cols);
            displayMatrix(matrix);
            calcBtn.Visible= true;
            resultLabel.Visible= true;
            resultBox.Visible= true;
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

        private void matrixGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
            if (Utils.isValidDoubleNumber(e.FormattedValue.ToString())) {
                matrix[e.RowIndex, e.ColumnIndex] = Convert.ToDouble(e.FormattedValue.ToString());
            } else {
                MessageBox.Show("Введене значення не є коректним. Дозволено тільки дійсні числа!");
                matrixGrid.CancelEdit();
                matrixGrid[e.RowIndex, e.ColumnIndex].Value = matrix[e.RowIndex, e.ColumnIndex];
            }
        }

    }
}
