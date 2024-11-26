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
            this.listBoxPermutations = new System.Windows.Forms.ListBox();
            this.lblCombinationCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(30, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 22);
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
            // listBoxPermutations
            // 
            this.listBoxPermutations.FormattingEnabled = true;
            this.listBoxPermutations.ItemHeight = 16;
            this.listBoxPermutations.Location = new System.Drawing.Point(30, 120);
            this.listBoxPermutations.Name = "listBoxPermutations";
            this.listBoxPermutations.Size = new System.Drawing.Size(200, 180);
            this.listBoxPermutations.TabIndex = 2;
            // 
            // lblCombinationCount
            // 
            this.lblCombinationCount.AutoSize = true;
            this.lblCombinationCount.Location = new System.Drawing.Point(30, 310);
            this.lblCombinationCount.Name = "lblCombinationCount";
            this.lblCombinationCount.Size = new System.Drawing.Size(154, 16);
            this.lblCombinationCount.TabIndex = 3;
            this.lblCombinationCount.Text = "Kombinációk száma: 0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 340);
            this.Controls.Add(this.lblCombinationCount);
            this.Controls.Add(this.listBoxPermutations);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Szám Permutációk";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox listBoxPermutations;
        private System.Windows.Forms.Label lblCombinationCount;
    }

}

