﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCs
{
    public class Pessoa
    {
        private string nome;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
        }

    }
}

