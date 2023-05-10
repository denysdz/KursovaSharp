using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaSharp.classes {
    internal class RealNumber {

        private double value;
        public RealNumber() {
            value = 0;
        }
        public RealNumber(double value) {
            this.value = value;
        }

        public RealNumber(RealNumber other) {
            value = other.value;
        }
        public double Value {
            get { 
                return value;
            }
            set {
                this.value = value;
            }
        }
        public virtual double Norm() {
            return Math.Abs(value);
        }
        public static RealNumber operator +(RealNumber first, RealNumber second) {
            return new RealNumber(first.value + second.value);
        }

        public static RealNumber operator -(RealNumber first, RealNumber second) {
            return new RealNumber(first.value - second.value);
        }

        public static RealNumber operator *(RealNumber first, RealNumber second) {
            return new RealNumber(first.value * second.value);
        }

        public static RealNumber operator /(RealNumber first, RealNumber second) {
            if (second.value == 0) {
                throw new ArgumentException("Операція не виконана! Не можна ділити на 0");
            }
            return new RealNumber(first.value / second.value);
        }

        public override string ToString() {
            return value.ToString();
        }

    }
}
