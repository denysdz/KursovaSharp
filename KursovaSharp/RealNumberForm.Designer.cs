namespace KursovaSharp {
    partial class RealNumberForm {
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
            this.real1 = new System.Windows.Forms.TextBox();
            this.real2 = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(159, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Демонстрація класу Дійсне число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Перше дійсне чило";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Друге дійсне число";
            // 
            // real1
            // 
            this.real1.Location = new System.Drawing.Point(220, 90);
            this.real1.Name = "real1";
            this.real1.Size = new System.Drawing.Size(127, 22);
            this.real1.TabIndex = 3;
            // 
            // real2
            // 
            this.real2.Location = new System.Drawing.Point(220, 163);
            this.real2.Name = "real2";
            this.real2.Size = new System.Drawing.Size(127, 22);
            this.real2.TabIndex = 4;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(220, 227);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(127, 36);
            this.calcBtn.TabIndex = 6;
            this.calcBtn.Text = "Обчислити";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.FormattingEnabled = true;
            this.resultBox.HorizontalScrollbar = true;
            this.resultBox.ItemHeight = 16;
            this.resultBox.Location = new System.Drawing.Point(162, 309);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(244, 116);
            this.resultBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат";
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(185, 200);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(192, 24);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RealNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.real2);
            this.Controls.Add(this.real1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RealNumberForm";
            this.Text = "Дісне число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox real1;
        private System.Windows.Forms.TextBox real2;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.ListBox resultBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errorLabel;
    }
}