namespace KursovaSharp.classes {
    partial class MatrixForm {
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
            this.rowEdit = new System.Windows.Forms.TextBox();
            this.colmEdit = new System.Windows.Forms.TextBox();
            this.matrixGrid = new System.Windows.Forms.DataGridView();
            this.calcBtn = new System.Windows.Forms.Button();
            this.createMatrix = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Демонстрація класу Матриця";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кількість рядків";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кількість стовпців";
            // 
            // rowEdit
            // 
            this.rowEdit.Location = new System.Drawing.Point(279, 84);
            this.rowEdit.Name = "rowEdit";
            this.rowEdit.Size = new System.Drawing.Size(81, 22);
            this.rowEdit.TabIndex = 5;
            // 
            // colmEdit
            // 
            this.colmEdit.Location = new System.Drawing.Point(409, 84);
            this.colmEdit.Name = "colmEdit";
            this.colmEdit.Size = new System.Drawing.Size(81, 22);
            this.colmEdit.TabIndex = 6;
            // 
            // matrixGrid
            // 
            this.matrixGrid.AllowUserToAddRows = false;
            this.matrixGrid.AllowUserToDeleteRows = false;
            this.matrixGrid.AllowUserToResizeColumns = false;
            this.matrixGrid.AllowUserToResizeRows = false;
            this.matrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixGrid.Location = new System.Drawing.Point(67, 185);
            this.matrixGrid.Name = "matrixGrid";
            this.matrixGrid.RowHeadersWidth = 51;
            this.matrixGrid.RowTemplate.Height = 24;
            this.matrixGrid.Size = new System.Drawing.Size(674, 178);
            this.matrixGrid.TabIndex = 7;
            this.matrixGrid.Visible = false;
            this.matrixGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.matrixGrid_CellValidating);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(339, 369);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(131, 39);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "Обчислити";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Visible = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // createMatrix
            // 
            this.createMatrix.Location = new System.Drawing.Point(339, 141);
            this.createMatrix.Name = "createMatrix";
            this.createMatrix.Size = new System.Drawing.Size(104, 38);
            this.createMatrix.TabIndex = 9;
            this.createMatrix.Text = "Створити";
            this.createMatrix.UseVisualStyleBackColor = true;
            this.createMatrix.Click += new System.EventHandler(this.createMatrix_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(252, 111);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(275, 27);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(255, 448);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultBox.Size = new System.Drawing.Size(304, 87);
            this.resultBox.TabIndex = 12;
            this.resultBox.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(67, 422);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(674, 23);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resultLabel.Visible = false;
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 547);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.createMatrix);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.matrixGrid);
            this.Controls.Add(this.colmEdit);
            this.Controls.Add(this.rowEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MatrixForm";
            this.Text = "Матриця";
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rowEdit;
        private System.Windows.Forms.TextBox colmEdit;
        private System.Windows.Forms.DataGridView matrixGrid;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button createMatrix;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label resultLabel;
    }
}