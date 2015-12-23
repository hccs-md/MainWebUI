(function() {
	"use strict";

	window.app.directive('editPerson', editPerson);

	function editPerson() {
		return {
			scope: {
				person: "="
			},
			templateUrl: '/person/template/editPerson.tmpl.cshtml',
			controller: controller,
			controllerAs: 'vm'
		}
	}

	controller.$inject = ['$scope', 'personSvc'];
	function controller($scope, personSvc) {
		var vm = this;
		vm.save = save;

		vm.saving = false;
		vm.person = angular.copy($scope.person);
		vm.errorMessage = null;

		function save() {
			vm.saving = true;
			personSvc.update($scope.person, vm.person)
				.success(function () {
					//Close the modal
					$scope.$parent.$close();
				})
				.error(function(data) {
					vm.errorMessage = 'There was a problem saving changes to the family member: ' + data;
				})
				.finally(function() {
					vm.saving = false;
				});
		}
	}
})();