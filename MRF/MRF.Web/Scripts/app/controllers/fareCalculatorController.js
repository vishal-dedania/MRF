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

        function calculateTaxiFare() {
            vm.success = false;
            vm.errorMessage = null;

            $http.post(fareCalculatorConfig.postBackUrl, vm.ride)
                .then(function successCallback(response) {
                        vm.success = true;
                        vm.ride = response.data;
                    },
                    function errorCallback(msg) {
                        vm.errorMessage = msg;
                    });
        }
    }
})();