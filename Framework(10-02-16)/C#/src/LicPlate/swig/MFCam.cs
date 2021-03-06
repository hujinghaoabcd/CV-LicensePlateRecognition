/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class MFCam : Camera_RGB8 {
  private HandleRef swigCPtr;

  internal MFCam(IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.MFCam_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MFCam obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MFCam() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_MFCam(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MFCam(uint camID, uint streamIndex, uint mode) : this(VisionLabPINVOKE.new_MFCam(camID, streamIndex, mode), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DisplayMF_MirrorMode(SWIGTYPE_p_ostream os) {
    VisionLabPINVOKE.MFCam_DisplayMF_MirrorMode(swigCPtr, SWIGTYPE_p_ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReadMF_MirrorMode(SWIGTYPE_p_istream arg0) {
    VisionLabPINVOKE.MFCam_ReadMF_MirrorMode(swigCPtr, SWIGTYPE_p_istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override Image SnapShot(int roiNr) {
    IntPtr cPtr = VisionLabPINVOKE.MFCam_SnapShot__SWIG_0(swigCPtr, roiNr);
    Image ret = (cPtr == IntPtr.Zero) ? null : new Image(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Image SnapShot() {
    IntPtr cPtr = VisionLabPINVOKE.MFCam_SnapShot__SWIG_1(swigCPtr);
    Image ret = (cPtr == IntPtr.Zero) ? null : new Image(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SnapShot(RGB888Image image, int roiNr) {
    VisionLabPINVOKE.MFCam_SnapShot__SWIG_2(swigCPtr, RGB888Image.getCPtr(image), roiNr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SnapShot(RGB888Image image) {
    VisionLabPINVOKE.MFCam_SnapShot__SWIG_3(swigCPtr, RGB888Image.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SnapShot(YUV888Image image, int roiNr) {
    VisionLabPINVOKE.MFCam_SnapShot__SWIG_4(swigCPtr, YUV888Image.getCPtr(image), roiNr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SnapShot(YUV888Image image) {
    VisionLabPINVOKE.MFCam_SnapShot__SWIG_5(swigCPtr, YUV888Image.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override SWIGTYPE_p_std__vectorT_JL_VisionLib_V3__Image_p_t SnapShotROIs() {
    SWIGTYPE_p_std__vectorT_JL_VisionLib_V3__Image_p_t ret = new SWIGTYPE_p_std__vectorT_JL_VisionLib_V3__Image_p_t(VisionLabPINVOKE.MFCam_SnapShotROIs__SWIG_0(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SnapShotROIs(vector_RGB888Image images) {
    VisionLabPINVOKE.MFCam_SnapShotROIs__SWIG_1(swigCPtr, vector_RGB888Image.getCPtr(images));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SnapShotROIs(vector_YUV888Image images) {
    VisionLabPINVOKE.MFCam_SnapShotROIs__SWIG_2(swigCPtr, vector_YUV888Image.getCPtr(images));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_HRESULT ShowError(string function, string message, SWIGTYPE_p_HRESULT hr, bool isFatal) {
    SWIGTYPE_p_HRESULT ret = new SWIGTYPE_p_HRESULT(VisionLabPINVOKE.MFCam_ShowError__SWIG_0(swigCPtr, function, message, SWIGTYPE_p_HRESULT.getCPtr(hr), isFatal), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_HRESULT ShowError(string function, string message, SWIGTYPE_p_HRESULT hr) {
    SWIGTYPE_p_HRESULT ret = new SWIGTYPE_p_HRESULT(VisionLabPINVOKE.MFCam_ShowError__SWIG_1(swigCPtr, function, message, SWIGTYPE_p_HRESULT.getCPtr(hr)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_HRESULT ShowError(string function, string message) {
    SWIGTYPE_p_HRESULT ret = new SWIGTYPE_p_HRESULT(VisionLabPINVOKE.MFCam_ShowError__SWIG_2(swigCPtr, function, message), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetMirrorMode() {
    string ret = VisionLabPINVOKE.MFCam_GetMirrorMode(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string SetMirrorMode(string mirrorOp) {
    string ret = VisionLabPINVOKE.MFCam_SetMirrorMode__SWIG_0(swigCPtr, mirrorOp);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetMirrorMode(int mode) {
    int ret = VisionLabPINVOKE.MFCam_SetMirrorMode__SWIG_1(swigCPtr, mode);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_std__vectorT_unsigned_int_t m_InstalledCameras {
    set {
      VisionLabPINVOKE.MFCam_m_InstalledCameras_set(SWIGTYPE_p_std__vectorT_unsigned_int_t.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.MFCam_m_InstalledCameras_get();
      SWIGTYPE_p_std__vectorT_unsigned_int_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_unsigned_int_t(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static int getCameraCount() {
    int ret = VisionLabPINVOKE.MFCam_getCameraCount();
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getConnectedCameras() {
    string ret = VisionLabPINVOKE.MFCam_getConnectedCameras();
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
