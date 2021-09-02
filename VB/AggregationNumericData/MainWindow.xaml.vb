Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace AggregationNumericData
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			DataContext = New AggregationDataContext()
		End Sub
	End Class

	Public Class AggregationDataContext
		Private Const pointCount As Integer = 100000

'INSTANT VB NOTE: The field series was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private ReadOnly series_Conflict As New List(Of NumericPoint)()

		Public ReadOnly Property Series() As List(Of NumericPoint)
			Get
				Return series_Conflict
			End Get
		End Property

		Public Sub New()
			FillPoints(series_Conflict)
		End Sub

		Private Sub FillPoints(ByVal series As List(Of NumericPoint))
			If series IsNot Nothing Then
				Dim value As Double = 0
				Dim argument As Double = 0
				Dim random As New Random()

				For i As Double = 0 To pointCount - 1
					series.Add(New NumericPoint(argument, value))
					value += (random.NextDouble() * 10.0 - 5.0)
					argument += random.NextDouble()
				Next i
			End If
		End Sub

	End Class

	Public Class NumericPoint
'INSTANT VB NOTE: The field argument was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private ReadOnly argument_Conflict As Double
'INSTANT VB NOTE: The field value was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private ReadOnly value_Conflict As Double

		Public ReadOnly Property Argument() As Double
			Get
				Return argument_Conflict
			End Get
		End Property
		Public ReadOnly Property Value() As Double
			Get
				Return value_Conflict
			End Get
		End Property

		Public Sub New(ByVal argument As Double, ByVal value As Double)
			Me.argument_Conflict = argument
			Me.value_Conflict = value
		End Sub
	End Class
End Namespace
