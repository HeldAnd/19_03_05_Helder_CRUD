(function () {
    var app = angular.module('MacApp', ['ngRoute']);
    app.controller('HomeController', function ($scope) {
        $scope.Mensagem = "AgularJS  in ASP .NEt.";
    });
})();