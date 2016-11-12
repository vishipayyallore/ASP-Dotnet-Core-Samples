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
        vm.rating = 3.5;

        var url = "http://salesserviceapi.azurewebsites.net/api/Products";
        //alert(url);
        $http.get(url)
            .then(function (response) {
                // Success
                angular.copy(response.data.products, vm.products);
                //alert(vm.products[0].imageUrl);
            }, function (error) {
                alert('Error : ' + error.statusText);
                // Failure
                vm.errorMessage = "Failed to load data: " + error;
            })
            .finally(function () {
                 vm.isBusy = false;
            });

        vm.getLikesCount = function () {
            var total = 0;
            for (var i = 0; i < vm.products.length; i++) {
                var product = vm.products[i];
                total += product.likesCount;
            }
            return total;
        }

        activate();

        function activate() { }
        
    }

})();