namespace TP05_181828
{
    partial class C
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C));
            this.Limpar = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amplificacao = new System.Windows.Forms.TextBox();
            this.capacitor = new System.Windows.Forms.TextBox();
            this.frequencia = new System.Windows.Forms.TextBox();
            this.variacao = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.timerdata = new System.Windows.Forms.Timer(this.components);
            this.data1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timeranimacao = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.anima = new System.Windows.Forms.PictureBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anima)).BeginInit();
            this.SuspendLayout();
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.Color.White;
            this.Limpar.BackgroundImage = global::TP05_181828.Properties.Resources.trashcan_146455;
            this.Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Limpar.Location = new System.Drawing.Point(684, 160);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(122, 142);
            this.Limpar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.Limpar, "Limpar");
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.White;
            this.Calcular.BackgroundImage = global::TP05_181828.Properties.Resources.calculator_404000;
            this.Calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calcular.Location = new System.Drawing.Point(684, 12);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(122, 142);
            this.Calcular.TabIndex = 10;
            this.toolTip1.SetToolTip(this.Calcular, "Calcular");
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrada de Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amplificação";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capacitor(μF)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Frequência(Hz)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Variação do Passo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // amplificacao
            // 
            this.amplificacao.Location = new System.Drawing.Point(173, 54);
            this.amplificacao.Name = "amplificacao";
            this.amplificacao.Size = new System.Drawing.Size(100, 20);
            this.amplificacao.TabIndex = 1;
            this.amplificacao.TextChanged += new System.EventHandler(this.amplificacao_TextChanged);
            // 
            // capacitor
            // 
            this.capacitor.Location = new System.Drawing.Point(178, 94);
            this.capacitor.Name = "capacitor";
            this.capacitor.Size = new System.Drawing.Size(100, 20);
            this.capacitor.TabIndex = 3;
            this.capacitor.TextChanged += new System.EventHandler(this.capacitor_TextChanged_1);
            // 
            // frequencia
            // 
            this.frequencia.Location = new System.Drawing.Point(488, 52);
            this.frequencia.Name = "frequencia";
            this.frequencia.Size = new System.Drawing.Size(100, 20);
            this.frequencia.TabIndex = 2;
            this.frequencia.TextChanged += new System.EventHandler(this.frequencia_TextChanged_2);
            // 
            // variacao
            // 
            this.variacao.Location = new System.Drawing.Point(517, 89);
            this.variacao.Name = "variacao";
            this.variacao.Size = new System.Drawing.Size(100, 20);
            this.variacao.TabIndex = 4;
            this.variacao.TextChanged += new System.EventHandler(this.variacao_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(497, 431);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 12;
            // 
            // timerdata
            // 
            this.timerdata.Enabled = true;
            this.timerdata.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // data1
            // 
            this.data1.AutoSize = true;
            this.data1.Location = new System.Drawing.Point(354, 379);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(0, 13);
            this.data1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Resultados";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // timeranimacao
            // 
            this.timeranimacao.Enabled = true;
            this.timeranimacao.Tick += new System.EventHandler(this.timeranimacao_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(681, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // anima
            // 
            this.anima.BackColor = System.Drawing.Color.Transparent;
            this.anima.Location = new System.Drawing.Point(96, 366);
            this.anima.Name = "anima";
            this.anima.Size = new System.Drawing.Size(710, 202);
            this.anima.TabIndex = 16;
            this.anima.TabStop = false;
            this.anima.Click += new System.EventHandler(this.anima_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(38, 200);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 147);
            this.listBox2.TabIndex = 18;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(182, 200);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 147);
            this.listBox3.TabIndex = 19;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(322, 200);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 147);
            this.listBox4.TabIndex = 20;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(465, 200);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(120, 147);
            this.listBox5.TabIndex = 0;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Resistor 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(198, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Resistor 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(339, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Resistor 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(474, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Capacitor 2";
            // 
            // C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(835, 570);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.anima);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.variacao);
            this.Controls.Add(this.frequencia);
            this.Controls.Add(this.capacitor);
            this.Controls.Add(this.amplificacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Calcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "C";
            this.Text = "Circuito Passa Baixa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Pendulo);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amplificacao;
        private System.Windows.Forms.TextBox capacitor;
        private System.Windows.Forms.TextBox frequencia;
        private System.Windows.Forms.TextBox variacao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Timer timerdata;
        private System.Windows.Forms.Label data1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timeranimacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox anima;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

