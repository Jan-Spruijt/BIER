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
            droppable: true, 
            eventDrop: function (info) {
                if (!confirm("Weet u zeker dat u " + info.event.title + " wilt verplaatsen naar " + moment(info.event.start).format("DD/MM/YYYY"))) {
                    info.revert();
                }
            }
        });
        calendar.render();
    }

    $('#EmployeeDropdownToggle').first().on('click', function () {
        $('#CustomEmployeeDropdown ul').slideToggle();
        $('#EmployeeDropdownToggle .fc-icon').toggleClass("active-icon");
    })
    $('#SearchEmployee').first().on('click', function (e) {
        if ($('#CustomEmployeeDropdown ul').is(':visible')){
            e.stopPropagation();
        }
    })

    $('#SearchEmployee').on('keyup', function () {
        var filter = $('#SearchEmployee').val().toUpperCase();
        console.log(filter);
        var items = $('#CustomEmployeeDropdown li');
        for (var i = 0; i < items.length; i++) {
            var textValue = items[i].textContent || items[i].innerText;
            if (textValue.toUpperCase().indexOf(filter) > -1) {
                items[i].style.display = "block";
            } else {
                items[i].style.display = "none";
            }
        }
    })

    $('#CustomEmployeeDropdown li').on('click', function () {
        var imgSrc = $(this).find('img').attr('src');
        $('#SelectedImg').attr('src', imgSrc);
        $('#SelectedImg').removeClass('SearchIcon');
        
    })
});
