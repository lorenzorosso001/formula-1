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
    //let _btnSearchScoreId = $('#btnSearchScoresId');

    /*TEAMS*/
    _btnTeamById.on('click', () => {
        if ($('#detailsCard').css("display") === "none")
            $('#detailsCard').css({ "display": "block" });
        let id = $('#txtIdTeam').val() - 1; //id partono da 0!
        $('#txtIdTeam').val("");
        //search team by id
        sendRequest('api/teams/' + id + '/details', 'get', (data) => {
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

    /*DRIVERS*/
    _btnDriverById.on('click', () => {
        if ($('#detailsCard').css("display") === "none")
            $('#detailsCard').css({ "display": "block" });
        let id = $('#txtIdDriver').val(); 
        $('#txtIdDriver').val(""); 
        //search driver by id
        sendRequest('api/drivers/' + id + '/details', 'get', (data) => {
            console.log(data);
            $('#lstDetails').empty();
            for (let item in data) {
                let _li = $('<li>');
                if (item === "Country")
                    _li.html(item + " : " + data[item].CountryName + " (" + data[item].CountryCode + ")");
                else if (item == "Dob") 
                    _li.html(item + " : " + data[item].substring(0, 10));
                else
                    _li.html(item + " : " + data[item]);
                _li.addClass('list-group-item');
                _li.appendTo($('#lstDetails'));
            }
        });
    });

    /*COUNTRIES*/
    _btnCountryByCode.on('click', () => {
        if ($('#detailsCard').css("display") === "none")
            $('#detailsCard').css({ "display": "block" });
        let code = $('#txtCodeCountry').val(); //code
        $('#txtCodeCountry').val("");
        //search country by code
        sendRequest('api/countries/' + code + '/details', 'get', (data) => {
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

    /*CIRCUITS*/
    _btnSearchCircuitId.on('click', () => {
        if ($('#detailsCard').css("display") === "none")
            $('#detailsCard').css({ "display": "block" });
        let id = $('#txtIdCircuit').val()-1; 
        $('#txtIdCircuit').val("");

        sendRequest('api/circuits/' + id + '/details', 'get', (data) => {
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

    /*RACES*/
    _btnSearchRaceId.on('click', () => {
        if ($('#detailsCard').css("display") === "none")
            $('#detailsCard').css({ "display": "block" });
        let id = $('#txtIdRaces').val() - 1;
        $('#txtIdRaces').val("");

        sendRequest('api/races/' + id + '/details', 'get', (data) => {
            console.log(data);
            $('#lstDetails').empty();
            for (let item in data) {
                let _li = $('<li>');
                if (item === "Country")
                    _li.html(item + " : " + data[item].CountryName + " (" + data[item].CountryCode + ")");
                else if (item === "Circuit")
                    _li.html(item + " : " + data[item].Name);
                else if (item == "GrandPrixDate")
                    _li.html(item + " : " + data[item].substring(0, 10));
                else
                    _li.html(item + " : " + data[item]);
                _li.addClass('list-group-item');
                _li.appendTo($('#lstDetails'));
            }
        });
    });

    /*SCORES
    _btnSearchScoreId.on('click', () => {
        if ($('#detailsCard').css("display") === "none")
            $('#detailsCard').css({ "display": "block" });
        let id = $('#txtIdScores').val() - 1;
        $('#txtIdScores').val("");

        sendRequest('/Scores/' + id + '/details', 'get', (data) => {
            console.log(data);
            $('#lstDetails').empty();
            for (let item in data) {
                let _li = $('<li>');
                _li.html(item + " : " + data[item]);
                _li.addClass('list-group-item');
                _li.appendTo($('#lstDetails'));
            }
        });
    });*/
});

function loadDrivers() {
    sendRequest("api/drivers", "get", data => {
        app.teams = [];
        app.countries = [];
        app.drivers = data;
        app.circuits = [];
        app.races = [];
        app.scores = [];
    });
}

function loadTeams() {
    sendRequest("api/teams", "get", data => {
        app.teams = data;
        app.countries = [];
        app.drivers = [];
        app.circuits = [];
        app.races = [];
        app.scores = [];
    });
}

function loadCountries() {
    sendRequest("api/countries", "get", data => {
        app.teams = [];
        app.countries = data;
        app.drivers = [];
        app.circuits = [];
        app.races = [];
        app.scores = [];
    });
}

function loadCircuits() {
    sendRequest("api/circuits", "get", data => {
        app.teams = [];
        app.countries = [];
        app.drivers = [];
        app.circuits = data;
        app.races = [];
        app.scores = [];
    });
}

function loadRaces() {
    sendRequest("api/races", "get", data => {
        app.teams = [];
        app.countries = [];
        app.drivers = [];
        app.circuits = [];
        app.races = data;
        app.scores = [];
    });
}

/*function loadScores() {
    sendRequest("/Scores", "get", data => {
        app.teams = [];
        app.countries = [];
        app.drivers = [];
        app.circuits = [];
        app.races = [];
        app.scores = data;
    });
}*/

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