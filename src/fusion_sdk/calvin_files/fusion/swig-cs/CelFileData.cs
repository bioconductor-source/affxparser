/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CelFileData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CelFileData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CelFileData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CelFileData() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CelFileData(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public CelFileData() : this(affx_fusionPINVOKE.new_CelFileData__SWIG_0(), true) {
  }

  public CelFileData(string filename) : this(affx_fusionPINVOKE.new_CelFileData__SWIG_1(filename), true) {
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    affx_fusionPINVOKE.CelFileData_Clear(swigCPtr);
  }

  public void SetFilename(string p) {
    affx_fusionPINVOKE.CelFileData_SetFilename(swigCPtr, p);
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetFilename() {
    string ret = affx_fusionPINVOKE.CelFileData_GetFilename(swigCPtr);
    return ret;
  }

  public void SetIntensityCount(int ln) {
    affx_fusionPINVOKE.CelFileData_SetIntensityCount(swigCPtr, ln);
  }

  public void SetStdDevCount(int ln) {
    affx_fusionPINVOKE.CelFileData_SetStdDevCount(swigCPtr, ln);
  }

  public void SetPixelCount(int ln) {
    affx_fusionPINVOKE.CelFileData_SetPixelCount(swigCPtr, ln);
  }

  public void SetOutlierCount(int ln) {
    affx_fusionPINVOKE.CelFileData_SetOutlierCount(swigCPtr, ln);
  }

  public void SetMaskCount(int ln) {
    affx_fusionPINVOKE.CelFileData_SetMaskCount(swigCPtr, ln);
  }

  public FileHeader GetFileHeader() {
    IntPtr cPtr = affx_fusionPINVOKE.CelFileData_GetFileHeader(swigCPtr);
    FileHeader ret = (cPtr == IntPtr.Zero) ? null : new FileHeader(cPtr, false);
    return ret;
  }

  public byte GetVersion() {
    byte ret = affx_fusionPINVOKE.CelFileData_GetVersion(swigCPtr);
    return ret;
  }

  public void SetArrayType(SWIGTYPE_p_std__wstring value) {
    affx_fusionPINVOKE.CelFileData_SetArrayType(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(value));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__wstring GetArrayType() {
    SWIGTYPE_p_std__wstring ret = new SWIGTYPE_p_std__wstring(affx_fusionPINVOKE.CelFileData_GetArrayType(swigCPtr), true);
    return ret;
  }

  public void SetAlgorithmName(SWIGTYPE_p_std__wstring value) {
    affx_fusionPINVOKE.CelFileData_SetAlgorithmName(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(value));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__wstring GetAlgorithmName() {
    SWIGTYPE_p_std__wstring ret = new SWIGTYPE_p_std__wstring(affx_fusionPINVOKE.CelFileData_GetAlgorithmName(swigCPtr), true);
    return ret;
  }

  public void SetRows(int value) {
    affx_fusionPINVOKE.CelFileData_SetRows(swigCPtr, value);
  }

  public int GetRows() {
    int ret = affx_fusionPINVOKE.CelFileData_GetRows(swigCPtr);
    return ret;
  }

  public void SetCols(int value) {
    affx_fusionPINVOKE.CelFileData_SetCols(swigCPtr, value);
  }

  public int GetCols() {
    int ret = affx_fusionPINVOKE.CelFileData_GetCols(swigCPtr);
    return ret;
  }

  public int GetNumCells() {
    int ret = affx_fusionPINVOKE.CelFileData_GetNumCells(swigCPtr);
    return ret;
  }

  public void GetAlgorithmParameters(SWIGTYPE_p_std__vectorTaffymetrix_calvin_parameter__ParameterNameValueType_t algParams) {
    affx_fusionPINVOKE.CelFileData_GetAlgorithmParameters(swigCPtr, SWIGTYPE_p_std__vectorTaffymetrix_calvin_parameter__ParameterNameValueType_t.getCPtr(algParams));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool FindAlgorithmParameter(SWIGTYPE_p_std__wstring name, ParameterNameValueType param) {
    bool ret = affx_fusionPINVOKE.CelFileData_FindAlgorithmParameter(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(name), ParameterNameValueType.getCPtr(param));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddAlgorithmParameter(ParameterNameValueType nvt) {
    affx_fusionPINVOKE.CelFileData_AddAlgorithmParameter(swigCPtr, ParameterNameValueType.getCPtr(nvt));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetData(int cellIdx, SWIGTYPE_p_float intensity, SWIGTYPE_p_float stdev, SWIGTYPE_p_short numPixels, SWIGTYPE_p_bool outlier, SWIGTYPE_p_bool masked) {
    affx_fusionPINVOKE.CelFileData_GetData(swigCPtr, cellIdx, SWIGTYPE_p_float.getCPtr(intensity), SWIGTYPE_p_float.getCPtr(stdev), SWIGTYPE_p_short.getCPtr(numPixels), SWIGTYPE_p_bool.getCPtr(outlier), SWIGTYPE_p_bool.getCPtr(masked));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasStdev() {
    bool ret = affx_fusionPINVOKE.CelFileData_HasStdev(swigCPtr);
    return ret;
  }

  public bool HasNumPixels() {
    bool ret = affx_fusionPINVOKE.CelFileData_HasNumPixels(swigCPtr);
    return ret;
  }

  public bool GetIntensities(int cellIdxStart, int count, SWIGTYPE_p_std__vectorTfloat_t values) {
    bool ret = affx_fusionPINVOKE.CelFileData_GetIntensities(swigCPtr, cellIdxStart, count, SWIGTYPE_p_std__vectorTfloat_t.getCPtr(values));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetStdev(int cellIdxStart, int count, SWIGTYPE_p_std__vectorTfloat_t values) {
    bool ret = affx_fusionPINVOKE.CelFileData_GetStdev(swigCPtr, cellIdxStart, count, SWIGTYPE_p_std__vectorTfloat_t.getCPtr(values));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetNumPixels(int cellIdxStart, int count, SWIGTYPE_p_std__vectorTshort_t values) {
    bool ret = affx_fusionPINVOKE.CelFileData_GetNumPixels(swigCPtr, cellIdxStart, count, SWIGTYPE_p_std__vectorTshort_t.getCPtr(values));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetOutliers(int cellIdxStart, int count, SWIGTYPE_p_std__vectorTbool_t values) {
    bool ret = affx_fusionPINVOKE.CelFileData_GetOutliers(swigCPtr, cellIdxStart, count, SWIGTYPE_p_std__vectorTbool_t.getCPtr(values));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetMasked(int cellIdxStart, int count, SWIGTYPE_p_std__vectorTbool_t values) {
    bool ret = affx_fusionPINVOKE.CelFileData_GetMasked(swigCPtr, cellIdxStart, count, SWIGTYPE_p_std__vectorTbool_t.getCPtr(values));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetOutlierCoords(SWIGTYPE_p_std__vectorTaffymetrix_calvin_io__XYCoord_t coords) {
    affx_fusionPINVOKE.CelFileData_GetOutlierCoords(swigCPtr, SWIGTYPE_p_std__vectorTaffymetrix_calvin_io__XYCoord_t.getCPtr(coords));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetMaskedCoords(SWIGTYPE_p_std__vectorTaffymetrix_calvin_io__XYCoord_t coords) {
    affx_fusionPINVOKE.CelFileData_GetMaskedCoords(swigCPtr, SWIGTYPE_p_std__vectorTaffymetrix_calvin_io__XYCoord_t.getCPtr(coords));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

}