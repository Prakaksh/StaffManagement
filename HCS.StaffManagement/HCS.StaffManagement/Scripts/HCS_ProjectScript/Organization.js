
function fncState() {
    $('#State').val($('#StateList').val())
}
$(document).ready(function () {
    debugger;
    $('#DivOraganization').load(BaseUrl + '/LegalizationProcess/_LegalRequestAssignTask');
    $('#DivOraganization').load(BaseUrl+'/Organization/_OrganizationList');

})

function fncGetOrganization() {
   

}