/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class __NumYUV161616Image : Image {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal __NumYUV161616Image(global::System.IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.__NumYUV161616Image_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(__NumYUV161616Image obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~__NumYUV161616Image() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete___NumYUV161616Image(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public __NumYUV161616Image() : this(VisionLabPINVOKE.new___NumYUV161616Image__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __NumYUV161616Image(int height, int width) : this(VisionLabPINVOKE.new___NumYUV161616Image__SWIG_1(height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __NumYUV161616Image(HeightWidth hw) : this(VisionLabPINVOKE.new___NumYUV161616Image__SWIG_2(HeightWidth.getCPtr(hw)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __NumYUV161616Image(__NumYUV161616Image image) : this(VisionLabPINVOKE.new___NumYUV161616Image__SWIG_3(__NumYUV161616Image.getCPtr(image)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Clear() {
    VisionLabPINVOKE.__NumYUV161616Image_Clear(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetBuf(string buf, int height, int width, bool deleteOrg) {
    VisionLabPINVOKE.__NumYUV161616Image_SetBuf__SWIG_0(swigCPtr, buf, height, width, deleteOrg);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetBuf(string buf, int height, int width) {
    VisionLabPINVOKE.__NumYUV161616Image_SetBuf__SWIG_1(swigCPtr, buf, height, width);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Resize(HeightWidth hw) {
    VisionLabPINVOKE.__NumYUV161616Image_Resize__SWIG_0(swigCPtr, HeightWidth.getCPtr(hw));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Resize(HeightWidth hw, __NumYUV161616Image properties) {
    VisionLabPINVOKE.__NumYUV161616Image_Resize__SWIG_1(swigCPtr, HeightWidth.getCPtr(hw), __NumYUV161616Image.getCPtr(properties));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadAsciiFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.__NumYUV161616Image_ReadAsciiFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void WriteAsciiToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.__NumYUV161616Image_WriteAsciiToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadBinFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.__NumYUV161616Image_ReadBinFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void WriteBinToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.__NumYUV161616Image_WriteBinToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public YUV161616Pixel GetFirstPixelPtr() {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__NumYUV161616Image_GetFirstPixelPtr(swigCPtr);
    YUV161616Pixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new YUV161616Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV161616Pixel GetLastPixelPtr() {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__NumYUV161616Image_GetLastPixelPtr(swigCPtr);
    YUV161616Pixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new YUV161616Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public __NumYUV161616Image Assign_Op(__NumYUV161616Image image) {
    __NumYUV161616Image ret = new __NumYUV161616Image(VisionLabPINVOKE.__NumYUV161616Image_Assign_Op__SWIG_0(swigCPtr, __NumYUV161616Image.getCPtr(image)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public __NumYUV161616Image Assign_Op(YUV161616Pixel pixel) {
    __NumYUV161616Image ret = new __NumYUV161616Image(VisionLabPINVOKE.__NumYUV161616Image_Assign_Op__SWIG_1(swigCPtr, YUV161616Pixel.getCPtr(pixel)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsEqual_Op(__NumYUV161616Image image) {
    bool ret = VisionLabPINVOKE.__NumYUV161616Image_IsEqual_Op(swigCPtr, __NumYUV161616Image.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(__NumYUV161616Image image) {
    bool ret = VisionLabPINVOKE.__NumYUV161616Image_Not(swigCPtr, __NumYUV161616Image.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CheckCoord(int x, int y) {
    bool ret = VisionLabPINVOKE.__NumYUV161616Image_CheckCoord__SWIG_0(swigCPtr, x, y);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CheckCoord(XYCoord xy) {
    bool ret = VisionLabPINVOKE.__NumYUV161616Image_CheckCoord__SWIG_1(swigCPtr, XYCoord.getCPtr(xy));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV161616Pixel GetPixelPtr(int x, int y) {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__NumYUV161616Image_GetPixelPtr__SWIG_0(swigCPtr, x, y);
    YUV161616Pixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new YUV161616Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YUV161616Pixel GetPixelPtr(XYCoord xy) {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__NumYUV161616Image_GetPixelPtr__SWIG_1(swigCPtr, XYCoord.getCPtr(xy));
    YUV161616Pixel ret = (cPtr == global::System.IntPtr.Zero) ? null : new YUV161616Pixel(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XYCoord GetXYCoord(YUV161616Pixel ptr) {
    XYCoord ret = new XYCoord(VisionLabPINVOKE.__NumYUV161616Image_GetXYCoord(swigCPtr, YUV161616Pixel.getCPtr(ptr)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPixel(int x, int y, YUV161616Pixel value) {
    VisionLabPINVOKE.__NumYUV161616Image_SetPixel(swigCPtr, x, y, YUV161616Pixel.getCPtr(value));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}
