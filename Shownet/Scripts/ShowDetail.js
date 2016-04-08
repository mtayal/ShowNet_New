
   

function getScheduleList() {
        $.ajax({
            type: 'POST',
            url: '/ShowNet/fillRingScheduleList',
            data: { 'year': $("#ddlYear").val(), 'month': $('#ddlMonth').val(), 'showNameId': $('#ddlShowName').val(), 'showDate': $('#ddlHorseShowDate').val(), 'showDayID': $('#ddlRingName').val() },
            success: function (response) {
                $("#horseShowName").text($("#ddlShowName option:selected").text());
                $(".removeRow").remove();
                $.each(response, function (i, item) {
                    var d = item.ETATime.substring(12, 20);
                    if (item.RingStatus == 'Entered') 
                    {
                        var e = "View Order";
                    }
                    else
                    {
                        if (item.SeenCount == item.ClassCount || item.SeenCount==0) {
                            var e = "View Result";
                        }
                        else {
                            var e = "Live (Seen " + item.SeenCount + " of " + item.ClassCount + ")";
                        }
                    }
                    if (item.ClassCount == 0)
                    {
                        var vedios = "";
                    }
                    else
                    {
                        var vedios = "<a href=''><i class='fa fa-video-camera' style='font-size: 18px;'></i>";
                    }
                    var html = "<tr class=removeRow><td style='color:black;'>" + item.ClassID + "</td>";
                    html += "<td style='color:black;'>" + item.ClassName + "</td>"; 
                    html += "<td style='color:black;'>" + d + "</td>";
                    html += "<td style='color:black;'>" + item.ClassCount + "</td>";
                    html += "<td style='color:black;'>" + vedios + "</div></a></td>";
                    html += "<td style='color:black;'> <a href='/ShowNet/ClassResults?ringID=" + item.RingId + "&HorseShowID=" + $('#ddlShowName').val() + "&ScheduleID=" + item.ScheduleID + "&ClassID=" + item.ClassID + "'> " + e + " </a></td>";
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
           // $("#horseShowName").html("");
            
            $("#ddlShowName").html("");
            if (years.length != 0) {
                $.each(years, function (i, showName) {
                    $("#ddlShowName").append(
                        $('<option></option>').val(showName.HorseShowID).html(showName.HorseShowName));
                    $("#ddlHorseShowDate").prop("disabled", false);
                    $("#ddlRingName").prop("disabled", false);
                    $("#ddlRingName1").prop("disabled", false);
                });
                $("#horseShowName").text($("#ddlShowName option:selected").text()); 
                getShowDate();
             //   getScheduleList();
                
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
                    $("#ddlHorseShowDate").prop("disabled", false);
                });
                
                getRingList();
               // getScheduleList();
            }
            else {
                $("#ddlHorseShowDate").append($('<option></option>').val(0).html("No available!"));
                $("#ddlHorseShowDate").prop("disabled", true);
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
                //$("#ddlRingName1 option:text=" + $("#ddlRingName").val() + "").attr("selected", "selected");
                getScheduleList();
                $("#ddlRingName1").val($("#ddlRingName option:selected").val());
              
            }
            else {
                $("#ddlRingName").append($('<option></option>').val(0).html("No available!"));
                $("#ddlRingName1").append($('<option></option>').val(0).html("No available!"));

            }
        }
    });
    
}
