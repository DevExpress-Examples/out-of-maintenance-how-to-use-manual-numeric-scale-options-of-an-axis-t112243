using System;
using System.Collections.Generic;
using System.Windows;

namespace AggregationNumericData
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new AggregationDataContext();
        }
    }

    public class AggregationDataContext
    {
        const int pointCount = 100000;

        readonly List<NumericPoint> series = new List<NumericPoint>();

        public List<NumericPoint> Series { get { return series; } }

        public AggregationDataContext()
        {
            FillPoints(series);
        }

        void FillPoints(List<NumericPoint> series)
        {
            if (series != null)
            {
                double value = 0;
                double argument = 0;
                Random random = new Random();

                for (double i = 0; i < pointCount; i++)
                {
                    series.Add(new NumericPoint(argument, value));
                    value += (random.NextDouble() * 10.0 - 5.0);
                    argument += random.NextDouble();
                }
            }
        }

    }

    public class NumericPoint
    {
        readonly double argument;
        readonly double value;

        public double Argument { get { return argument; } }
        public double Value { get { return value; } }

        public NumericPoint(double argument, double value)
        {
            this.argument = argument;
            this.value = value;
        }
    }
}
