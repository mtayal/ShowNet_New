
   

function getScheduleList() {
        $.ajax({
            type: 'POST',
            url: '/ShowNet/fillRingScheduleList',
            data: { 'year': $("#ddlYear").val(), 'month': $('#ddlMonth').val(), 'showNameId': $('#ddlShowName').val(), 'showDate': $('#ddlHorseShowDate').val(), 'showDayID': $('#ddlRingName').val() },
            success: function (response) {
                $(".removeRow").remove();
                debugger;
                $.each(response, function (i, item) {
                    var d = item.ETATime.substring(12,20);
                    var html = "<tr class=removeRow><td style='color:black;'>" + item.ClassID + "</td>";
                    html += "<td style='color:black;'>" + item.ClassName + "</td>"; 
                    html += "<td style='color:black;'>" + d + "</td>";
                    html += "<td style='color:black;'>" + item.StartedCount + "</td>";
                    html += "<td style='color:black;'><a href=''><i class='fa fa-video-camera' style='font-size: 18px;'></i></div></a></td>";
                    html += "<td style='color:black;'> <a href='/ShowNet/ClassResults?ringID=" + item.RingId+ "&HorseShowID=" + $('#ddlShowName').val() + "&ScheduleID=" + item.ScheduleID + "&ClassID=" + item.ClassID + "'> View Results </a></td>";
                    $("#tblRing tr:last").after(html);
                    
                });

            },
            error: function (response) {
                alert("error");
            }

        });

    }

    function getShowName() {
       
    $.ajax({
        url: '/ShowNet/fillShowName',
        type: "GET",
        dataType: "JSON",
        data: { 'year': $("#ddlYear").val(), 'month': $('#ddlMonth').val(), 'showNameId': $('#ddlShowName').val(), 'showDate': $('#ddlHorseShowDate').val(), 'showDayID': $('#ddlRingName').val() },
        success: function (years) {
            $("#ddlShowName").html("");
            if (years.length != 0) {
                $.each(years, function (i, showName) {
                    $("#ddlShowName").append(
                        $('<option></option>').val(showName.HorseShowID).html(showName.HorseShowName));
                    $("#ddlHorseShowDate").prop("disabled", false);
                    $("#ddlRingName").prop("disabled", false);
                    $("#ddlRingName1").prop("disabled", false);
                });
                getShowDate();
                getScheduleList();
            }
            else {
                $("#ddlShowName").append($('<option></option>').val(0).html("No shows for this months!"));
                $("#ddlHorseShowDate").prop("disabled", true);
                $("#ddlRingName").prop("disabled", true);
                $("#ddlRingName1").prop("disabled", true);


            }
        }


    });

   
}

function getShowDate() {
   
    $.ajax({
        url: '/ShowNet/fillShowDate',
        type: "GET",
        dataType: "JSON",
        data: { 'year': $("#ddlYear").val(), 'month': $('#ddlMonth').val(), 'showNameId': $('#ddlShowName').val(), 'showDate': $('#ddlHorseShowDate').val(), 'showDayID': $('#ddlRingName').val() },
        success: function (shows) {
            $("#ddlHorseShowDate").html("");
            if (shows.length != 0) {
                $.each(shows, function (i, show) {
                    $("#ddlHorseShowDate").append(
                       $('<option></option>').val(show.ShowsDate).html(show.ShowsDate));
                });
                getRingList();
                getScheduleList();
            }
            else {
                $("#ddlHorseShowDate").append($('<option></option>').val(0).html("No available!"));
             }
        }
    });
}
function getRingList() {
    $.ajax({
        url: '/ShowNet/fillRingName',
        type: "GET",
        dataType: "JSON",
        data: { 'year': $("#ddlYear").val(), 'month': $('#ddlMonth').val(), 'showNameId': $('#ddlShowName').val(), 'showDate': $('#ddlHorseShowDate').val(), 'showDayID': $('#ddlRingName').val() },
        success: function (shows) {
            $("#ddlRingName").html("");
            $("#ddlRingName1").html("");
            if (shows.length != 0) {

                $.each(shows, function (i, show) {
                    $("#ddlRingName").append(
                       $('<option></option>').val(show.ShowDayID).html(show.RingName));
                    $("#ddlRingName1").append(
                       $('<option></option>').val(show.ShowDayID).html(show.RingName));

                });
                $("#ddlRingName1").val($("#ddlRingName").val());
                getScheduleList();
            }
            else {
                $("#ddlRingName").append($('<option></option>').val(0).html("No available!"));
                $("#ddlRingName1").append($('<option></option>').val(0).html("No available!"));



            }
        }
    });
}

