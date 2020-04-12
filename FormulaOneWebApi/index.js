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

    let _btnTeamById = $('#btnSearchTeamId');
    let _btnDriverById = $('#btnSearchDriverId');
    let _btnCountryByCode = $('#btnSearchCountryCode');

    _btnTeamById.on('click', () => {
        let id = $('#txtIdTeam').val();
        //search team by id
    });

    _btnDriverById.on('click', () => {
        let id = $('#txtIdDriver').val();
        //search driver by id
    });

    _btnCountryByCode.on('click', () => {
        let id = $('#txtCodeCountry').val();
        //search country by code
    });
});

function loadDrivers() {
    sendRequest("/Drivers", "get", data => {
        app.teams = [];
        app.countries = [];
        app.drivers = data;
    });
}

function loadTeams() {
    sendRequest("/Teams", "get", data => {
        app.teams = data;
        app.countries = [];
        app.drivers = [];
    });
}

function loadCountries() {
    sendRequest("/Countries", "get", data => {
        app.teams = [];
        app.countries = data;
        app.drivers = [];
    });
}

function sendRequest(parameters, method, callback) {
    let _richiesta = $.ajax({
        url: "api" + parameters,
        type: method.toUpperCase(),
        data: "",
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        dataType: "json",
        timeout: 5000
    });

    _richiesta.done(callback);
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