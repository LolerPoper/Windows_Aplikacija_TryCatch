namespace MojaPrvaWindowsAplikacija
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
            this.txtUnosBrojaA = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.txtUnosBrojaB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzracun = new System.Windows.Forms.Button();
            this.txtGreske = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUnosBrojaA
            // 
            this.txtUnosBrojaA.Location = new System.Drawing.Point(65, 67);
            this.txtUnosBrojaA.Name = "txtUnosBrojaA";
            this.txtUnosBrojaA.Size = new System.Drawing.Size(154, 20);
            this.txtUnosBrojaA.TabIndex = 0;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(65, 269);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.ReadOnly = true;
            this.txtRezultat.Size = new System.Drawing.Size(154, 20);
            this.txtRezultat.TabIndex = 6;
            this.txtRezultat.TabStop = false;
            this.txtRezultat.TextChanged += new System.EventHandler(this.txtRezultat_TextChanged);
            // 
            // txtUnosBrojaB
            // 
            this.txtUnosBrojaB.Location = new System.Drawing.Point(389, 67);
            this.txtUnosBrojaB.Name = "txtUnosBrojaB";
            this.txtUnosBrojaB.Size = new System.Drawing.Size(164, 20);
            this.txtUnosBrojaB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zbroj";
            // 
            // btnIzracun
            // 
            this.btnIzracun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzracun.Location = new System.Drawing.Point(389, 266);
            this.btnIzracun.Name = "btnIzracun";
            this.btnIzracun.Size = new System.Drawing.Size(164, 23);
            this.btnIzracun.TabIndex = 2;
            this.btnIzracun.Text = "Izračunaj";
            this.btnIzracun.UseVisualStyleBackColor = true;
            this.btnIzracun.Click += new System.EventHandler(this.btnIzracun_Click);
            // 
            // txtGreske
            // 
            this.txtGreske.Location = new System.Drawing.Point(65, 344);
            this.txtGreske.Multiline = true;
            this.txtGreske.Name = "txtGreske";
            this.txtGreske.ReadOnly = true;
            this.txtGreske.Size = new System.Drawing.Size(154, 55);
            this.txtGreske.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Greške";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGreske);
            this.Controls.Add(this.btnIzracun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnosBrojaB);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.txtUnosBrojaA);
            this.Name = "Form1";
            this.Text = "Moja prva windows aplikacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosBrojaA;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.TextBox txtUnosBrojaB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzracun;
        private System.Windows.Forms.TextBox txtGreske;
        private System.Windows.Forms.Label label4;
    }
}

