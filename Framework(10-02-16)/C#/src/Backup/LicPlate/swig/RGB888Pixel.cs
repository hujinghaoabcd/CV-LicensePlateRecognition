/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class RGB888Pixel : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RGB888Pixel(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RGB888Pixel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RGB888Pixel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_RGB888Pixel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RGB888Pixel(int v) : this(VisionLabPINVOKE.new_RGB888Pixel__SWIG_0(v), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public RGB888Pixel() : this(VisionLabPINVOKE.new_RGB888Pixel__SWIG_1(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public RGB888Pixel(byte r, byte g, byte b) : this(VisionLabPINVOKE.new_RGB888Pixel__SWIG_2(r, g, b), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEqual_Op(RGB888Pixel p) {
    bool ret = VisionLabPINVOKE.RGB888Pixel_IsEqual_Op(swigCPtr, RGB888Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(RGB888Pixel p) {
    bool ret = VisionLabPINVOKE.RGB888Pixel_Not(swigCPtr, RGB888Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB888Pixel Add(RGB888Pixel p) {
    RGB888Pixel ret = new RGB888Pixel(VisionLabPINVOKE.RGB888Pixel_Add(swigCPtr, RGB888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB888Pixel Subtract(RGB888Pixel p) {
    RGB888Pixel ret = new RGB888Pixel(VisionLabPINVOKE.RGB888Pixel_Subtract(swigCPtr, RGB888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB888Pixel Multiply(RGB888Pixel p) {
    RGB888Pixel ret = new RGB888Pixel(VisionLabPINVOKE.RGB888Pixel_Multiply(swigCPtr, RGB888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB888Pixel Divide(RGB888Pixel p) {
    RGB888Pixel ret = new RGB888Pixel(VisionLabPINVOKE.RGB888Pixel_Divide(swigCPtr, RGB888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB888Pixel Add_Op(RGB888Pixel p) {
    RGB888Pixel ret = new RGB888Pixel(VisionLabPINVOKE.RGB888Pixel_Add_Op(swigCPtr, RGB888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB888Pixel Subtract_Op(RGB888Pixel p) {
    RGB888Pixel ret = new RGB888Pixel(VisionLabPINVOKE.RGB888Pixel_Subtract_Op(swigCPtr, RGB888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB888Pixel Multiply_Op(RGB888Pixel p) {
    RGB888Pixel ret = new RGB888Pixel(VisionLabPINVOKE.RGB888Pixel_Multiply_Op(swigCPtr, RGB888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB888Pixel Divide_Op(RGB888Pixel p) {
    RGB888Pixel ret = new RGB888Pixel(VisionLabPINVOKE.RGB888Pixel_Divide_Op(swigCPtr, RGB888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_int colOffTab {
    get {
      global::System.IntPtr cPtr = VisionLabPINVOKE.RGB888Pixel_colOffTab_get();
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static byte MAXValue {
    get {
      byte ret = VisionLabPINVOKE.RGB888Pixel_MAXValue_get();
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte blue {
    set {
      VisionLabPINVOKE.RGB888Pixel_blue_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.RGB888Pixel_blue_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte green {
    set {
      VisionLabPINVOKE.RGB888Pixel_green_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.RGB888Pixel_green_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte red {
    set {
      VisionLabPINVOKE.RGB888Pixel_red_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.RGB888Pixel_red_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte pad {
    set {
      VisionLabPINVOKE.RGB888Pixel_pad_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.RGB888Pixel_pad_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
