app.controller("MyProfile",function($scope,$http,ajax){
    ajax.get("api/CustomerHome/Profile",success,error);
    function success(response){
        $scope.p=response.data;
    }
    function error(error){
       console.log(error);
    }

});