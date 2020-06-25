
$(document).ready(function () {
    document.getElementsByTagName("html")[0].style.visibility = "visible";
    document.getElementById('PopUpForm').style.visibility = "visible";
    LoadEvents(true);
})

var Events = [];
function LoadEvents(loadAllEvents) {
    $.ajax({
        type: "GET",
        url: "/agenda/GetEvents",
        success: function (data) {
            Events = [];
            $.each(data, function () {
                $.each(this, function () {
                    Events.push({
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
            if (loadAllEvents) {
                GenerateCalendender();
            } else {
                Calendar.removeAllEvents();
                Calendar.addEventSource(Events);
            }
            
        },
        error: function (error) {
            console.log("Ajax failed");
        }
    })
};
    var Calendar;
    function GenerateCalendender() {
        var calendarEl = document.getElementById('Calendar');
         Calendar = new FullCalendar.Calendar(calendarEl, {
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
             events: Events,
            eventRender: function (info) {
                $(info.el).find('.fc-time').append('<span class="fc-time"> - ' + moment(info.event.end).format('HH.mm') + '</span>');
                $(info.el).find('.fc-title').append('<div class="hr-line-solid-no-margin"></div><span class="fc-employee" style="font-size: 10px">' + info.event.extendedProps.employee + '</span></div>');
            },
            dateClick: function (info) {
                ToggelPopUpForm();
                SetDatum(moment(info.dateStr).format('YYYY-MM-DD'));
            },
            eventClick: function (info) {
                var UpdateData = {
                    startDate: moment(info.event.start).format('YYYY-MM-DD'),
                    startTime: moment(info.event.start).format('HH:mm'),
                    endDate: moment(info.event.end).format('YYYY-MM-DD'),
                    endTime: moment(info.event.end).format('HH:mm'),
                    employee_id: info.event.extendedProps.employee_id,
                    event_id: info.event.extendedProps.event_id,
                    description: info.event.extendedProps.explanation
                };
                ToggelPopUpForm("update",UpdateData);
            }
        });
        Calendar.render();
    }

    $("#btnAddNewEvent").click(function () {
        var form = $("#CreateEventForm");
            var obj = $(form).serialize();
            var action = $(form).attr("action");

            if ($("#RepeatEvent").is(':checked')) {
                var dates = getDatesBetweenDates($("#DateStart").val(), $("#DateEnd").val())
                var counter = 0;
                $.each(dates, function () {
                    counter += 1;
                    var date = moment(this).format('YYYY-MM-DD');
                    $("#DateStart").val(date);
                    $("#DateEnd").val(date);
                    var obj = $(form).serialize();
                    if (counter == dates.length) {
                        postNewEvent(obj, true);
                    } else {
                        postNewEvent(obj, false);
                    }
                    console.log(date);
                })
            } else {
                postNewEvent(obj, true);
            }
            console.log(action);
            $("#RepeatEvent").prop("checked", false);
            ToggelPopUpForm();
    }) 

function postNewEvent(eventObj, loadEvents) {
    var form = $("#CreateEventForm");
    var action = $(form).attr("action");
    $.ajax({
        type: "post",
        url: action,
        contentType: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: eventObj,
        success: function () {
            if (loadEvents) {
                LoadEvents(false);
            }
        },
        error: function (err) {
            console.error("Ajax Could not create new event")
        }
    });
}

function getDatesBetweenDates(startDate, endDate) {
    var dates = [];
    var currDate = moment(startDate).startOf('day');
    var lastDate = moment(endDate).startOf('day').add(1, 'days');

    while (currDate.diff(lastDate) < 0) {
        console.log(currDate.toDate());
        dates.push(currDate.clone().toDate());
        currDate.add(1, 'days');
    }
    return dates;
};

function RemoveEvent(eventId) {
    $.ajax({
        type: "post",
        url: '/Agenda/DeleteEvent',
        contentType: 'application/json',
        dataType: 'json',
        data: JSON.stringify(eventId.toString()),
        success: function () {
            LoadEvents(false);
        },
        error: function (err) {
            LoadEvents(false);
        }
    });
    ToggelPopUpForm();
}


    function SetDatum(Datum) {
        $('#DateStart').attr("value", Datum);
        $('#DateStart').val(Datum);
        $('#DateEnd').attr("value", Datum);
        $('#DateEnd').val(Datum);
    }
    function SetFormUpdateData(updateData) {
        $('#DateStart').attr("value", updateData.startDate);
        $('#DateStart').val(updateData.startDate);
        $('#TimeStart').val(updateData.startTime);
        $('#TimeStart').attr("value", updateData.startTime);
        $('#DateEnd').attr("value", updateData.endDate);
        $('#DateEnd').val(updateData.endDate);
        $('#TimeEnd').val(updateData.endTime);
        $('#TimeEnd').attr("value", updateData.endTime);
        $('#Event_ID').val(updateData.event_id);
        $("li[value='" + updateData.employee_id + "']").trigger("click");
        $('#Description').val(updateData.description);
        $('#HeaderForm h2').first().text("Agenda-item");
        $('#BottomForm').hide();
        $('#EmployeeDropdownToggle .active-icon ').first().hide();
        $("#PopUpForm input, #PopUpForm textarea").attr("disabled", true);
        $('#CustomEmployeeDropdown section, #SearchEmployee').css("background", "#e9ecef");
        $('<span class="icon-container"><i class="edit-icon fa fa-pencil-square-o"></i><a onclick="RemoveEvent(' + updateData.event_id +')"><i class="fa fa-trash-o"></i></a></span>').insertAfter("#HeaderForm h2");
    }
    $(document).on("click", ".edit-icon", function () {
        $("#PopUpForm input, #PopUpForm textarea").attr("disabled", false);
        $('#BottomForm').slideDown("fast");
        $('#EmployeeDropdownToggle .active-icon ').first().fadeIn("fast");
        $('.icon-container').fadeOut("fast");
        $('#CustomEmployeeDropdown section, #SearchEmployee').css("background", "white");
        $('#PopUpForm form').first().attr('action', '/Agenda/UpdateEvent');
        $('#HeaderForm h2').first().text("Agenda-item bewerken");
    });
       
    
    function ToggelPopUpForm(action, updateData) {
        $('#PopUpForm').fadeToggle();
        $('#PopUpForm .row').first().toggleClass('rowvisible');
        $('#PopUpForm').css('display', 'flex');
        if (!$('PopUpForm .row').first().hasClass('rowvisible')) {
            ClosePopUpForm(); 
        } 
        if (action == "update") {
            SetFormUpdateData(updateData);
            $(".checkboxRepeat").hide();
        } else {
            $(".checkboxRepeat").show();
        }
    }
    $('#Overlay').click(function () {
        ToggelPopUpForm();
    })
    $('#PopUpForm .rowvisible').click(function(e) {
     //   e.stopPropagation();
    })

    $('#EmployeeDropdownToggle').first().on('click', function () {
        if (!$(this).hasClass("selected")) {
            $('#CustomEmployeeDropdown ul').slideToggle("fast");
            $('#EmployeeDropdownToggle .fc-icon').toggleClass("active-icon");
        }
    })

    $('#SearchEmployee').first().on('click', function (e) {
        if ($('#CustomEmployeeDropdown ul').is(':visible')){
            e.stopPropagation();
        }
    })

    $('#SearchEmployee').on('keyup', function () {
        var filter = $('#SearchEmployee').val().toUpperCase();
        var items = $('#CustomEmployeeDropdown li');
        filterList(filter, items);
    })

    function filterList(filter, list) {
        for (var i = 0; i < list.length; i++) {
            var textValue = list[i].textContent || list[i].innerText;
            if (textValue.toUpperCase().indexOf(filter) > -1) {
                list[i].style.display = "block";
            } else {
                list[i].style.display = "none";
            }
        }
    }

    $('#CustomEmployeeDropdown li').on('click', function () {
        var imgSrc = $(this).find('img').attr('src');
        $('#SelectedImg').attr('src', imgSrc);
        $('#SelectedImg').removeClass('SearchIcon');
        $('#SearchEmployee').val(this.innerText); 
        $('#Employee_ID').val($(this).attr("value"));
        $('#CustomEmployeeDropdown ul').slideUp("fast");
        $('#EmployeeDropdownToggle .fc-icon').toggleClass("active-icon");
        $('#EmployeeDropdownToggle').addClass('selected');
        $("#EmployeeDropdownToggle span").removeClass("fc-icon fc-icon-chevron-right");
        $("#EmployeeDropdownToggle span").addClass("fa fa-times");
        $("#SearchEmployee").prop("disabled", true);
    })

    $("#EmployeeDropdownToggle span").on('click', function () {
        if ($(this).hasClass("fa-times")) {
            $("#EmployeeDropdownToggle span").addClass("fc-icon fc-icon-chevron-right");
            $("#EmployeeDropdownToggle span").removeClass("fas fa-times");
            $('#EmployeeDropdownToggle').removeClass('selected');
            $('#EmployeeDropdownToggle .fc-icon').toggleClass("active-icon");
            $('#SelectedImg').attr('src', "../img/Icons/search.png");
            $('#SelectedImg').addClass('SearchIcon');
            $('#SearchEmployee').val("");
            $('#Employee_ID').val("");
            $("#SearchEmployee").prop("disabled", false);

            var items = $('#CustomEmployeeDropdown li');
            filterList("", items);
        }
    })

    function ClosePopUpForm() {
        if ($('#CustomEmployeeDropdown ul').css('display') == 'block' ||
            $('#EmployeeDropdownToggle').hasClass('selected')){
            $("#EmployeeDropdownToggle span").trigger("click");
        }
        $('#DateStart').val("0001-01-01");
        $('#TimeStart').val("00:00");
        $('#DateEnd').val("0001-01-01");
        $('#TimeEnd').val("00:00");
        $('#Description').val("");
        $("#PopUpForm input, #PopUpForm textarea").attr("disabled", false);
        $('#BottomForm').slideDown("fast");
        $('.icon-container').fadeOut("fast");
        $('#CustomEmployeeDropdown section, #SearchEmployee').css("background", "white");
        $('#PopUpForm form').first().attr('action', '/Agenda/CreateEvent');
        $('#HeaderForm h2').first().text("Creëer agenda-item"); 
    }

    $('#PopUpForm .btn-cancel').first().click(function () {
        ToggelPopUpForm();
    })
