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
                .success(function(data) {
                    $scope.originalIssue = angular.extend({}, data);

                    $scope.editing = false;

                    alerts.success("Your changes have been saved!");
                })
                .error(function(data) {
                    if (data.errorMessage) {
                        alerts.error("There was a problem saving the issue: \n" +
                            data.errorMessage +
                            "\nPlease try again.");
                    } else {
                        alerts.error("There was a problem saving the issue.  Please try again.");
                    }
                });
        }
    }
})();