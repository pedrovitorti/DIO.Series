using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace DIO.Series.Classes
//removi o .Classes para essa classe abstrata ser vista em toda a solução
namespace DIO.Series
{
    //Classe abstrata
    public abstract class EntidadeBase
    {
        //todos que herdarem essa classe irão possuir um Id
        public int Id { get; protected set; }
    }
}
