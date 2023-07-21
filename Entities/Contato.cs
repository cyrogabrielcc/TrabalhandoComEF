using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhandoComEF.Entities
{
    public class Contato
    {
        public int ContatoId { get; set; }
        public string NomeContato  { get; set; }

        public string Telefone  { get; set; }
        public string Ativo  { get; set; }
    }
}