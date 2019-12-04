using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EditorForms
{
    public partial class Estacionamento : MaterialSkin.Controls.MaterialForm
    {
        Semaphore pool = new Semaphore(1, 1);
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

            try
            {
                vagasEntrar = Int32.Parse(TbQtdEntrada.Text);

                if (vagasEntrar > 5 || vagasEntrar == 0)
                {
                    lbErroEntrada.Text = "VALOR INVÁLIDO. O valor deve ser menor ou igual a 5 e maior que 0.";
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
            catch
            {
                lbVagasOcupadas.Text = "Houve um erro ao realizar a operação. Tente novamente.";
            }
        }

        private void OcuparVagaEstacionamento()
        {
            pool.WaitOne();

            if (!vagas.Where(v => v.Ocupada == false).Any())
            {
                vagasOcupadas += "ESTACIONAMENTO LOTADO.";
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

            try
            {
                var qtdVagasSaida = vagasSaida.Count();

                if (qtdVagasSaida > 5)
                {
                    lbRetornoSaida.Text = string.Format("Você informou um total de {0} carros para sair, \nporém, nosso estacionamento possui somente 5 cancelas. \nTente novamente :(", qtdVagasSaida);
                    return;
                }

                foreach (var vetor in vagasSaida)
                {
                    vagasLiberar.Add(Convert.ToInt32(vetor));
                }

                for (int i = qtdVagasSaida; i > 0; i--)
                {
                    Thread t1 = new Thread(new ThreadStart(DesocuparVagasEstacionamento));
                    t1.Start();
                    t1.Join();
                }

                lbRetornoSaida.Text = resultVagasLiberadas;
                AtualizarLabelVagas();
                resultVagasLiberadas = string.Empty;
            }
            catch
            {
                 lbRetornoSaida.Text = "Houve um erro ao realizar a operação. Tente novamente.";
            }
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
