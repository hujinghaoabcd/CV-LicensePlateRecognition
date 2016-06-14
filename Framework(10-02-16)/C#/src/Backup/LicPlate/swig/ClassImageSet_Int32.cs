/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class ClassImageSet_Int32 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ClassImageSet_Int32(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ClassImageSet_Int32 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ClassImageSet_Int32() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_ClassImageSet_Int32(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ClassImageSet_Int32() : this(VisionLabPINVOKE.new_ClassImageSet_Int32__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public ClassImageSet_Int32(string info, int height, int width) : this(VisionLabPINVOKE.new_ClassImageSet_Int32__SWIG_1(info, height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public ClassImageSet_Int32(string info, int height) : this(VisionLabPINVOKE.new_ClassImageSet_Int32__SWIG_2(info, height), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public ClassImageSet_Int32(string info) : this(VisionLabPINVOKE.new_ClassImageSet_Int32__SWIG_3(info), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetImageType() {
    string ret = VisionLabPINVOKE.ClassImageSet_Int32_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddClass(string className) {
    int ret = VisionLabPINVOKE.ClassImageSet_Int32_AddClass(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ClassId(string className) {
    int ret = VisionLabPINVOKE.ClassImageSet_Int32_ClassId(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string ClassName(int classId) {
    string ret = VisionLabPINVOKE.ClassImageSet_Int32_ClassName(swigCPtr, classId);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t GetClassTab() {
    SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t ret = new SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t(VisionLabPINVOKE.ClassImageSet_Int32_GetClassTab(swigCPtr), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int MaxClassId() {
    int ret = VisionLabPINVOKE.ClassImageSet_Int32_MaxClassId(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveClass(string className) {
    VisionLabPINVOKE.ClassImageSet_Int32_RemoveClass(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int AddImage(string className, Int32Image image) {
    int ret = VisionLabPINVOKE.ClassImageSet_Int32_AddImage(swigCPtr, className, Int32Image.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Int32Image GetImage(string className, int imageIndex) {
    Int32Image ret = new Int32Image(VisionLabPINVOKE.ClassImageSet_Int32_GetImage__SWIG_0(swigCPtr, className, imageIndex), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Int32Image GetImage(int classId, int imageIndex) {
    Int32Image ret = new Int32Image(VisionLabPINVOKE.ClassImageSet_Int32_GetImage__SWIG_1(swigCPtr, classId, imageIndex), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetClassIds(vector_int classIds) {
    VisionLabPINVOKE.ClassImageSet_Int32_GetClassIds(swigCPtr, vector_int.getCPtr(classIds));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetSets(vector_Int32Image images, vector_int classIds) {
    VisionLabPINVOKE.ClassImageSet_Int32_GetSets(swigCPtr, vector_Int32Image.getCPtr(images), vector_int.getCPtr(classIds));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int NrOfImages(string className) {
    int ret = VisionLabPINVOKE.ClassImageSet_Int32_NrOfImages__SWIG_0(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int NrOfImages(int classId) {
    int ret = VisionLabPINVOKE.ClassImageSet_Int32_NrOfImages__SWIG_1(swigCPtr, classId);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveImage(string className, int imageIndex) {
    VisionLabPINVOKE.ClassImageSet_Int32_RemoveImage__SWIG_0(swigCPtr, className, imageIndex);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveImage(int classId, int imageIndex) {
    VisionLabPINVOKE.ClassImageSet_Int32_RemoveImage__SWIG_1(swigCPtr, classId, imageIndex);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetInfo() {
    string ret = VisionLabPINVOKE.ClassImageSet_Int32_GetInfo(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetImageHeight() {
    int ret = VisionLabPINVOKE.ClassImageSet_Int32_GetImageHeight(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetImageWidth() {
    int ret = VisionLabPINVOKE.ClassImageSet_Int32_GetImageWidth(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetMaxPixel() {
    double ret = VisionLabPINVOKE.ClassImageSet_Int32_GetMaxPixel(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetMinPixel() {
    double ret = VisionLabPINVOKE.ClassImageSet_Int32_GetMinPixel(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void WriteToFile(string fileName) {
    VisionLabPINVOKE.ClassImageSet_Int32_WriteToFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReadFromFile(string fileName) {
    VisionLabPINVOKE.ClassImageSet_Int32_ReadFromFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.ClassImageSet_Int32_WriteToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReadFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.ClassImageSet_Int32_ReadFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_QString info {
    set {
      VisionLabPINVOKE.ClassImageSet_Int32_info_set(swigCPtr, SWIGTYPE_p_QString.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_QString ret = new SWIGTYPE_p_QString(VisionLabPINVOKE.ClassImageSet_Int32_info_get(swigCPtr), true);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int height {
    set {
      VisionLabPINVOKE.ClassImageSet_Int32_height_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = VisionLabPINVOKE.ClassImageSet_Int32_height_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int width {
    set {
      VisionLabPINVOKE.ClassImageSet_Int32_width_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = VisionLabPINVOKE.ClassImageSet_Int32_width_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double minPixel {
    set {
      VisionLabPINVOKE.ClassImageSet_Int32_minPixel_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = VisionLabPINVOKE.ClassImageSet_Int32_minPixel_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double maxPixel {
    set {
      VisionLabPINVOKE.ClassImageSet_Int32_maxPixel_set(swigCPtr, value);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = VisionLabPINVOKE.ClassImageSet_Int32_maxPixel_get(swigCPtr);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t classTab {
    set {
      VisionLabPINVOKE.ClassImageSet_Int32_classTab_set(swigCPtr, SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = VisionLabPINVOKE.ClassImageSet_Int32_classTab_get(swigCPtr);
      SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_vector_Int32Image imageTab {
    set {
      VisionLabPINVOKE.ClassImageSet_Int32_imageTab_set(swigCPtr, vector_vector_Int32Image.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = VisionLabPINVOKE.ClassImageSet_Int32_imageTab_get(swigCPtr);
      vector_vector_Int32Image ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_vector_Int32Image(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void Init(string info, int height, int width) {
    VisionLabPINVOKE.ClassImageSet_Int32_Init(swigCPtr, info, height, width);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMinMaxPixel() {
    VisionLabPINVOKE.ClassImageSet_Int32_SetMinMaxPixel(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}
