<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128570275/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T112243)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/AggregationNumericData/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/AggregationNumericData/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/AggregationNumericData/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/AggregationNumericData/MainWindow.xaml.vb))
<!-- default file list end -->
# How to use manual numeric scale options of an Axis


<p>This example demonstrates how to use manual numeric scale options of an X-axis.</p>
<p>When the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAxisX2D_NumericScaleOptionstopic">AxisX2D.NumericScaleOptions </a> property is set to <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsManualNumericScaleOptionstopic">ManualNumericScaleOptions</a>  you can manually define the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsManualNumericScaleOptions_GridAlignmenttopic">ManualNumericScaleOptions.GridAlignment</a>,<strong> </strong><a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsManualNumericScaleOptions_MeasureUnittopic">ManualNumericScaleOptions.MeasureUnit</a>, and <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsManualNumericScaleOptions_AggregateFunctiontopic">ManualNumericScaleOptions.AggregateFunction</a>  properties.</p>
<p>To use the automatic numeric scale options, set the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAxisX2D_NumericScaleOptionstopic">AxisX2D.NumericScaleOptions</a> property to <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsAutomaticNumericScaleOptionstopic">AutomaticNumericScaleOptions</a>  and choose the appropriate <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAutomaticNumericScaleOptions_AggregateFunctiontopic">AutomaticNumericScaleOptions.AggregateFunction</a><strong>.</strong></p>
<p>To prevent the axis scale from being divided into intervals (and thus prevent chart data from being aggregated), set the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsManualNumericScaleOptions_AggregateFunctiontopic">ManualNumericScaleOptions.AggregateFunction </a> or <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAutomaticNumericScaleOptions_AggregateFunctiontopic">AutomaticNumericScaleOptions.AggregateFunction</a>  property to <strong>None</strong>.</p>

<br/>


