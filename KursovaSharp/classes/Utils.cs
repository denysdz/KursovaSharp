using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaSharp.classes {
    public class Utils {

        public static bool isValidDoubleNumber(String value) {
            double number;
            if (double.TryParse(value, out number)) {
                return true;
            }
            return false;
        }
        public static bool isValidIntNumber(String value) {
            int number;
            if (int.TryParse(value, out number)) {
                return true;
            }
            return false;
        }

    }
}
