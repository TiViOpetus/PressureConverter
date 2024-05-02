namespace UnitConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxkPa = new System.Windows.Forms.TextBox();
            this.textBoxBar = new System.Windows.Forms.TextBox();
            this.textBoxPsi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "kPa";
            // 
            // textBoxkPa
            // 
            this.textBoxkPa.Location = new System.Drawing.Point(42, 30);
            this.textBoxkPa.Name = "textBoxkPa";
            this.textBoxkPa.Size = new System.Drawing.Size(100, 20);
            this.textBoxkPa.TabIndex = 1;
            this.textBoxkPa.Enter += new System.EventHandler(this.textBoxkPa_Enter);
            this.textBoxkPa.Leave += new System.EventHandler(this.textBoxkPa_Leave);

            // 
            // textBoxBar
            // 
            this.textBoxBar.Location = new System.Drawing.Point(167, 30);
            this.textBoxBar.Name = "textBoxBar";
            this.textBoxBar.Size = new System.Drawing.Size(100, 20);
            this.textBoxBar.TabIndex = 2;
            this.textBoxBar.Enter += new System.EventHandler(this.textBoxBar_Enter);
            this.textBoxBar.Leave += new System.EventHandler(this.textBoxBar_Leave);


            // 
            // textBoxPsi
            // 
            this.textBoxPsi.Location = new System.Drawing.Point(288, 30);
            this.textBoxPsi.Name = "textBoxPsi";
            this.textBoxPsi.Size = new System.Drawing.Size(100, 20);
            this.textBoxPsi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Psi";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(313, 71);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Laske";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(220, 71);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Tyhjennä";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(55, 100);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(0, 20);
            this.textBoxStart.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPsi);
            this.Controls.Add(this.textBoxBar);
            this.Controls.Add(this.textBoxkPa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxkPa;
        private System.Windows.Forms.TextBox textBoxBar;
        private System.Windows.Forms.TextBox textBoxPsi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxStart;
    }
}

