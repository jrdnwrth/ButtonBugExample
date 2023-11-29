using System.Windows;
using System.Windows.Input;
using System.Windows.Shell;

namespace User_Interface.views;

/// <summary>
/// Reference: https://begincodingnow.com/wpf-custom-dialog/#:~:text=To%20create%20a%20custom%20dialog,%E2%80%A6%20and%20Window%20(WPF).
/// Example Usage: 
/// var dialog = new MessageInput(...);
///     if (dialog.ShowDialog() == true)
///         MessageBox.Show(dialog.user_feedback);
///     else
///         MessageBox.Show("Canceled");
/// </summary>
public partial class Auto_Populate_Popup : Window
{
    /// <summary>
    /// This contains the user's comment.  Read it if they click "OK".
    /// </summary>
    public string first_serial { get { return ui_first_serial.Text; } }
    public string count { get { return ui_count.Text; } }

    /// <param name="parent_window">Passing the paret allows us to center the window.</param>
    public Auto_Populate_Popup(DependencyObject? parent_window)
    {
        InitializeComponent();

        // Fix weird behavior
        WindowHelpers.fix_layout(this);

        // Center the window
        if (parent_window == null)
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        else
            this.Owner = Window.GetWindow(parent_window);

        // Place the cursor in the textbox.
        ui_first_serial.Focus();
    }

    private void on_click_close(object sender, RoutedEventArgs e)
    {
        this.DialogResult = false;  // This closes the window
    }

    private void on_click_accept(object sender, RoutedEventArgs e)
    {
        this.DialogResult = true;
    }

    private void on_mouse_left_button_down(object sender, MouseButtonEventArgs e)
    {
        DragMove();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        Height = ui_border.DesiredSize.Height + WindowChrome.GetWindowChrome(this).CaptionHeight;
        Width = ui_border.DesiredSize.Width;
    }
}

