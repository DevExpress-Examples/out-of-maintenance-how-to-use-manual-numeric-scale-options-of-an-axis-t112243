# How to use manual numeric scale options of an Axis


<p>This example demonstrates how to use manual numeric scale options of an X-axis.</p>
<p>When the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAxisX2D_NumericScaleOptionstopic">AxisX2D.NumericScaleOptions </a> property is set to <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsManualNumericScaleOptionstopic">ManualNumericScaleOptions</a>  you can manually define the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsManualNumericScaleOptions_GridAlignmenttopic">ManualNumericScaleOptions.GridAlignment</a>,<strong> </strong><a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsManualNumericScaleOptions_MeasureUnittopic">ManualNumericScaleOptions.MeasureUnit</a>, and <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsManualNumericScaleOptions_AggregateFunctiontopic">ManualNumericScaleOptions.AggregateFunction</a>  properties.</p>
<p>To use the automatic numeric scale options, set the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAxisX2D_NumericScaleOptionstopic">AxisX2D.NumericScaleOptions</a> property to <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsAutomaticNumericScaleOptionstopic">AutomaticNumericScaleOptions</a>  and choose the appropriate <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAutomaticNumericScaleOptions_AggregateFunctiontopic">AutomaticNumericScaleOptions.AggregateFunction</a><strong>.</strong></p>
<p>To prevent the axis scale from being divided into intervals (and thus prevent chart data from being aggregated), set the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsManualNumericScaleOptions_AggregateFunctiontopic">ManualNumericScaleOptions.AggregateFunction </a> or <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAutomaticNumericScaleOptions_AggregateFunctiontopic">AutomaticNumericScaleOptions.AggregateFunction</a>  property to <strong>None</strong>.</p>

<br/>


