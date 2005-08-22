/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class FusionCHPData {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected FusionCHPData(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(FusionCHPData obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_FusionCHPData(swigCPtr);
    }
    swigCPtr = 0;
  }

  public FusionCHPData() {
    this(affx_fusionJNI.new_FusionCHPData(), true);
  }

  public boolean GetExpressionResults(int index, FusionExpressionProbeSetResults result) {
    return affx_fusionJNI.FusionCHPData_GetExpressionResults(swigCPtr, index, FusionExpressionProbeSetResults.getCPtr(result));
  }

  public boolean GetGenotypingResults(int index, FusionGenotypeProbeSetResults result) {
    return affx_fusionJNI.FusionCHPData_GetGenotypingResults(swigCPtr, index, FusionGenotypeProbeSetResults.getCPtr(result));
  }

  public boolean GetUniversalResults(int index, FusionUniversalProbeSetResults result) {
    return affx_fusionJNI.FusionCHPData_GetUniversalResults(swigCPtr, index, FusionUniversalProbeSetResults.getCPtr(result));
  }

  public boolean Read() {
    return affx_fusionJNI.FusionCHPData_Read(swigCPtr);
  }

  public boolean ReadHeader() {
    return affx_fusionJNI.FusionCHPData_ReadHeader(swigCPtr);
  }

  public boolean Exists() {
    return affx_fusionJNI.FusionCHPData_Exists(swigCPtr);
  }

  public void SetFileName(String name) {
    affx_fusionJNI.FusionCHPData_SetFileName(swigCPtr, name);
  }

  public String GetFileName() {
    return affx_fusionJNI.FusionCHPData_GetFileName(swigCPtr);
  }

  public void Clear() {
    affx_fusionJNI.FusionCHPData_Clear(swigCPtr);
  }

  public void CheckAdapter() {
    affx_fusionJNI.FusionCHPData_CheckAdapter(swigCPtr);
  }

  public void CreateAdapter() {
    affx_fusionJNI.FusionCHPData_CreateAdapter(swigCPtr);
  }

  public void DeleteAdapter() {
    affx_fusionJNI.FusionCHPData_DeleteAdapter(swigCPtr);
  }

  public FusionCHPHeader GetHeader() {
    return new FusionCHPHeader(affx_fusionJNI.FusionCHPData_GetHeader(swigCPtr), false);
  }

}
