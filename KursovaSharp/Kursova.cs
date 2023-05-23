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

        private void vactorBtn_Click(object sender, EventArgs e) {
            VectorForm vectorForm = new VectorForm();
            vectorForm.Show();
        }

        private void vectorCompexNumbersBtn_Click(object sender, EventArgs e) {
            VectorComplexFrom vectorComplexFrom = new VectorComplexFrom();
            vectorComplexFrom.Show();
        }

        private void bindingBtn_Click(object sender, EventArgs e) {
            LastBinding lastBinding = new LastBinding();
            lastBinding.Show();
        }
    }

}
