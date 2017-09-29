using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloqueio_de_Sites
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); opções();
            




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void gravar()
        {
            String caminho;
            caminho = @"C:\Windows\System32\drivers\etc\hosts";
            //textBox1.Text = caminho;
            
            String site = "127.0.0.1 " + comboBox1.Text;
            /*StreamWriter host_ed = new StreamWriter(caminho);
            host_ed.Write(site);
            host_ed.Close();*/
            StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System),caminho));
            MessageBox.Show(comboBox1.Text + " bloqueado");
        }
        public void opções()
        {
            comboBox1.Items.Add("Facebook");
            comboBox1.Items.Add("Youtube");
            comboBox1.Items.Add("Orkut");
            comboBox1.Items.Add("Spotify");
            comboBox1.Items.Add("Instagram");
            comboBox1.Items.Add("Click Jogos");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gravar();
        }
    }
}
