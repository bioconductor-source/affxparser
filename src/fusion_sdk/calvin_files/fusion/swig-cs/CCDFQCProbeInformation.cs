/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CCDFQCProbeInformation : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CCDFQCProbeInformation(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CCDFQCProbeInformation obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CCDFQCProbeInformation() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CCDFQCProbeInformation(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public CCDFQCProbeInformation() : this(affx_fusionPINVOKE.new_CCDFQCProbeInformation(), true) {
  }

  public int GetX() {
    int ret = affx_fusionPINVOKE.CCDFQCProbeInformation_GetX(swigCPtr);
    return ret;
  }

  public int GetY() {
    int ret = affx_fusionPINVOKE.CCDFQCProbeInformation_GetY(swigCPtr);
    return ret;
  }

  public int GetPLen() {
    int ret = affx_fusionPINVOKE.CCDFQCProbeInformation_GetPLen(swigCPtr);
    return ret;
  }

  public bool IsPerfectMatchProbe() {
    bool ret = affx_fusionPINVOKE.CCDFQCProbeInformation_IsPerfectMatchProbe(swigCPtr);
    return ret;
  }

  public bool IsBackgroundProbe() {
    bool ret = affx_fusionPINVOKE.CCDFQCProbeInformation_IsBackgroundProbe(swigCPtr);
    return ret;
  }

}