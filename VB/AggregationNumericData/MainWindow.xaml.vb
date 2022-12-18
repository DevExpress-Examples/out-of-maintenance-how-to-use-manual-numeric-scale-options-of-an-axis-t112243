Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace AggregationNumericData

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            DataContext = New AggregationDataContext()
        End Sub
    End Class

    Public Class AggregationDataContext

        Const pointCount As Integer = 100000

        Private ReadOnly seriesField As List(Of NumericPoint) = New List(Of NumericPoint)()

        Public ReadOnly Property Series As List(Of NumericPoint)
            Get
                Return seriesField
            End Get
        End Property

        Public Sub New()
            FillPoints(seriesField)
        End Sub

        Private Sub FillPoints(ByVal series As List(Of NumericPoint))
            If series IsNot Nothing Then
                Dim value As Double = 0
                Dim argument As Double = 0
                Dim random As Random = New Random()
                For i As Double = 0 To pointCount - 1
                    series.Add(New NumericPoint(argument, value))
                    value +=(random.NextDouble() * 10.0 - 5.0)
                    argument += random.NextDouble()
                Next
            End If
        End Sub
    End Class

    Public Class NumericPoint

        Private ReadOnly argumentField As Double

        Private ReadOnly valueField As Double

        Public ReadOnly Property Argument As Double
            Get
                Return argumentField
            End Get
        End Property

        Public ReadOnly Property Value As Double
            Get
                Return valueField
            End Get
        End Property

        Public Sub New(ByVal argument As Double, ByVal value As Double)
            argumentField = argument
            valueField = value
        End Sub
    End Class
End Namespace
