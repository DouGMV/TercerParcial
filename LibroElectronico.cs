namespace TercerParcial
{
    public class LibroElectronico : Libro
    {
        public string Formato {  get; set; }
        public string Tamanio { get; set; }

        public LibroElectronico() 
        { 
            Formato = string.Empty;
            Tamanio = string.Empty;
        }
    }
}
