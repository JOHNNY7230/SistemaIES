using Instituicaodeensino;
using Servico;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class DisciplinaForm : Form
    {
        private DisciplinaServico disciplinaServico;
        // Pega a string de conexão configurada no App.config do projeto
        private string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;

        public DisciplinaForm()
        {
            InitializeComponent();
            disciplinaServico = new DisciplinaServico(new SqlConnection(connectionString));
            AtualizarDataGridView();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                disciplinaServico.Gravar(new Disciplina()
                {
                    Nome = txtNome.Text,
                    CargaHoraria = Convert.ToInt16(txtCargaHoraria.Text)
                });

                AtualizarDataGridView();
                MessageBox.Show("Gravação realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void AtualizarDataGridView()
        {
            dgvDisciplinas.DataSource = null;
            dgvDisciplinas.DataSource = disciplinaServico.ObterTodas();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}