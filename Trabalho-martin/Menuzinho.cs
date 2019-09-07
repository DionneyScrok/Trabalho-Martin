using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_martin
{
    class Menuzinho
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }

        public Menuzinho(int id, string nome, string senha)
        {
            Id = id;
            Name = nome;
            Pass = senha;;

        }

    }
}
