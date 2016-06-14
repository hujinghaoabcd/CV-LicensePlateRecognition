/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class ClassLexicon : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ClassLexicon(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ClassLexicon obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ClassLexicon() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_ClassLexicon(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ClassLexicon(SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t classTab) : this(VisionLabPINVOKE.new_ClassLexicon__SWIG_0(SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t.getCPtr(classTab)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddWord(string word) {
    VisionLabPINVOKE.ClassLexicon_AddWord__SWIG_0(swigCPtr, word);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public string ClassIdToName(int id) {
    string ret = VisionLabPINVOKE.ClassLexicon_ClassIdToName(swigCPtr, id);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Clear() {
    VisionLabPINVOKE.ClassLexicon_Clear(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public double FindBestWord(vector_vector_LetterMatch wmTab, SWIGTYPE_p_std__string bestWord, Optimize opt) {
    double ret = VisionLabPINVOKE.ClassLexicon_FindBestWord__SWIG_0(swigCPtr, vector_vector_LetterMatch.getCPtr(wmTab), SWIGTYPE_p_std__string.getCPtr(bestWord), (int)opt);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetWords(vector_string wordTab) {
    VisionLabPINVOKE.ClassLexicon_GetWords(swigCPtr, vector_string.getCPtr(wordTab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int NrClasses() {
    int ret = VisionLabPINVOKE.ClassLexicon_NrClasses(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int NrWords() {
    int ret = VisionLabPINVOKE.ClassLexicon_NrWords(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ReadFromFile(string fileName) {
    VisionLabPINVOKE.ClassLexicon_ReadFromFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveWord(string word) {
    VisionLabPINVOKE.ClassLexicon_RemoveWord__SWIG_0(swigCPtr, word);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteToFile(string fileName) {
    VisionLabPINVOKE.ClassLexicon_WriteToFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public ClassLexicon(int nrClasses) : this(VisionLabPINVOKE.new_ClassLexicon__SWIG_1(nrClasses), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public ClassLexicon() : this(VisionLabPINVOKE.new_ClassLexicon__SWIG_2(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddWord(vector_int word) {
    VisionLabPINVOKE.ClassLexicon_AddWord__SWIG_1(swigCPtr, vector_int.getCPtr(word));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_int GetWord(int index) {
    vector_int ret = new vector_int(VisionLabPINVOKE.ClassLexicon_GetWord(swigCPtr, index), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetWord(int index, vector_int word) {
    VisionLabPINVOKE.ClassLexicon_SetWord(swigCPtr, index, vector_int.getCPtr(word));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveWord(vector_int word) {
    VisionLabPINVOKE.ClassLexicon_RemoveWord__SWIG_1(swigCPtr, vector_int.getCPtr(word));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public double FindBestWord(vector_vector_LetterMatch wmTab, vector_int bestWord, Optimize opt) {
    double ret = VisionLabPINVOKE.ClassLexicon_FindBestWord__SWIG_1(swigCPtr, vector_vector_LetterMatch.getCPtr(wmTab), vector_int.getCPtr(bestWord), (int)opt);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
