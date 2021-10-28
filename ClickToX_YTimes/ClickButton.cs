using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClickToX_YTimes
{
    class ClickButton
    {
        #region Mouse Event
        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x0002,
            LeftUp = 0x0004,
        }
        /// <summary>Simulate a mouse event with the system.</summary>
        /// <remarks>https://msdn.microsoft.com/en-us/library/windows/desktop/ms646260(v=vs.85).aspx</remarks>
        [DllImport("user32.dll")]
        public static extern void mouse_event(int flags, int x, int y, int data, int extraInfo);

        public void LeftDownClick(Point clickPoint)
        {
            Cursor.Position = clickPoint;
            mouse_event((int)MouseEventFlags.LeftDown, 0, 0, 0, 0);
        }
        public void LeftUpClick()
        {
            mouse_event((int)MouseEventFlags.LeftUp, 0, 0, 0, 0);
        }
        #endregion

        #region Constant, Structure and Delegate Definitions

        public delegate int KeyBoardHookProc(int code, int wParam, ref KeyBoardHookStruct lParam);

        public struct KeyBoardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;
        const int WM_SYSKEYDOWN = 0x104;
        const int WM_SYSKEYUP = 0x105;
        #endregion

        #region Instance Variables

        public List<Keys> hookedKeys = new List<Keys>();

        IntPtr hhook = IntPtr.Zero;
        #endregion

        #region Events

        public event KeyEventHandler KeyDown;

        public event KeyEventHandler KeyUp;
        #endregion

        #region Constructors and Destructors

        public ClickButton()
        {
            Hook();
        }
        ~ClickButton()
        {
            Unhook();
        }
        #endregion

        #region Public Methods
        public void Hook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, HookProc, hInstance, 0);
        }
        public void Unhook()
        {
            UnhookWindowsHookEx(hhook);
        }
        public int HookProc(int code, int wParam, ref KeyBoardHookStruct lParam)
        {
            if (code >= 0)
            {
                Keys key = (Keys)lParam.vkCode;
                if (hookedKeys.Contains(key))
                {
                    KeyEventArgs kea = new KeyEventArgs(key);
                    if ((wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN) && (KeyDown != null))
                    {
                        KeyDown(this, kea);
                    }
                    else if ((wParam == WM_KEYUP || wParam == WM_SYSKEYUP) && (KeyUp != null))
                    {
                        KeyUp(this, kea);
                    }
                    if (kea.Handled)
                        return 1;
                }
            }
            return CallNextHookEx(hhook, code, wParam, ref lParam);
        }
        #endregion

        #region DLL imports
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, KeyBoardHookProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref KeyBoardHookStruct lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);
        #endregion
    }
}
