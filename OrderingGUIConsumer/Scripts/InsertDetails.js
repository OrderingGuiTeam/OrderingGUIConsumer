function InsertDetails() {
    var firstName = $('#txtFirstName').val();
    var lastName = $('#txtLastName').val();
    var address = $('#taAddress').val();
    var location = $('#ddlLocation').val();

    if (firstName == "") {
        alert("Enter firstName");
        return false;
    }
    else if (address == "") {
        alert("Enter address");
        return false;
    }
    else if ((location == "select")) {
        alert("Select location");
        return false;
    }

    //Insert Details
    $.ajax({
        type: 'POST',
        url: '../CustomerDetails/ToState',
        data: {
            'strFirstName': firstName,
            'strLastName': lastName,
            'strAddress': address,
            'strLocation': location
        },
        success: function (data) {
            alert(data);
        }
    });


}