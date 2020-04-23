## Web Document Viewer - How to show a detail report in a popup

This example illustrates how to show a detail report in the [DevExtreme Popup](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxPopup/) widget.
To accomplish this task, we need to store a parent key field that should be used to filter a detail report. For this, the BeforePrint **event of table cells that belong to the table showing data of the main report is handled. In the event handler, the value of the master key field is written to the Tag property of a table cell.

It is also necessary to handle the client-side [PreviewClick](https://docs.devexpress.com/XtraReports/DevExpress.AspNetCore.Reporting.WebDocumentViewer.WebDocumentViewerClientSideEventsBuilder.PreviewClick(System.String)) event of the Web Document Viewer. In this event handler, we obtain the master key field value from the Tag property of the clicked table cell and assign this value to the corresponding [report parameter](https://docs.devexpress.com/XtraReports/9997/detailed-guide-to-devexpress-reporting/shape-report-data/use-report-parameters/parameters-overview) in a detail report. The parameter is used to filter a detail report.

Finally, a popup with the Web Document Viewer which contains a filtered detail report is shown.
