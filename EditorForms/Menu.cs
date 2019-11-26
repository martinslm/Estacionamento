using System;
using System.Threading;

namespace EditorForms
{
    public partial class Menu : MaterialSkin.Controls.MaterialForm
    {
        int vagas = 500;
        Semaphore pool = new Semaphore(1, 1);
        string mensagem;

        public Menu()
        {
         //   OcuparVagaEstacionamento();
           // pool.Release();
            InitializeComponent();
        }

        private void btnEntrada1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
            t1.Start();
            t1.Join();
            lbEntrada1.Text = "Entrada 1:" + mensagem;
            //pool.Release();
        }

        private void btnEntrada2_Click(object sender, EventArgs e)
        {
            Thread t2 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
            t2.Start();
            t2.Join();
            lbEntrada2.Text = "Entrada 2:" + mensagem;
            //pool.Release();
        }

        private void btnEntrada3_Click(object sender, EventArgs e)
        {
            Thread t3 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
            t3.Start();
            t3.Join();
            lbEntrada3.Text = "Entrada 3: " + mensagem;
        }

        private void btnEntrada4_Click(object sender, EventArgs e)
        {
            Thread t4 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
            t4.Start();
            t4.Join();
            lbEntrada4.Text = "Entrada 4:" + mensagem;
        }

        private void btnEntrada5_Click(object sender, EventArgs e)
        {
            Thread t5 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
            t5.Start();
            t5.Join();
            lbEntrada5.Text = " Entrada 5:" + mensagem;
        }

        private void btnSaida1_Click(object sender, EventArgs e)
        {
            Thread t6 = new Thread(new ThreadStart(LiberarVagaEstacionamento));
            t6.Start();
            t6.Join();
            lbSaida1.Text = " Saída 1:" + mensagem;
            //pool.Release();

        }

        private void btnSaida2_Click(object sender, EventArgs e)
        {
            Thread t7 = new Thread(new ThreadStart(LiberarVagaEstacionamento));
            t7.Start();
            t7.Join();
            lbSaida2.Text = " Saída 2:" + mensagem;
        }

        private void btnSaida3_Click(object sender, EventArgs e)
        {
            Thread t8 = new Thread(new ThreadStart(LiberarVagaEstacionamento));
            t8.Start();
            t8.Join();
            lbSaida3.Text = " Saída 3:" + mensagem;
        }

        private void btnSaida4_Click(object sender, EventArgs e)
        {
            Thread t9 = new Thread(new ThreadStart(LiberarVagaEstacionamento));
            t9.Start();
            t9.Join();
            lbSaida4.Text = " Saída 4:" + mensagem;
        }

        private void btnSaida5_Click(object sender, EventArgs e)
        {
            Thread t0 = new Thread(new ThreadStart(LiberarVagaEstacionamento));
            t0.Start();
            t0.Join();
            lbSaida5.Text = " Saída 5:" + mensagem;
        }

        private void OcuparVagaEstacionamento()
        {
            pool.WaitOne();
            if (vagas > 0)
            {
                mensagem = "Este carro ocupou a vaga: " + vagas;
                vagas--;
            }
            else
            {
                mensagem = "ESTACIONAMENTO LOTADO.";
            }
            pool.Release();
        }

        private void LiberarVagaEstacionamento()
        {
            pool.WaitOne();
            if (vagas < 500)
            {
                vagas++;
                mensagem = "Obrigada e volte sempre!";
            }
            else
            {
                mensagem = "Estacionamento vazio.";
            }
            pool.Release();
        }
    }
}
