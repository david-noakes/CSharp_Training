function togglePane() {
    $('#pane').toggle('bounce', { distance: 100, times: 9 }, 'slow');
}

function changeVal() {
    var textVal = $('#field1').val();
    $('#display').html(textVal);
}

function changeStyle() {
    $('#display').css('background-color', '#01ff03'); // neon green
}

function clearAll() {
    $('#display').html('Sample message appears here');
    $('#display').css('background-color', '#efeeef'); // light grey
}

function initPicker() {
    $("#dp").datepicker();
}

function toggleList1() {
    $("#list1").toggle("fold", 1500);
}

function toggleList2() {
    $("#list2").toggle("fold", 1500);
}

function showMsg1() {
    $("#display").html("'Twas brillig, and the slythy toves");
}

function showMsg2() {
    $("#display").html("did gyre and gymbol in the wabe,");
}

function showMsg3() {
    $("#display").html("all mimsey were the borogoves...");
}

//$('#pane').position({
//    my: 'center',
//    at: 'center',
//    of: '#paneContainer'
//});
//
//$("#pane1").position({
//    my: "left center",   /*  horizontal  vertical */
//    at: "left center",
//    of: "#validArea"
//});

//$("#pane2").position({
//    my: "center",
//    at: "center",
//    of: "#validArea"
//});

//$("#pane3").position({
//    my: "right center",
//    at: "right center",
//    of: "#validArea"
//});

$("#btnRequest").click(function () {
    $.ajax({
        /*     url: "http://localhost:52476/Home/TestPage",  good results */
        /*     url: "/",  good results */
        /*     url: "/Home/",   good results */
        /*     url: "/Home/TestPage",  good results */
        /*     url: "TestPage",   good results */
        url: "TestPage",
        type: "POST",
        success: function (data, textStatus, xhr) {
            var successMsg = "Request complete: " + textStatus;
            alert(successMsg);
            $("#resultContainer").html(data);
        },
        error: function (xhr, status, error) {
            var errorMsg = "Request failed: " + error;
            alert(errorMsg);
        },
        statusCode: {
            404: function () {
                alert("Error: the requ3sted page was not found");
            },
            200: function (){
                alert("Status code 200 - good results");
            }
        },
        complete: function (xhr, textStatus) {
            var doneMsg = "Operation complete with status: " + textStatus;
            alert(doneMsg);
        }
    })
})