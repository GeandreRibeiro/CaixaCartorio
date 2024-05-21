using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaCartorio
{
    public class DToSaldoAnterior
    {
        public decimal Saldo { get; set; }
        private DataBase _database;
        private DateTime _dataAlvo;
        public DToSaldoAnterior(DataBase dataBase, DateTime dataAlvo)
        {
            _database = dataBase;
            _dataAlvo = dataAlvo;
            Calcular();
        }

        private void Calcular()
        {
            DateTime dtInicial = _dataAlvo.AddDays(-1);
            DateTime dtFinal = dtInicial.AddDays(-30);

            var dto = _database.Listar(dtInicial, dtFinal, false, true);

            DtoTotais totais = new DtoTotais(dto);

            decimal entradas = totais.TotalEntrada;
            decimal saidas = totais.TotalSaida;

            this.Saldo = entradas - saidas;

        }
    }
}
