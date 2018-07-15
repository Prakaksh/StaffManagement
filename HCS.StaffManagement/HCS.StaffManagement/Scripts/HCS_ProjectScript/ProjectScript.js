
$(document).ready(function () {

    getStateList();

})


function getStateList() {
    //var stateId = $("#State").val();
    $.ajax
    ({
        url: BaseUrl+'Api/WebApi/GetStateList',
        type: 'Get',
        data:'json',
        success: function (result) {

            var select = $("#StateList");
              $(result).each(function (index, item) {
               select.append($("<option>").val(item.StateID).text(item.Name));
                });
        },
        error: function () {
            alert("Whooaaa! Something went wrong..")
        },
    });
}


