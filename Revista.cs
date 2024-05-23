namespace TercerParcial
{
    public class Revista : Libro
    {
        public string Volumen {  get; set; }
        public string NumEjemplar { get; set; }

        public Revista()
        {
            Volumen = string.Empty;
            NumEjemplar = string.Empty;
        }
    }
}
