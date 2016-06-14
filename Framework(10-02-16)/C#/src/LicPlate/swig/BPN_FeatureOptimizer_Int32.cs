/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BPN_FeatureOptimizer_Int32 : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BPN_FeatureOptimizer_Int32(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BPN_FeatureOptimizer_Int32 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BPN_FeatureOptimizer_Int32() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_BPN_FeatureOptimizer_Int32(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public BPN_FeatureOptimizer_Int32(int populationSize, int nrEpochs, double lowConfidence, ClassFeatureSet_Int32 trainCFS, ClassFeatureSet_Int32 evalCFS, int hidden1Low, int hidden1High, int hidden2Low, int hidden2High, double learnRateLow, double learnRateHigh, double momentumLow, double momentumHigh, vector_bool selectTab) : this(VisionLabPINVOKE.new_BPN_FeatureOptimizer_Int32(populationSize, nrEpochs, lowConfidence, ClassFeatureSet_Int32.getCPtr(trainCFS), ClassFeatureSet_Int32.getCPtr(evalCFS), hidden1Low, hidden1High, hidden2Low, hidden2High, learnRateLow, learnRateHigh, momentumLow, momentumHigh, vector_bool.getCPtr(selectTab)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetImageType() {
    string ret = VisionLabPINVOKE.BPN_FeatureOptimizer_Int32_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Optimize(int nrGenerations, double minError, double deltaError, double microP, ref double error, ref int hidden1, ref int hidden2, ref double learnRate, ref double momentum, vector_bool selectTab) {
    int ret = VisionLabPINVOKE.BPN_FeatureOptimizer_Int32_Optimize(swigCPtr, nrGenerations, minError, deltaError, microP, ref error, ref hidden1, ref hidden2, ref learnRate, ref momentum, vector_bool.getCPtr(selectTab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
