app.controller("deleteCart",function($scope,$routeParams){
    var id=$routeParams.id;

    var newCart=[];
    var carts=JSON.parse(localStorage["cart"]);
    var cnt=0;

    for(var i in carts)
    {
        if(carts[i].id!=id  || cnt==1)
        {
            newCart.push(carts[i]);
        }
        else
        {
            cnt=1;
        }
    }

    localStorage.setItem('cart', JSON.stringify(newCart));
    $scope.carts=  JSON.parse(localStorage.getItem("cart"));
  

});