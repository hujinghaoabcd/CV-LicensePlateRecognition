/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class __Camera_Byte : CameraBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal __Camera_Byte(global::System.IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.__Camera_Byte_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(__Camera_Byte obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~__Camera_Byte() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete___Camera_Byte(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void SnapShot(ByteImage image, int roiNr) {
    VisionLabPINVOKE.__Camera_Byte_SnapShot__SWIG_0(swigCPtr, ByteImage.getCPtr(image), roiNr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SnapShot(ByteImage image) {
    VisionLabPINVOKE.__Camera_Byte_SnapShot__SWIG_1(swigCPtr, ByteImage.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override Image SnapShot(int roiNr) {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__Camera_Byte_SnapShot__SWIG_2(swigCPtr, roiNr);
    Image ret = (cPtr == global::System.IntPtr.Zero) ? null : new Image(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Image SnapShot() {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__Camera_Byte_SnapShot__SWIG_3(swigCPtr);
    Image ret = (cPtr == global::System.IntPtr.Zero) ? null : new Image(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SWIGTYPE_p_std__vectorT_JL_VisionLib_V3__Image_p_t SnapShotROIs() {
    SWIGTYPE_p_std__vectorT_JL_VisionLib_V3__Image_p_t ret = new SWIGTYPE_p_std__vectorT_JL_VisionLib_V3__Image_p_t(VisionLabPINVOKE.__Camera_Byte_SnapShotROIs__SWIG_0(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SnapShotROIs(vector_ByteImage images) {
    VisionLabPINVOKE.__Camera_Byte_SnapShotROIs__SWIG_1(swigCPtr, vector_ByteImage.getCPtr(images));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string GetImageType() {
    string ret = VisionLabPINVOKE.__Camera_Byte_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
