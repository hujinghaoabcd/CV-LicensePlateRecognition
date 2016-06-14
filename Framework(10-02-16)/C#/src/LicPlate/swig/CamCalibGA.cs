/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CamCalibGA : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CamCalibGA(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CamCalibGA obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CamCalibGA() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_CamCalibGA(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public CamCalibGA(HeightWidth hw, vector_CamCalLowHigh tab, vector_Coord2D pixelTab, vector_Coord3D worldTab, double mutationP, double deltaP, int populationSize, int trace, string traceFileName) : this(VisionLabPINVOKE.new_CamCalibGA__SWIG_0(HeightWidth.getCPtr(hw), vector_CamCalLowHigh.getCPtr(tab), vector_Coord2D.getCPtr(pixelTab), vector_Coord3D.getCPtr(worldTab), mutationP, deltaP, populationSize, trace, traceFileName), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public CamCalibGA(HeightWidth hw, vector_CamCalLowHigh tab, vector_Coord2D pixelTab, vector_Coord3D worldTab, double mutationP, double deltaP, int populationSize, int trace) : this(VisionLabPINVOKE.new_CamCalibGA__SWIG_1(HeightWidth.getCPtr(hw), vector_CamCalLowHigh.getCPtr(tab), vector_Coord2D.getCPtr(pixelTab), vector_Coord3D.getCPtr(worldTab), mutationP, deltaP, populationSize, trace), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public CamCalibGA(HeightWidth hw, vector_CamCalLowHigh tab, vector_Coord2D pixelTab, vector_Coord3D worldTab, double mutationP, double deltaP, int populationSize) : this(VisionLabPINVOKE.new_CamCalibGA__SWIG_2(HeightWidth.getCPtr(hw), vector_CamCalLowHigh.getCPtr(tab), vector_Coord2D.getCPtr(pixelTab), vector_Coord3D.getCPtr(worldTab), mutationP, deltaP, populationSize), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public CamCalibGA(HeightWidth hw, vector_CamCalLowHigh tab, vector_Coord2D pixelTab, vector_Coord3D worldTab, double mutationP, double deltaP) : this(VisionLabPINVOKE.new_CamCalibGA__SWIG_3(HeightWidth.getCPtr(hw), vector_CamCalLowHigh.getCPtr(tab), vector_Coord2D.getCPtr(pixelTab), vector_Coord3D.getCPtr(worldTab), mutationP, deltaP), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RandomInitialize(int populationSize) {
    VisionLabPINVOKE.CamCalibGA_RandomInitialize(swigCPtr, populationSize);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFounder(int populationSize, CamCalibration cal) {
    VisionLabPINVOKE.CamCalibGA_SetFounder(swigCPtr, populationSize, CamCalibration.getCPtr(cal));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Optimize(int maxGen, double minError, double deltaError, CamCalibration camCalib, double microP) {
    double ret = VisionLabPINVOKE.CamCalibGA_Optimize__SWIG_0(swigCPtr, maxGen, minError, deltaError, CamCalibration.getCPtr(camCalib), microP);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Optimize(int maxGen, double minError, double deltaError, CamCalibration camCalib) {
    double ret = VisionLabPINVOKE.CamCalibGA_Optimize__SWIG_1(swigCPtr, maxGen, minError, deltaError, CamCalibration.getCPtr(camCalib));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
