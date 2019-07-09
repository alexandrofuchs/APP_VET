using Apresentacao.Buscas;
using Modelo;
using Servico;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Agendamentos
{
    public partial class F_AgendarServico : Form
    {
        AgendamentoServico agendamentoServico = new AgendamentoServico();
        public Animal animal;
        public Veterinario veterinario;

        public F_AgendarServico()
        {
            InitializeComponent();
            ShowDialog();
        }

        public void GetAnimal(Animal animal)
        {
            this.animal = animal;
            CarregarDadosAnimal();
        }

        public void GetVeterinario(Veterinario veterinario)
        {
            this.veterinario = veterinario;
            CarregarDadosVeterinario();
        }

        public void CarregarDadosAnimal()
        {
            txt_NomeAnimal.Text = animal.Nome;
            txt_Proprietario.Text = animal.Cliente.Nome;
        }

        public void CarregarDadosVeterinario()
        {
            txt_NomeVeterinario.Text = veterinario.Nome;
        }


        private void Btn_AgendarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_DataConsulta.Text) || string.IsNullOrEmpty(txt_DataConsulta.Text))
                {
                    throw new Exception("Defina uma Data Válida");
                }

                if (string.IsNullOrWhiteSpace(txt_HoraConsulta.Text) || string.IsNullOrEmpty(txt_HoraConsulta.Text))
                {
                    throw new Exception("Defina uma Hora Válida");
                }
                if( animal is null)
                {
                    throw new Exception("Animal não Relacionado!");
                }
                if( veterinario is null)
                {
                    throw new Exception("Veterinário não Relacionado!");
                }

                var op = new F_Confirmacao("Agendar Consulta?").Acao;
                if (op == AcaoConfirmacao.Não)
                {
                    throw new Exception("Procedimento Cancelado pelo usuário");
                }
                agendamentoServico.Registrar(new Agendamento
                {
                    AnimalID = animal.AnimalID,
                    VeterinarioID = veterinario.VeterinarioID,
                    DataHora = DateTime.ParseExact($"{txt_DataConsulta.Text}{txt_HoraConsulta.Text}", "dd/MM/yyyyHH:mm", CultureInfo.InvariantCulture),
                    DescricaoAgendamento = txt_DescricaoAgendamento.Text,
                    Observacoes = txt_Observacoes.Text
                });
                new F_TelaDeMensagem("Registrado");
                Close();
                
            }
            catch (Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }              
        }
        private void MonthCalendar_Consultas_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_DataConsulta.Text = monthCalendar_Consultas.SelectionRange.Start.ToShortDateString();
        }

        private void Btn_BuscarAnimal_Click(object sender, EventArgs e)
        {
            new F_BuscarAnimal(this);
        }

        private void btn_BuscarVeterinario_Click(object sender, EventArgs e)
        {
            new F_BuscarVeterinario(this);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_HoraConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_DataConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
