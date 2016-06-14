/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Mask_Double : MaskBase {
  private HandleRef swigCPtr;

  internal Mask_Double(IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.Mask_Double_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Mask_Double obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Mask_Double() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_Mask_Double(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Mask_Double() : this(VisionLabPINVOKE.new_Mask_Double__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Mask_Double(Mask_Double mask) : this(VisionLabPINVOKE.new_Mask_Double__SWIG_1(Mask_Double.getCPtr(mask)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Mask_Double(int height, int width) : this(VisionLabPINVOKE.new_Mask_Double__SWIG_2(height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Mask_Double(int height, int width, double v) : this(VisionLabPINVOKE.new_Mask_Double__SWIG_3(height, width, v), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Mask_Double(int height, int width, int orgX, int orgY, double v) : this(VisionLabPINVOKE.new_Mask_Double__SWIG_4(height, width, orgX, orgY, v), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Mask_Double(int height, int width, int orgX, int orgY) : this(VisionLabPINVOKE.new_Mask_Double__SWIG_5(height, width, orgX, orgY), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEqual_Op(Mask_Double mask) {
    bool ret = VisionLabPINVOKE.Mask_Double_IsEqual_Op(swigCPtr, Mask_Double.getCPtr(mask));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(Mask_Double mask) {
    bool ret = VisionLabPINVOKE.Mask_Double_Not(swigCPtr, Mask_Double.getCPtr(mask));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Mask_Double Assign_Op(Mask_Double mask) {
    Mask_Double ret = new Mask_Double(VisionLabPINVOKE.Mask_Double_Assign_Op(swigCPtr, Mask_Double.getCPtr(mask)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMask(int height, int width, int orgX, int orgY) {
    VisionLabPINVOKE.Mask_Double_SetMask(swigCPtr, height, width, orgX, orgY);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetMaskValue(int x, int y) {
    double ret = VisionLabPINVOKE.Mask_Double_GetMaskValue(swigCPtr, x, y);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMaskValue(int x, int y, double v) {
    VisionLabPINVOKE.Mask_Double_SetMaskValue(swigCPtr, x, y, v);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_double tab {
    set {
      VisionLabPINVOKE.Mask_Double_tab_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.Mask_Double_tab_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
