(function() {
    'use strict';

    var controllerId = 'fareCalculatorController';

    angular.module('mrfApp').controller(controllerId,
        ['$scope', '$http', 'alerts', fareCalculatorController]);

    function fareCalculatorController($scope, $http, alerts) {
        $scope.calculateFare = calculateTaxiFare;

        function calculateTaxiFare() {

            $http.post("/Home/CalculateTaxiFare", $scope.issue)
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