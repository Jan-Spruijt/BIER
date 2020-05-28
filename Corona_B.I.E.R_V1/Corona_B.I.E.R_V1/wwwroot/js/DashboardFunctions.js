$(document).ready(function () {

    var events = [];
    console.log("start");
    $.ajax({
        type: "GET",
        url: "/agenda/GetEmployeeEvents",
        success: function (data) {

            $.each(data, function () {
                $.each(this, function () {
                    events.push({
                        title: this.type,
                        start: this.datetimeStart,
                        end: this.datetimeEnd,
                        employee_id: this.employee_id,
                        event_id: this.id,
                        employee: this.employeeName,
                        explanation: this.description
                    })
                })
            })
            GenerateCalendender(events);
        },
        error: function (error) {
            console.log("Ajax failed");
        }
    })

    function GenerateCalendender(event) {
       event = event.slice(0, 4);
        var calendarEl = document.getElementById('Calendar');
        var calendar = new FullCalendar.Calendar(calendarEl, {
            lang: 'nl',
            locale: 'nl',
            plugins: ['list'],
            defaultView: 'listWeek',
            header: {
                left: '',
                center: '',
                right: ''
            },
            events: event,
            eventRender: function (info) {
               
            }      
        });
        calendar.render();
    }
});
