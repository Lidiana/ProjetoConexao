using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoConexao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdTesteDataSet2.tbCidade'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCidadeTableAdapter2.Fill(this.bdTesteDataSet2.tbCidade);
            // TODO: esta linha de código carrega dados na tabela 'bdTesteDataSet1.tbCidade'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCidadeTableAdapter1.Fill(this.bdTesteDataSet1.tbCidade);
            // TODO: esta linha de código carrega dados na tabela 'bdTesteDataSet.tbCidade'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCidadeTableAdapter.Fill(this.bdTesteDataSet.tbCidade);
            // TODO: esta linha de código carrega dados na tabela 'bdTesteDataSet.tbUF'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUFTableAdapter.Fill(this.bdTesteDataSet.tbUF);

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
