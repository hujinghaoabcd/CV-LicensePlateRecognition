/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class NumHSV161616Image : Image {
  private HandleRef swigCPtr;

  internal NumHSV161616Image(IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.NumHSV161616Image_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(NumHSV161616Image obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~NumHSV161616Image() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_NumHSV161616Image(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public NumHSV161616Image() : this(VisionLabPINVOKE.new_NumHSV161616Image__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public NumHSV161616Image(int height, int width) : this(VisionLabPINVOKE.new_NumHSV161616Image__SWIG_1(height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public NumHSV161616Image(HeightWidth hw) : this(VisionLabPINVOKE.new_NumHSV161616Image__SWIG_2(HeightWidth.getCPtr(hw)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public NumHSV161616Image(NumHSV161616Image image) : this(VisionLabPINVOKE.new_NumHSV161616Image__SWIG_3(NumHSV161616Image.getCPtr(image)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Clear() {
    VisionLabPINVOKE.NumHSV161616Image_Clear(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetBuf(string buf, int height, int width, bool deleteOrg) {
    VisionLabPINVOKE.NumHSV161616Image_SetBuf__SWIG_0(swigCPtr, buf, height, width, deleteOrg);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetBuf(string buf, int height, int width) {
    VisionLabPINVOKE.NumHSV161616Image_SetBuf__SWIG_1(swigCPtr, buf, height, width);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Resize(HeightWidth hw) {
    VisionLabPINVOKE.NumHSV161616Image_Resize__SWIG_0(swigCPtr, HeightWidth.getCPtr(hw));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Resize(HeightWidth hw, NumHSV161616Image properties) {
    VisionLabPINVOKE.NumHSV161616Image_Resize__SWIG_1(swigCPtr, HeightWidth.getCPtr(hw), NumHSV161616Image.getCPtr(properties));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadAsciiFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.NumHSV161616Image_ReadAsciiFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void WriteAsciiToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.NumHSV161616Image_WriteAsciiToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadBinFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.NumHSV161616Image_ReadBinFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void WriteBinToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.NumHSV161616Image_WriteBinToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public HSV161616Pixel GetFirstPixelPtr() {
    IntPtr cPtr = VisionLabPINVOKE.NumHSV161616Image_GetFirstPixelPtr(swigCPtr);
    HSV161616Pixel ret = (cPtr == IntPtr.Zero) ? null : new HSV161616Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Pixel GetLastPixelPtr() {
    IntPtr cPtr = VisionLabPINVOKE.NumHSV161616Image_GetLastPixelPtr(swigCPtr);
    HSV161616Pixel ret = (cPtr == IntPtr.Zero) ? null : new HSV161616Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NumHSV161616Image Assign_Op(NumHSV161616Image image) {
    NumHSV161616Image ret = new NumHSV161616Image(VisionLabPINVOKE.NumHSV161616Image_Assign_Op__SWIG_0(swigCPtr, NumHSV161616Image.getCPtr(image)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NumHSV161616Image Assign_Op(HSV161616Pixel pixel) {
    NumHSV161616Image ret = new NumHSV161616Image(VisionLabPINVOKE.NumHSV161616Image_Assign_Op__SWIG_1(swigCPtr, HSV161616Pixel.getCPtr(pixel)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsEqual_Op(NumHSV161616Image image) {
    bool ret = VisionLabPINVOKE.NumHSV161616Image_IsEqual_Op(swigCPtr, NumHSV161616Image.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(NumHSV161616Image image) {
    bool ret = VisionLabPINVOKE.NumHSV161616Image_Not(swigCPtr, NumHSV161616Image.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CheckCoord(int x, int y) {
    bool ret = VisionLabPINVOKE.NumHSV161616Image_CheckCoord__SWIG_0(swigCPtr, x, y);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CheckCoord(XYCoord xy) {
    bool ret = VisionLabPINVOKE.NumHSV161616Image_CheckCoord__SWIG_1(swigCPtr, XYCoord.getCPtr(xy));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Pixel GetPixelPtr(int x, int y) {
    IntPtr cPtr = VisionLabPINVOKE.NumHSV161616Image_GetPixelPtr__SWIG_0(swigCPtr, x, y);
    HSV161616Pixel ret = (cPtr == IntPtr.Zero) ? null : new HSV161616Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Pixel GetPixelPtr(XYCoord xy) {
    IntPtr cPtr = VisionLabPINVOKE.NumHSV161616Image_GetPixelPtr__SWIG_1(swigCPtr, XYCoord.getCPtr(xy));
    HSV161616Pixel ret = (cPtr == IntPtr.Zero) ? null : new HSV161616Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XYCoord GetXYCoord(HSV161616Pixel ptr) {
    XYCoord ret = new XYCoord(VisionLabPINVOKE.NumHSV161616Image_GetXYCoord(swigCPtr, HSV161616Pixel.getCPtr(ptr)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPixel(int x, int y, HSV161616Pixel value) {
    VisionLabPINVOKE.NumHSV161616Image_SetPixel(swigCPtr, x, y, HSV161616Pixel.getCPtr(value));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}
