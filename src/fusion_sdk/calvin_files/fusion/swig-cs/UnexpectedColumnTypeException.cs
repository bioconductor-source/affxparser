/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class UnexpectedColumnTypeException : CalvinException {
  private HandleRef swigCPtr;

  internal UnexpectedColumnTypeException(IntPtr cPtr, bool cMemoryOwn) : base(affx_fusionPINVOKE.UnexpectedColumnTypeExceptionUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnexpectedColumnTypeException obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnexpectedColumnTypeException() {
    Dispose();
  }

  public override void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_UnexpectedColumnTypeException(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
    base.Dispose();
  }

  public UnexpectedColumnTypeException() : this(affx_fusionPINVOKE.new_UnexpectedColumnTypeException(), true) {
  }

}
