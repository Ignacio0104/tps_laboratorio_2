namespace BibliotecaDeClases
{
    public class Producto
    {
        private string nombreProducto;
        private double precioProducto;
        private int stockProducto;
        private static int ultimoId;
        private int idProducto;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int StockProducto { get => stockProducto; set => stockProducto = value; }


        static Producto()
        {
            ultimoId = 2000;
        }

        public Producto() { }

        public Producto(string nombreProducto,double precioProducto, int stockProducto)
        {
            this.idProducto = ultimoId;
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.stockProducto = stockProducto;
            ultimoId+=100;
        }

        public override string ToString()
        {
            return nombreProducto + " - $" + precioProducto;
        }
    }
}