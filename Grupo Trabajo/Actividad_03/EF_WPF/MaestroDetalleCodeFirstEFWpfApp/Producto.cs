﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaestroDetalleCodeFirstEFWpfApp
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categorias { get; set; } 
    }
}
