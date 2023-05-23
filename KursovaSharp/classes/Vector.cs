using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaSharp.classes {
    class Vector : RealNumber {
        private int size;
        private double[] values;

        public Vector() : base() {
            size = 0;
            values = null;
        }

        public Vector(int n) : base() {
            size = n;
            values = new double[size];
            for (int i = 0; i < size; i++) {
                values[i] = 0.0;
            }
        }

        public Vector(double[] arr) : base() {
            size = arr.Length;
            values = new double[size];
            Array.Copy(arr, values, size);
        }

        ~Vector() {
            if (values != null) {
                Array.Clear(values, 0, values.Length);
            }
        }

        public double this[int index] {
            get {
                return values[index];
            }
            set {
                values[index] = value;
            }
        }

        public int Size {
            get {
                return size;
            }
        }
        public override double Norm() {
            double sum = 0.0;
            for (int i = 0; i < size; i++) {
                sum += values[i] * values[i];
            }
            return Math.Sqrt(sum);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            for (int i = 0; i < size; i++) {
                sb.Append(values[i]);
                if (i < size - 1) {
                    sb.Append(", ");
                }
            }
            sb.Append("}");
            return sb.ToString();
        }

    }
}
