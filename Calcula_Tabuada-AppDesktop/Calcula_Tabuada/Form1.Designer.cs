namespace Calcula_Tabuada
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.numerotextBox1 = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Digite o numero";
            // 
            // numerotextBox1
            // 
            this.numerotextBox1.Location = new System.Drawing.Point(117, 23);
            this.numerotextBox1.Name = "numerotextBox1";
            this.numerotextBox1.Size = new System.Drawing.Size(100, 20);
            this.numerotextBox1.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(241, 21);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(34, 78);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(282, 212);
            this.resultadoListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(422, 337);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.numerotextBox1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tabuadatextBox1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.ListBox tabuadalistBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okbutton1;
        private System.Windows.Forms.ListBox resultadolistBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numerotextBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ListBox resultadoListBox;
    }
}

