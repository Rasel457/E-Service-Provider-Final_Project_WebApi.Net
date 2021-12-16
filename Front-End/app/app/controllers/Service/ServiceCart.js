app.controller("ServiceCart",function($scope,$http,$location){
    //$scope.value = "Wellcome";
     //$location.path("/products");
     $scope.carts=  JSON.parse(localStorage.getItem("cart"));
     var s=JSON.parse(localStorage["cart"]);
     $scope.submit=function(){
        var o = {
            delevery_address: $scope.delevery_address
         };
         console.log(o);
         console.log(s);
          $http.post("https://localhost:44348/api/CustomerService/Checkout",s, o).
          then(function(response){
              console.log(response);
             $location.path("/CustomerHome/MyOrder");
            alert("Order Place Successfully");
         })
    //      function success(response){
    //      console.log(response);
    //      $location.path("/CustomerHome/MyProfile");
    //      //alert("New Project Added Successfully");
    //  }
    //  function error(error){
    //      console.log(error);
    //      alert("Failed To Added !!!!");
    //  }

 }
});