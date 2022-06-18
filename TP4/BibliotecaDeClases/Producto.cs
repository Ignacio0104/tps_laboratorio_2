namespace BibliotecaDeClases
{
    public delegate void DelegadoStock();
    public class Producto
    {
        public event DelegadoStock InformarNoHayStock; //Se crea este evento para que ser llamado al acabarse el stock
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
            this.idProducto = Blockbuster.BuscarUltimoIdProducto() + 100;
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.stockProducto = stockProducto;

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
                if(InformarNoHayStock is not null) //Verificamos que alguien este suscripto al evento
                {
                    InformarNoHayStock();
                }
            }
        }

        public bool ValidarQueElEventoNoEsteAsignado() //Este evento sirve para no asignar multiples veces el evento.
        {                                               //al asignar el metodo en el evento CellClick, tengo que evitar asignarlo cada vez que hago click
            if(InformarNoHayStock is not null)
            {
                return false;
            }

            return true;
        }
    }
}