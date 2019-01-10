class EmployeeService {

    getAll() {
        return fetch('../api/Employees')
            .then(function (response) {
                return response.json();
            })
    }

    getById(id) {
        return fetch(`../api/Employees/${id}`)
            .then(function (response) {
                return response.json();
            })
    }
}

var service = new EmployeeService();

var app = new Vue({
    el: '#app',
    data: {
        id: null,
        employees: []
    },
    created: function () {
        service.getAll().then((data) => {
            this.employees = data;
        })
    },
    methods: {
        search: function(event) {
            console.log(this.id)
            if (!this.id) {
                service.getAll().then((data) => {
                    this.employees = data;
                })
            }
            else {
                service.getById(this.id).then((data) => {
                    this.employees = [data];
                })
            }
        }
    }
})