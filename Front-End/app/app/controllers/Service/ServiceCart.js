app.controller("ServiceCart",function($scope,$http,$location){
     $scope.carts=  JSON.parse(localStorage.getItem("cart"));
     var s=JSON.parse(localStorage.getItem("cart"));
     $scope.submit=function(){
        var o = {
            delevery_address: $scope.delevery_address
      
         };
       
        // console.log(o);
         //console.log(s);
         var data={
            Service:s,
            Address:$scope.delevery_address,
            //Address2:$scope.delevery_address
           
         };
         localStorage.clear("cart");
         //console.log(data);
          $http.post("https://localhost:44348/api/CustomerService/Checkout",data).
          then(function(response){
              console.log(response);
             $location.path("/CustomerHome/MyOrder");
            alert("Order Place Successfully");
         })

 }
});