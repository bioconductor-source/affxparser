/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class CCHPFileData {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected CCHPFileData(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(CCHPFileData obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_CCHPFileData(swigCPtr);
    }
    swigCPtr = 0;
  }

  public CCHPFileData() {
    this(affx_fusionJNI.new_CCHPFileData(), true);
  }

  public CCHPFileHeader GetHeader() {
    return new CCHPFileHeader(affx_fusionJNI.CCHPFileData_GetHeader(swigCPtr), false);
  }

  public CExpressionProbeSetResults GetExpressionResults(int index) {
    long cPtr = affx_fusionJNI.CCHPFileData_GetExpressionResults(swigCPtr, index);
    return (cPtr == 0) ? null : new CExpressionProbeSetResults(cPtr, false);
  }

  public CGenotypeProbeSetResults GetGenotypingResults(int index) {
    long cPtr = affx_fusionJNI.CCHPFileData_GetGenotypingResults(swigCPtr, index);
    return (cPtr == 0) ? null : new CGenotypeProbeSetResults(cPtr, false);
  }

  public CUniversalProbeSetResults GetUniversalResults(int index) {
    long cPtr = affx_fusionJNI.CCHPFileData_GetUniversalResults(swigCPtr, index);
    return (cPtr == 0) ? null : new CUniversalProbeSetResults(cPtr, false);
  }

  public CResequencingResults GetResequencingResults() {
    long cPtr = affx_fusionJNI.CCHPFileData_GetResequencingResults(swigCPtr);
    return (cPtr == 0) ? null : new CResequencingResults(cPtr, false);
  }

  public String GetError() {
    return affx_fusionJNI.CCHPFileData_GetError(swigCPtr);
  }

  public boolean Read() {
    return affx_fusionJNI.CCHPFileData_Read(swigCPtr);
  }

  public boolean ReadHeader() {
    return affx_fusionJNI.CCHPFileData_ReadHeader(swigCPtr);
  }

  public boolean Exists() {
    return affx_fusionJNI.CCHPFileData_Exists(swigCPtr);
  }

  public boolean IsXDACompatibleFile() {
    return affx_fusionJNI.CCHPFileData_IsXDACompatibleFile(swigCPtr);
  }

  public void SetFileName(String name) {
    affx_fusionJNI.CCHPFileData_SetFileName(swigCPtr, name);
  }

  public String GetFileName() {
    return affx_fusionJNI.CCHPFileData_GetFileName(swigCPtr);
  }

  public void Clear() {
    affx_fusionJNI.CCHPFileData_Clear(swigCPtr);
  }

}