namespace Ariketa2_Zerrenda
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
            this.labelZenbakia = new System.Windows.Forms.Label();
            this.txtBoxZenb = new System.Windows.Forms.TextBox();
            this.btnHurrengoa = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnItxi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelZenbakia
            // 
            this.labelZenbakia.AutoSize = true;
            this.labelZenbakia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelZenbakia.Location = new System.Drawing.Point(199, 143);
            this.labelZenbakia.Name = "labelZenbakia";
            this.labelZenbakia.Size = new System.Drawing.Size(94, 21);
            this.labelZenbakia.TabIndex = 0;
            this.labelZenbakia.Text = "1.Zenbakia";
            // 
            // txtBoxZenb
            // 
            this.txtBoxZenb.Location = new System.Drawing.Point(373, 141);
            this.txtBoxZenb.Name = "txtBoxZenb";
            this.txtBoxZenb.Size = new System.Drawing.Size(256, 23);
            this.txtBoxZenb.TabIndex = 1;
            // 
            // btnHurrengoa
            // 
            this.btnHurrengoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHurrengoa.Location = new System.Drawing.Point(184, 328);
            this.btnHurrengoa.Name = "btnHurrengoa";
            this.btnHurrengoa.Size = new System.Drawing.Size(158, 61);
            this.btnHurrengoa.TabIndex = 2;
            this.btnHurrengoa.Text = "Hurrengoa";
            this.btnHurrengoa.UseVisualStyleBackColor = true;
            this.btnHurrengoa.Click += new System.EventHandler(this.btnHurrengoa_Click);
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGarbitu.Location = new System.Drawing.Point(406, 328);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(149, 61);
            this.btnGarbitu.TabIndex = 3;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.btnGarbitu_Click);
            // 
            // btnItxi
            // 
            this.btnItxi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnItxi.Location = new System.Drawing.Point(609, 328);
            this.btnItxi.Name = "btnItxi";
            this.btnItxi.Size = new System.Drawing.Size(164, 61);
            this.btnItxi.TabIndex = 4;
            this.btnItxi.Text = "Itxi";
            this.btnItxi.UseVisualStyleBackColor = true;
            this.btnItxi.Click += new System.EventHandler(this.btnItxi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 523);
            this.Controls.Add(this.btnItxi);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.btnHurrengoa);
            this.Controls.Add(this.txtBoxZenb);
            this.Controls.Add(this.labelZenbakia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelZenbakia;
        private TextBox txtBoxZenb;
        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnItxi;
    }
}