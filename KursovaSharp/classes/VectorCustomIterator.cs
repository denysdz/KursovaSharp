using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaSharp.classes {
    class VectorCustomIterator {

        private List<ComplexNumber>.Enumerator enumerator;
        private List<ComplexNumber> data;
        private int index;

        public VectorCustomIterator(List<ComplexNumber> data) {
            this.data = data;
            this.index = -1;
        }

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

        public ComplexNumber Current {
            get
            {
                if (index < 0 || index >= data.Count) {
                    throw new InvalidOperationException("Iterator out of bounds");
                }
                return data[index];
            }
        }
    }
}
