﻿// <autogenerated>
//   This file was generated by T4 code generator AngularGenerator.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


var crudControllers = angular.module('crudControllers', []);

crudControllers.controller('fullViewController', function ($scope, $route, $location) {
    $scope.$on('$routeChangeSuccess', function () {
        var path = $location.path();
        console.log(path);
        $scope.showEmployer = false;
        $scope.showEmployee = false;
        if (path === '/employer') {
            $scope.showEmployer = true;
        } else if (path.lastIndexOf('/Employees', 0) === 0) {
            $scope.showEmployer = true;
            $scope.showEmployee = true;
        } else {
            $scope.showEmployer = true;
        }
    });
});

	crudControllers.controller('employeeController', function ($scope, $http, $stateParams) {
	    $http.get('../api/Employee/' + $stateParams.id).success(function (data) {
        $scope.employee = data;
    });
}
);

	
	crudControllers.controller('employerController', function ($scope, $http) {
    $http.get('../api/Employer').success(function (data) {
        $scope.employer = data;
    });
}
);

	
	crudControllers.controller('salarycalculationController', function ($scope, $http) {
    $http.get('../api/SalaryCalculation').success(function (data) {
        $scope.salarycalculation = data;
    });
}
);

	
	crudControllers.controller('taxcardController', function ($scope, $http) {
    $http.get('../api/Taxcard').success(function (data) {
        $scope.taxcard = data;
    });
}
);

	