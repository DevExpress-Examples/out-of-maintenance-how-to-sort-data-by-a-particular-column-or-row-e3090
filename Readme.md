<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3090)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXPivotGrid_SortBySummary/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXPivotGrid_SortBySummary/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_SortBySummary/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_SortBySummary/MainWindow.xaml.vb))
<!-- default file list end -->
# How to sort data by a particular column or row


<p>The following example demonstrates how to sort data by a particular column.</p><p>In this example, values of the Product Name field are sorted by September 1994 column summary values. To do this, two sort conditions represented by SortByCondition instances are created. One of them identifies the '1994' field value, while another identifies the 'September' value. These sort conditions are added to the Product Name field's PivotGridField.SortByConditions collection to specify the column by which Product Name values should be sorted. A data field that identifies the column is specified via the PivotGridField.SortByField property.</p>

<br/>


