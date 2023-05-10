namespace KursovaSharp {
    partial class Kursova {
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
            this.realNumberBtn = new System.Windows.Forms.Button();
            this.complexNumberBtn = new System.Windows.Forms.Button();
            this.matrixBtn = new System.Windows.Forms.Button();
            this.vactorBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(159, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Програма для демонстрації класів: Дійсне число, Комлексне чиcло, Матриця, Вектор," +
    " Вектор Комплексних чисел";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(310, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Курсова робота";
            // 
            // realNumberBtn
            // 
            this.realNumberBtn.Location = new System.Drawing.Point(127, 142);
            this.realNumberBtn.Name = "realNumberBtn";
            this.realNumberBtn.Size = new System.Drawing.Size(163, 42);
            this.realNumberBtn.TabIndex = 2;
            this.realNumberBtn.Text = "Клас Дійсне число";
            this.realNumberBtn.UseVisualStyleBackColor = true;
            this.realNumberBtn.Click += new System.EventHandler(this.realNumberBtn_Click);
            // 
            // complexNumberBtn
            // 
            this.complexNumberBtn.Location = new System.Drawing.Point(311, 142);
            this.complexNumberBtn.Name = "complexNumberBtn";
            this.complexNumberBtn.Size = new System.Drawing.Size(164, 42);
            this.complexNumberBtn.TabIndex = 3;
            this.complexNumberBtn.Text = "Клас Комплекне число";
            this.complexNumberBtn.UseVisualStyleBackColor = true;
            this.complexNumberBtn.Click += new System.EventHandler(this.complexNumberBtn_Click);
            // 
            // matrixBtn
            // 
            this.matrixBtn.Location = new System.Drawing.Point(497, 142);
            this.matrixBtn.Name = "matrixBtn";
            this.matrixBtn.Size = new System.Drawing.Size(164, 40);
            this.matrixBtn.TabIndex = 4;
            this.matrixBtn.Text = "Клас Матриця";
            this.matrixBtn.UseVisualStyleBackColor = true;
            this.matrixBtn.Click += new System.EventHandler(this.matrixBtn_Click);
            // 
            // vactorBtn
            // 
            this.vactorBtn.Location = new System.Drawing.Point(77, 206);
            this.vactorBtn.Name = "vactorBtn";
            this.vactorBtn.Size = new System.Drawing.Size(163, 39);
            this.vactorBtn.TabIndex = 5;
            this.vactorBtn.Text = "Клас Вектор";
            this.vactorBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Клас Вектор Комплексних чисел";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bindingBtn
            // 
            this.bindingBtn.Location = new System.Drawing.Point(526, 205);
            this.bindingBtn.Name = "bindingBtn";
            this.bindingBtn.Size = new System.Drawing.Size(176, 40);
            this.bindingBtn.TabIndex = 7;
            this.bindingBtn.Text = "Демонстрація пізнього зв\'язування";
            this.bindingBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(311, 272);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(163, 40);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Вихід";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Kursova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.bindingBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vactorBtn);
            this.Controls.Add(this.matrixBtn);
            this.Controls.Add(this.complexNumberBtn);
            this.Controls.Add(this.realNumberBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kursova";
            this.Text = "Курсова робота ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button realNumberBtn;
        private System.Windows.Forms.Button complexNumberBtn;
        private System.Windows.Forms.Button matrixBtn;
        private System.Windows.Forms.Button vactorBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bindingBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

