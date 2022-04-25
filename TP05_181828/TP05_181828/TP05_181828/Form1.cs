using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TP05_181828
{
    public partial class C : Form
    {
        int contador;
        double R1;
        double R2;
        double R3;
        double C2;
        double freq;
        double ampli;
        double C1;
        double varia;
        int i = 0;
        int tipo;

        public C()
        {
            InitializeComponent();
        }
        #region Verificar 
        private void verificar()
        {

            if (frequencia.Text != "" && amplificacao.Text != "" && capacitor.Text != "" && variacao.Text != "")
            {
                Calcular.Enabled = true;
                Limpar.Enabled = true ;
            }
        }

        #endregion
        #region Data
        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToShortDateString();

        }
        #endregion
        #region Form_Load
        private void Form1_Load(object sender, EventArgs e)
        {
           Calcular.Enabled = false;
           Limpar.Enabled = false;
        }
        #endregion 
        #region Fechar
        private void Frm_Pendulo(object sender, FormClosingEventArgs e)
        {

            if(
                MessageBox.Show("Deseja Sair?","Fechar o Aplicativo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)==DialogResult.No)
                e.Cancel = true;
            
        }
        #endregion
        #region Calcular
        private void Calcular_Click(object sender, EventArgs e)
        {

            freq = double.Parse(frequencia.Text);
            varia = double.Parse(variacao.Text);
            ampli = double.Parse(amplificacao.Text);
            C1 = double.Parse(capacitor.Text);

            for (i = 0; i < 5; i++)
            {
                R1 = Math.Sqrt(2) / (2 * ampli * 2 * Math.PI * freq * C1);
                R2 = (R1 * ampli);
                R3 = R2 / (ampli + 1);
                C2 = (2 * (ampli + 1) * C1);


                listBox2.Items.Add(R1.ToString("#0.0000"));
                listBox3.Items.Add(R2.ToString("#0.0000"));
                listBox4.Items.Add(R3.ToString("#0.0000"));
                listBox5.Items.Add(C2.ToString("#0.0000"));

                ampli += varia;
            }
        }
        #endregion
        #region Animacao
        private void timeranimacao_Tick(object sender, EventArgs e)
        {

            contador = (contador % 9) + 1;

            anima.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\res0" + Convert.ToString(contador) + ".png");

        }

        #endregion
        #region Limpar

        private void Limpar_Click(object sender, EventArgs e)
        {

            string pergunta = "Deseja limpar  os dados?";
            string sair = "Limpar dados";
            MessageBoxButtons botao = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            MessageBoxDefaultButton Default = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(pergunta, sair, botao, icon, Default) == DialogResult.Yes)
            {
                Calcular.Enabled = false;
                Limpar.Enabled = false;
                amplificacao.Text = "";
                capacitor.Text = "";
                variacao.Text = "";
                frequencia.Text = "";
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox5.Items.Clear();
            }

     
            }
#endregion
        #region Lixo

private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frequencia_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void capacitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void frequencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void anima_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void variacao_TextChanged(object sender, EventArgs e)
        {
            verificar();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

private void amplificacao_TextChanged(object sender, EventArgs e)
{
            verificar();
        }

        private void capacitor_TextChanged_1(object sender, EventArgs e)
        {
            verificar();
        }

        private void frequencia_TextChanged_2(object sender, EventArgs e)
        {
            verificar();
        }
        #endregion
    }
}
/*
         #region Tipo
        private void Tipo1()
        {
            
            if (ampli<=0)
            {
                MessageBox.Show("Amplificação Errada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                amplificacao.Clear();
                amplificacao.Focus();
            }
            if (C1 <= 0)
            {
                MessageBox.Show("Capacitor Errado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                capacitor.Clear();
                capacitor.Focus();
            }

            if (freq <= 0)
            {
                MessageBox.Show("Frequência Errada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frequencia.Clear();
                frequencia.Focus();
                }
            if (varia <= 0)
            {
                MessageBox.Show("Variação Errada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                variacao.Clear();
                variacao.Focus();
            }
        }
        #endregion
        */
