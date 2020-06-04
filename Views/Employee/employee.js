var Employees = /** @class */ (function () {
    //private urlSaveEmployee = '/employee/save';
    //private urlDeleteEmployee = '/employee/delete';
    //private urlEditEmployee = '/employee/edit';
    //private urlSearchEmployee = '/employee/search';
    function Employees() {
        this.urlGetData = "/employee/table-data-view";
        this.urlAddEmployee = '/employee/add';
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
        try {
            Util.request(this.urlGetData, 'GET', 'html', function (response) {
                $('#employees_list tbody').empty();
                $('#employees_list tbody').append(response);
            }, function () {
                console.error('Failed to get data #T5G354. Please try again');
            });
        }
        catch (e) {
            console.error(e);
        }
    };
    Employees.prototype.add = function () {
        try {
            Util.request(this.urlAddEmployee, 'get', 'html', function (response) {
                $('#employee_form').html(response).addClass('popup');
                $('#employee_list').empty().toggleClass('shrink');
                //this.initForm();
            }), function () {
                console.error('Failed to get data #T6G352. Please try again');
            };
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