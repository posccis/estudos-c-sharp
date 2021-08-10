var dataTable;

$(document).ready(function () {
    loadDataTable;
})

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/Book",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "titulo", "width": "30%" },
            { "data": "autor", "width": "30%" },
            { "data": "isbn", "width": "30%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                    <a href="/BookList/Edit?id=${data}" class'btn btn-info text-white' style='cursor:pointer; width: 100px'>
                        Edit
                    </a>
                    &nbsp;
                    <a class'btn btn-info text-white' style='cursor:pointer; width: 100px'>
                        Delete
                    </a>

                    </div>`;


                }, "width": "30%"
            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    });
}