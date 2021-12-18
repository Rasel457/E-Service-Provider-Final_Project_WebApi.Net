app.controller("logout",function($scope,ajax,$location){
   // localStorage.removeItem("token");
    ajax.get("api/logout",success,error);
    function success(response){
        console.log(response);
        localStorage.removeItem("token");
    }
    function error(error){
       console.log(error);
    }
});