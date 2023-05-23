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
    public partial class LastBinding : Form {

        private static Random random = new Random();
        public LastBinding() {
            InitializeComponent();
            binding();
        }

        private void binding() {
            double real= GenerateRandomNumber(0, 100);
            double image = GenerateRandomNumber(0, 100);
            RealNumber complexNumber = new ComplexNumber(real, image);
            normComplex.Text = complexNumber.Norm().ToString();
            int vecSize = GenerateRandomNumber(0, 15);
            double[] tmpArray = new double[vecSize];
            for(int i=0; i<vecSize; i++) {
                tmpArray[i] = GenerateRandomNumber(0, 100);
            }
            RealNumber vector = new Vector(tmpArray);
            normVector.Text = vector.Norm().ToString();
        }

        public static int GenerateRandomNumber(int minValue, int maxValue) {
            return random.Next(minValue, maxValue + 1);
        }

    }

}
