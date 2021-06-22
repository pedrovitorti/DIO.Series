using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO.Series.Interfaces; //namespace para usar a interface

namespace DIO.Series
{

    //se fosse um repositorio de filmes? seria: 
    //class SerieRepositorio : IRepositorio<Filmes> //Aqui eu passo a classe, ele irá implementar um repositório de filmes
    //{
    //}
    
    //botão direito e clicar em implementar interface, ele gera automático os métodos 
    class SerieRepositorio : IRepositorio<Serie> //Aqui eu passo a classe, ele irá implementar um repositório de serie(T)
    {

        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            //ele remove e reclassifica os outros índices, pode causar inconsistência 
            //listaSerie.RemoveAt(id);
            listaSerie[id].Excluir(); // só iremos marcar como excluído

            //implementar envio de email quando excluir uma série 
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
