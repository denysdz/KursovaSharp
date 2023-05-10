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

        ~Vector() {
            if (values != null) {
                Array.Clear(values, 0, values.Length);
            }
        }

        public double this[int index] {
            get
            {
                return values[index];
            }
            set
            {
                values[index] = value;
            }
        }

        public int Size {
            get
            {
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

        /*
        public static Vector operator +(Vector v1, Vector v2) {
            if (v1.Size != v2.Size) {
                throw new ArgumentException("Вектори повинні мати одинаковий розмір");
            }
            Vector result = new Vector(v1.Size);
            for (int i = 0; i < result.Size; i++) {
                result[i] = v1[i] + v2[i];
            }
            return result;
        }

        public static Vector operator -(Vector v1, Vector v2) {
            if (v1.Size != v2.Size) {
                throw new ArgumentException("Вектори повинні мати одинаковий розмір");
            }
            Vector result = new Vector(v1.Size);
            for (int i = 0; i < result.Size; i++) {
                result[i] = v1[i] - v2[i];
            }
            return result;
        }

        public static double operator *(Vector v1, Vector v2) {
            if (v1.Size != v2.Size) {
                throw new ArgumentException("Вектори повинні мати одинаковий розмір");
            }
            double result = 0.0;
            for (int i = 0; i < v1.Size; i++) {
                result += v1[i] * v2[i];
            }
            return result;
        }

        public static Vector operator *(Vector v, double scalar) {
            Vector result = new Vector(v.Size);
            for (int i = 0; i < result.Size; i++) {
                result[i] = v[i] * scalar;
            }
            return result;
        }

        public static Vector operator /(Vector v, double scalar) {
            if (scalar == 0.0) {
                throw new DivideByZeroException("Cannot divide vector by zero");
            }
            Vector result = new Vector(v.Size);
            for (int i = 0; i < result.Size; i++) {
                result[i] = v[i] / scalar;
            }
            return result;
        }

        */
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
