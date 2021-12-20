app.controller("CustomerLogin",function($scope,$http,ajax,$location){
    $scope.login=function(){
        ajax.post("api/login",$scope.data,success,error);
        function success(response){
            //console.log(response.data);
            if(response==null)
            {
                $scope.invalid="Invalid Email or Password";
            }
            localStorage.setItem("UserId",response.data.UserId);
            localStorage.setItem("token",response.data.AccessToken);
            $location.path("/CustomerHome");
        }
        function error(error){
            console.log(error);
        }
        
        
    }

});