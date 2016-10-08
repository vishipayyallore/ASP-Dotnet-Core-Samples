(function() {
    "use strict";

    angular
        .module("app.home")
        .controller("HomeController", HomeController);

    function HomeController() {
        var vm = this;
        alert('Hi');
        activate();

        function activate() {
        }
    }

})();