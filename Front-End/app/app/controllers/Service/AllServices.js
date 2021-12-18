// app.controller("AllServices",function($scope,$http){
//     $http.get("https://localhost:44348/api/CustomerHome/AllServices").
//     then(function(response){
//         $scope.services=response.data;
//     })
// });

app.controller("AllServices",function($scope,$http,ajax){
    ajax.get("api/CustomerHome/AllServices",success,error);
    function success(response){
        $scope.services=response.data;
       // console.log(response,);
    }
    function error(error){
       console.log(error);
    }

});

// app.controller("AllServices",function($scope,$http,ajax){
//     ajax.get("api/CustomerHome/AllServices",function(response){
//         $scope.services=response.data;
//     },function(error){
//         console.log(error);
//     });

// });