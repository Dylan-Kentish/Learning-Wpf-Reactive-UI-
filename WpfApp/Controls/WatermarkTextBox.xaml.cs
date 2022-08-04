﻿using System.Windows;
using System.Windows.Controls;
using ModernWpf.Controls;

namespace WpfApp.Controls
{
    /// <summary>
    /// Interaction logic for WatermarkTextBox.xaml
    /// </summary>
    public partial class WatermarkTextBox : Grid
    {
        public WatermarkTextBox()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            nameof(Text),
            typeof(string),
            typeof(WatermarkTextBox));

        public static readonly DependencyProperty WatermarkProperty = DependencyProperty.Register(
            nameof(Watermark),
            typeof(string),
            typeof(WatermarkTextBox));

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            nameof(Icon),
            typeof(string),
            typeof(WatermarkTextBox));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public string Watermark
        {
            get => (string)GetValue(WatermarkProperty);
            set => SetValue(WatermarkProperty, value);
        }

        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
    }
}
