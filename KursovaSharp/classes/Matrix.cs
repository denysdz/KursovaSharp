using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaSharp.classes {
    class Matrix : RealNumber {
        private int rows;
        private int columns;
        private double[,] data;

        public Matrix() : base(0) {
            rows = 0;
            columns = 0;
            data = null;
        }

        public Matrix(int rows, int columns) : base(0) {
            this.rows = rows;
            this.columns = columns;
            data = new double[rows, columns];
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    data[i, j] = 0;
                }
            }
        }
        public int Rows {
            get { return rows; }
        }
        
        public int Columns {
            get { return columns; }
        }

        public double[,] Data {
            get { return data; }
            set { data = value; }
        }

        public double this[int row, int col] {
            get { return data[row, col]; }
            set { data[row, col] = value; }
        }

        public override double Norm() {
            double maxNorm = double.MinValue;
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    double absValue = Math.Abs(data[i, j]);
                    if (absValue > maxNorm) {
                        maxNorm = absValue;
                    }
                }
            }
            return maxNorm;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    sb.Append(data[i, j]);
                    sb.Append(" ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }


    }

}
