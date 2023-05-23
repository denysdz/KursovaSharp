namespace KursovaSharp {
    partial class VectorComplexFrom {
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
            this.label4 = new System.Windows.Forms.Label();
            this.realEdit = new System.Windows.Forms.TextBox();
            this.imageEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vectorListBox = new System.Windows.Forms.ListBox();
            this.maxModuleLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(212, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Демонстрація класу Вектор Комплексних чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Добавити елемент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дісна частина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Уявна частина";
            // 
            // realEdit
            // 
            this.realEdit.Location = new System.Drawing.Point(92, 171);
            this.realEdit.Name = "realEdit";
            this.realEdit.Size = new System.Drawing.Size(96, 22);
            this.realEdit.TabIndex = 9;
            // 
            // imageEdit
            // 
            this.imageEdit.Location = new System.Drawing.Point(233, 171);
            this.imageEdit.Name = "imageEdit";
            this.imageEdit.Size = new System.Drawing.Size(96, 22);
            this.imageEdit.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Елементи вектора";
            // 
            // vectorListBox
            // 
            this.vectorListBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vectorListBox.FormattingEnabled = true;
            this.vectorListBox.ItemHeight = 19;
            this.vectorListBox.Location = new System.Drawing.Point(451, 131);
            this.vectorListBox.Name = "vectorListBox";
            this.vectorListBox.Size = new System.Drawing.Size(211, 137);
            this.vectorListBox.TabIndex = 12;
            // 
            // maxModuleLabel
            // 
            this.maxModuleLabel.AutoSize = true;
            this.maxModuleLabel.Location = new System.Drawing.Point(407, 331);
            this.maxModuleLabel.Name = "maxModuleLabel";
            this.maxModuleLabel.Size = new System.Drawing.Size(176, 16);
            this.maxModuleLabel.TabIndex = 13;
            this.maxModuleLabel.Text = "Максимаьний за модулем";
            this.maxModuleLabel.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(92, 215);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(237, 19);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(160, 248);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(98, 31);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "Добавити";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(410, 368);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultBox.Size = new System.Drawing.Size(304, 87);
            this.resultBox.TabIndex = 16;
            this.resultBox.Visible = false;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(506, 285);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(115, 33);
            this.calcBtn.TabIndex = 17;
            this.calcBtn.Text = "Обчислити";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Visible = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // VectorComplexFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.maxModuleLabel);
            this.Controls.Add(this.vectorListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imageEdit);
            this.Controls.Add(this.realEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VectorComplexFrom";
            this.Text = "VectorComplexFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox realEdit;
        private System.Windows.Forms.TextBox imageEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox vectorListBox;
        private System.Windows.Forms.Label maxModuleLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button calcBtn;
    }
}