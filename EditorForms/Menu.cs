using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EditorForms
{
    public class Vagas
    {
        public int NumeroVaga { get; set; }
        public bool Ocupada { get; set; }
    }
    public partial class Menu : MaterialSkin.Controls.MaterialForm
    {
        Semaphore pool = new Semaphore(1, 1);
        string mensagem;
        string vagasOcupadas;
        private IList<Vagas> vagas = new List<Vagas>();

        public Menu()
        { 
         //   OcuparVagaEstacionamento();
           // pool.Release();
            InitializeComponent();
            InicializarVagas();
            AtualizarLabelVagas();
        }

        private void InicializarVagas()
        {
            for(int i = 1; i < 500; i++)
            {
                vagas.Add(new Vagas { NumeroVaga = i, Ocupada = false });
            }
        }

        private void btnEntrada1_Click(object sender, EventArgs e)
        {
            int vagasEntrar;

            try
            {
                vagasEntrar = Int32.Parse(TbQtdEntrada.Text);

                if(vagasEntrar > 5)
                {
                    //retorna mensagem de erro aqui
                }

                while(vagasEntrar > 0)
                {
                    Thread t1 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
                    t1.Start();
                    t1.Join();
                }

            }
            catch
            {
                //inserir alerta de erro de conversão aqui
            }
           // Thread t1 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
            //t1.Start();
            //t1.Join();
            lbEntrada1.Text = "Entrada 1:" + mensagem;
            AtualizarLabelVagas();
            //pool.Release();
        }

        /*private void btnEntrada2_Click(object sender, EventArgs e)
        {
            Thread t2 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
            t2.Start();
            t2.Join();
            lbEntrada2.Text = "Entrada 2:" + mensagem;
            AtualizarLabelVagas();
            //pool.Release();
        }

        private void btnEntrada3_Click(object sender, EventArgs e)
        {
            Thread t3 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
            t3.Start();
            t3.Join();
            lbEntrada3.Text = "Entrada 3: " + mensagem;
            AtualizarLabelVagas();
        }

        private void btnEntrada4_Click(object sender, EventArgs e)
        {
            Thread t4 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
            t4.Start();
            t4.Join();
            AtualizarLabelVagas();
            lbEntrada4.Text = "Entrada 4:" + mensagem;
        }

        private void btnEntrada5_Click(object sender, EventArgs e)
        {
            Thread t5 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
            t5.Start();
            t5.Join();
            AtualizarLabelVagas();
            lbEntrada5.Text = " Entrada 5:" + mensagem;
        }

        private void btnSaida1_Click(object sender, EventArgs e)
        {
            Thread t6 = new Thread(new ThreadStart(LiberarVagaEstacionamento));
            t6.Start();
            t6.Join();
            AtualizarLabelVagas();
            lbSaida1.Text = " Saída 1:" + mensagem;
            //pool.Release();

        }

        private void btnSaida2_Click(object sender, EventArgs e)
        {
            Thread t7 = new Thread(new ThreadStart(LiberarVagaEstacionamento));
            t7.Start();
            t7.Join();
            AtualizarLabelVagas();
            lbSaida2.Text = " Saída 2:" + mensagem;
        }

        private void btnSaida3_Click(object sender, EventArgs e)
        {
            Thread t8 = new Thread(new ThreadStart(LiberarVagaEstacionamento));
            t8.Start();
            t8.Join();
            AtualizarLabelVagas();
            lbSaida3.Text = " Saída 3:" + mensagem;
        }

        private void btnSaida4_Click(object sender, EventArgs e)
        {
            Thread t9 = new Thread(new ThreadStart(LiberarVagaEstacionamento));
            t9.Start();
            t9.Join();
            AtualizarLabelVagas();
            lbSaida4.Text = " Saída 4:" + mensagem;
        }

        private void btnSaida5_Click(object sender, EventArgs e)
        {
            Thread t0 = new Thread(new ThreadStart(LiberarVagaEstacionamento));
            t0.Start();
            t0.Join();
            AtualizarLabelVagas();
            lbSaida5.Text = " Saída 5:" + mensagem;
        }*/

        private void OcuparVagaEstacionamento()
        {
            pool.WaitOne();

            if (!vagas.Where(v => v.Ocupada == false).Any())
                mensagem = "ESTACIONAMENTO LOTADO.";

            int vagaParaOcupar = vagas.Where(v => v.Ocupada == false).Select(v => v.NumeroVaga).First();

            vagas[vagaParaOcupar - 1].Ocupada = true;

            vagasOcupadas = string.Format("{0},", vagaParaOcupar);
        
            pool.Release();
        }

        /*private void LiberarVagaEstacionamento()
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
        } */

        private void AtualizarLabelVagas()
        {
            labelVagas.Text = string.Format("/Vagas disponíveis: {0}", vagas.Where(v => v.Ocupada == false).Count());
        }
    }
}
