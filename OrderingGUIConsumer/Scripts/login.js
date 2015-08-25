function ValidateUser() {
    var userid = $('#txtUserID').val();
    var userpwd = $('#txtPwd').val();
    if (userid == "") {
        alert("Enter User ID");
        return false;
    }
    else if (userpwd == "") {
        alert("Enter Password");
        return false;
    }

    //validate user
    $.ajax({
        type: 'POST',
        url: 'Login/ValidateCredentials',
        data: {

            'strUserID': userid,
            'strPwd': userpwd
        },
        success: function (msg) {
            alert(msg);
        }
    });


}