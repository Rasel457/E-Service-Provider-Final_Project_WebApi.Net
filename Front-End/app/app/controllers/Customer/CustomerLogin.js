app.controller("CustomerLogin",function($scope,$http,ajax,$location){
    $scope.login=function(){
        ajax.post("api/login",$scope.data,success,error);
        function success(response){
            console.log(response.data);
            localStorage.setItem("token",response.data.AccessToken);
            $location.path("/CustomerHome");
        }
        function error(error){
            console.log(error);
        }
        
        
    }

});