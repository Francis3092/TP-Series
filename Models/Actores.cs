public class Actores
{
    public int IdActor { get; set; }
    public int IdSerie { get; set; }
    public string Nombre { get; set; }

    public Actores()
    {

    }

    public Actores(int idActor, int idSerie, string nombre)
    {
        IdActor = idActor;
        IdSerie = idSerie;
        Nombre = nombre;
    }
}