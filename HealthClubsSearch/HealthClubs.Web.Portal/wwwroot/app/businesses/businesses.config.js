"use strict";

(function () {

    angular.module("app.businesses")
        .config(["$stateProvider", "$locationProvider", "$urlRouterProvider", initrouter]);

    function initrouter($stateProvider, $locationProvider, $urlRouterProvider){
        $locationProvider.html5Mode(true);
        $urlRouterProvider.otherwise("/Businesses");
        $stateProvider
            .state(
                "addbusiness", {
                    url: "/AddBusiness",
                    templateUrl: "app/businesses/add.html",
                    controller: "BusinessesController",
                    controllerAs: "vm"
                }
            );
    }

})();