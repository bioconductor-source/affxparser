/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class PointU16_t : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PointU16_t(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PointU16_t obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PointU16_t() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_PointU16_t(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public ushort x {
    set {
      affx_fusionPINVOKE.set_PointU16_t_x(swigCPtr, value);
    } 
    get {
      ushort ret = affx_fusionPINVOKE.get_PointU16_t_x(swigCPtr);
      return ret;
    } 
  }

  public ushort y {
    set {
      affx_fusionPINVOKE.set_PointU16_t_y(swigCPtr, value);
    } 
    get {
      ushort ret = affx_fusionPINVOKE.get_PointU16_t_y(swigCPtr);
      return ret;
    } 
  }

  public PointU16_t() : this(affx_fusionPINVOKE.new_PointU16_t(), true) {
  }

}