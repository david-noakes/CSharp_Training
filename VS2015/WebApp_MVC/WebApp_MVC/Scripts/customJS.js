﻿//$('#pane').position({
//    my: 'center',
//    at: 'center',
//    of: '#paneContainer'
//});

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

