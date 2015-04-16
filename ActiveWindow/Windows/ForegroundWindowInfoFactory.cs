using System;
using System.Diagnostics;
using System.Text;

namespace ActiveWindow.Windows
{
    internal sealed class ForegroundWindowInfoFactory
    {
        public ForegroundWindowInfo Create()
        {
            var foregroundWindow = NativeFunctions.GetForegroundWindow();
            var windowTextLength = NativeFunctions.GetWindowTextLength(foregroundWindow) + 1;
            var windowTitle = new StringBuilder(windowTextLength);

            if (windowTextLength > 0)
            {
                NativeFunctions.GetWindowText(foregroundWindow, windowTitle, windowTextLength);
            }

            var processPath = GetProcessPathFromWindowHandle(foregroundWindow);

            return new ForegroundWindowInfo
            {
                Path = processPath,
                WindowTitle = windowTitle.ToString()
            };
        }

        private string GetProcessPathFromWindowHandle(IntPtr hwnd)
        {
            try
            {
                uint pid;
                NativeFunctions.GetWindowThreadProcessId(hwnd, out pid);
                var p = Process.GetProcessById((int)pid);
                return p.MainModule.FileName;
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return null;
            }
        }
    }
}
