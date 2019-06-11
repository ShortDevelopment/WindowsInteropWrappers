﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Input.Spatial;

namespace WindowsInterop
{
    //MIDL_INTERFACE("5C4EE536-6A98-4B86-A170-587013D6FD4B")
    //ISpatialInteractionManagerInterop : public IInspectable
    //{
    //public:
    //    virtual HRESULT STDMETHODCALLTYPE GetForWindow(
    //        /* [in] */ __RPC__in HWND window,
    //        /* [in] */ __RPC__in REFIID riid,
    //        /* [iid_is][retval][out] */ __RPC__deref_out_opt void** spatialInteractionManager) = 0;

    //};
    [System.Runtime.InteropServices.Guid("5C4EE536-6A98-4B86-A170-587013D6FD4B")]
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIInspectable)]
    interface ISpatialInteractionManagerInterop
    {
        SpatialInteractionManager GetForWindow(IntPtr Window, [System.Runtime.InteropServices.In] ref Guid riid);
    }
}
