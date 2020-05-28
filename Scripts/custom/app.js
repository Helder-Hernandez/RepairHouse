﻿function manipularTablas() {
    // tabla principal
    var tablePrincipal = $("table[class='table']")[0];
    $(tablePrincipal).addClass("table-striped table-dark table-responsive-md"); // agregamos estilos boostrap
};

function manipularEnlacesInternosTablas() {
    // iconos edit
    $("td a:contains(Edit)").each(function () {
        var editLink = $(this)[0];
        $(editLink).text("");
        $(editLink).attr("title", "Editar");
        $(editLink).append('<button class="btn btn-primary"><i class="fa fa-pencil"></i></button>'); 
    })

    // iconos details
    $("td a:contains(Details)").each(function () {
        var detailsLink = $(this)[0];
        $(detailsLink).text("");
        $(detailsLink).attr("title", "Detalle");
        $(detailsLink).append('<button class="btn btn-secondary"><i class="fa fa-eye"></i></button>'); 
    })


    // iconos delete
    $("td a:contains(Delete)").each(function () {
        var deleteLink = $(this)[0];
        $(deleteLink).text("");
        $(deleteLink).attr("title", "Eliminar");
        $(deleteLink).append('<button class="btn btn-danger"><i class="fa fa-trash"></i></button>');
    })
};

function manipularEnlacesExternosTablas() {
    // enlace crear nuevo
    $("p a:contains(Create New)").each(function () {
        var createLink = $(this)[0];
        $(createLink).text("Crear Nuevo");
        $(createLink).attr("title", "Crear Nuevo");
        $(createLink).addClass("btn btn-success")
        $(createLink).append('<span style="margin-left: 10px"><i class="fa fa-plus"></i></span>');
    })

    // enlace regresar
    $("div a:contains(Back to List)").each(function () {
        var regresarLink = $(this)[0];
        $(regresarLink).text("Regresar");
        $(regresarLink).attr("title", "Regresar");
        $(regresarLink).addClass("btn btn-dark")
        $(regresarLink).prepend('<span style="margin-right: 10px"><i class="fa fa-arrow-left"></i></span>');

    })
};

function manipularInputsCUD() {
    //input Create
    var inputCreate = $("input[value='Create']")[0];
    $(inputCreate).val("Crear");
    $(inputCreate).attr("title", "Crear");
    $(inputCreate).addClass("btn btn-success");

    //input Save
    var inputSave = $("input[value='Save']")[0];
    $(inputSave).val("Guardar");
    $(inputSave).attr("title", "Guardar");
    $(inputSave).addClass("btn btn-success");

     //input Delete
    var inputDelete = $("input[value='Delete']")[0];
    $(inputDelete).val("Eliminar");
    $(inputDelete).attr("title", "Eliminar");
    $(inputDelete).addClass("btn btn-danger");
}

$(document).ready(function () {
    manipularTablas();
    manipularEnlacesInternosTablas();
    manipularEnlacesExternosTablas();
    manipularInputsCUD();
});