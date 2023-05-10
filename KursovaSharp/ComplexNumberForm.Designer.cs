namespace KursovaSharp.classes {
    partial class ComplexNumberForm {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.realEdit = new System.Windows.Forms.TextBox();
            this.imageEdit = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(133, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Демонстрація класу Комплексне число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дійсна частина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Уявна частина";
            // 
            // realEdit
            // 
            this.realEdit.Location = new System.Drawing.Point(136, 123);
            this.realEdit.Name = "realEdit";
            this.realEdit.Size = new System.Drawing.Size(102, 22);
            this.realEdit.TabIndex = 4;
            // 
            // imageEdit
            // 
            this.imageEdit.Location = new System.Drawing.Point(317, 123);
            this.imageEdit.Name = "imageEdit";
            this.imageEdit.Size = new System.Drawing.Size(102, 22);
            this.imageEdit.TabIndex = 5;
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(139, 161);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(281, 25);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(230, 201);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(101, 40);
            this.calcBtn.TabIndex = 7;
            this.calcBtn.Text = "Обчислити";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.FormattingEnabled = true;
            this.resultBox.HorizontalScrollbar = true;
            this.resultBox.ItemHeight = 16;
            this.resultBox.Location = new System.Drawing.Point(138, 288);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(281, 116);
            this.resultBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результат";
            // 
            // ComplexNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.imageEdit);
            this.Controls.Add(this.realEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ComplexNumberForm";
            this.Text = "Комплексне число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox realEdit;
        private System.Windows.Forms.TextBox imageEdit;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.ListBox resultBox;
        private System.Windows.Forms.Label label4;
    }
}