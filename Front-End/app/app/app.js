var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/CustomerHome", {
        templateUrl : "views/pages/Customer/CustomerHome.html",
        controller: 'home'
    })
    .when("/CustomerHome/AllService", {
        templateUrl : "views/pages/Service/AllService.html",
          controller: 'AllServices'
    })
    .when("/CustomerHome/ServiceDetails/:id", {
        templateUrl : "views/pages/Service/ServiceDetails.html",
        controller: 'serviceDetails'
    })
    .when("/CustomerHome/MyOrder", {
        templateUrl : "views/pages/Customer/MyOrders.html",
        controller: 'MyOrder'
    })
    .when("/CustomerHome/OrderDetails/:id", {
        templateUrl : "views/pages/Customer/MyOrderDetails.html",
        controller: 'MyOrderDetails'
    })
    .when("/CustomerHome/MyProfile", {
        templateUrl : "views/pages/Customer/MyProfile.html",
        controller: 'MyProfile'
    })
    .when("/CustomerHome/EditProfile/:id", {
        templateUrl : "views/pages/Customer/EditProfile.html",
        controller: 'EditProfile'
    })
    .when("/CustomerService/AddToCart", {
        templateUrl : "views/pages/Service/Services.html",
        controller: 'services'
    })
    .when("/CustomerService/Cart/:id", {
        templateUrl : "views/pages/Service/Cart.html",
        controller: 'cart'
    })
    .when("/CustomerService/CartDelete/:id", {
        templateUrl : "views/pages/Service/DeleteCart.html",
        controller: 'deleteCart'
    })
    .when("/CustomerService/Search", {
        templateUrl : "views/pages/Service/Search.html",
        controller: 'search'
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
