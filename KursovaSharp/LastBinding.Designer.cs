namespace KursovaSharp {
    partial class LastBinding {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.complexNorm = new System.Windows.Forms.Label();
            this.normComplex = new System.Windows.Forms.Label();
            this.normVector = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Демонстрація пізнього звязування";
            // 
            // complexNorm
            // 
            this.complexNorm.Location = new System.Drawing.Point(123, 111);
            this.complexNorm.Name = "complexNorm";
            this.complexNorm.Size = new System.Drawing.Size(303, 23);
            this.complexNorm.TabIndex = 18;
            this.complexNorm.Text = "Норма згенерованого комплексного числа";
            this.complexNorm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // normComplex
            // 
            this.normComplex.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normComplex.Location = new System.Drawing.Point(148, 144);
            this.normComplex.Name = "normComplex";
            this.normComplex.Size = new System.Drawing.Size(249, 23);
            this.normComplex.TabIndex = 22;
            this.normComplex.Text = "0";
            this.normComplex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // normVector
            // 
            this.normVector.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normVector.Location = new System.Drawing.Point(149, 214);
            this.normVector.Name = "normVector";
            this.normVector.Size = new System.Drawing.Size(249, 23);
            this.normVector.TabIndex = 24;
            this.normVector.Text = "0";
            this.normVector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(110, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Норма згенерованого комплексного вектору";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LastBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 470);
            this.Controls.Add(this.normVector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.normComplex);
            this.Controls.Add(this.complexNorm);
            this.Controls.Add(this.label1);
            this.Name = "LastBinding";
            this.Text = "Пізнє зв\'язування";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label complexNorm;
        private System.Windows.Forms.Label normComplex;
        private System.Windows.Forms.Label normVector;
        private System.Windows.Forms.Label label3;
    }
}