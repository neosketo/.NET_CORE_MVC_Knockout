
function Jobs(job) {
    this.Company = job.company;
    this.DateApplied = job.dateApplied;
    this.Interview = job.interview;
    this.Position = job.position; 
}


function MainViewModel()
{
    var self = this;
    self.isLoading = ko.observable(true);
    self.jobs = ko.observableArray();
    self.Company = ko.observable();
    self.DateApplied = ko.observable();
    self.Interview = ko.observable();
    self.Position = ko.observable();

    var userObject = {
        Email: userEmail
    }

        $.ajax({
            type: "POST",
            url: "/webapi/api/GetUserJobs",
            data: JSON.stringify(userObject),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result) {


                     
                ko.utils.arrayForEach(result,
                            function (job) {
                                self.jobs.push(new Jobs(job));
                            });
                   



                self.isLoading(false);
            },
            error: function(msg) {
                alert("No Data: " + msg); 
                self.isLoading(false);
            }
        });
    
};

ko.applyBindings(new MainViewModel());