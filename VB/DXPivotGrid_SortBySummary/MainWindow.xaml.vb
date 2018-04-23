Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid

Namespace DXPivotGrid_SortBySummary
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = _
				(New nwindDataSetTableAdapters.SalesPersonTableAdapter()).GetData()
		End Sub
		Private Sub pivotGridControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)

			' Locks the pivot grid from updating while the Sort by Summary
			' settings are being customized.
			pivotGridControl1.BeginUpdate()
			Try

				' Specifies a data field whose summary values should be used to sort values
				' of the Product Name field.
				fieldProductName.SortByField = fieldUnitPrice

				' Specifies a column by which the Product Name field values should be sorted.
				fieldProductName.SortByConditions.Add(New SortByCondition(fieldYear, "1994"))
				fieldProductName.SortByConditions.Add(New SortByCondition(fieldMonth, "9"))
			Finally

				' Unlocks the pivot grid and applies changes.
				pivotGridControl1.EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
