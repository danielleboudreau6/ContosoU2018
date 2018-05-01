$(function () {
    // wait for dom to be loaded (ready function)
    $("#tablesorted").DataTable({
        "columnDefs": [
            { "orderable": false, "targets": -1 }, // stop sorting on last column
        ],
        "lengthMenu": [[5, 10, 25, , -1], [5, 10, 25, 50,"All"]] // drop down for how many entries 
    });
});
