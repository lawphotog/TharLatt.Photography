var app = angular.module('tharlattphotography', ['ngRoute']);

app.controller('photosController', ['$scope', '$http', function ($scope, $http) {

    $scope.photos = [
        { "id": 1, "type": "portraits", "href": "/content/images/1 (1).jpg" },
        { "id": 2, "type": "portraits", "href": "/content/images/1 (2).jpg" },
        { "id": 3, "type": "portraits", "href": "/content/images/1 (3).jpg" },
        { "id": 4, "type": "portraits", "href": "/content/images/1 (4).jpg" },
        { "id": 5, "type": "portraits", "href": "/content/images/1 (5).jpg" },
        { "id": 6, "type": "portraits", "href": "/content/images/1 (6).jpg" },
        { "id": 7, "type": "portraits", "href": "/content/images/1 (7).jpg" },
        { "id": 8, "type": "portraits", "href": "/content/images/1 (8).jpg" },
        { "id": 9, "type": "portraits", "href": "/content/images/1 (9).jpg" },
        { "id": 10, "type": "portraits", "href": "/content/images/1 (10).jpg" },
        { "id": 11, "type": "portraits", "href": "/content/images/1 (11).jpg" },
        { "id": 12, "type": "portraits", "href": "/content/images/1 (12).jpg" },
    ];

    //$scope.photos = [];

    //$http.get('/api/Photos/GetPhotos')
    //        .success(function (data) {
    //            angular.copy(data, $scope.photos);
    //        })
    //        .error(function () {
    //            toastr.error('error');
    //        });

    

}]);