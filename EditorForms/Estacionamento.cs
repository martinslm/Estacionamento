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
        private IList<Vaga> vagas = new List<Vaga>();

        public Estacionamento()
        {
            InitializeComponent();
            InicializarVagas();
        }

        private void InicializarVagas()
        {
            for (int i = 1; i < 500; i++)
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
            vagasOcupadas = string.Empty;
        }

        private void OcuparVagaEstacionamento()
        {
            pool.WaitOne();

            if (!vagas.Where(v => v.Ocupada == false).Any())
                mensagem = "ESTACIONAMENTO LOTADO.";

            int vagaParaOcupar = vagas.Where(v => v.Ocupada == false).Select(v => v.NumeroVaga).First();

            vagas[vagaParaOcupar - 1].Ocupada = true;

            vagasOcupadas += string.Format("{0},", vagaParaOcupar);

            pool.Release();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {

        }
    }
}
