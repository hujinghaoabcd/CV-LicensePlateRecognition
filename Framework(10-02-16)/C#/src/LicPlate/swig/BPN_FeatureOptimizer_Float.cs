/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BPN_FeatureOptimizer_Float : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BPN_FeatureOptimizer_Float(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BPN_FeatureOptimizer_Float obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BPN_FeatureOptimizer_Float() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_BPN_FeatureOptimizer_Float(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public BPN_FeatureOptimizer_Float(int populationSize, int nrEpochs, double lowConfidence, ClassFeatureSet_Float trainCFS, ClassFeatureSet_Float evalCFS, int hidden1Low, int hidden1High, int hidden2Low, int hidden2High, double learnRateLow, double learnRateHigh, double momentumLow, double momentumHigh, vector_bool selectTab) : this(VisionLabPINVOKE.new_BPN_FeatureOptimizer_Float(populationSize, nrEpochs, lowConfidence, ClassFeatureSet_Float.getCPtr(trainCFS), ClassFeatureSet_Float.getCPtr(evalCFS), hidden1Low, hidden1High, hidden2Low, hidden2High, learnRateLow, learnRateHigh, momentumLow, momentumHigh, vector_bool.getCPtr(selectTab)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetImageType() {
    string ret = VisionLabPINVOKE.BPN_FeatureOptimizer_Float_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Optimize(int nrGenerations, double minError, double deltaError, double microP, ref double error, ref int hidden1, ref int hidden2, ref double learnRate, ref double momentum, vector_bool selectTab) {
    int ret = VisionLabPINVOKE.BPN_FeatureOptimizer_Float_Optimize(swigCPtr, nrGenerations, minError, deltaError, microP, ref error, ref hidden1, ref hidden2, ref learnRate, ref momentum, vector_bool.getCPtr(selectTab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
