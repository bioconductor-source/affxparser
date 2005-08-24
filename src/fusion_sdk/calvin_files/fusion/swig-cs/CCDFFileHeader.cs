/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CCDFFileHeader : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CCDFFileHeader(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CCDFFileHeader obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CCDFFileHeader() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CCDFFileHeader(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public int GetCols() {
    int ret = affx_fusionPINVOKE.CCDFFileHeader_GetCols(swigCPtr);
    return ret;
  }

  public int GetRows() {
    int ret = affx_fusionPINVOKE.CCDFFileHeader_GetRows(swigCPtr);
    return ret;
  }

  public int GetNumProbeSets() {
    int ret = affx_fusionPINVOKE.CCDFFileHeader_GetNumProbeSets(swigCPtr);
    return ret;
  }

  public int GetNumQCProbeSets() {
    int ret = affx_fusionPINVOKE.CCDFFileHeader_GetNumQCProbeSets(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_std__string GetReference() {
    SWIGTYPE_p_std__string ret = new SWIGTYPE_p_std__string(affx_fusionPINVOKE.CCDFFileHeader_GetReference(swigCPtr), false);
    return ret;
  }

  public CCDFFileHeader() : this(affx_fusionPINVOKE.new_CCDFFileHeader(), true) {
  }

}