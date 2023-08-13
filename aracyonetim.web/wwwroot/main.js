function clearForm() {
    $('[name="id"]').val(0);
    let form = $("#genericform").dxForm("instance");
    form.resetValues();
    form.itemOption('silbtn', 'visible', false);
}

let deleteUrl = "";
function deleteItem() {
    fetch(deleteUrl + '?id=' + $('[name="id"]').val())
        .then(res => res.json())
        .then(res => {

            if (res) {
                DevExpress.ui.notify("Başarılı! İşlem tamamlandı.", "success", 1000);
                initData(tpage.url + "/list");
                $('#genericmodal').modal('hide')
            } else {
                DevExpress.ui.notify("Başarısız! Lütfen daha sonra tekrar deneyiniz.", "error", 1000);
            }
            $('#deletemodal').modal('hide')
        })
}

function deleteForm() {
    $('#deletemodal').modal('show')
}
var tpage;
$(function () {
    fetch('/Yetkiler/RolMenuler')
        .then(res => res.json())
        .then(res => {
            res.map(item =>
                $('#menuul').append('<li class="nav-item"><a href="' + item.adres + '" class="nav-link"><i data-feather="' + item.icon + '"></i> <span>' + item.isim + '</span></a></li>'));
            feather.replace();
            if (tpage)
            $('[href="' + tpage.url + '"]').parent().addClass("active");
        })
    let page = pages.find(f => f.url.toLowerCase() == window.location.pathname.toLowerCase());
    if (page)
        pageInit(page)
});

function pageInit(page) {
    tpage = page;
    if (page.onInit) {
        page.onInit()
    }
    $('.pageHeader').text(page.name);

    $('#genericforparent').attr("action", page.url + "/Save");


    deleteUrl = page.url + "/Remove";

    $("#genericform").dxForm({
        labelLocation: "top",
        items: page.form
    });

    $("#generictable").dxDataGrid({
        paging: {
            pageSize: 10
        },
        pager: {
            showPageSizeSelector: true,
            allowedPageSizes: [5, 10, 20],
            showInfo: true
        },
        export: {
            enabled: true,
            fileName: page.name + " " + Date.now().toLocaleString()
        },
        columnChooser: {
            enabled: true,
            mode: "select",
            title: "Sütun Seç"
        },
        filterRow: {
            visible: true,
            applyFilter: "auto"
        },
        searchPanel: {
            visible: true,
            width: 240,
            placeholder: "Ara..."
        },
        headerFilter: {
            visible: true
        },
        grouping: {
            autoExpandAll: true
        },
        scrolling: {
            mode: "infinite"
        },
        selection: {
            mode: 'single'
        },
        hoverStateEnabled: true,
        editing: {
            editMode: 'row',
            editEnabled: true,
            removeEnabled: true,
            insertEnabled: true
        },
        sorting: {
            mode: 'multiple'
        },
        allowColumnReordering: true,
        allowColumnResizing: true,
        columnAutoWidth: true,
        showColumnLines: true,
        showRowLines: true,
        rowAlternationEnabled: true,
        columnFixing: {
            enabled: true
        },
        showBorders: true,
        stateStoring: {
            enabled: true
        },
        columns: page.table
    });
    initData(page.url + "/List");
}

$('form').on('submit', function (event) {
    event.preventDefault();
    const formData = new FormData(event.currentTarget);
    fetch(event.currentTarget.action, {
        method: 'post',
        body: formData
    }).then(res => res.json())
        .then(res => {
            if (res) {
                DevExpress.ui.notify("Başarılı! İşlem tamamlandı.", "success", 1000);
                initData(tpage.url + "/list");
                $('#genericmodal').modal('hide')
            } else {
                DevExpress.ui.notify("Başarısız! Lütfen daha sonra tekrar deneyiniz.", "error", 1000);
            }
            buttonIndicator.option("visible", false);
        });
})

function initData(url) {
    fetch(url)
        .then(res => res.json())
        .then(items => {
            $("#generictable").dxDataGrid("instance").option("dataSource", { store: { type: 'array', data: items.data, totalCount: items.totalCount, key: "id" } })
        });
}