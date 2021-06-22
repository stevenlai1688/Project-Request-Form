$(function() {
    // call the tablesorter plugin and apply the uitheme widget
    const $table = $(".tablesorter").tablesorter({
            // this will apply the bootstrap theme if "uitheme" widget is included
            // the widgetOptions.uitheme is no longer required to be set
            theme: "bootstrap",

            headers: {
                //4: {
                //    sorter: false,
                //    filter: false
                //}
        
            },

            widthFixed: true,

            headerTemplate: "{content} {icon}", // new in v2.7. Needed to add the bootstrap icon!

            // widget code contained in the jquery.tablesorter.widgets.js file
            // use the zebra stripe widget if you plan on hiding any rows (filter widget)
            widgets: ["uitheme", "filter", "columns", "zebra"],

            widgetOptions: {
                // using the default zebra striping class name, so it actually isn't included in the theme variable above
                // this is ONLY needed for bootstrap theming if you are using the filter widget, because rows are hidden
                zebra: ["even", "odd"],

                // class names added to columns when sorted
                columns: ["primary", "secondary", "tertiary"],

                // reset filters button
                filter_reset: ".reset",

                filter_hideFilters: true,

                // extra css class name (string or array) added to the filter element (input or select)
                filter_cssFilter: "form-control",

                // set the uitheme widget to use the bootstrap theme class names
                // this is no longer required, if theme is set
                // ,uitheme : "bootstrap"

                filter_columnFilters: true,
                filter_saveFilters: true,
                filter_defaultFilter: {
                    // do exact match on select columns
                    '.filter-select': "={q}"
                },
                filter_functions: {
                    0: {
                        '{ empty }': function(e, n, f, i, $r, c) {
                            return $.trim(e) === "";
                        }
                    },
                    1: {
                        '{ empty }': function(e, n, f, i, $r, c) {
                            return $.trim(e) === "";
                        }
                    },
                    2: {
                        '{ empty }': function(e, n, f, i, $r, c) {
                            return $.trim(e) === "";
                        }
                    },
                    3: {
                        '{ empty }': function(e, n, f, i, $r, c) {
                            return $.trim(e) === "";
                        }
                    },
                    4: {
                        '{ empty }': function(e, n, f, i, $r, c) {
                            return $.trim(e) === "";
                        }
                    },
                    5: {
                        '{ empty }': function(e, n, f, i, $r, c) {
                            return $.trim(e) === "";
                        }
                    },
                    6: {
                        '{ empty }': function(e, n, f, i, $r, c) {
                            return $.trim(e) === "";
                        }
                    },
                    7: {
                        '{ empty }': function(e, n, f, i, $r, c) {
                            return $.trim(e) === "";
                        }
                    },
                    8: {
                        '{ empty }': function(e, n, f, i, $r, c) {
                            return $.trim(e) === "";
                        }
                    },
                    9: {
                        '{ empty }': function(e, n, f, i, $r, c) {
                            return $.trim(e) === "";
                        }
                    }
                },
                filter_selectSource: {
                    0: function(table, column, onlyAvail) {
                        // get an array of all table cell contents for a table column
                        var array = $.tablesorter.filter.getOptions(table, column, onlyAvail).sort();
                        // manipulate the array as desired, then return it
                        array.unshift("{ empty }");
                        return array;
                    },
                    1: function(table, column, onlyAvail) {
                        // get an array of all table cell contents for a table column
                        var array = $.tablesorter.filter.getOptions(table, column, onlyAvail).sort();
                        // manipulate the array as desired, then return it
                        array.unshift("{ empty }");
                        return array;
                    },
                    2: function(table, column, onlyAvail) {
                        // get an array of all table cell contents for a table column
                        var array = $.tablesorter.filter.getOptions(table, column, onlyAvail).sort();
                        // manipulate the array as desired, then return it
                        array.unshift("{ empty }");
                        return array;
                    },
                    3: function(table, column, onlyAvail) {
                        // get an array of all table cell contents for a table column
                        var array = $.tablesorter.filter.getOptions(table, column, onlyAvail).sort();
                        // manipulate the array as desired, then return it
                        array.unshift("{ empty }");
                        return array;
                    },
                    4: function(table, column, onlyAvail) {
                        // get an array of all table cell contents for a table column
                        var array = $.tablesorter.filter.getOptions(table, column, onlyAvail).sort();
                        // manipulate the array as desired, then return it
                        array.unshift("{ empty }");
                        return array;
                    },
                    5: function(table, column, onlyAvail) {
                        // get an array of all table cell contents for a table column
                        var array = $.tablesorter.filter.getOptions(table, column, onlyAvail).sort();
                        // manipulate the array as desired, then return it
                        array.unshift("{ empty }");
                        return array;
                    },
                    6: function(table, column, onlyAvail) {
                        // get an array of all table cell contents for a table column
                        var array = $.tablesorter.filter.getOptions(table, column, onlyAvail).sort();
                        // manipulate the array as desired, then return it
                        array.unshift("{ empty }");
                        return array;
                    },
                    7: function(table, column, onlyAvail) {
                        // get an array of all table cell contents for a table column
                        var array = $.tablesorter.filter.getOptions(table, column, onlyAvail).sort();
                        // manipulate the array as desired, then return it
                        array.unshift("{ empty }");
                        return array;
                    },
                    8: function(table, column, onlyAvail) {
                        // get an array of all table cell contents for a table column
                        var array = $.tablesorter.filter.getOptions(table, column, onlyAvail).sort();
                        // manipulate the array as desired, then return it
                        array.unshift("{ empty }");
                        return array;
                    },
                    9: function(table, column, onlyAvail) {
                        // get an array of all table cell contents for a table column
                        var array = $.tablesorter.filter.getOptions(table, column, onlyAvail).sort();
                        // manipulate the array as desired, then return it
                        array.unshift("{ empty }");
                        return array;
                    }
                }


            }
        })
        .tablesorterPager({

            // target the pager markup - see the HTML block below
            container: $(".ts-pager"),

            // target the pager page select dropdown - choose a page
            cssGoto: ".pagenum",

            // remove rows from the table to speed up the sort of large tables.
            // setting this to false, only hides the non-visible rows; needed if you plan to add/remove rows with the pager enabled.
            removeRows: false,

            // output string - default is '{page}/{totalPages}';
            // possible variables: {page}, {totalPages}, {filteredPages}, {startRow}, {endRow}, {filteredRows} and {totalRows}
            output: "{startRow} - {endRow} / {filteredRows} ({totalRows})"

        });

    // Target the $('.search') input using built in functioning
    // this binds to the search using "search" and "keyup"
    // Allows using filter_liveSearch or delayed search &
    // pressing escape to cancel the search
    $.tablesorter.filter.bindSearch($table, $("#searchbox"));


});