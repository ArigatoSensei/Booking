$(document).ready(function () {
    loadCustomerReservationPieChart();
});

function loadCustomerReservationPieChart() {
    $(".chart-spinner").show();

    $.ajax({
        url: "/Dashboard/GetReservationPieChartData",
        type: 'GET',
        dataType: 'json',
        success: function (data) {

            loadPieChart("customerReservationsPieChart", data);

            $(".chart-spinner").hide();
        }
    });
}

function loadPieChart(id, data) {
    var chartColors = getChartColorsArray(id);
    var options = {
        colors: chartColors,
        series: data.series,
        labels: data.labels,
        chart: {
            width: 380,
            type: 'pie',
        },
        stroke: {
            show: false
        },
        legend: {
            position: 'bottom',
            horizontalAlign: 'center',
            labels: {
                colors: "#fff",
                useSeriesColors: true
            },
        },
    };
    var chart = new ApexCharts(document.querySelector("#" + id), options);
    chart.render();
}