namespace AppWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lNum1 = new System.Windows.Forms.Label();
            this.tboxNum1 = new System.Windows.Forms.TextBox();
            this.tboxNum2 = new System.Windows.Forms.TextBox();
            this.lNum2 = new System.Windows.Forms.Label();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bBaciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lNum1
            // 
            this.lNum1.AutoSize = true;
            this.lNum1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNum1.Location = new System.Drawing.Point(30, 79);
            this.lNum1.Name = "lNum1";
            this.lNum1.Size = new System.Drawing.Size(85, 17);
            this.lNum1.TabIndex = 0;
            this.lNum1.Text = "Furst number";
            this.lNum1.Click += new System.EventHandler(this.lNum1_Click);
            // 
            // tboxNum1
            // 
            this.tboxNum1.Location = new System.Drawing.Point(137, 73);
            this.tboxNum1.Name = "tboxNum1";
            this.tboxNum1.Size = new System.Drawing.Size(140, 23);
            this.tboxNum1.TabIndex = 1;
            this.tboxNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tboxNum2
            // 
            this.tboxNum2.Location = new System.Drawing.Point(137, 112);
            this.tboxNum2.Name = "tboxNum2";
            this.tboxNum2.Size = new System.Drawing.Size(140, 23);
            this.tboxNum2.TabIndex = 3;
            this.tboxNum2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // lNum2
            // 
            this.lNum2.AutoSize = true;
            this.lNum2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNum2.Location = new System.Drawing.Point(30, 118);
            this.lNum2.Name = "lNum2";
            this.lNum2.Size = new System.Drawing.Size(101, 17);
            this.lNum2.TabIndex = 2;
            this.lNum2.Text = "Segund number";
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(81, 176);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(196, 23);
            this.tboxResult.TabIndex = 5;
            this.tboxResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // bCalcular
            // 
            this.bCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCalcular.Location = new System.Drawing.Point(81, 207);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(94, 23);
            this.bCalcular.TabIndex = 6;
            this.bCalcular.Text = "Calculate";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // bBaciar
            // 
            this.bBaciar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBaciar.Location = new System.Drawing.Point(183, 207);
            this.bBaciar.Name = "bBaciar";
            this.bBaciar.Size = new System.Drawing.Size(94, 23);
            this.bBaciar.TabIndex = 7;
            this.bBaciar.Text = "Clean";
            this.bBaciar.UseVisualStyleBackColor = true;
            this.bBaciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calculate the sum of two numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBaciar);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.tboxNum2);
            this.Controls.Add(this.lNum2);
            this.Controls.Add(this.tboxNum1);
            this.Controls.Add(this.lNum1);
            this.Name = "Form1";
            this.Text = "CalculosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lNum1;
        private Label lNum2;

        private TextBox tboxNum1;
        private TextBox tboxNum2;        
        private TextBox tboxResult;
        
        private Button bCalcular;
        private Button bBaciar;
        private Label label1;
        private Label label2;
    }
}