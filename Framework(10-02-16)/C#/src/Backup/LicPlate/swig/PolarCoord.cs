/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class PolarCoord : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PolarCoord(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PolarCoord obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PolarCoord() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_PolarCoord(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PolarCoord(double rr, double pphi) : this(VisionLabPINVOKE.new_PolarCoord__SWIG_0(rr, pphi), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public PolarCoord(double rr) : this(VisionLabPINVOKE.new_PolarCoord__SWIG_1(rr), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public PolarCoord() : this(VisionLabPINVOKE.new_PolarCoord__SWIG_2(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEqual_Op(PolarCoord c) {
    bool ret = VisionLabPINVOKE.PolarCoord_IsEqual_Op(swigCPtr, PolarCoord.getCPtr(c));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(PolarCoord c) {
    bool ret = VisionLabPINVOKE.PolarCoord_Not(swigCPtr, PolarCoord.getCPtr(c));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SmallerThan(PolarCoord arg0) {
    bool ret = VisionLabPINVOKE.PolarCoord_SmallerThan(swigCPtr, PolarCoord.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double r {
    set {
      VisionLabPINVOKE.PolarCoord_r_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = VisionLabPINVOKE.PolarCoord_r_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double phi {
    set {
      VisionLabPINVOKE.PolarCoord_phi_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = VisionLabPINVOKE.PolarCoord_phi_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
