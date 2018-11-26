﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XF.Recursos.Lista
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
