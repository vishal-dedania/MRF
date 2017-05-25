(function() {
    'use strict';

    window.onerror = function(msg) {
        if (window.alerts) {
            window.alerts.error("There was a problem with your last action.  Please reload the page, then try again.");
        } else {
            alert("Something serious went wrong.  Please close out of Fail Tracker, then try again.");
        }
    };

    var id = 'mrfApp';
    window.app = angular.module(id, []).directive("numberValidate",
        function() {
            // requires an isloated model
            return {
                restrict: 'AEC',
                require: 'ngModel',
                link: function(scope, ele, attrs, ctrl) {
                    ctrl.$parsers.unshift(function(value) {
                        var valid = /^\s*(\-|\+)?(\d+|(\d*(\.\d*)))\s*$/.test(value);
                        if (valid && value <= 0) valid = false;
                        if (value) {
                            ctrl.$setValidity('invalidNumber', valid);
                        }

                        // if it's valid, return the value to the model,
                        // otherwise return undefined.
                        return valid ? value : undefined;
                    });
                }
            }
        });
})();