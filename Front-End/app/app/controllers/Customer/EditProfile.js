app.controller("EditProfile",function($scope,$http,ajax,$routeParams,$location){

    $scope.submit=function(){
           var data = {
                id: $scope.id,
                name: $scope.name,
                phone: $scope.phone,
                email: $scope.email,
                password: $scope.password,
                house: $scope.house,
                road: $scope.road
            };
            console.log(data);
            ajax.post("api/CustomerHome/UpdateProfile", data, success, error)
            function success(response){
            console.log(response);
            $location.path("/CustomerHome/MyProfile");
            //alert("New Project Added Successfully");
        }
        function error(error){
            console.log(error);
            alert("Failed To Added !!!!");
        }

    }
    if($routeParams!= null)
    {
        ajax.get("api/CustomerHome/EditProfile/"+$routeParams.id,success,error);
        function success(response){
        $scope.id=response.data.id;
        $scope.name=response.data.name;
        $scope.phone=response.data.phone;
        $scope.email=response.data.email;
        $scope.password=response.data.password;
        $scope.house=response.data.house;
        $scope.road=response.data.road;
       // $scope.p=response.data;
        
    }
        function error(error){
        console.log(error);
        }
    }
    

});