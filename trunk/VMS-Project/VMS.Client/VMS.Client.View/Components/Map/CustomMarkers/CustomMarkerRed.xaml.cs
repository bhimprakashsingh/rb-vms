﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using GMap.NET.WindowsPresentation;

namespace VMS.Client.View.Component.Map.CustomMarkers
{
   /// <summary>
   /// Interaction logic for CustomMarkerDemo.xaml
   /// </summary>
   public partial class CustomMarkerRed
   {
      Popup Popup;
      Label Label;
      GMapMarker Marker;
      MapsView mapsView;

      public CustomMarkerRed(MapsView view, GMapMarker marker, string title)
      {
         this.InitializeComponent();

         this.mapsView = view;
         this.Marker = marker;

         Popup = new Popup();
         Label = new Label();

         this.Loaded += new RoutedEventHandler(CustomMarkerDemo_Loaded);
         this.SizeChanged += new SizeChangedEventHandler(CustomMarkerDemo_SizeChanged);
         this.MouseEnter += new MouseEventHandler(MarkerControl_MouseEnter);
         this.MouseLeave += new MouseEventHandler(MarkerControl_MouseLeave);
         this.MouseMove += new MouseEventHandler(CustomMarkerDemo_MouseMove);
         this.MouseLeftButtonUp += new MouseButtonEventHandler(CustomMarkerDemo_MouseLeftButtonUp);
         this.MouseLeftButtonDown += new MouseButtonEventHandler(CustomMarkerDemo_MouseLeftButtonDown);

         Popup.Placement = PlacementMode.Mouse;
         {
            Label.Background = Brushes.Blue;
            Label.Foreground = Brushes.White;
            Label.BorderBrush = Brushes.WhiteSmoke;
            Label.BorderThickness = new Thickness(2);
            Label.Padding = new Thickness(5);
            Label.FontSize = 22;
            Label.Content = title;
         }
         Popup.Child = Label;
      }

      void CustomMarkerDemo_Loaded(object sender, RoutedEventArgs e)
      {
         if(icon.Source.CanFreeze)
         {
            icon.Source.Freeze();
         }
      }

      void CustomMarkerDemo_SizeChanged(object sender, SizeChangedEventArgs e)
      {
         Marker.Offset = new Point(-e.NewSize.Width/2, -e.NewSize.Height);
      }

      void CustomMarkerDemo_MouseMove(object sender, MouseEventArgs e)
      {
         if(e.LeftButton == MouseButtonState.Pressed && IsMouseCaptured)
         {
            Point p = e.GetPosition(mapsView.MainMap);
            Marker.Position = mapsView.MainMap.FromLocalToLatLng((int) p.X, (int) p.Y);
         }
      }

      void CustomMarkerDemo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
      {
         if(!IsMouseCaptured)
         {
            Mouse.Capture(this);
         }
      }

      void CustomMarkerDemo_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
      {
         if(IsMouseCaptured)
         {
            Mouse.Capture(null);
         }
      }

      void MarkerControl_MouseLeave(object sender, MouseEventArgs e)
      {
         Marker.ZIndex -= 10000;
         Popup.IsOpen = false;
      }

      void MarkerControl_MouseEnter(object sender, MouseEventArgs e)
      {
         Marker.ZIndex += 10000;
         Popup.IsOpen = true;
      }
   }
}