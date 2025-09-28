using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        var welcomeForm = new Form
        {
            Text = "Welcome Window",
            Width = 300,
            Height = 180,
            StartPosition = FormStartPosition.CenterScreen
        };

        var welcomeButton = new Button
        {
            Text = "Welcome",
            Width = 100,
            Height = 40,
            Left = (welcomeForm.ClientSize.Width - 100) / 2,
            Top = (welcomeForm.ClientSize.Height - 40) / 2
        };

        welcomeButton.Click += (_, __) =>
        {
            MessageBox.Show("Hello World!", "提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        welcomeForm.Controls.Add(welcomeButton);

        // 若仍被 IDE 判成別的 Application，保險用完整名稱
        System.Windows.Forms.Application.Run(welcomeForm);
    }
}
