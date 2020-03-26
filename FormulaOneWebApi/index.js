"use strict";

let app;

$(function () {
    app = new Vue({
        el: "#app",
        data: {
            teams: [],
            drivers: [],
            countries: []
        }
    });
});

function loadDrivers() {
    let _richiesta = $.ajax({
        url: "api/drivers",
        type: "GET",
        data: "",
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        dataType: "json",
        timeout: 5000
    });

    _richiesta.done(data => {
        app.teams = [];
        app.countries = [];
        app.drivers = data;
    });
    _richiesta.fail(error);
}

function loadTeams() {
    let _richiesta = $.ajax({
        url: "api/Teams",
        type: "GET",
        data: "",
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        dataType: "json",
        timeout: 5000
    });

    _richiesta.done(data => {
        app.teams = data;
        app.countries = [];
        app.drivers = [];
    });
    _richiesta.fail(error);
}

function loadCountries() {
    let _richiesta = $.ajax({
        url: "api/Countries",
        type: "GET",
        data: "",
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        dataType: "json",
        timeout: 5000
    });

    _richiesta.done(data => {
        app.teams = [];
        app.countries = data;
        app.drivers = [];
    });
    _richiesta.fail(error);
}

function error(jqXHR, testStatus, strError) {
    if (jqXHR.status === 0)
        alert("server timeout");
    else if (jqXHR.status === 200)
        alert("Formato dei dati non corretto : " + jqXHR.responseText);
    else
        alert("Server Error: " + jqXHR.status + " - " + jqXHR.responseText);
};