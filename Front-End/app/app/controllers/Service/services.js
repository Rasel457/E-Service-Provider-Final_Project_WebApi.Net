app.controller("services",function($scope,$http,ajax){
    ajax.get("api/CustomerService/All",success,error);
    function success(response){
        $scope.services=response.data;
       
    }
    function error(error){
       console.log(error);
    }

});