(function () {
    console.log("ok");
    $(".datepicker").datepicker({
        changeMonth: true, //显示月份下拉框
        changeYear: true, //显示年份下拉框
        onSelect: function(dateText,inst) {
            $(this).focus();
        }
    });
})();