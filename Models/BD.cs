using System.Data.SqlClient;
using Dapper;

public static class BD
{
    private static string _ConnectionString = @"Server=localhost; DataBase=BDSeries; Trusted_Connection=True;";

    //Ver cual de estas hace falta y cual no

    public static List<Series> ObtenerSeries()
    {
        List<Series> _ListadoSeries = new List<Series>();

        using (SqlConnection db = new SqlConnection(_ConnectionString))
        {
            string SQL = "SELECT * FROM Series";
            _ListadoSeries = db.Query<Series>(SQL).ToList();
        }

        return _ListadoSeries;
    }

    public static Series ObtenerSerie(int serie)
    {
        Series Serie = null;

        using (SqlConnection db = new SqlConnection(_ConnectionString))
        {
            string SQL = "SELECT * FROM Series WHERE IdSerie = @pSerie";
            Serie = db.QueryFirstOrDefault<Series>(SQL, new { pSerie = serie });
        }
        return Serie;
    }

    public static List<Actores> ObtenerActores()
    {
        List<Actores> _ListadoActores = new List<Actores>();

        using (SqlConnection db = new SqlConnection(_ConnectionString))
        {
            string SQL = "SELECT * FROM Actores";
            _ListadoActores = db.Query<Actores>(SQL).ToList();
        }

        return _ListadoActores;
    }

    public static Actores ObtenerActor(int actor)
    {
        Actores Actor = null;

        using (SqlConnection db = new SqlConnection(_ConnectionString))
        {
            string SQL = "SELECT * FROM Actores WHERE IdActor = @pActor";
            Actor = db.QueryFirstOrDefault<Actores>(SQL, new { pActor = actor });
        }
        
        return Actor;
    }

    public static List<Temporadas> ObtenerTemporadas()
    {
        List<Temporadas> _ListadoTemporadas = new List<Temporadas>();

        using (SqlConnection db = new SqlConnection(_ConnectionString))
        {
            string SQL = "SELECT * FROM Temporadas";
            _ListadoTemporadas = db.Query<Temporadas>(SQL).ToList();
        }

        return _ListadoTemporadas;
    }

    public static Temporadas ObtenerTemporada(int temporada)
    {
        Temporadas Temporada = null;

        using (SqlConnection db = new SqlConnection(_ConnectionString))
        {
            string SQL = "SELECT * FROM Temporadas WHERE IdTemprorada = @pTemporada";
            Temporada = db.QueryFirstOrDefault<Temporadas>(SQL, new { pTemporada = temporada });
        }

        return Temporada;
    }

}