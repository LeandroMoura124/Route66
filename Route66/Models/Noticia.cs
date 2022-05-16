using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Route66.Models
{
    public class Noticia
    {
        public int NoticiaID { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }


        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiaID = 1,
                    Categoria="Esportes",
                    Titulo = "O time da escola DST ganha!",
                    Conteudo = "O time da escola vence de 5x1 contra fofoca y programa",
                    Data=new DateTime(25/04/2022)
                }

            };
            return retorno;
        }

   

    }
}

