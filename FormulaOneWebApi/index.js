"use strict";

let app;

$(function () {
    app = new Vue({
        el: "#app",
        data: {
            teams: [],
            drivers: [],
            countries: [],
            circuits: [],
            races: [],
            scores: []
        }
    });

    let _btnTeamById = $('#btnSearchTeamId');
    let _btnDriverById = $('#btnSearchDriverId');
    let _btnCountryByCode = $('#btnSearchCountryCode');
    let _btnSearchCircuitId = $('#btnSearchCircuitId');
    let _btnSearchRaceId = $('#btnSearchRaceId');
    let _btnSearchScoreId = $('#btnSearchScoresId');

    _btnTeamById.on('click', () => {
        if ($('#detailsCard').css("display") === "none")
            $('#detailsCard').css({ "display": "block" });
        let id = $('#txtIdTeam').val() - 1; //id partono da 0!
        $('#txtIdTeam').val("");
        //search team by id
        sendRequest('/Teams/' + id + '/details', 'get', (data) => {
            console.log(data);
            $('#lstDetails').empty();
            for(let item in data) {
                let _li = $('<li>');
                if (item === "Country")
                    _li.html(item + " : " + data[item].CountryName + " (" + data[item].CountryCode + ")");
                else if (item === "FirstDriver" || item === "SecondDriver")
                    _li.html(item + " : " + data[item].Lastname + " " + data[item].Firstname);
                else
                    _li.html(item + " : " + data[item]);
                _li.addClass('list-group-item');
                _li.appendTo($('#lstDetails'));
            }
        });
    });

    _btnDriverById.on('click', () => {
        if ($('#detailsCard').css("display") === "none")
            $('#detailsCard').css({ "display": "block" });
        let id = $('#txtIdDriver').val(); 
        $('#txtIdDriver').val(""); 
        //search driver by id
        sendRequest('/Drivers/' + id + '/details', 'get', (data) => {
            console.log(data);
            $('#lstDetails').empty();
            for (let item in data) {
                let _li = $('<li>');
                if (item === "Country")
                    _li.html(item + " : " + data[item].CountryName + " (" + data[item].CountryCode + ")");
                else
                    _li.html(item + " : " + data[item]);
                _li.addClass('list-group-item');
                _li.appendTo($('#lstDetails'));
            }
        });
    });

    _btnCountryByCode.on('click', () => {
        if ($('#detailsCard').css("display") === "none")
            $('#detailsCard').css({ "display": "block" });
        let code = $('#txtCodeCountry').val(); //code
        $('#txtCodeCountry').val("");
        //search country by code
        sendRequest('/Countries/' + code + '/details', 'get', (data) => {
            console.log(data);
            $('#lstDetails').empty();
            for (let item in data) {
                let _li = $('<li>');
                _li.html(item + " : " + data[item]);
                _li.addClass('list-group-item');
                _li.appendTo($('#lstDetails'));
            }
        });
    });
});

function loadDrivers() {
    sendRequest("/Drivers", "get", data => {
        app.teams = [];
        app.countries = [];
        app.drivers = data;
        app.circuits = [];
        app.races = [];
        app.scores = [];
    });
}

function loadTeams() {
    sendRequest("/Teams", "get", data => {
        app.teams = data;
        app.countries = [];
        app.drivers = [];
        app.circuits = [];
        app.races = [];
        app.scores = [];
    });
}

function loadCountries() {
    sendRequest("/Countries", "get", data => {
        app.teams = [];
        app.countries = data;
        app.drivers = [];
        app.circuits = [];
        app.races = [];
        app.scores = [];
    });
}

function sendRequest(parameters, method, callback) {
    let _richiesta = $.ajax({
        //url: "api" + parameters,
        url: parameters,
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