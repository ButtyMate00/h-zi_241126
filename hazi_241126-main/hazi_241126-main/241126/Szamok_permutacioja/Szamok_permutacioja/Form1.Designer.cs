namespace Szamok_permutacioja
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

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.listBoxKombinacio = new System.Windows.Forms.ListBox();
            this.lblkombinaciocount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(30, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(30, 70);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 30);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Permutációk";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // listBoxKombinacio
            // 
            this.listBoxKombinacio.FormattingEnabled = true;
            this.listBoxKombinacio.Location = new System.Drawing.Point(30, 120);
            this.listBoxKombinacio.Name = "listBoxKombinacio";
            this.listBoxKombinacio.Size = new System.Drawing.Size(200, 173);
            this.listBoxKombinacio.TabIndex = 2;
            // 
            // lblkombinaciocount
            // 
            this.lblkombinaciocount.AutoSize = true;
            this.lblkombinaciocount.Location = new System.Drawing.Point(30, 310);
            this.lblkombinaciocount.Name = "lblkombinaciocount";
            this.lblkombinaciocount.Size = new System.Drawing.Size(113, 13);
            this.lblkombinaciocount.TabIndex = 3;
            this.lblkombinaciocount.Text = "Kombinációk száma: 0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 340);
            this.Controls.Add(this.lblkombinaciocount);
            this.Controls.Add(this.listBoxKombinacio);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Szám Permutációk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox listBoxKombinacio;
        private System.Windows.Forms.Label lblkombinaciocount;
    }

}

