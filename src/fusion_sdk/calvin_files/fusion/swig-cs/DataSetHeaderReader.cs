/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class DataSetHeaderReader : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DataSetHeaderReader(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DataSetHeaderReader obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DataSetHeaderReader() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_DataSetHeaderReader(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public DataSetHeaderReader() : this(affx_fusionPINVOKE.new_DataSetHeaderReader(), true) {
  }

  public void ReadAllMinimumInfo(SWIGTYPE_p_std__ifstream fileStream, DataGroupHeader dch, uint dataSetCnt) {
    affx_fusionPINVOKE.DataSetHeaderReader_ReadAllMinimumInfo(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(fileStream), DataGroupHeader.getCPtr(dch), dataSetCnt);
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReadAll(SWIGTYPE_p_std__ifstream fileStream, DataGroupHeader dch, uint dataSetCnt) {
    affx_fusionPINVOKE.DataSetHeaderReader_ReadAll(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(fileStream), DataGroupHeader.getCPtr(dch), dataSetCnt);
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint ReadMinimumInfo(SWIGTYPE_p_std__ifstream fileStream, DataSetHeader dph) {
    uint ret = affx_fusionPINVOKE.DataSetHeaderReader_ReadMinimumInfo(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(fileStream), DataSetHeader.getCPtr(dph));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint Read(SWIGTYPE_p_std__ifstream fileStream, DataSetHeader dph) {
    uint ret = affx_fusionPINVOKE.DataSetHeaderReader_Read(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(fileStream), DataSetHeader.getCPtr(dph));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}