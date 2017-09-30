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
        String caminho = @"c:\Windows\System32\drivers\etc\hosts";
     
        public Form1()
        {
            InitializeComponent();
            conteudo.ReadOnly = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region função
        public void gravar()
        {
            try
            {
                StreamWriter host_ed = new StreamWriter(caminho);
                host_ed.WriteLine(conteudo.Text);
                host_ed.Close();
                MessageBox.Show(link.Text + " bloqueado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error =" + ex.ToString());
            }
                        
        }
        public void ler_hosts()
        {
            try
            {
                StreamReader ler = new StreamReader(caminho);
                ler.ReadLine();
                conteudo.Text = ler.ReadToEnd();
                ler.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
        }
        public void add_url()
        {
            String pagina = link.Text;
            string n127 = "127.0.0.1 ";
            string hosts = conteudo.Text + n127 + link.Text;
            conteudo.Text = hosts;
         
        }
        #endregion

        #region buttons
        private void button1_Click(object sender, EventArgs e)
        {
            conteudo.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ler_hosts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_url();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gravar();
            
        }
        #endregion
    }
}
