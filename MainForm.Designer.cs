namespace Calculadora {
    partial class MainForm {
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
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnCambioSigno = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestar
            // 
            this.btnRestar.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestar.Location = new System.Drawing.Point(237, 329);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(76, 76);
            this.btnRestar.TabIndex = 45;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.click_Operador);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDividir.Location = new System.Drawing.Point(312, 329);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(76, 76);
            this.btnDividir.TabIndex = 44;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.click_Operador);
            // 
            // btnBorrar
            // 
            this.btnBorrar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBorrar.Font = new System.Drawing.Font("Nunito", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(237, 105);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(151, 76);
            this.btnBorrar.TabIndex = 43;
            this.btnBorrar.Text = "DELETE";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(237, 179);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(151, 76);
            this.btnEqual.TabIndex = 42;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.equalClick);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMultiplicar.Location = new System.Drawing.Point(312, 254);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(76, 76);
            this.btnMultiplicar.TabIndex = 41;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.click_Operador);
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSumar.Location = new System.Drawing.Point(237, 254);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(76, 76);
            this.btnSumar.TabIndex = 39;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.click_Operador);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPunto.Location = new System.Drawing.Point(162, 404);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(76, 76);
            this.btnPunto.TabIndex = 38;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum0.Location = new System.Drawing.Point(87, 404);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(76, 76);
            this.btnNum0.TabIndex = 37;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.addNumber);
            // 
            // btnCambioSigno
            // 
            this.btnCambioSigno.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCambioSigno.Location = new System.Drawing.Point(12, 404);
            this.btnCambioSigno.Name = "btnCambioSigno";
            this.btnCambioSigno.Size = new System.Drawing.Size(76, 76);
            this.btnCambioSigno.TabIndex = 36;
            this.btnCambioSigno.Text = "±";
            this.btnCambioSigno.UseVisualStyleBackColor = true;
            this.btnCambioSigno.Click += new System.EventHandler(this.btnCambioSigno_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearAll.Location = new System.Drawing.Point(162, 105);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(76, 76);
            this.btnClearAll.TabIndex = 34;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(12, 105);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 76);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum9.Location = new System.Drawing.Point(162, 179);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(76, 76);
            this.btnNum9.TabIndex = 32;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.addNumber);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum8.Location = new System.Drawing.Point(87, 179);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(76, 76);
            this.btnNum8.TabIndex = 31;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.addNumber);
            // 
            // btnNum7
            // 
            this.btnNum7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNum7.FlatAppearance.BorderSize = 0;
            this.btnNum7.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNum7.Location = new System.Drawing.Point(12, 179);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(76, 76);
            this.btnNum7.TabIndex = 30;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.addNumber);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum6.Location = new System.Drawing.Point(162, 254);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(76, 76);
            this.btnNum6.TabIndex = 29;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.addNumber);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum5.Location = new System.Drawing.Point(87, 254);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(76, 76);
            this.btnNum5.TabIndex = 28;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.addNumber);
            // 
            // btnNum4
            // 
            this.btnNum4.FlatAppearance.BorderSize = 0;
            this.btnNum4.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum4.Location = new System.Drawing.Point(12, 254);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(76, 76);
            this.btnNum4.TabIndex = 27;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.addNumber);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum3.Location = new System.Drawing.Point(162, 329);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(76, 76);
            this.btnNum3.TabIndex = 26;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.addNumber);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum2.Location = new System.Drawing.Point(87, 329);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(76, 76);
            this.btnNum2.TabIndex = 25;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.addNumber);
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNum1.Location = new System.Drawing.Point(12, 329);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(76, 76);
            this.btnNum1.TabIndex = 24;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.addNumber);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtResult.Location = new System.Drawing.Point(12, 35);
            this.txtResult.MaxLength = 17;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(376, 55);
            this.txtResult.TabIndex = 23;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRaizCuadrada.Location = new System.Drawing.Point(237, 404);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(76, 76);
            this.btnRaizCuadrada.TabIndex = 40;
            this.btnRaizCuadrada.Text = "√";
            this.btnRaizCuadrada.UseVisualStyleBackColor = true;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.click_Operador);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Nunito", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPotencia.Location = new System.Drawing.Point(312, 404);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(76, 76);
            this.btnPotencia.TabIndex = 35;
            this.btnPotencia.Text = "x²";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.click_Operador);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(402, 491);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnCambioSigno);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.txtResult);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRestar;
        private Button btnDividir;
        private Button btnBorrar;
        private Button btnEqual;
        private Button btnMultiplicar;
        private Button btnSumar;
        private Button btnPunto;
        private Button btnNum0;
        private Button btnCambioSigno;
        private Button btnClearAll;
        private Button btnClear;
        private Button btnNum9;
        private Button btnNum8;
        private Button btnNum7;
        private Button btnNum6;
        private Button btnNum5;
        private Button btnNum4;
        private Button btnNum3;
        private Button btnNum2;
        private Button btnNum1;
        private TextBox txtResult;
        private Button btnRaizCuadrada;
        private Button btnPotencia;
    }
}