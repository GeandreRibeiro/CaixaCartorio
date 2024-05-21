using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaCartorio
{
    public partial class frmReport : Form
    {
        private DataBase _dataBase;
        public frmReport(DataBase dataBase)
        {
            InitializeComponent();
            _dataBase = dataBase;
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            dtInicial.Value = DateTime.Now;
            dtFinal.Value = DateTime.Now;
            chTodos.Checked = true;

            CarregarLista();
        }

        private void CarregarLista()
        {
            List<DTOCaixa> lista = _dataBase.Listar(dtInicial.Value, dtFinal.Value, chFiltroDeposito.Checked, chTodos.Checked); ;
            dataGridView1.DataSource = lista;
            dataGridView1.Refresh();

            DtoTotais daTotais = new DtoTotais(lista);
            txEntrada.Text = daTotais.TotalEntrada.ToString(Util.FormatarMoeda());
            txSaida.Text = daTotais.TotalSaida.ToString(Util.FormatarMoeda());

            DToSaldoAnterior saldoAnterior = new DToSaldoAnterior(_dataBase, dtInicial.Value);
            txSaldoAnterior.Text = saldoAnterior.Saldo.ToString(Util.FormatarMoeda());

            decimal totalGeral = (daTotais.TotalEntrada - daTotais.TotalSaida) + saldoAnterior.Saldo;
            decimal saldoAtual = (daTotais.TotalEntrada - daTotais.TotalSaida);

            txTotalGeral.Text = totalGeral.ToString(Util.FormatarMoeda());
            txDepositos.Text = daTotais.TotalEntradaDeposito.ToString(Util.FormatarMoeda());
            txSaldoAtual.Text = saldoAtual.ToString(Util.FormatarMoeda());

        }

    }
}
