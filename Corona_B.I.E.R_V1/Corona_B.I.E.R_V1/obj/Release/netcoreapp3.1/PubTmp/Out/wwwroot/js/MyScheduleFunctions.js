

$(document).ready(function () {
    document.getElementsByTagName("html")[0].style.visibility = "visible";
    var events = [];
    console.log("start");
    $.ajax({
        type: "GET",
        url: "/agenda/GetEmployeeEvents",
        success: function (data) {

            $.each(data, function () {
                $.each(this, function () {
                    events.push({
                        title: this.title,
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
        var calendarEl = document.getElementById('Calendar');
        var calendar = new FullCalendar.Calendar(calendarEl, {
            lang: 'nl',
            locale: 'nl',
            plugins: ['interaction', 'dayGrid', 'timeGrid'],
            defaultView: 'dayGridMonth',
            defaultDate: new Date(),
            header: {
                left: 'prev,next today',
                center: 'title',
                right: 'dayGridMonth,timeGridWeek,timeGridDay'
            },
            events: event,
            eventRender: function (info) {
                console.log(info.event);
                console.log(info.event.end);
                $(info.el).find('.fc-time').append('<span class="fc-time"> - ' + moment(info.event.end).format('HH.mm') + '</span>');
                $(info.el).find('.fc-title').append('<div class="hr-line-solid-no-margin"></div><span class="fc-employee" style="font-size: 10px">' + info.event.extendedProps.employee + '</span></div>');
            },
        });
        calendar.render();
    }
});
