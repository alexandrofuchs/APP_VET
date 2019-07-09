using Apresentacao.Buscas;
using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Apresentacao.Consultas
{
    public partial class F_RegistrarConsulta : F_AbrirForm
    {
        ConsultaServico consultaServico = new ConsultaServico();

        Animal animal;
        Veterinario veterinario;


        public F_RegistrarConsulta(F_Principal f_principal, Animal animal) : base(f_principal)
        {
            InitializeComponent();
            this.animal = animal;
            CarregarDGV_DadoClinico();
            CarregarDados(animal);
        }

        private void CarregarDados(Animal a)
        {
            lbl_ValorNomeAnimal.Text = a.Nome;
            lbl_ValorEspecieAnimal.Text = a.Especie;
            lbl_ValorRaca.Text = a.Raca;
            lbl_ValorSexo.Text = a.Sexo;
            lbl_ValorIdade.Text = a.Idade.ToString();
            lbl_ValorPelagem.Text = a.Pelagem;
            lbl_ValorProprietario.Text = a.Cliente.Nome;
            lbl_ValorCPF.Text = a.Cliente.CPF;
            lbl_ValorContato.Text = a.Cliente.Telefone + "\r\n" + a.Cliente.Celular;
            lvl_ValorPeso.Text = a.Peso.ToString("F2", CultureInfo.InvariantCulture)+"(KG)";
        }

        public void GetVeterinario(Veterinario veterinario)
        {
            this.veterinario = veterinario;
            txt_Veterinario.Text = veterinario.Nome;
        }

        List<string> DadosClinicos = new List<string>
        {
            "Doenças",
            "Sistema Digestório",
            "Sistema Urogenital",
            "Sistema Cardiorespiratório",
            "Sistema Neurológico",
            "Sistema Locomotor",
            "Pele",
            "Olhos",
            "Ouvido",
            "Ambiente",
            "Hidratação",
            "Glicemia",
            "Mucosa",
            "Pelagem",
            "Frequencia Cardiaca",
            "Frequencia Respiratória",
            "Cavidade Oral",
            "Condutores Auditivos",
            "Temperatura",
            "Pressão Arterial Sistêmica",
            "Linfonodos",
            "Deambulação",
            "Propriocepção",
            "Palpitação Abdominal",
            "Cavidade Nasal",
            "Oftalmológicos"
        };
        
        private void CarregarDGV_DadoClinico()
        {            
            
            dgv_DadoClinico.Columns.Add("Dado", "Dado");
            dgv_DadoClinico.Columns["Dado"].ReadOnly = true;
            dgv_DadoClinico.Columns.Add("Situacao", "Relato Situação(Descrição)");
            foreach (var a in DadosClinicos)
            {
                dgv_DadoClinico.Rows.Add(a, "OK");
            }            
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (animal is null)
                {
                    throw new Exception("Animal não Relacionado");
                }
                if (veterinario is null)
                {
                    throw new Exception("Veterinario não Relacionado");
                }
                List<DadoConsulta> dadosConsulta = new List<DadoConsulta>();
                for (int i = 0; i < dgv_DadoClinico.RowCount; i++)
                {
                    dadosConsulta.Add(new DadoConsulta { Dado = dgv_DadoClinico["Dado", i].Value.ToString(), Situacao = dgv_DadoClinico["Situacao", i].Value.ToString() });
                }
                var op = new F_Confirmacao("Registrar Consulta?").Acao;
                if( op == AcaoConfirmacao.Sim)
                {
                    var c = new Consulta
                    {
                        AnimalID = animal.AnimalID,
                        VeterinarioID = veterinario.VeterinarioID,
                        ProblemasRelatados = txt_PrincipalQueixa.Text,
                        PrescricaoMedica = txt_PrescricaoMedica.Text,
                        MedicamentosReceitados = txt_MedicamentosReceitados.Text,
                        ExamesSolicitados = txt_ExamesSolicitados.Text,
                        SintomasRelatados = txt_SintomasRelatados.Text,
                        DataConsulta = DateTime.Parse(txt_DataConsulta.Value.ToString())
                    };
                    c.AdicionarDadosConsulta(dadosConsulta);
                    consultaServico.Registrar(c);
                    new F_TelaDeMensagem("Registrado!");
                    f_Principal.VoltarForm();
                }
                
            }
            catch(Exception error)
            {
                new F_TelaDeMensagem(error.Message);
            }            
        }

        private void btn_BuscarVeterinario_Click(object sender, EventArgs e)
        {
            new F_BuscarVeterinario(this);
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            f_Principal.VoltarForm();
        }
    }
}
