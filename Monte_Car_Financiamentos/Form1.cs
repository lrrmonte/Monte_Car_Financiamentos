using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Car_Financiamentos
{
    public partial class Form1 : Form
    {
        double vlr_bem, entrada, tac, vlr_tot_financ, taxa, coeficiente, parcela;
        int prazo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_vlr_veiculo.Clear();
            tb_entrada.Clear();
            tb_tac.Clear();
            tb_taxa.Clear();
            lb_vlr_tot_financ.ResetText();
            lb_parcela.ResetText();
            lb_coeficiente.ResetText();
            
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            Converter();

            vlr_tot_financ = (vlr_bem - entrada) + tac;

            lb_vlr_tot_financ.Text = vlr_tot_financ.ToString();

            coeficiente = Financial.Pmt((taxa / 100), prazo, -100) / 100;

            parcela = Financial.Pmt((taxa / 100), prazo, -vlr_tot_financ);

            lb_coeficiente.Text = Math.Round(coeficiente,5).ToString();

            lb_parcela.Text = Math.Round(parcela,2).ToString();

        }

        private void Converter()
        {
            try
            {
                vlr_bem = double.Parse(tb_vlr_veiculo.Text);
                entrada = double.Parse(tb_entrada.Text);
                tac = double.Parse(tb_tac.Text);
                taxa = double.Parse(tb_taxa.Text);
                prazo = Convert.ToInt32(cb_prazos.Text);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
