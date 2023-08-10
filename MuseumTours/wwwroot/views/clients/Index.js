﻿$(function () {
    var language = {
        emptyTable: "Нет данных для отображения",
        info: "_START_-_END_ из _TOTAL_ элементов",
        infoEmpty: "Нет записей",
        infoFiltered: "(отфильтровано из _MAX_ записей)",
        infoPostFix: "",
        infoThousands: ",",
        lengthMenu: "Показано _MENU_ записей",
        loadingRecords: l('LoadingWithThreeDot'),
        processing: '<i class="fas fa-refresh fa-spin"></i>',
        search: "Искать:",
        zeroRecords: "Нет записей, удовлетворяющих поиску",
        paginate: {
            first: '<i class="fas fa-angle-double-left"></i>',
            last: '<i class="fas fa-angle-double-right"></i>',
            next: '<i class="fas fa-chevron-right"></i>',
            previous: '<i class="fas fa-chevron-left"></i>'
        },
        aria: {
            sortAscending: ": " + "для сортировки столбцов по возрастанию</",
            sortDescending: ": " + "для сортировки столбцов по убыванию"
        }
    };
    new DataTable('#example'); {
        language: language
        dom: [
            "<'row'<'col-md-12'f>>",
            "<'row'<'col-md-12't>>",
            "<'row mt-2'",
            "<'col-lg-1 col-xs-12'<'float-left text-center data-tables-refresh'B>>",
            "<'col-lg-3 col-xs-12'<'float-left text-center'i>>",
            "<'col-lg-3 col-xs-12'<'text-center'l>>",
            "<'col-lg-5 col-xs-12'<'float-right'p>>",
            ">"
        ].join('')
    }
})