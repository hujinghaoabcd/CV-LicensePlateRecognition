/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class BPN_ImageClassifier_Double : BPN_Classifier {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BPN_ImageClassifier_Double(global::System.IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.BPN_ImageClassifier_Double_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BPN_ImageClassifier_Double obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BPN_ImageClassifier_Double() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_BPN_ImageClassifier_Double(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BPN_ImageClassifier_Double() : this(VisionLabPINVOKE.new_BPN_ImageClassifier_Double__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public BPN_ImageClassifier_Double(int nrPixels, int nrHiddens1, int nrHiddens2, int nrClasses, BiasNodes bias, double minInput, double maxInput) : this(VisionLabPINVOKE.new_BPN_ImageClassifier_Double__SWIG_1(nrPixels, nrHiddens1, nrHiddens2, nrClasses, (int)bias, minInput, maxInput), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetImageType() {
    string ret = VisionLabPINVOKE.BPN_ImageClassifier_Double_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double TrainImage(double learnRate, double momentum, DoubleImage image, int classNr) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Double_TrainImage(swigCPtr, learnRate, momentum, DoubleImage.getCPtr(image), classNr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double TrainImageSet(int nrOfEpochs, double learnRate, double momentum, vector_DoubleImage images, vector_int classes, ref double meanError) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Double_TrainImageSet(swigCPtr, nrOfEpochs, learnRate, momentum, vector_DoubleImage.getCPtr(images), vector_int.getCPtr(classes), ref meanError);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double TrainClassImageSet(int nrOfEpochs, double learnRate, double momentum, ClassImageSet_Double cis, ref double meanError) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Double_TrainClassImageSet(swigCPtr, nrOfEpochs, learnRate, momentum, ClassImageSet_Double.getCPtr(cis), ref meanError);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Classify(DoubleImage image, ref double confidency) {
    int ret = VisionLabPINVOKE.BPN_ImageClassifier_Double_Classify(swigCPtr, DoubleImage.getCPtr(image), ref confidency);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double ClassifyOutputTab(DoubleImage image, vector_ClassOutput outputTab) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Double_ClassifyOutputTab(swigCPtr, DoubleImage.getCPtr(image), vector_ClassOutput.getCPtr(outputTab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double EvaluateImage(DoubleImage image, int classExp, ref int classRes, ref double confidency, vector_double output) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Double_EvaluateImage(swigCPtr, DoubleImage.getCPtr(image), classExp, ref classRes, ref confidency, vector_double.getCPtr(output));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double EvaluateImageSet(vector_DoubleImage images, vector_int classesExp, vector_int classesRes, vector_double confidencies, vector_vector_double outputs, ref double meanError) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Double_EvaluateImageSet(swigCPtr, vector_DoubleImage.getCPtr(images), vector_int.getCPtr(classesExp), vector_int.getCPtr(classesRes), vector_double.getCPtr(confidencies), vector_vector_double.getCPtr(outputs), ref meanError);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double EvaluateClassImageSet(ClassImageSet_Double cis, vector_int classesRes, vector_double confidencies, vector_vector_double outputs, ref double meanError) {
    double ret = VisionLabPINVOKE.BPN_ImageClassifier_Double_EvaluateClassImageSet(swigCPtr, ClassImageSet_Double.getCPtr(cis), vector_int.getCPtr(classesRes), vector_double.getCPtr(confidencies), vector_vector_double.getCPtr(outputs), ref meanError);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}