//AJAX http://localhost:63529/webapi/api/GetUserJobs

function MainViewModel()
{
    var self = this;
    self.isLoading = ko.observable(true);
    self.Jobs = ko.observableArray();


}

ko.applyBindings(new MainViewModel());