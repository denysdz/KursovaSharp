using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaSharp.classes {
    class VectorCustomIterator : IEnumerator<ComplexNumber> {
        private List<ComplexNumber> data;
        private int index;

        public VectorCustomIterator(List<ComplexNumber> data) {
            this.data = data;
            this.index = -1;
        }

        public ComplexNumber Current {
            get
            {
                if (index < 0 || index >= data.Count) {
                    throw new InvalidOperationException("Iterator out of bounds");
                }
                return data[index];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext() {
            if (index < data.Count - 1) {
                index++;
                return true;
            }
            return false;
        }

        public bool MovePrevious() {
            if (index > 0) {
                index--;
                return true;
            }
            return false;
        }

        public void Reset() {
            index = -1;
        }

        public void Dispose() {}

    }
}
