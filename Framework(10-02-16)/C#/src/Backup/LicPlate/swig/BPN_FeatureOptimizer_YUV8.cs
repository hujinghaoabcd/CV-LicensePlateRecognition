/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class BPN_FeatureOptimizer_YUV8 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BPN_FeatureOptimizer_YUV8(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BPN_FeatureOptimizer_YUV8 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BPN_FeatureOptimizer_YUV8() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_BPN_FeatureOptimizer_YUV8(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public BPN_FeatureOptimizer_YUV8(int populationSize, int nrEpochs, double lowConfidence, ClassFeatureSet_YUV8 trainCFS, ClassFeatureSet_YUV8 evalCFS, int hidden1Low, int hidden1High, int hidden2Low, int hidden2High, double learnRateLow, double learnRateHigh, double momentumLow, double momentumHigh, vector_bool selectTab) : this(VisionLabPINVOKE.new_BPN_FeatureOptimizer_YUV8(populationSize, nrEpochs, lowConfidence, ClassFeatureSet_YUV8.getCPtr(trainCFS), ClassFeatureSet_YUV8.getCPtr(evalCFS), hidden1Low, hidden1High, hidden2Low, hidden2High, learnRateLow, learnRateHigh, momentumLow, momentumHigh, vector_bool.getCPtr(selectTab)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetImageType() {
    string ret = VisionLabPINVOKE.BPN_FeatureOptimizer_YUV8_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Optimize(int nrGenerations, double minError, double deltaError, double microP, ref double error, ref int hidden1, ref int hidden2, ref double learnRate, ref double momentum, vector_bool selectTab) {
    int ret = VisionLabPINVOKE.BPN_FeatureOptimizer_YUV8_Optimize(swigCPtr, nrGenerations, minError, deltaError, microP, ref error, ref hidden1, ref hidden2, ref learnRate, ref momentum, vector_bool.getCPtr(selectTab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
