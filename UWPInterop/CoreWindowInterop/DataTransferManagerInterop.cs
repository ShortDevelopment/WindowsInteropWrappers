﻿using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;

namespace UWPInterop.CoreWindowInterop
{
    [ComImport, Guid("3A3DCD6C-3EAB-43DC-BCDE-45671CE800C8")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDataTransferManagerInterop
    {
        DataTransferManager GetForWindow(IntPtr appWindow, [In] ref Guid riid);
        void ShowShareUIForWindow(IntPtr appWindow);
    }

    //Helper to initialize DataTransferManager
    public static class DataTransferManagerInterop
    {
        public static DataTransferManager GetForWindow(IntPtr hWnd)
        {
            IDataTransferManagerInterop dataTransferManagerInterop = (IDataTransferManagerInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(DataTransferManager));
            Guid guid = typeof(DataTransferManager).GUID; // Seems to be wrong?!
            Guid guid3 = new Guid("a5caee9b-8708-49d1-8d36-67d25a8da00c");

            return dataTransferManagerInterop.GetForWindow(hWnd, guid3);
        }

        public static void ShowShareUIForWindow(IntPtr hWnd)
        {
            IDataTransferManagerInterop dataTransferManagerInterop = (IDataTransferManagerInterop)WindowsRuntimeMarshal.GetActivationFactory(typeof(DataTransferManager));

            dataTransferManagerInterop.ShowShareUIForWindow(hWnd);
        }
    }
}
