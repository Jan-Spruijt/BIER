$(document).ready(function () {

   /* var Calendar = FullCalendar.Calendar;
    var Draggable = FullCalendarInteraction.Draggable;

    var containerEl = document.getElementById('external-events');
    var calendarEl = document.getElementById('calendar');
    var checkbox = document.getElementById('drop-remove');

    // initialize the external events
    // -----------------------------------------------------------------

    new Draggable(containerEl, {
        itemSelector: '.fc-event',
        eventData: function (eventEl) {
            return {
                title: eventEl.innerText
            };
        }
    });*/

    var events = [];
    console.log("start");
    $.ajax({
        type: "GET",
        url: "/agenda/GetEvents",
        success: function (data) {

            $.each(data, function () {
                $.each(this, function () {
                    events.push({
                        title: this.title,
                        description: this.description,
                        start: this.datetimeStart,
                        end: this.datetimeEnd

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
        console.log(event);
        var calendar = new FullCalendar.Calendar(calendarEl, {
            plugins: ['interaction', 'dayGrid', 'timeGrid'],
            defaultView: 'dayGridMonth',
            defaultDate: new Date(),
            header: {
                left: 'prev,next today',
                center: 'title',
                right: 'dayGridMonth,timeGridWeek,timeGridDay'
            },
            events: event,
            editable: true,
            droppable: true, // this allows things to be dropped onto the calendar
            drop: function (info) {
                // is the "remove after drop" checkbox checked?
                if (checkbox.checked) {
                    // if so, remove the element from the "Draggable Events" list
                    info.draggedEl.parentNode.removeChild(info.draggedEl);
                }
            }
        });
        calendar.render();
    }
    /*var calendar = new Calendar(calendarEl, {
        plugins: ['interaction', 'dayGrid', 'timeGrid'],
        header: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay'
        },
        events: events,
        editable: true,
        droppable: true, // this allows things to be dropped onto the calendar
        drop: function (info) {
            // is the "remove after drop" checkbox checked?
            if (checkbox.checked) {
                // if so, remove the element from the "Draggable Events" list
                info.draggedEl.parentNode.removeChild(info.draggedEl);
            }
        }
    });

    calendar.render();*/
});
