using Apresentacao.Registros;
using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Agendamentos
{
    public partial class F_Agendamento : F_AbrirForm
    {
        public AgendamentoServico agendamentoServico = new AgendamentoServico();
        Agendamento agendamento;

        public F_Agendamento(F_Principal f_Principal) : base(f_Principal)
        {
            InitializeComponent();
            CarregarAgendaDiaria(DateTime.Today);
            CarregarAgendaMensal(DateTime.Today.Month);
            CarregarMeses();
            btn_Cancelar.Enabled = false;
            btn_Concluir.Enabled = false;
        }

        private void CarregarMeses()
        {
            var mes = new List<string>()
            {
                "[selecione]",
                "Janeiro",
                "Fevereiro",
                "Março",
                "Abril",
                "Maio",
                "Junho",
                "Julho",
                "Agosto",
                "Setembro",
                "Outubro",
                "Novembro",
                "Dezembro"
            };
            cmb_Mes.DataSource = mes;
        }

        private void CarregarAgendaDiaria(DateTime data)
        {
            var agendamentos = from a in agendamentoServico.BuscarPorData(data)
                               select new
                               {
                                   ID = a.AgendamentoID,
                                   Situação = a.Status,
                                   DiaSemana = DiaSemana(a.DataHora),
                                   Horário = a.DataHora.ToShortTimeString(),
                                   Animal = a.Animal.Nome,
                                   Proprietário = a.Animal.Cliente.Nome,
                                   Veterinário = a.Veterinario.Nome
                               };
            dgv_AgendaDiaria.DataSource = agendamentos.ToList();
            dgv_AgendaDiaria.Columns["ID"].Visible = false;
            dgv_AgendaDiaria.Columns["DiaSemana"].HeaderText = "Dia da Semana";
        }


        private void CarregarAgendaMensal(int mes)
        {
            var agendamentos = from a in agendamentoServico.BuscarPorMes(mes).OrderBy(a => a.DataHora)
                               select new
                               {
                                   ID = a.AgendamentoID,
                                   Situação = a.Status,
                                   DiaSemana = DiaSemana(a.DataHora),
                                   Data = a.DataHora.ToShortDateString(),
                                   Horário = a.DataHora.ToShortTimeString(),
                                   Animal = a.Animal.Nome,
                                   Proprietário = a.Animal.Cliente.Nome,
                                   Veterinário = a.Veterinario.Nome
                               };
            dgv_AgendaMensal.DataSource = agendamentos.ToList();
            dgv_AgendaMensal.Columns["ID"].Visible = false;
            dgv_AgendaMensal.Columns["DiaSemana"].HeaderText = "Dia da Semana";
        }

        private void monthCalendar_Consultas_DateChanged(object sender, DateRangeEventArgs e)
        {
            var data = monthCalendar_Consultas.SelectionStart;
            CarregarAgendaDiaria(data);
        }

        public void CarregarDetalhes(long agendamentoID)
        {
            var a = agendamentoServico.BuscarPorID(agendamentoID);
            if (a is null)
            {
                throw new Exception("Agendamento não encontrado");
            }
            this.agendamento = a;
            lbl_ValorAnimal.Text = a.Animal.Nome;
            lbl_ValorCliente.Text = a.Animal.Cliente.Nome;
            lbl_ValorVeterinario.Text = a.Veterinario.Nome;
            lbl_ValorDataHora.Text = a.DataHora.ToString();
            btn_Cancelar.Enabled = true;
            btn_Concluir.Enabled = true;
        }


        private string DiaSemana(DateTime data)
        {
            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                return "Domingo";
            }
            if (data.DayOfWeek == DayOfWeek.Monday)
            {
                return "Segunda-Feira";                  
            }        
            if( data.DayOfWeek == DayOfWeek.Tuesday)
            {
                return "Terça-Feira";
            }
            if( data.DayOfWeek == DayOfWeek.Wednesday)
            {
                return "Quarta-Feira";
            }
            if( data.DayOfWeek == DayOfWeek.Thursday)
            {
                return "Quinta-Feira";
            }
            if( data.DayOfWeek == DayOfWeek.Friday)
            {
                return "Sexta-Feira";
            }
            return "Sábado";            
        }
        

        private void dgv_AgendaDiaria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_AgendaDiaria.RowCount > 0 && dgv_AgendaDiaria.CurrentRow.Index >= 0)
            {
                var linha = dgv_AgendaDiaria.CurrentRow.Index;
                var id = long.Parse(dgv_AgendaDiaria["ID", linha].Value.ToString());
                CarregarDetalhes(id);
            }
        }

        private void dgv_AgendaMensal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_AgendaMensal.RowCount > 0 && dgv_AgendaMensal.CurrentRow.Index >=0)
            {
                var linha = dgv_AgendaMensal.CurrentRow.Index;
                var id = long.Parse(dgv_AgendaMensal["ID", linha].Value.ToString());
                CarregarDetalhes(id);
            }
        }

        private void btn_AgendarServico_Click(object sender, EventArgs e)
        {
            new F_AgendarServico();
            CarregarAgendaDiaria(monthCalendar_Consultas.SelectionStart);
            CarregarAgendaMensal(DateTime.Today.Month);
        }

        private void cmb_Mes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_Mes.SelectedIndex != 0)
            {
                CarregarAgendaMensal(cmb_Mes.SelectedIndex);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new F_Confirmacao("Cancelar Agendamento? ").Acao;
                if (op == AcaoConfirmacao.Sim)
                {
                    agendamento.CancelarAgendamento();
                    AtualizarAgendamento();
                }
            }
            catch (Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }

        }

        private void btn_Concluir_Click(object sender, EventArgs e)
        {
            try
            {
                var op = new F_Confirmacao("Concluir Atendimento? ").Acao;
                if (op == AcaoConfirmacao.Sim)
                {
                    agendamento.ConcluirAtendimento();
                    AtualizarAgendamento();
                }
            }
            catch(Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }
            
        }

        private void AtualizarAgendamento()
        {
            agendamentoServico.Atualizar(agendamento);
            CarregarAgendaDiaria(monthCalendar_Consultas.SelectionStart);
            CarregarAgendaMensal(DateTime.Today.Month);
        }
    }
}
