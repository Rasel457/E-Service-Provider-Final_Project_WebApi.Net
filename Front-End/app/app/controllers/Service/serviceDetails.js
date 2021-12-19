app.controller("serviceDetails",function($scope,ajax,$routeParams,$location){
    ajax.get("api/CustomerService/WithComment/"+$routeParams.id,success,error);
    function success(response){
        $scope.s=response.data;
    }
    function error(error){
        console.log(error);
    }
   

    $scope.submit=function(){
        var data = {
                    service_id:$routeParams.id,
                    comment1:$scope.comment1,
                    user_id:JSON.parse(localStorage.getItem("UserId"))
              
                 };
        //console.log(data);
        ajax.post("api/CustomerHome/AddComment", data, success, error)
        function success(response){
        console.log(response);
        $location.path("/CustomerHome/AllService");
            alert("Comment send Successfully");
        }
        function error(error){
            console.log(error);
            alert("Failed To Added !!!!");
        }
     }          
    

});