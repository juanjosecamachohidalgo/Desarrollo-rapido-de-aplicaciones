using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MaestroDetalleCodeFirstEFWpfApp
{
    public partial class Categoria
    {
        public Categoria()
        {
            this.Productos = new ObservableCollection<Producto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ObservableCollection<Producto> Productos { get; private set; } 
    }
}
