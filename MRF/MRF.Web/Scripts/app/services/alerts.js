(function() {
    'use strict';

    var serviceId = 'alerts';

    angular.module('mrfApp').factory(serviceId,
        function() {
            return window.alerts;
        });

})();