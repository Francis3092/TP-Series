function MostrarDetalleTemporadas(idS) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/VerDetalleTemporadas',
        data: { IdSerie: idS },
        success:
            function (response) {
                var content = "<ul>";
                response.forEach(element => {
                    content += "<li>" + element.tituloTemporada + "<li>";
                });
                $("#TemporadasContent").html(content);
            }
    });
}

function MostrarDetalleActores(idS) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/VerDetalleActores',
        data: { IdSerie: idS },
        success:
            function (response) {
                var content = "<ul>";
                response.forEach(element => {
                    content += "<li>" + element.nombre + "</li>";
                });
                $("#ActoresContent").html(content);
            }
    })
}

function MostrarDetalleSeries(idS) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/VerDetalleSeries',
        data: { IdSerie: idS },
        success:
            function (response) {
                $("#SeriesContent").html(response.sinopsis);
            }
    })
}