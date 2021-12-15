app.controller("search",function($scope,ajax,$routeParams){
    $scope.submit=function(){
        //alert("Submited");
       var data ={
           type:$scope.type
        };
      
      //console.log(data);
     // var myJSON = JSON.stringify(data);
     // const obj = JSON.parse(myJSON);
     // var catagory=obj.type;
      //console.log(catagory);

        ajax.post("api/CustomerService/Search",data, success, error)
        function success(response){
            $scope.services=response.data;
            //console.log(response.data);
            
        }
        function error(error){
            console.log(error);
            //alert("Failed To Added !!!!");
        }
 
    }
});
