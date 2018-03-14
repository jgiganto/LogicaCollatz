namespace ClienteCollatz
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lstnumeros = new System.Windows.Forms.ListBox();
            this.btncollatz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(88, 27);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 24);
            this.txtnumero.TabIndex = 1;
            // 
            // lstnumeros
            // 
            this.lstnumeros.FormattingEnabled = true;
            this.lstnumeros.ItemHeight = 18;
            this.lstnumeros.Location = new System.Drawing.Point(16, 127);
            this.lstnumeros.Name = "lstnumeros";
            this.lstnumeros.Size = new System.Drawing.Size(198, 508);
            this.lstnumeros.TabIndex = 2;
            // 
            // btncollatz
            // 
            this.btncollatz.Location = new System.Drawing.Point(16, 80);
            this.btncollatz.Name = "btncollatz";
            this.btncollatz.Size = new System.Drawing.Size(198, 30);
            this.btncollatz.TabIndex = 3;
            this.btncollatz.Text = "LLamar a Collatz";
            this.btncollatz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 645);
            this.Controls.Add(this.btncollatz);
            this.Controls.Add(this.lstnumeros);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.ListBox lstnumeros;
        private System.Windows.Forms.Button btncollatz;
    }
}

