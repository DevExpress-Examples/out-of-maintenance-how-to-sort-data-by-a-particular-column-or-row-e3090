Imports System.Windows
Imports DevExpress.Xpf.PivotGrid

Namespace DXPivotGrid_SortBySummary

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource =(New nwindDataSetTableAdapters.SalesPersonTableAdapter()).GetData()
        End Sub

        Private Sub pivotGridControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ' Locks the pivot grid from updating while the Sort by Summary
            ' settings are being customized.
            'pivotGridControl1.BeginUpdate();
            Try
                ' Specifies a data field whose summary values should be used to sort values
                ' of the Product Name field.
                Me.fieldProductName.SortByField = Me.fieldUnitPrice
                ' Specifies a column by which the Product Name field values should be sorted.
                Me.fieldProductName.SortByConditions.Add(New SortByCondition(Me.fieldYear, 1994))
                Me.fieldProductName.SortByConditions.Add(New SortByCondition(Me.fieldMonth, 9))
            Finally
            ' Unlocks the pivot grid and applies changes.
            'pivotGridControl1.EndUpdate();
            End Try
        End Sub
    End Class
End Namespace
