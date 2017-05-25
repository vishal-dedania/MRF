(function() {
    'use strict';

    var controllerId = 'fareCalculatorController';

    angular.module('mrfApp').controller(controllerId,
        ['$scope', '$http', 'alerts', 'fareCalculatorConfig', 'model', fareCalculatorController]);

    function fareCalculatorController($scope, $http, alerts, fareCalculatorConfig, model) {
        var vm = this;


        model.startDateTime = new Date(model.startDateTime);
        vm.ride = model;

        vm.calculateTaxiFare = calculateTaxiFare;


        //$scope.calculateFare = calculateTaxiFare;

        function calculateTaxiFare() {

            $http.post(fareCalculatorConfig.postBackUrl, vm.ride)
                .then(function successCallback(response) {
                        alert(response.data.startDateTime);
                    },
                    function errorCallback(response) {
                        alert("Error");
                    });
        }
    }
})();