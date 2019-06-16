$(document).ready(function() {
    $('.js-article-list').DataTable({ responsive: true, dom: 'Bfrtip' })

    //Exportable table
    $('.js-exportable').DataTable({
        dom: 'Bfrtip',
        responsive: true,
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ]
    });
});