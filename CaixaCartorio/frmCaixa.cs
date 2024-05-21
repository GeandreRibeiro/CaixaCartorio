using System.Drawing.Printing;
using System.Runtime.CompilerServices;

namespace CaixaCartorio
{
    public partial class frmCaixa : Form
    {
        public int Codigo { get; set; }

        private DataBase _dataBase;
        public frmCaixa(DataBase database)
        {
            _dataBase = database;
            InitializeComponent();
        }


        private void frmCaixa_Load(object sender, EventArgs e)
        {
            dtLancamento.Value = DateTime.Now;
            dtInicial.Value = DateTime.Now;
            dtFinal.Value = DateTime.Now;
            cbForma.SelectedIndex = 0;
            chTodos.Checked = true;

            this.carregarLista();

        }

        private void frmCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dataBase.Desconectar();
        }

        private void txEntrada_Validated(object sender, EventArgs e)
        {
            try
            {
                decimal valor;
                valor = decimal.Parse(txEntrada.Text);

                if (valor != 0) { txSaida.Enabled = false; cbForma.Focus(); } else { txSaida.Enabled = true; }

                txEntrada.Text = valor.ToString(Util.FormatarMoeda());
            }
            catch (Exception)
            {

                txEntrada.Text = "0,00";
                txEntrada.Focus();
            }
        }

        private void txSaida_Validated(object sender, EventArgs e)
        {
            try
            {
                decimal valor;
                valor = decimal.Parse(txSaida.Text);

                if (valor != 0) { txEntrada.Text = "0,00"; txEntrada.Enabled = false; cbForma.Focus(); } else { txEntrada.Enabled = true; }

                txSaida.Text = valor.ToString(Util.FormatarMoeda());
            }
            catch (Exception)
            {

                txSaida.Text = "0,00";
                txSaida.Focus();
            }
        }

        private void txEntrada_Enter(object sender, EventArgs e)
        {
            txEntrada.SelectAll();

        }

        private void txSaida_Enter(object sender, EventArgs e)
        {
            txSaida.SelectAll();
        }

        private void frmCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            this.carregarLista();

        }

        private void carregarLista()
        {
            List<DTOCaixa> lista = _dataBase.Listar(dtInicial.Value, dtFinal.Value, chFiltroDeposito.Checked, chTodos.Checked); ;
            dataGridView1.DataSource = lista;
            dataGridView1.Refresh();

            DtoTotais daTotais = new DtoTotais(lista);
            lbTotalEntrada.Text = daTotais.TotalEntrada.ToString(Util.FormatarMoeda());
            lbTotalSaida.Text = daTotais.TotalSaida.ToString(Util.FormatarMoeda());
            lbTotalDeposito.Text = daTotais.TotalEntradaDeposito.ToString(Util.FormatarMoeda());

            decimal totalGeral = daTotais.TotalEntrada - daTotais.TotalSaida;

            lbTotalGeral.Text = totalGeral.ToString(Util.FormatarMoeda());
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            DTOCaixa dto = CarregarObjeto();

            if (_dataBase.GravarCaixa(dto))
            {
                LimparCampos();
                carregarLista();
            }
        }

        private DTOCaixa CarregarObjeto()
        {
            if (ValidarCampos())
            {
                DTOCaixa dto = new DTOCaixa();
                dto.Codigo = this.Codigo;
                dto.Data = dtLancamento.Value;
                dto.Historico = txHistorico.Text;
                dto.Entrada = decimal.Parse(txEntrada.Text);
                dto.Saida = decimal.Parse(txSaida.Text);
                dto.Forma = cbForma.Text;
                dto.DepositoFuturo = chDeposito.Checked;

                return dto;
            }

            LimparCampos();
            return new DTOCaixa();

        }

        private bool ValidarCampos()
        {
            if (txHistorico.Text == string.Empty)
            {
                MessageBox.Show("O campo histórico precisa ser informado.");
                txHistorico.Focus();
                return false;
            }

            decimal entrada = decimal.Parse(txEntrada.Text);
            decimal saida = decimal.Parse(txSaida.Text);

            if (entrada == 0 && saida == 0)
            {
                MessageBox.Show("Informe um valor para o lançamento.");
                txEntrada.Focus();
                return false;
            }

            if (entrada > 0 && saida > 0)
            {
                MessageBox.Show("Não é permitido lançar dois valores.");
                txEntrada.Focus();
                return false;
            }

            if (chDeposito.Checked && saida > 0)
            {
                MessageBox.Show("Não é permitido lançar saída para depósito.");
                LimparCampos();
                return false;
            }

            return true;

        }

        private void LimparCampos()
        {
            this.Codigo = 0;
            txHistorico.Text = string.Empty;
            txEntrada.Text = "0,00";
            txEntrada.Enabled = true;
            txSaida.Text = "0,00";
            txSaida.Enabled = true;
            cbForma.SelectedIndex = 0;
            chDeposito.Checked = false;
            dtLancamento.Value = DateTime.Now;
            dtLancamento.Focus();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

                if (row == null) { return; }
                if (row.DataBoundItem == null) { return; }

                DTOCaixa dto = (DTOCaixa)row.DataBoundItem;
                CarregarForm(dto);
                txHistorico.Focus();
            }
        }

        private void CarregarForm(DTOCaixa dto)
        {
            if (dto == null) { return; }

            this.Codigo = dto.Codigo;
            dtLancamento.Value = dto.Data;
            txHistorico.Text = dto.Historico;
            if (dto.Entrada > 0)
            {
                txEntrada.Text = dto.Entrada.ToString(Util.FormatarMoeda());
                txSaida.Enabled = false;
            }
            if (dto.Saida > 0)
            {
                txSaida.Text = dto.Saida.ToString(Util.FormatarMoeda());
                txEntrada.Enabled = false;
            }

            chDeposito.Checked = dto.DepositoFuturo;

            int i = 0;
            foreach (var item in cbForma.Items)
            {
                if (item.ToString() == dto.Forma)
                {
                    cbForma.SelectedIndex = i;
                    return;
                }
                i++;
            }

        }

        private void conferirLançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport(_dataBase);
            frm.ShowDialog();
        }
    }
}