$("#btnRequest").click(function () {
    $.ajax({
        /*     url: "http://localhost:52476/Home/TestPage",   does not respond, no error*/
        /*     url: "localhost:52476/Home/TestPage",   request failed */
        /*     url: "localhost:52476/",  request failed*/
        /*     url: "/",  no response */
        /*     url: "/Home/",   no response */
        /*     url: "/Home/TestPage",  no response */
        /*     url: "Home/TestPage",   page not found */
        /*     url: "Home/TestPage/",  page not found */
        /*     url: "/TestPage",   page not found */
        /*     url: "TestPage",   no response */
        /*     url: "Contact",  no response */
        url: "TestPage",
        type: "POST",
        datatype: "text",
        success: function (data, textStatus, xhr) {
            var successMsg = "Request complete: " + textStatus;
            alert(successMsg);
            $("#resultContainer").html(data);
        },
        error: function (xhr, status, error) {
            var errorMsg = "Request failed: " + status + "[" + xhr.status + "]=" + error + "\n" +
                            "ReadyState: " +xhr.readyState + ", ResponseText: " + xhr.responseText    ;
            alert(errorMsg);
        },
        statusCode: {
            500: function () {
                alert("Error: server error");
            },
            404: function () {
                alert("Error: the requ3sted page was not found");
            },
            403: function () {
                alert("Error: access forbidden");
            },
            400: function () {
                alert("Error: access forbidden");
            },
            200: function () {
                alert("Status code 200 - good results");
            },
            default: function (xhr, status) {
                alert("default case, status " + xhr.status + ", ReadyState: " + xhr.readyState + ", ResponseText: " + xhr.responseText);
            }
        },
        complete: function (xhr, textStatus) {
            var doneMsg = "Operation complete with status: " + textStatus;
            alert(doneMsg);
        }
    })
})