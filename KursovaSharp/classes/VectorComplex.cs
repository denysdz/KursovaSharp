using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaSharp.classes {
    class VectorComplex {
        private List<ComplexNumber> data;

        public VectorComplex() {
            data = new List<ComplexNumber>();
        }

        public VectorComplex(List<ComplexNumber> v) {
            data = v;
        }

        public List<ComplexNumber> Data {
            get { return data; }
            private set { data = value; }
        }

        public void PushBack(ComplexNumber c) {
            data.Add(c);
        }

        public VectorComplex Clone() {
            return new VectorComplex(new List<ComplexNumber>(data));
        }

        public ComplexNumber GetMaxModule() {
            ComplexNumber max = data[0];
            foreach (var current in data) {
                if (current.Norm() > max.Norm()) {
                    max = current;
                }
            }
            return max;
        }

        public override string ToString() {
            StringBuilder output = new StringBuilder("[");
            for (int i = 0; i < data.Count; i++) {
                output.Append(data[i].ToString());
                if (i < data.Count - 1) {
                    output.Append(", ");
                }
            }
            output.Append("]");
            return output.ToString();
        }
    }

}
