app.controller("MyOrderDetails",function($scope,$http,ajax,$routeParams){
    ajax.get("api/CustomerHome/Details/"+$routeParams.id,success,error);
    function success(response){
        $scope.o=response.data;
        // for(var x in response.data.Order_Details)
        // {
        //     console.log(x);
        // }
        
        //console.log(obj["Order_details"][0]);
        var sum=0;
        for( var x in response.data.Order_Details)
        {
            sum=sum+(response.data.Order_Details[x].unit_price*response.data.Order_Details[x].quantity);
        }
        $scope.total=sum;
        //console.log(sum);

        // $scope.pr=response.data.Order_Details[0].order_id;
        // $scope.total=0;

        //console.log(pr);
        //$scope.a=0;

    
    }
    function error(error){
       console.log(error);
    }

});