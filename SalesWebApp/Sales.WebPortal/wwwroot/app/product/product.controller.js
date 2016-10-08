(function () {
    "use strict";

    angular
        .module("app.product")
        .controller("ProductController", ["$http", "$location", "$stateParams", ProductController]);


    function ProductController($http, $location, $stateParams) {

        var vm = this;
        //Variables.
        vm.isBusy = true;
        vm.searchOn = "";
        vm.errorMessage = "";
        vm.products = [];

        var url = "http://salesserviceapi.azurewebsites.net/api/Products";

        $http.get(url)
            .then(function (response) {
                // Success
                angular.copy(response.data, vm.products);
                alert(vm.products.products);
            }, function (error) {
                alert('Error' + error.description);
                // Failure
                vm.errorMessage = "Failed to load data: " + error;
            })
            .finally(function () {
                 vm.isBusy = false;
            });

        activate();

        function activate() { }
        
    }

})();