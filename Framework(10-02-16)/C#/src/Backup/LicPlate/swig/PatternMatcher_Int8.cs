/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class PatternMatcher_Int8 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PatternMatcher_Int8(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PatternMatcher_Int8 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PatternMatcher_Int8() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_PatternMatcher_Int8(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual int AddPattern(Int8Image image, string name) {
    int ret = VisionLabPINVOKE.PatternMatcher_Int8_AddPattern(swigCPtr, Int8Image.getCPtr(image), name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void RemovePattern(string name) {
    VisionLabPINVOKE.PatternMatcher_Int8_RemovePattern(swigCPtr, name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int BestMatch(Int8Image blob, float beginAngle, float endAngle, ref float confidency, ref float error, ref float scale, ref float angle) {
    int ret = VisionLabPINVOKE.PatternMatcher_Int8_BestMatch(swigCPtr, Int8Image.getCPtr(blob), beginAngle, endAngle, ref confidency, ref error, ref scale, ref angle);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual float AllMatches(Int8Image blob, float beginAngle, float endAngle, vector_PatternMatchResult tab) {
    float ret = VisionLabPINVOKE.PatternMatcher_Int8_AllMatches(swigCPtr, Int8Image.getCPtr(blob), beginAngle, endAngle, vector_PatternMatchResult.getCPtr(tab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual float EvaluateClassImageSet(ClassImageSet_Int8 cis, float beginAngle, float endAngle, vector_PatternEvalResult tabs, ref float meanError) {
    float ret = VisionLabPINVOKE.PatternMatcher_Int8_EvaluateClassImageSet(swigCPtr, ClassImageSet_Int8.getCPtr(cis), beginAngle, endAngle, vector_PatternEvalResult.getCPtr(tabs), ref meanError);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int FindPatterns(Int8Image image, float maxError, float minConfindence, float beginAngle, float endAngle, vector_PatternMatchResult labelTab, vector_vector_int patTab) {
    int ret = VisionLabPINVOKE.PatternMatcher_Int8_FindPatterns(swigCPtr, Int8Image.getCPtr(image), maxError, minConfindence, beginAngle, endAngle, vector_PatternMatchResult.getCPtr(labelTab), vector_vector_int.getCPtr(patTab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetImageType() {
    string ret = VisionLabPINVOKE.PatternMatcher_Int8_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t GetPatternNamesTab() {
    SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t ret = new SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t(VisionLabPINVOKE.PatternMatcher_Int8_GetPatternNamesTab(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int NumberOfPatterns() {
    int ret = VisionLabPINVOKE.PatternMatcher_Int8_NumberOfPatterns(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string PatternName(int id) {
    string ret = VisionLabPINVOKE.PatternMatcher_Int8_PatternName(swigCPtr, id);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int PatternId(string name) {
    int ret = VisionLabPINVOKE.PatternMatcher_Int8_PatternId(swigCPtr, name);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Int8Image PatternImage(int id) {
    Int8Image ret = new Int8Image(VisionLabPINVOKE.PatternMatcher_Int8_PatternImage__SWIG_0(swigCPtr, id), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Int8Image PatternImage(string name) {
    Int8Image ret = new Int8Image(VisionLabPINVOKE.PatternMatcher_Int8_PatternImage__SWIG_1(swigCPtr, name), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void WriteToFile(string fileName) {
    VisionLabPINVOKE.PatternMatcher_Int8_WriteToFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ReadFromFile(string fileName) {
    VisionLabPINVOKE.PatternMatcher_Int8_ReadFromFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void WriteToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.PatternMatcher_Int8_WriteToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ReadFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.PatternMatcher_Int8_ReadFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}
