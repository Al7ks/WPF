﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Fasetto.Word
{
    /// <summary>
    /// The NoFrameHistory attached property for creating a <see cref="Frame"/> that never shows navigation
    /// </summary>
    public class PanelChildMarginProperty : BaseAttachedProperty<PanelChildMarginProperty, string>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get the panel (grid typically)
            var panel = (sender as Panel);

            // Wait for panel to load
            panel.Loaded += (s, ee) =>
            {
                // Loop each child
                foreach(var child in panel.Children)
                {
                    // Set it's margin to the given value
                    (child as FrameworkElement).Margin = (Thickness)(new ThicknessConverter().ConvertFromString(e.NewValue as string));
                }
            };
        }
    }
}
