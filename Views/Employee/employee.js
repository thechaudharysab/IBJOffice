var Employees = /** @class */ (function () {
    //private urdAddEmployee = '/employee/add';
    //private urdSaveEmployee = '/employee/save';
    //private urdDeleteEmployee = '/employee/delete';
    //private urdEditEmployee = '/employee/edit';
    //private urdSearchEmployee = '/employee/search';
    function Employees() {
        this.urlGetData = "/employee/table-data-view";
        this.init();
    }
    Employees.prototype.init = function () {
        try {
            this.initTable();
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
    return Employees;
}());
$(document).ready(function () {
    new Employees();
});
//# sourceMappingURL=employee.js.map