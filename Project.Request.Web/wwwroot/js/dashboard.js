const dashboardApiUrl = "/api/Dashboard";

$(function() {
    var data = genericAJAX(`${dashboardApiUrl}/GetIdeasInMotionStatus`, "GET", {});

    data.then(json => {
        if (!$.isEmptyObject(json)) {
            showStatusItems(json);
            showChart(json);
        }
    });
});

function showStatusItems(items) {
    const $container = $("#dashboard-items-container");
    const totalIdeas = items.reduce((acc, idea) => acc + idea.ideasInMotion, 0);

    let statusItems = "";

    $.each(items,
        (i, e) => {
            statusItems += `
        <div class="dashboard-counter col-lg-3 col-md-3 col-sm-4 col-xs-6">
            <div class="dashboard-item">
                <div class="dashboard-item-content">

                    <span class="item-title">${e.ideasInMotion} <span>of ${totalIdeas}</span></span>
                    <a title="See details..." class="item-subtitle" href="IdeasInMotion?status=${e.status != null
                ? e.status
                : "All"}">${e.status != null ? e.status : "No Status"}</a>
                </div>
            </div>
        </div>`;
        });

    $container.append(statusItems);
}

function showChart(json) {
    console.log(json);
    Highcharts.chart("ideas-in-motion-chart",
        {
            chart: {
                type: "column"
            },
            title: {
                text: "Ideas In Motion by Status"
            },
            subtitle: {
                text: ""
            },
            credits: {
                enabled: false
            },
            exporting: {
                enabled: false
            },
            xAxis: {
                categories: json.map(x => { return x.status != null ? x.status : "No Status" }),
                crosshair: true
            },
            yAxis: {
                min: 0,
                allowDecimals: false,
                title: {
                    text: "Total Ideas"
                }
            },
            tooltip: {
                headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
                pointFormat: '<tr><td style="color:{series.color};padding:0">Amount: </td>' +
                    '<td style="padding:0"><b>{point.y}</b></td></tr>',
                footerFormat: "</table>",
                shared: true,
                useHTML: true
            },
            plotOptions: {
                series: {
                    cursor: "pointer",
                    events: {
                        click: event => {
                            location.href =
                                "IdeasInMotion" +
                                (event.point.category != "No Status" ? "?status=" + event.point.category : "");
                        }
                    }
                },
                column: {
                    pointPadding: 0.2,
                    borderWidth: 0
                }
            },
            series: [
                {
                    name: "Ideas In Motion",
                    color: "#0173C7",
                    data: json.map(x => { return x.ideasInMotion })
                }
            ]
        });
}