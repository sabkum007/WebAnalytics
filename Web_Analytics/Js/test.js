$(document).ready(function () {
    $("form#Submit").submit(function () {
        var count = $(this).data("count") || 0;
        if (count >= x) {
            //user clicked more than you wanted to so do something here 
        }

        $(this).data("count", ++count);
        alert(1);
    });

    function save() {
        alert(1);
    }
});