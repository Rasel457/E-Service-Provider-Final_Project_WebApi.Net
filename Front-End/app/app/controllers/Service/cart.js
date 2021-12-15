app.controller("cart",function($scope,ajax,$routeParams){
    ajax.get("api/CustomerService/GetById/"+$routeParams.id,success,error);

    function success(response){

        //console.log(response.data);
        let services = [];
        services.push(response.data);
        
        var old = localStorage.getItem('cart');
        if (old === null) {
        localStorage.setItem("cart", JSON.stringify(services));
        } else {
        old = JSON.parse(old);
        localStorage.setItem('cart', JSON.stringify(old.concat(services)));
       }
        // localStorage.clear("products");
        $scope.carts=  JSON.parse(localStorage.getItem("cart"));


       
        // $scope.cart=  found;
      //  $scope.s=response.data;
    }
    function error(error){
       console.log(error);
    }

});

