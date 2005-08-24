/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ParameterNameValuePair : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ParameterNameValuePair(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ParameterNameValuePair obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ParameterNameValuePair() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_ParameterNameValuePair(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public SWIGTYPE_p_std__wstring Name {
    set {
      affx_fusionPINVOKE.set_ParameterNameValuePair_Name(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(value));
      if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_std__wstring ret = new SWIGTYPE_p_std__wstring(affx_fusionPINVOKE.get_ParameterNameValuePair_Name(swigCPtr), true);
      if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__wstring Value {
    set {
      affx_fusionPINVOKE.set_ParameterNameValuePair_Value(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(value));
      if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_std__wstring ret = new SWIGTYPE_p_std__wstring(affx_fusionPINVOKE.get_ParameterNameValuePair_Value(swigCPtr), true);
      if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ParameterNameValuePair ParameterNameValuePair_copy(ParameterNameValuePair param) {
    ParameterNameValuePair ret = new ParameterNameValuePair(affx_fusionPINVOKE.ParameterNameValuePair_ParameterNameValuePair_copy(swigCPtr, ParameterNameValuePair.getCPtr(param)), true);
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ParameterNameValuePair_equals_obj(ParameterNameValuePair param) {
    bool ret = affx_fusionPINVOKE.ParameterNameValuePair_ParameterNameValuePair_equals_obj(swigCPtr, ParameterNameValuePair.getCPtr(param));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ParameterNameValueControlVocabulary_equals_name(SWIGTYPE_p_std__wstring name) {
    bool ret = affx_fusionPINVOKE.ParameterNameValuePair_ParameterNameValueControlVocabulary_equals_name(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(name));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParameterNameValuePair() : this(affx_fusionPINVOKE.new_ParameterNameValuePair(), true) {
  }

}