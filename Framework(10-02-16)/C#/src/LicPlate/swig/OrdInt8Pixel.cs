/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class OrdInt8Pixel : NumInt8Pixel {
  private HandleRef swigCPtr;

  internal OrdInt8Pixel(IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.OrdInt8Pixel_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(OrdInt8Pixel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~OrdInt8Pixel() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_OrdInt8Pixel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public OrdInt8Pixel() : this(VisionLabPINVOKE.new_OrdInt8Pixel__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public OrdInt8Pixel(int height, int width) : this(VisionLabPINVOKE.new_OrdInt8Pixel__SWIG_1(height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public OrdInt8Pixel(HeightWidth hw) : this(VisionLabPINVOKE.new_OrdInt8Pixel__SWIG_2(HeightWidth.getCPtr(hw)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public OrdInt8Pixel(OrdInt8Pixel image) : this(VisionLabPINVOKE.new_OrdInt8Pixel__SWIG_3(OrdInt8Pixel.getCPtr(image)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public OrdInt8Pixel(NumInt8Pixel image) : this(VisionLabPINVOKE.new_OrdInt8Pixel__SWIG_4(NumInt8Pixel.getCPtr(image)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Resize(HeightWidth hw) {
    VisionLabPINVOKE.OrdInt8Pixel_Resize__SWIG_0(swigCPtr, HeightWidth.getCPtr(hw));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Resize(HeightWidth hw, OrdInt8Pixel properties) {
    VisionLabPINVOKE.OrdInt8Pixel_Resize__SWIG_1(swigCPtr, HeightWidth.getCPtr(hw), OrdInt8Pixel.getCPtr(properties));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public static char BackGround() {
    char ret = VisionLabPINVOKE.OrdInt8Pixel_BackGround();
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static char Object() {
    char ret = VisionLabPINVOKE.OrdInt8Pixel_Object();
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
