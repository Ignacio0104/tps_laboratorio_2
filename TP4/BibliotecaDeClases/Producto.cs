namespace BibliotecaDeClases
{
    public delegate void DelegadoStock();
    public class Producto
    {
        public event DelegadoStock InformarNoHayStock;
        private string nombreProducto;
        private double precioProducto;
        private int stockProducto;
        private static int ultimoId;
        private int idProducto;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int StockProducto { get => stockProducto; set => stockProducto = value; }


        public Producto() { }

        public Producto(string nombreProducto,double precioProducto, int stockProducto)
        {
            ultimoId = Blockbuster.BuscarUltimoIdProducto();
            this.idProducto = ultimoId + 1;
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.stockProducto = stockProducto;
            ultimoId+=100;
        }

        public override string ToString()
        {
            return nombreProducto + " - $" + precioProducto;
        }

        public void ActualizarStock()
        {
            Blockbuster.BuscarProducto(this.IdProducto).StockProducto--;

            if(Blockbuster.BuscarProducto(this.IdProducto).StockProducto < 1)
            {
                if(InformarNoHayStock is not null)
                {
                    InformarNoHayStock();
                }
            }
        }

        public bool ValidarQueElEventoNoEsteAsignado()
        {
            if(InformarNoHayStock is not null)
            {
                return false;
            }

            return true;
        }
    }
}