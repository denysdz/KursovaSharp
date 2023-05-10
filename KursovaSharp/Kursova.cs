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
    public partial class Kursova : Form {

        public Kursova() {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void realNumberBtn_Click(object sender, EventArgs e) {
            RealNumberForm realNumberForm= new RealNumberForm();
            realNumberForm.Show();
        }

        private void complexNumberBtn_Click(object sender, EventArgs e) {
            ComplexNumberForm complexNumberForm = new ComplexNumberForm();
            complexNumberForm.Show();
        }

        private void matrixBtn_Click(object sender, EventArgs e) {
            MatrixForm matrixForm = new MatrixForm();
            matrixForm.Show();
        }
    }

}
