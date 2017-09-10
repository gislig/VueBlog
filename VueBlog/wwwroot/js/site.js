var app = new Vue({
    el: '#app',
    data: {
        firstName: 'Gísli',
        lastName: 'Guðmundsson'
    },
    methods: {
        getFullName: function (first, last) {
            return {
                name: first + ' ' + last
            }
        }
    }
});

var butonapp = new Vue({
    el: '#buttonapp',
    methods: {
        clickedButton: function () {
            alert("You clicked the button!");
        }
    }
})
