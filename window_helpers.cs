using System;
using System.Windows;

namespace User_Interface.views;

public static class WindowHelpers
{
    /// <summary>
    /// https://stackoverflow.com/questions/29207331/wpf-window-with-custom-chrome-has-unwanted-outline-on-right-and-bottom
    /// </summary>
    public static void fix_layout(this Window window)
    {
        void Window_SourceInitialized(object sender, EventArgs e)
        {
            window.InvalidateMeasure();
            window.SourceInitialized -= Window_SourceInitialized;
        }

        window.SourceInitialized += Window_SourceInitialized;
    }
}