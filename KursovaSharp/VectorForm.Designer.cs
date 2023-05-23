namespace KursovaSharp {
    partial class VectorForm {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeEdit = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.vectorGrid = new System.Windows.Forms.DataGridView();
            this.createBtn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vectorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Розмір вектора";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Демонстрація класу Вектор";
            // 
            // sizeEdit
            // 
            this.sizeEdit.Location = new System.Drawing.Point(325, 81);
            this.sizeEdit.Name = "sizeEdit";
            this.sizeEdit.Size = new System.Drawing.Size(106, 22);
            this.sizeEdit.TabIndex = 6;
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(41, 115);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(697, 23);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vectorGrid
            // 
            this.vectorGrid.AllowUserToAddRows = false;
            this.vectorGrid.AllowUserToDeleteRows = false;
            this.vectorGrid.AllowUserToResizeColumns = false;
            this.vectorGrid.AllowUserToResizeRows = false;
            this.vectorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vectorGrid.Location = new System.Drawing.Point(41, 182);
            this.vectorGrid.Name = "vectorGrid";
            this.vectorGrid.RowHeadersWidth = 51;
            this.vectorGrid.RowTemplate.Height = 24;
            this.vectorGrid.Size = new System.Drawing.Size(697, 72);
            this.vectorGrid.TabIndex = 8;
            this.vectorGrid.Visible = false;
            this.vectorGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.vectorGrid_CellValidating);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(325, 141);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(106, 35);
            this.createBtn.TabIndex = 9;
            this.createBtn.Text = "Створити";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(325, 275);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(106, 35);
            this.calcBtn.TabIndex = 10;
            this.calcBtn.Text = "Обчислити";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Visible = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(44, 325);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(694, 23);
            this.resultLabel.TabIndex = 14;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resultLabel.Visible = false;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(227, 351);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultBox.Size = new System.Drawing.Size(304, 87);
            this.resultBox.TabIndex = 15;
            this.resultBox.Visible = false;
            // 
            // VectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.vectorGrid);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.sizeEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VectorForm";
            this.Text = "Вектор";
            ((System.ComponentModel.ISupportInitialize)(this.vectorGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeEdit;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridView vectorGrid;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultBox;
    }
}