/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CBARFileData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CBARFileData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CBARFileData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CBARFileData() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CBARFileData(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public CBARFileData() : this(affx_fusionPINVOKE.new_CBARFileData(), true) {
  }

  public void SetFileName(string name) {
    affx_fusionPINVOKE.CBARFileData_SetFileName(swigCPtr, name);
  }

  public string GetFileName() {
    string ret = affx_fusionPINVOKE.CBARFileData_GetFileName(swigCPtr);
    return ret;
  }

  public bool Read() {
    bool ret = affx_fusionPINVOKE.CBARFileData_Read(swigCPtr);
    return ret;
  }

  public bool ReadHeader() {
    bool ret = affx_fusionPINVOKE.CBARFileData_ReadHeader(swigCPtr);
    return ret;
  }

  public bool Exists() {
    bool ret = affx_fusionPINVOKE.CBARFileData_Exists(swigCPtr);
    return ret;
  }

  public void Close() {
    affx_fusionPINVOKE.CBARFileData_Close(swigCPtr);
  }

  public string GetError() {
    string ret = affx_fusionPINVOKE.CBARFileData_GetError(swigCPtr);
    return ret;
  }

  public float GetVersion() {
    float ret = affx_fusionPINVOKE.CBARFileData_GetVersion(swigCPtr);
    return ret;
  }

  public int GetNumberSequences() {
    int ret = affx_fusionPINVOKE.CBARFileData_GetNumberSequences(swigCPtr);
    return ret;
  }

  public int GetNumberColumns() {
    int ret = affx_fusionPINVOKE.CBARFileData_GetNumberColumns(swigCPtr);
    return ret;
  }

  public int GetNumberParameters() {
    int ret = affx_fusionPINVOKE.CBARFileData_GetNumberParameters(swigCPtr);
    return ret;
  }

  public TagValuePairType GetParameter(int index) {
    TagValuePairType ret = new TagValuePairType(affx_fusionPINVOKE.CBARFileData_GetParameter(swigCPtr, index), false);
    return ret;
  }

  public SWIGTYPE_p_affxbar___GDACFILES_BAR_DATA_TYPE GetColumnTypes(int index) {
    SWIGTYPE_p_affxbar___GDACFILES_BAR_DATA_TYPE ret = new SWIGTYPE_p_affxbar___GDACFILES_BAR_DATA_TYPE(affx_fusionPINVOKE.CBARFileData_GetColumnTypes(swigCPtr, index), false);
    return ret;
  }

  public void GetResults(int index, CGDACSequenceResultItem seq) {
    affx_fusionPINVOKE.CBARFileData_GetResults(swigCPtr, index, CGDACSequenceResultItem.getCPtr(seq));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddAlgorithmParameter(string tag, string value) {
    affx_fusionPINVOKE.CBARFileData_AddAlgorithmParameter(swigCPtr, tag, value);
  }

  public void AddColumn(GDACFILES_BAR_DATA_TYPE ctype) {
    affx_fusionPINVOKE.CBARFileData_AddColumn(swigCPtr, (int)ctype);
  }

  public void SetNumberSequences(int n) {
    affx_fusionPINVOKE.CBARFileData_SetNumberSequences(swigCPtr, n);
  }

  public CGDACSequenceResultItem GetResultsPtr(int index) {
    IntPtr cPtr = affx_fusionPINVOKE.CBARFileData_GetResultsPtr(swigCPtr, index);
    CGDACSequenceResultItem ret = (cPtr == IntPtr.Zero) ? null : new CGDACSequenceResultItem(cPtr, false);
    return ret;
  }

}