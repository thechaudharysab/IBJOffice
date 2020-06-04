class Employees {
    private urlGetData = "/employee/table-data-view";
    private urlAddEmployee = '/employee/add';
    //private urlSaveEmployee = '/employee/save';
    //private urlDeleteEmployee = '/employee/delete';
    //private urlEditEmployee = '/employee/edit';
    //private urlSearchEmployee = '/employee/search';

    constructor() {
        this.init();
    }

    private init() {
        try {
            this.initTable();

            $('#add_employee').click(() => {
                this.add();
            });

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

    private add() {
        try {
            Util.request(this.urlAddEmployee, 'get', 'html', (response) => {
                $('#employee_form').html(response).addClass('popup');
                $('#employee_list').empty().toggleClass('shrink');

                //this.initForm();

            }), () => {
                console.error('Failed to get data #T6G352. Please try again');
            }
        } catch (e) {
            console.error(e);
        }
    }

}

$(document).ready(function () {
    new Employees();
});