
$(window).on('load', function () {
    $('.loader').fadeOut('slow');
});
function confirmDelete(itemId) {
    swal({
        title: "آیا برای حذف مطئنید؟",
        text: "پس از حذف امکان بازیابی اطلاعات نمی باشد!",
        icon: "warning",
        buttons: true,
        confirmButtonText: "kkkk",
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            deleteItem(itemId);
        }
    });
}

function deleteItem(itemId) {
    fetch(`/Contact/Delete/${itemId}`, {
        method: "DELETE"
    }).then(response => {
        if (response.ok) {
            swal("حذف شد!", "سطر مورد نظر با موفقیت حذف شد", "success").then(() => {

                location.reload();
            });
        } else {
            swal("Error", "An error occurred while deleting the item", "error");
        }
    }).catch(error => {
        swal("Error", "An error occurred while deleting the item", "error");
    });
}

$(document).ready(function () {
    $("#myInput").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});

function sortTable(n) {
    var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
    table = document.getElementById("myTable");
    switching = true;
    dir = "asc";
    while (switching) {
        switching = false;
        rows = table.rows;
        for (i = 1; i < (rows.length - 1); i++) {
            shouldSwitch = false;
            x = rows[i].getElementsByTagName("TD")[n];
            y = rows[i + 1].getElementsByTagName("TD")[n];
            if (dir == "asc") {
                if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                    shouldSwitch = true;
                    break;
                }
            } else if (dir == "desc") {
                if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                    shouldSwitch = true;
                    break;
                }
            }
        }
        if (shouldSwitch) {
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = true;
            switchcount++;
        } else {
            if (switchcount == 0 && dir == "asc") {
                dir = "desc";
                switching = true;
            }
        }
    }
}