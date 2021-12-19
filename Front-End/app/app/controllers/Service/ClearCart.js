app.controller("ClearCart",function($scope){
    //$scope.value = "Wellcome";
     //$location.path("/products");
     localStorage.removeItem("cart");
    
});