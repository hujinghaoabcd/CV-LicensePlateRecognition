/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ClassImageSet_HSV16 : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ClassImageSet_HSV16(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ClassImageSet_HSV16 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ClassImageSet_HSV16() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_ClassImageSet_HSV16(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ClassImageSet_HSV16() : this(VisionLabPINVOKE.new_ClassImageSet_HSV16__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public ClassImageSet_HSV16(string info, int height, int width) : this(VisionLabPINVOKE.new_ClassImageSet_HSV16__SWIG_1(info, height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public ClassImageSet_HSV16(string info, int height) : this(VisionLabPINVOKE.new_ClassImageSet_HSV16__SWIG_2(info, height), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public ClassImageSet_HSV16(string info) : this(VisionLabPINVOKE.new_ClassImageSet_HSV16__SWIG_3(info), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetImageType() {
    string ret = VisionLabPINVOKE.ClassImageSet_HSV16_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddClass(string className) {
    int ret = VisionLabPINVOKE.ClassImageSet_HSV16_AddClass(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ClassId(string className) {
    int ret = VisionLabPINVOKE.ClassImageSet_HSV16_ClassId(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string ClassName(int classId) {
    string ret = VisionLabPINVOKE.ClassImageSet_HSV16_ClassName(swigCPtr, classId);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_int_t GetClassTab() {
    SWIGTYPE_p_std__mapT_std__string_int_t ret = new SWIGTYPE_p_std__mapT_std__string_int_t(VisionLabPINVOKE.ClassImageSet_HSV16_GetClassTab(swigCPtr), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int MaxClassId() {
    int ret = VisionLabPINVOKE.ClassImageSet_HSV16_MaxClassId(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveClass(string className) {
    VisionLabPINVOKE.ClassImageSet_HSV16_RemoveClass(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int AddImage(string className, HSV161616Image image) {
    int ret = VisionLabPINVOKE.ClassImageSet_HSV16_AddImage(swigCPtr, className, HSV161616Image.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Image GetImage(string className, int imageIndex) {
    HSV161616Image ret = new HSV161616Image(VisionLabPINVOKE.ClassImageSet_HSV16_GetImage__SWIG_0(swigCPtr, className, imageIndex), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HSV161616Image GetImage(int classId, int imageIndex) {
    HSV161616Image ret = new HSV161616Image(VisionLabPINVOKE.ClassImageSet_HSV16_GetImage__SWIG_1(swigCPtr, classId, imageIndex), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetClassIds(vector_int classIds) {
    VisionLabPINVOKE.ClassImageSet_HSV16_GetClassIds(swigCPtr, vector_int.getCPtr(classIds));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetSets(vector_HSV161616Image images, vector_int classIds) {
    VisionLabPINVOKE.ClassImageSet_HSV16_GetSets(swigCPtr, vector_HSV161616Image.getCPtr(images), vector_int.getCPtr(classIds));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int NrOfImages(string className) {
    int ret = VisionLabPINVOKE.ClassImageSet_HSV16_NrOfImages__SWIG_0(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int NrOfImages(int classId) {
    int ret = VisionLabPINVOKE.ClassImageSet_HSV16_NrOfImages__SWIG_1(swigCPtr, classId);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveImage(string className, int imageIndex) {
    VisionLabPINVOKE.ClassImageSet_HSV16_RemoveImage__SWIG_0(swigCPtr, className, imageIndex);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveImage(int classId, int imageIndex) {
    VisionLabPINVOKE.ClassImageSet_HSV16_RemoveImage__SWIG_1(swigCPtr, classId, imageIndex);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetInfo() {
    string ret = VisionLabPINVOKE.ClassImageSet_HSV16_GetInfo(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetImageHeight() {
    int ret = VisionLabPINVOKE.ClassImageSet_HSV16_GetImageHeight(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetImageWidth() {
    int ret = VisionLabPINVOKE.ClassImageSet_HSV16_GetImageWidth(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetMaxPixel() {
    double ret = VisionLabPINVOKE.ClassImageSet_HSV16_GetMaxPixel(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetMinPixel() {
    double ret = VisionLabPINVOKE.ClassImageSet_HSV16_GetMinPixel(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void WriteToFile(string fileName) {
    VisionLabPINVOKE.ClassImageSet_HSV16_WriteToFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReadFromFile(string fileName) {
    VisionLabPINVOKE.ClassImageSet_HSV16_ReadFromFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.ClassImageSet_HSV16_WriteToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReadFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.ClassImageSet_HSV16_ReadFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_QString info {
    set {
      VisionLabPINVOKE.ClassImageSet_HSV16_info_set(swigCPtr, SWIGTYPE_p_QString.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_QString ret = new SWIGTYPE_p_QString(VisionLabPINVOKE.ClassImageSet_HSV16_info_get(swigCPtr), true);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int height {
    set {
      VisionLabPINVOKE.ClassImageSet_HSV16_height_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = VisionLabPINVOKE.ClassImageSet_HSV16_height_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int width {
    set {
      VisionLabPINVOKE.ClassImageSet_HSV16_width_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = VisionLabPINVOKE.ClassImageSet_HSV16_width_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double minPixel {
    set {
      VisionLabPINVOKE.ClassImageSet_HSV16_minPixel_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = VisionLabPINVOKE.ClassImageSet_HSV16_minPixel_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double maxPixel {
    set {
      VisionLabPINVOKE.ClassImageSet_HSV16_maxPixel_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = VisionLabPINVOKE.ClassImageSet_HSV16_maxPixel_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__mapT_std__string_int_t classTab {
    set {
      VisionLabPINVOKE.ClassImageSet_HSV16_classTab_set(swigCPtr, SWIGTYPE_p_std__mapT_std__string_int_t.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.ClassImageSet_HSV16_classTab_get(swigCPtr);
      SWIGTYPE_p_std__mapT_std__string_int_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__mapT_std__string_int_t(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_vector_HSV161616Image imageTab {
    set {
      VisionLabPINVOKE.ClassImageSet_HSV16_imageTab_set(swigCPtr, vector_vector_HSV161616Image.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.ClassImageSet_HSV16_imageTab_get(swigCPtr);
      vector_vector_HSV161616Image ret = (cPtr == IntPtr.Zero) ? null : new vector_vector_HSV161616Image(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void Init(string info, int height, int width) {
    VisionLabPINVOKE.ClassImageSet_HSV16_Init(swigCPtr, info, height, width);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMinMaxPixel() {
    VisionLabPINVOKE.ClassImageSet_HSV16_SetMinMaxPixel(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}