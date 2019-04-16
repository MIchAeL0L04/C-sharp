using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaDuasNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {
            cxtSituacao.Text = "";
            cxtSituacaoSequencial.Text = "";
            cxtEncadeada.Text = "";
            cxtSequencial.Text = "";
        }

        private void butSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void butCalcular_Click(object sender, EventArgs e)
        {
            double media;
            media = (double.Parse(cxtNota1.Text) + double.Parse(cxtNota2.Text)) / 2;

            cxtSequencial.Text = media.ToString();
           

            //Sequencial

            if (media < 4)
            {
                cxtSituacaoSequencial.ForeColor = Color.Red;
                cxtSituacaoSequencial.Text = "Reprovado";
            }
            if ((media >= 4) && (media < 6))
            {
                cxtSituacaoSequencial.ForeColor = Color.DarkOrange;
                cxtSituacaoSequencial.Text = "Fazer exame";
            }
            if (media >= 6)
            {
                cxtSituacaoSequencial.ForeColor = Color.Green;
                cxtSituacaoSequencial.Text = "Aprovado";
            }

            //Encadeado

            cxtEncadeada.Text = media.ToString();
            if (media < 4)
            {
                cxtSituacao.ForeColor = Color.Red;
                cxtSituacao.Text = "Reprovado";
            }      
            else 
                if (media <6)
                {
                cxtSituacao.ForeColor = Color.DarkOrange;
                cxtSituacao.Text = "Fazer Exame";
                }
                else
                {
                    cxtSituacao.ForeColor = Color.Green;
                    cxtSituacao.Text = "Aprovado";
                }

        }

        private void butLimpar_Click(object sender, EventArgs e)
        {
            cxtNota1.Text = "";
            cxtNota2.Text = "";
            cxtSituacao.Text = "";
            cxtSituacaoSequencial.Text = "";
            cxtEncadeada.Text = "";
            cxtSequencial.Text = "";
        }

        private void cxtNota2_TextChanged(object sender, EventArgs e)
        {
            cxtSituacao.Text = "";
            cxtSituacaoSequencial.Text = "";
            cxtEncadeada.Text = "";
            cxtSequencial.Text = "";
        }
    }
}
