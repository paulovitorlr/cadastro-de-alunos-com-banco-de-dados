using Portal_do_Aluno.infrastructure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Portal_do_Aluno
{
    public partial class form : Form
    {
        public List<Aluno> Alunos { get; private set; } = [];
        public form()
        {
            InitializeComponent();
            //sempre que o form for iniciado, ele vai chamar o método ObterAlunos
            ObterAlunos();
        }

        private void ObterAlunos()
        {
            //obter alunos do banco de dados
            var repository = new AlunoRepository();
            Alunos = repository.Get();

            //adicionar alunos no listview
            foreach (var item in Alunos)
            {
                
                lv_alunos.Items.Add(new ListViewItem(new String[] { item.Nome, item.Idade.ToString(), item.Curso }));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_nome1.Text;
                var idade = txt_nome2.Text;
                var curso = txt_nome3.Text;

                foreach (var item in Alunos)
                {
                    if (item.Nome == nome)
                    {
                        MessageBox.Show("Aluno já cadastrado!");
                        return;
                    }
                }
                //adicionar aluno no listview
                var aluno = new Aluno(nome, idade, curso);
                Alunos.Add(aluno);

                //adicionar aluno no banco de dados
                var repository = new AlunoRepository();
                repository.Add(aluno);

                lv_alunos.Items.Add(new ListViewItem([nome, idade, curso]));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
