(function() {
    'use strict';

    var controllerId = 'fareCalculatorController';

    angular.module('mrfApp').controller(controllerId,
        ['$scope', '$http', 'fareCalculatorConfig', 'model', fareCalculatorController]);

    function fareCalculatorController($scope, $http, fareCalculatorConfig, model) {
        var vm = this;

        //model.startDateTime = new Date(model.startDateTime);
        vm.ride = model;
        convertJsonStringToDate(vm.ride.startDateTime);
        vm.calculateTaxiFare = calculateTaxiFare;

        function convertJsonStringToDate(val) {
            vm.ride.startDateTime = new Date(val);
        }

        function calculateTaxiFare() {
            vm.success = false;
            vm.errorMessage = null;

            $http.post(fareCalculatorConfig.postBackUrl, vm.ride)
                .then(function successCallback(response) {
                        vm.success = true;
                        vm.ride = response.data;
                        convertJsonStringToDate(vm.ride.startDateTime);
                    },
                    function errorCallback(msg) {
                        vm.errorMessage = msg;
                    });
        }
    }
})();