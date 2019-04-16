namespace MediaDuasNotas
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
            this.cxtNota1 = new System.Windows.Forms.TextBox();
            this.cxtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.Label();
            this.butCalcular = new System.Windows.Forms.Button();
            this.butLimpar = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            this.labIFseq = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cxtSequencial = new System.Windows.Forms.TextBox();
            this.cxtSituacaoSequencial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cxtSituacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cxtEncadeada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1:";
            // 
            // cxtNota1
            // 
            this.cxtNota1.Location = new System.Drawing.Point(120, 86);
            this.cxtNota1.Name = "cxtNota1";
            this.cxtNota1.Size = new System.Drawing.Size(100, 20);
            this.cxtNota1.TabIndex = 1;
            this.cxtNota1.TextChanged += new System.EventHandler(this.txtNota1_TextChanged);
            // 
            // cxtNota2
            // 
            this.cxtNota2.Location = new System.Drawing.Point(382, 86);
            this.cxtNota2.Name = "cxtNota2";
            this.cxtNota2.Size = new System.Drawing.Size(100, 20);
            this.cxtNota2.TabIndex = 3;
            this.cxtNota2.TextChanged += new System.EventHandler(this.cxtNota2_TextChanged);
            // 
            // txtNota2
            // 
            this.txtNota2.AutoSize = true;
            this.txtNota2.Location = new System.Drawing.Point(334, 89);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(42, 13);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.Text = "Nota 2:";
            // 
            // butCalcular
            // 
            this.butCalcular.Location = new System.Drawing.Point(74, 149);
            this.butCalcular.Name = "butCalcular";
            this.butCalcular.Size = new System.Drawing.Size(75, 23);
            this.butCalcular.TabIndex = 4;
            this.butCalcular.Text = "Calcular";
            this.butCalcular.UseVisualStyleBackColor = true;
            this.butCalcular.Click += new System.EventHandler(this.butCalcular_Click);
            // 
            // butLimpar
            // 
            this.butLimpar.Location = new System.Drawing.Point(249, 148);
            this.butLimpar.Name = "butLimpar";
            this.butLimpar.Size = new System.Drawing.Size(75, 23);
            this.butLimpar.TabIndex = 5;
            this.butLimpar.Text = "Limpar";
            this.butLimpar.UseVisualStyleBackColor = true;
            this.butLimpar.Click += new System.EventHandler(this.butLimpar_Click);
            // 
            // butSair
            // 
            this.butSair.Location = new System.Drawing.Point(406, 148);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(75, 23);
            this.butSair.TabIndex = 6;
            this.butSair.Text = "Sair";
            this.butSair.UseVisualStyleBackColor = true;
            this.butSair.Click += new System.EventHandler(this.butSair_Click);
            // 
            // labIFseq
            // 
            this.labIFseq.AutoSize = true;
            this.labIFseq.Location = new System.Drawing.Point(72, 203);
            this.labIFseq.Name = "labIFseq";
            this.labIFseq.Size = new System.Drawing.Size(118, 13);
            this.labIFseq.TabIndex = 7;
            this.labIFseq.Text = "Condicional Sequencial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Média:";
            // 
            // cxtSequencial
            // 
            this.cxtSequencial.Enabled = false;
            this.cxtSequencial.Location = new System.Drawing.Point(117, 250);
            this.cxtSequencial.Name = "cxtSequencial";
            this.cxtSequencial.Size = new System.Drawing.Size(100, 20);
            this.cxtSequencial.TabIndex = 9;
            // 
            // cxtSituacaoSequencial
            // 
            this.cxtSituacaoSequencial.Enabled = false;
            this.cxtSituacaoSequencial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cxtSituacaoSequencial.Location = new System.Drawing.Point(350, 250);
            this.cxtSituacaoSequencial.Name = "cxtSituacaoSequencial";
            this.cxtSituacaoSequencial.Size = new System.Drawing.Size(100, 20);
            this.cxtSituacaoSequencial.TabIndex = 11;
            this.cxtSituacaoSequencial.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Situação:";
            // 
            // cxtSituacao
            // 
            this.cxtSituacao.Enabled = false;
            this.cxtSituacao.Location = new System.Drawing.Point(350, 366);
            this.cxtSituacao.Name = "cxtSituacao";
            this.cxtSituacao.Size = new System.Drawing.Size(100, 20);
            this.cxtSituacao.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Situação:";
            // 
            // cxtEncadeada
            // 
            this.cxtEncadeada.Enabled = false;
            this.cxtEncadeada.Location = new System.Drawing.Point(117, 366);
            this.cxtEncadeada.Name = "cxtEncadeada";
            this.cxtEncadeada.Size = new System.Drawing.Size(100, 20);
            this.cxtEncadeada.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Média:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Condicional Encadeada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Média duas Notas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 434);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cxtSituacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cxtEncadeada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cxtSituacaoSequencial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cxtSequencial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labIFseq);
            this.Controls.Add(this.butSair);
            this.Controls.Add(this.butLimpar);
            this.Controls.Add(this.butCalcular);
            this.Controls.Add(this.cxtNota2);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.cxtNota1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Média Duas Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cxtNota1;
        private System.Windows.Forms.TextBox cxtNota2;
        private System.Windows.Forms.Label txtNota2;
        private System.Windows.Forms.Button butCalcular;
        private System.Windows.Forms.Button butLimpar;
        private System.Windows.Forms.Button butSair;
        private System.Windows.Forms.Label labIFseq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cxtSequencial;
        private System.Windows.Forms.TextBox cxtSituacaoSequencial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cxtSituacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cxtEncadeada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

