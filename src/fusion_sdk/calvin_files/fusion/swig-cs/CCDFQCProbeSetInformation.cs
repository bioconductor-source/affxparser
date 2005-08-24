/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CCDFQCProbeSetInformation : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CCDFQCProbeSetInformation(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CCDFQCProbeSetInformation obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CCDFQCProbeSetInformation() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CCDFQCProbeSetInformation(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public GeneChipQCProbeSetType GetQCProbeSetType() {
    GeneChipQCProbeSetType ret = (GeneChipQCProbeSetType)affx_fusionPINVOKE.CCDFQCProbeSetInformation_GetQCProbeSetType(swigCPtr);
    return ret;
  }

  public int GetNumCells() {
    int ret = affx_fusionPINVOKE.CCDFQCProbeSetInformation_GetNumCells(swigCPtr);
    return ret;
  }

  public void GetProbeInformation(int index, CCDFQCProbeInformation info) {
    affx_fusionPINVOKE.CCDFQCProbeSetInformation_GetProbeInformation(swigCPtr, index, CCDFQCProbeInformation.getCPtr(info));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public CCDFQCProbeSetInformation() : this(affx_fusionPINVOKE.new_CCDFQCProbeSetInformation(), true) {
  }

}