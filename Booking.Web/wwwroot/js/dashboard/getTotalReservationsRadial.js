$(document).ready(function () {
    loadTotalReservationRadialChart();
});

function loadTotalReservationRadialChart() {
    $(".chart-spinner").show();

    $.ajax({
        url: "/Dashboard/GetTotalReservationRadialChartData",
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            document.querySelector("#spanTotalReservationCount").innerHTML = data.totalCount;

            var sectionCurrentCount = document.createElement("span");
            if (data.hasRatioIncreased) {
                sectionCurrentCount.className = "text-success me-1";
                sectionCurrentCount.innerHTML = '<i class="bi bi-arrow-up-right-circle me-1"></i> <span> ' + data.countInCurrentMonth + '</span>';
            }
            else {
                sectionCurrentCount.className = "text-danger me-1";
                sectionCurrentCount.innerHTML = '<i class="bi bi-arrow-down-right-circle me-1"></i> <span> ' + data.countInCurrentMonth + '</span>';
            }

            document.querySelector("#sectionReservationCount").append(sectionCurrentCount);
            document.querySelector("#sectionReservationCount").append("since last month");

            loadRadialBarChart("totalReservationsRadialChart", data);

            $(".chart-spinner").hide();
        }
    });
}

