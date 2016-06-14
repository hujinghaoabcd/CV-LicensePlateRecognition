/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class NumComplexFloatImage : Image {
  private HandleRef swigCPtr;

  internal NumComplexFloatImage(IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.NumComplexFloatImage_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(NumComplexFloatImage obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~NumComplexFloatImage() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_NumComplexFloatImage(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public NumComplexFloatImage() : this(VisionLabPINVOKE.new_NumComplexFloatImage__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public NumComplexFloatImage(int height, int width) : this(VisionLabPINVOKE.new_NumComplexFloatImage__SWIG_1(height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public NumComplexFloatImage(HeightWidth hw) : this(VisionLabPINVOKE.new_NumComplexFloatImage__SWIG_2(HeightWidth.getCPtr(hw)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public NumComplexFloatImage(NumComplexFloatImage image) : this(VisionLabPINVOKE.new_NumComplexFloatImage__SWIG_3(NumComplexFloatImage.getCPtr(image)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Clear() {
    VisionLabPINVOKE.NumComplexFloatImage_Clear(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetBuf(string buf, int height, int width, bool deleteOrg) {
    VisionLabPINVOKE.NumComplexFloatImage_SetBuf__SWIG_0(swigCPtr, buf, height, width, deleteOrg);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetBuf(string buf, int height, int width) {
    VisionLabPINVOKE.NumComplexFloatImage_SetBuf__SWIG_1(swigCPtr, buf, height, width);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Resize(HeightWidth hw) {
    VisionLabPINVOKE.NumComplexFloatImage_Resize__SWIG_0(swigCPtr, HeightWidth.getCPtr(hw));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Resize(HeightWidth hw, NumComplexFloatImage properties) {
    VisionLabPINVOKE.NumComplexFloatImage_Resize__SWIG_1(swigCPtr, HeightWidth.getCPtr(hw), NumComplexFloatImage.getCPtr(properties));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadAsciiFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.NumComplexFloatImage_ReadAsciiFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void WriteAsciiToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.NumComplexFloatImage_WriteAsciiToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadBinFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.NumComplexFloatImage_ReadBinFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void WriteBinToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.NumComplexFloatImage_WriteBinToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__complexT_float_t GetFirstPixelPtr() {
    IntPtr cPtr = VisionLabPINVOKE.NumComplexFloatImage_GetFirstPixelPtr(swigCPtr);
    SWIGTYPE_p_std__complexT_float_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__complexT_float_t(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__complexT_float_t GetLastPixelPtr() {
    IntPtr cPtr = VisionLabPINVOKE.NumComplexFloatImage_GetLastPixelPtr(swigCPtr);
    SWIGTYPE_p_std__complexT_float_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__complexT_float_t(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NumComplexFloatImage Assign_Op(NumComplexFloatImage image) {
    NumComplexFloatImage ret = new NumComplexFloatImage(VisionLabPINVOKE.NumComplexFloatImage_Assign_Op__SWIG_0(swigCPtr, NumComplexFloatImage.getCPtr(image)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NumComplexFloatImage Assign_Op(SWIGTYPE_p_std__complexT_float_t pixel) {
    NumComplexFloatImage ret = new NumComplexFloatImage(VisionLabPINVOKE.NumComplexFloatImage_Assign_Op__SWIG_1(swigCPtr, SWIGTYPE_p_std__complexT_float_t.getCPtr(pixel)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsEqual_Op(NumComplexFloatImage image) {
    bool ret = VisionLabPINVOKE.NumComplexFloatImage_IsEqual_Op(swigCPtr, NumComplexFloatImage.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(NumComplexFloatImage image) {
    bool ret = VisionLabPINVOKE.NumComplexFloatImage_Not(swigCPtr, NumComplexFloatImage.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CheckCoord(int x, int y) {
    bool ret = VisionLabPINVOKE.NumComplexFloatImage_CheckCoord__SWIG_0(swigCPtr, x, y);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CheckCoord(XYCoord xy) {
    bool ret = VisionLabPINVOKE.NumComplexFloatImage_CheckCoord__SWIG_1(swigCPtr, XYCoord.getCPtr(xy));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__complexT_float_t GetPixelPtr(int x, int y) {
    IntPtr cPtr = VisionLabPINVOKE.NumComplexFloatImage_GetPixelPtr__SWIG_0(swigCPtr, x, y);
    SWIGTYPE_p_std__complexT_float_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__complexT_float_t(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__complexT_float_t GetPixelPtr(XYCoord xy) {
    IntPtr cPtr = VisionLabPINVOKE.NumComplexFloatImage_GetPixelPtr__SWIG_1(swigCPtr, XYCoord.getCPtr(xy));
    SWIGTYPE_p_std__complexT_float_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__complexT_float_t(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XYCoord GetXYCoord(SWIGTYPE_p_std__complexT_float_t ptr) {
    XYCoord ret = new XYCoord(VisionLabPINVOKE.NumComplexFloatImage_GetXYCoord(swigCPtr, SWIGTYPE_p_std__complexT_float_t.getCPtr(ptr)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPixel(int x, int y, SWIGTYPE_p_std__complexT_float_t value) {
    VisionLabPINVOKE.NumComplexFloatImage_SetPixel(swigCPtr, x, y, SWIGTYPE_p_std__complexT_float_t.getCPtr(value));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}
