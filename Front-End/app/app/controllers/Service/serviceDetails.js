app.controller("serviceDetails",function($scope,ajax,$routeParams){
    ajax.get("api/CustomerService/WithComment/"+$routeParams.id,success,error);
    function success(response){
        $scope.s=response.data;
    }
    function error(error){
       console.log(error);
    }

});