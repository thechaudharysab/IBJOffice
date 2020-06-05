var Employees = /** @class */ (function () {
    //private urlEditEmployee = '/employee/edit';
    //private urlSearchEmployee = '/employee/search';
    function Employees() {
        this.urlGetData = "/employee/table-data-view";
        this.urlAddEmployee = '/employee/add';
        this.urlSaveEmployee = '/employee/save';
        this.urlDeleteEmployee = '/employee/delete';
        this.init();
    }
    Employees.prototype.init = function () {
        var _this = this;
        try {
            this.initTable();
            $('#add_employee').click(function () {
                _this.add();
            });
        }
        catch (e) {
            console.error(e);
        }
    };
    Employees.prototype.initTable = function () {
        var _this = this;
        try {
            Util.request(this.urlGetData, 'GET', 'html', function (response) {
                $('#employees_list tbody').empty();
                $('#employees_list tbody').append(response);
                $('.employee-delete').click(function (e) {
                    var id = $(e.currentTarget).data('id');
                    var data = {
                        id: id
                    };
                    _this.delete(data);
                });
            }, function () {
                console.error('Failed to get data #T5G354. Please try again');
            });
        }
        catch (e) {
            console.error(e);
        }
    };
    Employees.prototype.delete = function (data) {
        try {
            if (confirm("Are you sure you want to delete this employee?") == true) {
                Util.request(this.urlDeleteEmployee, 'post', 'json', function () {
                    $.notify("Employee deleted successfully.");
                    location.reload();
                }, function () {
                    $.notify("Failed to delete Employee. Please try again");
                }, data);
            }
        }
        catch (e) {
            console.error(e);
        }
    };
    Employees.prototype.add = function () {
        var _this = this;
        try {
            Util.request(this.urlAddEmployee, 'get', 'html', function (response) {
                $('#employee_form').html(response).addClass('popup');
                $('#employee_list').hide(); //.empty().toggleClass('shrink');
                _this.initForm();
            }), function () {
                console.error('Failed to get data #T6G352. Please try again');
            };
        }
        catch (e) {
            console.error(e);
        }
    };
    Employees.prototype.initForm = function () {
        var _this = this;
        try {
            $('#save_form').click(function () {
                _this.save();
            });
            $('#close_form').click(function () {
                location.reload(); //Reloads the page to show table
            });
        }
        catch (e) {
            console.error(e);
        }
    };
    Employees.prototype.save = function () {
        try {
            var employee_1 = this.createEmployee();
            console.log(employee_1);
            Util.request(this.urlSaveEmployee, 'post', 'json', function (response) {
                if (response != null) {
                    $.notify(response.message);
                    location.reload();
                }
                else {
                    $.notify(response.message);
                    console.error('Failed to get data #T7G985. Please try again.');
                }
            }, function () {
                console.log(employee_1);
            }, employee_1);
        }
        catch (e) {
            console.error(e);
        }
    };
    Employees.prototype.createEmployee = function () {
        try {
            var employee = {
                Firstname: $('#first_name').val(),
                Lastname: $('#last_name').val(),
                Position: $('#position').val(),
                Department: $('#department').val(),
                Salary: $('#salary').val(),
                DateJoined: $('#date_joined').val(),
                LastUpdated: $('#last_changed').val()
            };
            return employee;
        }
        catch (e) {
            console.error(e);
        }
    };
    return Employees;
}());
$(document).ready(function () {
    new Employees();
});
//# sourceMappingURL=employee.js.map