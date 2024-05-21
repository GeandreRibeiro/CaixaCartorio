using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Common;
using System.Data;

namespace CaixaCartorio
{
    public class DataBase
    {
        public OleDbConnection Connection { get => connection;}
        public OleDbCommand Command { get => command;}

        private OleDbConnection connection;
        private OleDbCommand command;

        public bool Conectar()
        {
            try
            {
                string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={AppContext.BaseDirectory}\CaixaCartorio.accdb"; ;
                connection = new OleDbConnection(connectionString);
                connection.Open();
                command = connection.CreateCommand();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Desconectar()
        {
            try
            {
                connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<DTOCaixa> Listar( DateTime dataInicial, DateTime dataFinal, bool deposito, bool todos)
        {
            try
            {
                List<DTOCaixa> list = new List<DTOCaixa>();

                string strSQL = "SELECT * FROM CAIXA WHERE " +
                    $"DATA BETWEEN #{dataInicial.ToString("MM/dd/yyyy")}# AND #{dataFinal.ToString("MM/dd/yyyy")}# ";
                
                if (!todos)
                {
                    if (deposito)
                    {
                        strSQL += " AND DEPOSITOFUTURO = TRUE";
                    }
                    else
                    {
                        strSQL += " AND DEPOSITOFUTURO = FALSE";
                    }
                }

                strSQL += " ORDER BY CÓDIGO DESC";

                command = new OleDbCommand(strSQL, connection);

                DataAdapter da = new OleDbDataAdapter(command);
                
                DataSet ds = new DataSet();
                
                da.Fill(ds);
                list.Clear();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    list.Add(new DTOCaixa((int)dr["código"], (DateTime)dr["Data"], dr["Historico"].ToString(), (decimal)dr["Entrada"], (decimal)dr["Saida"], dr["Forma"].ToString(), (bool)dr["DepositoFuturo"]));
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<DTOCaixa>();
            }
            
        }

        public bool GravarCaixa(DTOCaixa caixa)
        {
            try
            {
                string strSQL = GerarSqlGravar(caixa);
                
                if (strSQL == string.Empty) { return false; }

                command = new OleDbCommand(strSQL, connection);
                
                command.Parameters.Add(new OleDbParameter("@Data", caixa.Data.ToString("dd/MM/yyyy")));
                command.Parameters.Add(new OleDbParameter("@Historico", caixa.Historico));
                
                command.Parameters.Add(new OleDbParameter("@Entrada", caixa.Entrada.ToString(Util.FormatarMoeda())));
                command.Parameters.Add(new OleDbParameter("@Saida", caixa.Saida.ToString(Util.FormatarMoeda())));

                command.Parameters.Add(new OleDbParameter("@Forma", caixa.Forma));
                command.Parameters.Add(new OleDbParameter("@DepositoFuturo", caixa.DepositoFuturo));

                if (caixa.Codigo > 0)
                {
                    command.Parameters.Add(new OleDbParameter("@Codigo", caixa.Codigo));
                }

                var ret = command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private string GerarSqlGravar(DTOCaixa caixa)
        {
            string strSQL = "";

            if(caixa == null) { return ""; }

            if(caixa.Codigo == 0) 
            {
                strSQL = "INSERT INTO CAIXA (Data, Historico, Entrada, Saida, Forma, DepositoFuturo" +
                    ")VALUES(@Data, @Historico, @Entrada, @Saida, @Forma, @DepositoFuturo)";
            }
            else
            {
                strSQL = "UPDATE CAIXA SET " +
                    "Data = @Data, Historico = @Historico, Entrada = @Entrada, Saida = @Saida, Forma = @Forma, DepositoFuturo = @DepositoFuturo " +
                    "WHERE Código = @Codigo";
            }

            return strSQL;
        }
    }
}
