/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class HSV161616Pixel : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal HSV161616Pixel(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(HSV161616Pixel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HSV161616Pixel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_HSV161616Pixel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public HSV161616Pixel(int v) : this(VisionLabPINVOKE.new_HSV161616Pixel__SWIG_0(v), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public HSV161616Pixel() : this(VisionLabPINVOKE.new_HSV161616Pixel__SWIG_1(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public HSV161616Pixel(short h, short s, short i) : this(VisionLabPINVOKE.new_HSV161616Pixel__SWIG_2(h, s, i), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public HSV161616Pixel(HSV888Pixel pixel) : this(VisionLabPINVOKE.new_HSV161616Pixel__SWIG_3(HSV888Pixel.getCPtr(pixel)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEqual_Op(HSV161616Pixel p) {
    bool ret = VisionLabPINVOKE.HSV161616Pixel_IsEqual_Op(swigCPtr, HSV161616Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(HSV161616Pixel p) {
    bool ret = VisionLabPINVOKE.HSV161616Pixel_Not(swigCPtr, HSV161616Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Pixel Add(HSV161616Pixel p) {
    HSV161616Pixel ret = new HSV161616Pixel(VisionLabPINVOKE.HSV161616Pixel_Add(swigCPtr, HSV161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Pixel Subtract(HSV161616Pixel p) {
    HSV161616Pixel ret = new HSV161616Pixel(VisionLabPINVOKE.HSV161616Pixel_Subtract(swigCPtr, HSV161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Pixel Multiply(HSV161616Pixel p) {
    HSV161616Pixel ret = new HSV161616Pixel(VisionLabPINVOKE.HSV161616Pixel_Multiply(swigCPtr, HSV161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Pixel Divide(HSV161616Pixel p) {
    HSV161616Pixel ret = new HSV161616Pixel(VisionLabPINVOKE.HSV161616Pixel_Divide(swigCPtr, HSV161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Pixel Add_Op(HSV161616Pixel p) {
    HSV161616Pixel ret = new HSV161616Pixel(VisionLabPINVOKE.HSV161616Pixel_Add_Op(swigCPtr, HSV161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Pixel Subtract_Op(HSV161616Pixel p) {
    HSV161616Pixel ret = new HSV161616Pixel(VisionLabPINVOKE.HSV161616Pixel_Subtract_Op(swigCPtr, HSV161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Pixel Multiply_Op(HSV161616Pixel p) {
    HSV161616Pixel ret = new HSV161616Pixel(VisionLabPINVOKE.HSV161616Pixel_Multiply_Op(swigCPtr, HSV161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Pixel Divide_Op(HSV161616Pixel p) {
    HSV161616Pixel ret = new HSV161616Pixel(VisionLabPINVOKE.HSV161616Pixel_Divide_Op(swigCPtr, HSV161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_int colOffTab {
    get {
      IntPtr cPtr = VisionLabPINVOKE.HSV161616Pixel_colOffTab_get();
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static short MAXValue {
    get {
      short ret = VisionLabPINVOKE.HSV161616Pixel_MAXValue_get();
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public short value {
    set {
      VisionLabPINVOKE.HSV161616Pixel_value_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      short ret = VisionLabPINVOKE.HSV161616Pixel_value_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public short saturation {
    set {
      VisionLabPINVOKE.HSV161616Pixel_saturation_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      short ret = VisionLabPINVOKE.HSV161616Pixel_saturation_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public short hue {
    set {
      VisionLabPINVOKE.HSV161616Pixel_hue_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      short ret = VisionLabPINVOKE.HSV161616Pixel_hue_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
