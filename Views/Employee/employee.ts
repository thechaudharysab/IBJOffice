class Employees {
    private urlGetData = "/employee/table-data-view";
    //private urdAddEmployee = '/employee/add';
    //private urdSaveEmployee = '/employee/save';
    //private urdDeleteEmployee = '/employee/delete';
    //private urdEditEmployee = '/employee/edit';
    //private urdSearchEmployee = '/employee/search';

    constructor() {
        this.init();
    }

    private init() {
        try {
            this.initTable();
        } catch (e) {
            console.error(e);
        }
    }

    private initTable() {
        try {
            Util.request(this.urlGetData, 'GET', 'html', (response) => {
                $('#employees_list tbody').empty();
                $('#employees_list tbody').append(response);

            }, function () {
                    console.error('Failed to get data #T5G354. Please try again');
            });

        } catch (e) {
            console.error(e);
        }
    }
}

$(document).ready(function () {
    new Employees();
});