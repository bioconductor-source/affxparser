/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ArrayAuditEntry : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ArrayAuditEntry(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ArrayAuditEntry obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArrayAuditEntry() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_ArrayAuditEntry(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public ArrayAuditEntry() : this(affx_fusionPINVOKE.new_ArrayAuditEntry(), true) {
  }

  public SWIGTYPE_p_std__wstring UserName() {
    SWIGTYPE_p_std__wstring ret = new SWIGTYPE_p_std__wstring(affx_fusionPINVOKE.ArrayAuditEntry_UserName(swigCPtr), false);
    return ret;
  }

  public DateTime DateTime() {
    DateTime ret = new DateTime(affx_fusionPINVOKE.ArrayAuditEntry_DateTime(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__string ActionType() {
    SWIGTYPE_p_std__string ret = new SWIGTYPE_p_std__string(affx_fusionPINVOKE.ArrayAuditEntry_ActionType(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__string ArrayGuid() {
    SWIGTYPE_p_std__string ret = new SWIGTYPE_p_std__string(affx_fusionPINVOKE.ArrayAuditEntry_ArrayGuid(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__listTstd__string_t InputFileGuids() {
    SWIGTYPE_p_std__listTstd__string_t ret = new SWIGTYPE_p_std__listTstd__string_t(affx_fusionPINVOKE.ArrayAuditEntry_InputFileGuids(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__listTstd__string_t OutputFileGuids() {
    SWIGTYPE_p_std__listTstd__string_t ret = new SWIGTYPE_p_std__listTstd__string_t(affx_fusionPINVOKE.ArrayAuditEntry_OutputFileGuids(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__listTaffymetrix_calvin_parameter___tagParameterNameValuePair_t ActionParameters() {
    SWIGTYPE_p_std__listTaffymetrix_calvin_parameter___tagParameterNameValuePair_t ret = new SWIGTYPE_p_std__listTaffymetrix_calvin_parameter___tagParameterNameValuePair_t(affx_fusionPINVOKE.ArrayAuditEntry_ActionParameters(swigCPtr), false);
    return ret;
  }

  public void Clear() {
    affx_fusionPINVOKE.ArrayAuditEntry_Clear(swigCPtr);
  }

}
