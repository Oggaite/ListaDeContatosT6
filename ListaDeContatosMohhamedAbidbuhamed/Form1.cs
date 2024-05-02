using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaDeContatosMohhamedAbidbuhamed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Contato[] listaDeContatos = new Contato[1];

        private void Escrever(Contato contato)
        {
            StreamWriter escrever = new StreamWriter("Contatos.txt");

            escrever.WriteLine(listaDeContatos.Length + 1);
            escrever.WriteLine(contato.Nome);
            escrever.WriteLine(contato.Sobrenome);
            escrever.WriteLine(contato.Telefone);

            for (int x = 0; x < listaDeContatos.Length; x++)
            {
                escrever.WriteLine(listaDeContatos[x].Nome);
                escrever.WriteLine(listaDeContatos[x].Sobrenome);
                escrever.WriteLine(listaDeContatos[x].Telefone);
            }

            escrever.Close();
        }

        private void Ler()
        {
            StreamReader ler = new StreamReader("Contatos.txt");

            listaDeContatos = new Contato[Convert.ToInt32(ler.ReadLine())];

            for (int x = 0; x < listaDeContatos.Length; x++)
            {
                listaDeContatos[x] = new Contato();
                listaDeContatos[x].Nome = ler.ReadLine();
                listaDeContatos[x].Sobrenome = ler.ReadLine();
                listaDeContatos[x].Telefone = ler.ReadLine();
            }
            ler.Close();
        }

        private void Exbir()
        {
            listBoxContato.Items.Clear();

            for (int x = 0; x <listaDeContatos.Length; x++)
            {
                listBoxContato.Items.Add(listaDeContatos[x].ToString());
            }
        }

        private void limparCampos()
        {
            textBoxNome.Text = String.Empty;
            textBoxSobrenome.Text = String.Empty;  
            textBoxTelefone.Text = String.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonContato_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();

            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = textBoxTelefone.Text;

            listBoxContato.Items.Add(contato.ToString());

            Escrever(contato);
            Ler();
            Exbir();
            limparCampos();
        }

        private void listBoxContato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Exbir();
        }
    }
}
