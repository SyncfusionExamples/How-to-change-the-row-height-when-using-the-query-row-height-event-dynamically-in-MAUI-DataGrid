# How to change the row height when using the query row height event dynamically in MAUI DataGrid?

The [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) provides support for setting row height based on the row content using the QueryRowHeight event.

In order to trigger this event at runtime, like resizing the windows or resizing the column, We can use the `InvalidateRowHeight` method to invoke the event at runtime.

#### XAML
```XML
<syncfusion:SfDataGrid x:Name="dataGrid"
                        AutoGenerateColumnsMode="None"                       
                        AllowResizingColumns="True"
                        ColumnResizing="dataGrid_ColumnResizing"
                        GridLinesVisibility="Both"
                        HeaderGridLinesVisibility="Both"
                        x:DataType="viewModel:EmployeeViewModel" 
                        QueryRowHeight="dataGrid_QueryRowHeight"
                        PropertyChanged="dataGrid_PropertyChanged"
                        ItemsSource="{Binding EmployeeInformation}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn HeaderText="Name" MappingName="Name"  />
        <syncfusion:DataGridTextColumn HeaderText="Employee ID" MappingName="EmployeeID"  />
        <syncfusion:DataGridTextColumn HeaderText="Telephone" MappingName="Telephone"/>
        <syncfusion:DataGridTextColumn HeaderText="About" MappingName="About"/>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>

```
#### C#
This event will set the row height based on its content.
```C#
private void ordersDataGrid_QueryRowHeight(object sender, Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex > 0)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
        e.Handled = true;
    }
}
```
This event will be called when the column is resized. We will get the visible rows in the view and then we will set the row height dynamically when the column is resized.
```C#
private void dataGrid_ColumnResizing(object sender, Syncfusion.Maui.DataGrid.DataGridColumnResizingEventArgs e)
{
    var VisibleRowCount = dataGrid.GetVisualContainer().ScrollRows.GetVisibleLines().Count;
    for (int i = 0; i < VisibleRowCount; i++)
    {
        dataGrid.InvalidateRowHeight(i);
    }
}
```
This event will be called when the window or datagrid is resized. We will get the visible rows in the view, and then we will set the row height dynamically .
```C#
private void ordersDataGrid_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
{
    if (e.PropertyName!.Equals("Width"))
    {
        var VisibleRowCount = dataGrid.GetVisualContainer().ScrollRows.GetVisibleLines().Count;
        for (int i = 0; i < VisibleRowCount; i++)
        {
            dataGrid.InvalidateRowHeight(i);
        }
    }
}

```
![DataGrid Dynamic Row height](SfDataGrid_Dynamic_RowHeight.gif)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-change-the-row-height-when-using-the-query-row-height-event-dynamically-in-MAUI-DataGrid)

Take a moment to pursue this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples.
Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid(SfDataGrid).

### Conclusion
I hope you enjoyed learning about how to change the row height when using the query row height event dynamically in MAUI DataGrid.

You can refer to our [.NET MAUI DataGrid's feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to know about its other groundbreaking feature representations. You can also explore our .NET MAUI DataGrid Documentation to understand how to present and manipulate data.
For current customers, you can check out our .NET MAUI components from the [License and Downloads](https://www.syncfusion.com/account/downloads) page. If you are new to Syncfusion, you can try our 30-day free trial to check out our .NET MAUI DataGrid and other .NET MAUI components.
If you have any queries or require clarifications, please let us know in comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/account/login?ReturnUrl=%2Faccount%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dc54e52f3eb3cde0c3f20474f1bc179ed%26redirect_uri%3Dhttps%253A%252F%252Fsupport.syncfusion.com%252Fagent%252Flogincallback%26response_type%3Dcode%26scope%3Dopenid%2520profile%2520agent.api%2520integration.api%2520offline_access%2520kb.api%26state%3D8db41f98953a4d9ba40407b150ad4cf2%26code_challenge%3DvwHoT64z2h21eP_A9g7JWtr3vp3iPrvSjfh5hN5C7IE%26code_challenge_method%3DS256%26response_mode%3Dquery) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid). We are always happy to assist you!