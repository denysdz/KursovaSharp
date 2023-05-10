using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaSharp.classes {
   
    class ComplexNumber : RealNumber {
        private double imageNumber;
        public ComplexNumber(double realNumber = 0.0, double imageNumber = 0.0) : base(realNumber) {
            this.imageNumber = imageNumber;
        }
        public double ImageNumber {
            get { 
                return imageNumber;
            }
            set { 
                imageNumber = value;
            }
        }
        public override double Norm() {
            return Math.Abs(Value + imageNumber);
        }

        public override string ToString() {
            if (imageNumber < 0) {
                return $"{Value}{imageNumber}i";
            } else {
                return $"{Value}+{imageNumber}i";
            }
        }

    }

}
