/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AuditFileReader : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AuditFileReader(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AuditFileReader obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AuditFileReader() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_AuditFileReader(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public AuditFileReader() : this(affx_fusionPINVOKE.new_AuditFileReader(), true) {
  }

  public bool Read(string fileName, SWIGTYPE_p_std__listTaffymetrix_calvin_array__ArrayAuditEntry_t auditData) {
    bool ret = affx_fusionPINVOKE.AuditFileReader_Read(swigCPtr, fileName, SWIGTYPE_p_std__listTaffymetrix_calvin_array__ArrayAuditEntry_t.getCPtr(auditData));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
