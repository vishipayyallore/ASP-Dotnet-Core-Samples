(function () {
    "use strict";

    angular
        .module("app.businesses")
        .controller("BusinessesController", ["$http", "$location", "$stateParams", BusinessesController]);


    function BusinessesController($http, $location, $stateParams) {

        var vm = this;
        //Variables.
        vm.isBusy = true;
        vm.searchOn = "";
        vm.errorMessage = "";
        vm.businesses = [];
        vm.rating = 3.5;

        var url = "http://healthclubsservicesapi.azurewebsites.net/api/BusinessEntities";
        //"http://salesserviceapi.azurewebsites.net/api/Products";

        $http.get(url)
            .then(function (response) {
                // Success
                angular.copy(response.data.businesses, vm.businesses);
                //alert(vm.businesses[0].businessName);
            }, function (error) {
                alert('Error : ' + error.statusText);
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