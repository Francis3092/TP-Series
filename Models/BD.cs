using System.Data.SqlClient;
using Dapper;

public static class BD
{
    private static string _ConnectionString = @"Server=localhost; DataBase=BDSeries; Trusted_Connection=True;";

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

    public static Series ObtenerSerie(int idSerie)
    {
        Series Serie = null;

        using (SqlConnection db = new SqlConnection(_ConnectionString))
        {
            string SQL = "SELECT * FROM Series WHERE IdSerie = @pIdSerie";
            Serie = db.QueryFirstOrDefault<Series>(SQL, new { pIdSerie = idSerie });
        }
        return Serie;
    }

    public static List<Actores> ObtenerActores(int idSerie)
    {
        List<Actores> _ListadoActores = new List<Actores>();

        using (SqlConnection db = new SqlConnection(_ConnectionString))
        {
            string SQL = "SELECT * FROM Actores WHERE IdSerie = @pIdSerie";
            _ListadoActores = db.Query<Actores>(SQL, new { pIdSerie = idSerie } ).ToList();
        }

        return _ListadoActores;
    }

    public static List<Temporadas> ObtenerTemporadas(int idSerie)
    {
        List<Temporadas> _ListadoTemporadas = new List<Temporadas>();

        using (SqlConnection db = new SqlConnection(_ConnectionString))
        {
            string SQL = "SELECT * FROM Temporadas WHERE IdSerie = @pIdSerie";
            _ListadoTemporadas = db.Query<Temporadas>(SQL, new { pIdSerie = idSerie } ).ToList();
        }

        return _ListadoTemporadas;
    }

}