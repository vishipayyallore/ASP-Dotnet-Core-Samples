"use strict";

(function () {

    angular.module("app.product")
        .config(["$stateProvider", "$locationProvider", "$urlRouterProvider", initrouter]);

    function initrouter($stateProvider, $locationProvider, $urlRouterProvider){
        $locationProvider.html5Mode(true);
        $urlRouterProvider.otherwise("/Product");
        $stateProvider
            .state(
                "addproduct", {
                    url: "/AddProduct",
                    templateUrl: "app/product/add.html",
                    controller: "ProductController",
                    controllerAs: "vm"
                }
            );
    }

})();