using System;
using System.Collections.Generic;
using DIOProjetoFinal.Interfaces;

namespace DIOProjetoFinal.Entities
{
    public class SeriesRepositorio : IRepositorio<Series>
    {   
        private List<Series> listaSeries = new List<Series>();

        void IRepositorio<Series>.Atualiza(int id, Series entidade)
        {
            listaSeries[id] = entidade;
        }

        void IRepositorio<Series>.Exclui(int id)
        {
            listaSeries[id].Excluir();
        }

        void IRepositorio<Series>.Insere(Series entidade)
        {
            listaSeries.Add(entidade);
        }

        List<Series> IRepositorio<Series>.Lista()
        {
            return listaSeries;
        }

        int IRepositorio<Series>.ProximoId()
        {
            return listaSeries.Count;
        }

        Series IRepositorio<Series>.RetornaPorId(int id)
        {
            return listaSeries[id];
        }
    }
}
