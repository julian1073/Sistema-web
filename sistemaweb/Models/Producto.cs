﻿using System;
using System.Collections.Generic;

namespace sistemaweb.Models
{
    public partial class Producto
    {
        public int Idproducto { get; set; }
        public int Idcategoria { get; set; }
        public string Codigo { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual Categoria IdcategoriaNavigation { get; set; }
    }
}
