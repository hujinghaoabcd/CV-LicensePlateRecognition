/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class RGB161616Pixel : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RGB161616Pixel(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RGB161616Pixel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RGB161616Pixel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_RGB161616Pixel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RGB161616Pixel(int v) : this(VisionLabPINVOKE.new_RGB161616Pixel__SWIG_0(v), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public RGB161616Pixel() : this(VisionLabPINVOKE.new_RGB161616Pixel__SWIG_1(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public RGB161616Pixel(short r, short g, short b) : this(VisionLabPINVOKE.new_RGB161616Pixel__SWIG_2(r, g, b), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public RGB161616Pixel(RGB888Pixel pixel) : this(VisionLabPINVOKE.new_RGB161616Pixel__SWIG_3(RGB888Pixel.getCPtr(pixel)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEqual_Op(RGB161616Pixel p) {
    bool ret = VisionLabPINVOKE.RGB161616Pixel_IsEqual_Op(swigCPtr, RGB161616Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(RGB161616Pixel p) {
    bool ret = VisionLabPINVOKE.RGB161616Pixel_Not(swigCPtr, RGB161616Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB161616Pixel Add(RGB161616Pixel p) {
    RGB161616Pixel ret = new RGB161616Pixel(VisionLabPINVOKE.RGB161616Pixel_Add(swigCPtr, RGB161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB161616Pixel Subtract(RGB161616Pixel p) {
    RGB161616Pixel ret = new RGB161616Pixel(VisionLabPINVOKE.RGB161616Pixel_Subtract(swigCPtr, RGB161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB161616Pixel Multiply(RGB161616Pixel p) {
    RGB161616Pixel ret = new RGB161616Pixel(VisionLabPINVOKE.RGB161616Pixel_Multiply(swigCPtr, RGB161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB161616Pixel Divide(RGB161616Pixel p) {
    RGB161616Pixel ret = new RGB161616Pixel(VisionLabPINVOKE.RGB161616Pixel_Divide(swigCPtr, RGB161616Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB161616Pixel Add_Op(RGB161616Pixel p) {
    RGB161616Pixel ret = new RGB161616Pixel(VisionLabPINVOKE.RGB161616Pixel_Add_Op(swigCPtr, RGB161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB161616Pixel Subtract_Op(RGB161616Pixel p) {
    RGB161616Pixel ret = new RGB161616Pixel(VisionLabPINVOKE.RGB161616Pixel_Subtract_Op(swigCPtr, RGB161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB161616Pixel Multiply_Op(RGB161616Pixel p) {
    RGB161616Pixel ret = new RGB161616Pixel(VisionLabPINVOKE.RGB161616Pixel_Multiply_Op(swigCPtr, RGB161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RGB161616Pixel Divide_Op(RGB161616Pixel p) {
    RGB161616Pixel ret = new RGB161616Pixel(VisionLabPINVOKE.RGB161616Pixel_Divide_Op(swigCPtr, RGB161616Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_int colOffTab {
    get {
      global::System.IntPtr cPtr = VisionLabPINVOKE.RGB161616Pixel_colOffTab_get();
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public short blue {
    set {
      VisionLabPINVOKE.RGB161616Pixel_blue_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      short ret = VisionLabPINVOKE.RGB161616Pixel_blue_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public short green {
    set {
      VisionLabPINVOKE.RGB161616Pixel_green_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      short ret = VisionLabPINVOKE.RGB161616Pixel_green_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public short red {
    set {
      VisionLabPINVOKE.RGB161616Pixel_red_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      short ret = VisionLabPINVOKE.RGB161616Pixel_red_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
