/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CGDACSequenceResultItem : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CGDACSequenceResultItem(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CGDACSequenceResultItem obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CGDACSequenceResultItem() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CGDACSequenceResultItem(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public CGDACSequenceResultItem() : this(affx_fusionPINVOKE.new_CGDACSequenceResultItem(), true) {
  }

  public string GetName() {
    string ret = affx_fusionPINVOKE.CGDACSequenceResultItem_GetName(swigCPtr);
    return ret;
  }

  public string GetVersion() {
    string ret = affx_fusionPINVOKE.CGDACSequenceResultItem_GetVersion(swigCPtr);
    return ret;
  }

  public string GetGroupName() {
    string ret = affx_fusionPINVOKE.CGDACSequenceResultItem_GetGroupName(swigCPtr);
    return ret;
  }

  public int GetNumberDataPoints() {
    int ret = affx_fusionPINVOKE.CGDACSequenceResultItem_GetNumberDataPoints(swigCPtr);
    return ret;
  }

  public int GetNumberColumns() {
    int ret = affx_fusionPINVOKE.CGDACSequenceResultItem_GetNumberColumns(swigCPtr);
    return ret;
  }

  public GDACFILES_BAR_DATA_TYPE GetColumnType(int index) {
    GDACFILES_BAR_DATA_TYPE ret = (GDACFILES_BAR_DATA_TYPE)affx_fusionPINVOKE.CGDACSequenceResultItem_GetColumnType(swigCPtr, index);
    return ret;
  }

  public void GetData(int iData, int iCol, BarSequenceResultData data) {
    affx_fusionPINVOKE.CGDACSequenceResultItem_GetData(swigCPtr, iData, iCol, BarSequenceResultData.getCPtr(data));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetNumberParameters() {
    int ret = affx_fusionPINVOKE.CGDACSequenceResultItem_GetNumberParameters(swigCPtr);
    return ret;
  }

  public TagValuePairType GetParameter(int index) {
    TagValuePairType ret = new TagValuePairType(affx_fusionPINVOKE.CGDACSequenceResultItem_GetParameter(swigCPtr, index), false);
    return ret;
  }

  public void SetName(string name) {
    affx_fusionPINVOKE.CGDACSequenceResultItem_SetName(swigCPtr, name);
  }

  public void SetVersion(string ver) {
    affx_fusionPINVOKE.CGDACSequenceResultItem_SetVersion(swigCPtr, ver);
  }

  public void SetGroupName(string group) {
    affx_fusionPINVOKE.CGDACSequenceResultItem_SetGroupName(swigCPtr, group);
  }

  public void SetNumberDataPoints(int n) {
    affx_fusionPINVOKE.CGDACSequenceResultItem_SetNumberDataPoints(swigCPtr, n);
  }

  public void SetDataPoint(int nIndex, int colIndex, BarSequenceResultData data) {
    affx_fusionPINVOKE.CGDACSequenceResultItem_SetDataPoint(swigCPtr, nIndex, colIndex, BarSequenceResultData.getCPtr(data));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddParameter(string tag, string value) {
    affx_fusionPINVOKE.CGDACSequenceResultItem_AddParameter(swigCPtr, tag, value);
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

}