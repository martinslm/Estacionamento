using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EditorForms
{
    public partial class Estacionamento : MaterialSkin.Controls.MaterialForm
    {
        Semaphore pool = new Semaphore(1, 1);
        string mensagem;
        string vagasOcupadas = string.Empty;
        string resultVagasLiberadas = string.Empty;
        private IList<int> vagasLiberar = new List<int>();
        private IList<Vaga> vagas = new List<Vaga>();
        int vagasDisponiveis = 500;

        public Estacionamento()
        {
            InitializeComponent();
            InicializarVagas();
            AtualizarLabelVagas();
        }

        private void InicializarVagas()
        {
            for (int i = 1; i <= 500; i++)
            {
                vagas.Add(new Vaga { NumeroVaga = i, Ocupada = false });
            }
        }

        private void btnEntrar_Click(object sender, System.EventArgs e)
        {
            int vagasEntrar;

            vagasEntrar = Int32.Parse(TbQtdEntrada.Text);

           if (vagasEntrar > 5)
           {
                lbErroEntrada.Text = "VALOR INVÁLIDO. O valor deve ser menor que 5.";
                return;
           }

            while (vagasEntrar > 0)
            {
                Thread t1 = new Thread(new ThreadStart(OcuparVagaEstacionamento));
                t1.Start();
                t1.Join();

                vagasEntrar--;
            }

            lbVagasOcupadas.Text = string.Format("Vagas Ocupadas: {0}", vagasOcupadas.Remove(vagasOcupadas.Length - 1));
            AtualizarLabelVagas();
            vagasOcupadas = string.Empty;
        }

        private void OcuparVagaEstacionamento()
        {
            pool.WaitOne();

            if (!vagas.Where(v => v.Ocupada == false).Any())
            {
                mensagem = "ESTACIONAMENTO LOTADO.";
                pool.Release();
                return;
            }

            int vagaParaOcupar = vagas.Where(v => v.Ocupada == false).Select(v => v.NumeroVaga).First();

            vagas[vagaParaOcupar - 1].Ocupada = true;
            vagasDisponiveis--;

            vagasOcupadas += string.Format("{0},", vagaParaOcupar);

            pool.Release();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            string[] vagasSaida = tbSaida.Text.Split(',');

            foreach (var vetor in vagasSaida)
            {
                vagasLiberar.Add(Convert.ToInt32(vetor));
            }

            for(int i = vagasSaida.Count(); i>0; i--)
            {
                Thread t1 = new Thread(new ThreadStart(DesocuparVagasEstacionamento));
                t1.Start();
                t1.Join();
            }

            lbRetornoSaida.Text = resultVagasLiberadas;
            AtualizarLabelVagas();
            resultVagasLiberadas = string.Empty;
        }

        private void DesocuparVagasEstacionamento()
        {
            pool.WaitOne();
            int vaga = vagasLiberar.First();

            try
            {
                if (vagas.Where(v => v.NumeroVaga == vaga).FirstOrDefault().Ocupada == false)
                {
                    resultVagasLiberadas += string.Format("A vaga {0} já encontrava-se disponível. Por favor verifique o valor informado. \n", vaga);
                }
                else
                {
                    vagas[vaga - 1].Ocupada = false;
                    vagasDisponiveis++;
                    resultVagasLiberadas += string.Format("A vaga {0} foi liberada com sucesso. \n", vaga);
                }
            }
            catch
            {
                resultVagasLiberadas += string.Format("A vaga {0} não foi encontrada. \n", vaga);
            }

            vagasLiberar.Remove(vaga);

            pool.Release();
        }

        private void AtualizarLabelVagas()
        {
            lbVagasDisponiveis.Text = vagasDisponiveis.ToString();
        }
    }
}
