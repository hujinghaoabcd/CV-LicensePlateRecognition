/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class HSV888Pixel : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal HSV888Pixel(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HSV888Pixel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~HSV888Pixel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_HSV888Pixel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public HSV888Pixel(int v) : this(VisionLabPINVOKE.new_HSV888Pixel__SWIG_0(v), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public HSV888Pixel() : this(VisionLabPINVOKE.new_HSV888Pixel__SWIG_1(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public HSV888Pixel(byte h, byte s, byte i) : this(VisionLabPINVOKE.new_HSV888Pixel__SWIG_2(h, s, i), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEqual_Op(HSV888Pixel p) {
    bool ret = VisionLabPINVOKE.HSV888Pixel_IsEqual_Op(swigCPtr, HSV888Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(HSV888Pixel p) {
    bool ret = VisionLabPINVOKE.HSV888Pixel_Not(swigCPtr, HSV888Pixel.getCPtr(p));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV888Pixel Add(HSV888Pixel p) {
    HSV888Pixel ret = new HSV888Pixel(VisionLabPINVOKE.HSV888Pixel_Add(swigCPtr, HSV888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV888Pixel Subtract(HSV888Pixel p) {
    HSV888Pixel ret = new HSV888Pixel(VisionLabPINVOKE.HSV888Pixel_Subtract(swigCPtr, HSV888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV888Pixel Multiply(HSV888Pixel p) {
    HSV888Pixel ret = new HSV888Pixel(VisionLabPINVOKE.HSV888Pixel_Multiply(swigCPtr, HSV888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV888Pixel Divide(HSV888Pixel p) {
    HSV888Pixel ret = new HSV888Pixel(VisionLabPINVOKE.HSV888Pixel_Divide(swigCPtr, HSV888Pixel.getCPtr(p)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV888Pixel Add_Op(HSV888Pixel p) {
    HSV888Pixel ret = new HSV888Pixel(VisionLabPINVOKE.HSV888Pixel_Add_Op(swigCPtr, HSV888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV888Pixel Subtract_Op(HSV888Pixel p) {
    HSV888Pixel ret = new HSV888Pixel(VisionLabPINVOKE.HSV888Pixel_Subtract_Op(swigCPtr, HSV888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV888Pixel Multiply_Op(HSV888Pixel p) {
    HSV888Pixel ret = new HSV888Pixel(VisionLabPINVOKE.HSV888Pixel_Multiply_Op(swigCPtr, HSV888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV888Pixel Divide_Op(HSV888Pixel p) {
    HSV888Pixel ret = new HSV888Pixel(VisionLabPINVOKE.HSV888Pixel_Divide_Op(swigCPtr, HSV888Pixel.getCPtr(p)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_int colOffTab {
    get {
      global::System.IntPtr cPtr = VisionLabPINVOKE.HSV888Pixel_colOffTab_get();
      SWIGTYPE_p_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static byte MAXValue {
    get {
      byte ret = VisionLabPINVOKE.HSV888Pixel_MAXValue_get();
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte value {
    set {
      VisionLabPINVOKE.HSV888Pixel_value_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.HSV888Pixel_value_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte saturation {
    set {
      VisionLabPINVOKE.HSV888Pixel_saturation_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.HSV888Pixel_saturation_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte hue {
    set {
      VisionLabPINVOKE.HSV888Pixel_hue_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.HSV888Pixel_hue_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte pad {
    set {
      VisionLabPINVOKE.HSV888Pixel_pad_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = VisionLabPINVOKE.HSV888Pixel_pad_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
