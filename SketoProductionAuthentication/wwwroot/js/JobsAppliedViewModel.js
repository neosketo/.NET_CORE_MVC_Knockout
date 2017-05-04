
function MainViewModel()
{
    var self = this;
    self.isLoading = ko.observable(true);
    self.Jobs = ko.observableArray();

    $.getJSON("/webapi/api/GetUserJobs",
        function (data) {
            ko.utils.arrayForEach(data,
                function (course) {
                    self.products.push(new Program(course));
                });
            self.isLoading(false);
        });

}

ko.applyBindings(new MainViewModel());