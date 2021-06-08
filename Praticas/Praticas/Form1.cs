using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nome = new string[3];
            nome[0] = "Pintos";
            nome[1] = "Advogado";
            nome[2] = "pé";
            List<string> Gente = new List<string>();
            Gente.Add("Gustavo");
            Gente.Add("Pinto");
            Gente.AddRange(nome);

            foreach(string i in Gente)
            {
                lista.Items.Add(i);
            }


        }

        private void hashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto", "Barco"
            };
            foreach(string item in veiculos)
            {
                lista.Items.Add(item);
            }

        }

        private void dicionaro_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            Dictionary<int, string> alunos = new Dictionary<int, string>() 
            {
                {100, "queijo" },
                {150, "Pamonha" },
                {200, "Dinheiro" }
            };
            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Value);
            }

        }
    }
}
