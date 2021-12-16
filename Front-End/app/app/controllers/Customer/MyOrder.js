app.controller("MyOrder",function($scope,$http,ajax){
    ajax.get("api/CustomerHome/MyOrder",success,error);
    function success(response){
        $scope.orders=response.data;
        //console.log(response.data);
    }
    function error(error){
       console.log(error);
    }

});