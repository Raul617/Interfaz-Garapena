namespace Ariketa2
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
            this.btnHurrengoa = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnIrten = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtZenbakia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHurrengoa
            // 
            this.btnHurrengoa.Location = new System.Drawing.Point(213, 236);
            this.btnHurrengoa.Name = "btnHurrengoa";
            this.btnHurrengoa.Size = new System.Drawing.Size(75, 23);
            this.btnHurrengoa.TabIndex = 0;
            this.btnHurrengoa.Text = "Hurrengoa";
            this.btnHurrengoa.UseVisualStyleBackColor = true;
            this.btnHurrengoa.Click += new System.EventHandler(this.btnHurrengoa_Click);
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Location = new System.Drawing.Point(349, 236);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(75, 23);
            this.btnGarbitu.TabIndex = 1;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.btnGarbitu_Click);
            // 
            // btnIrten
            // 
            this.btnIrten.Location = new System.Drawing.Point(501, 236);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(75, 23);
            this.btnIrten.TabIndex = 2;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.btnIrten_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtZenbakia
            // 
            this.txtZenbakia.AutoSize = true;
            this.txtZenbakia.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtZenbakia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtZenbakia.Location = new System.Drawing.Point(213, 129);
            this.txtZenbakia.Name = "txtZenbakia";
            this.txtZenbakia.Size = new System.Drawing.Size(94, 21);
            this.txtZenbakia.TabIndex = 4;
            this.txtZenbakia.Text = "1.Zenbakia";
            this.txtZenbakia.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtZenbakia);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.btnHurrengoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnIrten;
        private TextBox textBox1;
        private Label txtZenbakia;
    }
}