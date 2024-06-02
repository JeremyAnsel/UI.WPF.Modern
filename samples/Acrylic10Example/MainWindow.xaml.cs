﻿using iNKORE.UI.WPF.Modern.Controls.Helpers;
using iNKORE.UI.WPF.Modern.Controls.Primitives;
using iNKORE.UI.WPF.Modern.Helpers.Styles;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;

namespace Acrylic10Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WindowChrome.SetWindowChrome(this, new WindowChrome()
            {
                GlassFrameThickness = new Thickness(0, 1, 0, 0),
                UseAeroCaptionButtons = false,
                CornerRadius = new CornerRadius(0),
                ResizeBorderThickness = new Thickness(4),
                NonClientFrameEdges = NonClientFrameEdges.None,
                CaptionHeight = 36d,

            });

            WindowHelper.SetApplyBackground(this, false);
            AcrylicHelper.Apply(this, true);
        }
    }
}