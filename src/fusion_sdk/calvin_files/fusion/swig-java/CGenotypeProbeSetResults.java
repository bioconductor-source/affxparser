/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class CGenotypeProbeSetResults extends CProbeSetResults {
  private long swigCPtr;

  protected CGenotypeProbeSetResults(long cPtr, boolean cMemoryOwn) {
    super(affx_fusionJNI.SWIGCGenotypeProbeSetResultsUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(CGenotypeProbeSetResults obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_CGenotypeProbeSetResults(swigCPtr);
    }
    swigCPtr = 0;
    super.delete();
  }

  public void setAlleleCall(short value) {
    affx_fusionJNI.set_CGenotypeProbeSetResults_AlleleCall(swigCPtr, value);
  }

  public short getAlleleCall() {
    return affx_fusionJNI.get_CGenotypeProbeSetResults_AlleleCall(swigCPtr);
  }

  public void setConfidence(float value) {
    affx_fusionJNI.set_CGenotypeProbeSetResults_Confidence(swigCPtr, value);
  }

  public float getConfidence() {
    return affx_fusionJNI.get_CGenotypeProbeSetResults_Confidence(swigCPtr);
  }

  public void setRAS1(float value) {
    affx_fusionJNI.set_CGenotypeProbeSetResults_RAS1(swigCPtr, value);
  }

  public float getRAS1() {
    return affx_fusionJNI.get_CGenotypeProbeSetResults_RAS1(swigCPtr);
  }

  public void setRAS2(float value) {
    affx_fusionJNI.set_CGenotypeProbeSetResults_RAS2(swigCPtr, value);
  }

  public float getRAS2() {
    return affx_fusionJNI.get_CGenotypeProbeSetResults_RAS2(swigCPtr);
  }

  public void setPvalue_AA(float value) {
    affx_fusionJNI.set_CGenotypeProbeSetResults_pvalue_AA(swigCPtr, value);
  }

  public float getPvalue_AA() {
    return affx_fusionJNI.get_CGenotypeProbeSetResults_pvalue_AA(swigCPtr);
  }

  public void setPvalue_AB(float value) {
    affx_fusionJNI.set_CGenotypeProbeSetResults_pvalue_AB(swigCPtr, value);
  }

  public float getPvalue_AB() {
    return affx_fusionJNI.get_CGenotypeProbeSetResults_pvalue_AB(swigCPtr);
  }

  public void setPvalue_BB(float value) {
    affx_fusionJNI.set_CGenotypeProbeSetResults_pvalue_BB(swigCPtr, value);
  }

  public float getPvalue_BB() {
    return affx_fusionJNI.get_CGenotypeProbeSetResults_pvalue_BB(swigCPtr);
  }

  public void setPvalue_NoCall(float value) {
    affx_fusionJNI.set_CGenotypeProbeSetResults_pvalue_NoCall(swigCPtr, value);
  }

  public float getPvalue_NoCall() {
    return affx_fusionJNI.get_CGenotypeProbeSetResults_pvalue_NoCall(swigCPtr);
  }

  public String GetAlleleCallString() {
    return affx_fusionJNI.CGenotypeProbeSetResults_GetAlleleCallString(swigCPtr);
  }

  public CGenotypeProbeSetResults CGenotypeProbeSetResults_assign(CGenotypeProbeSetResults src) {
    return new CGenotypeProbeSetResults(affx_fusionJNI.CGenotypeProbeSetResults_CGenotypeProbeSetResults_assign(swigCPtr, CGenotypeProbeSetResults.getCPtr(src)), true);
  }

  public CGenotypeProbeSetResults() {
    this(affx_fusionJNI.new_CGenotypeProbeSetResults(), true);
  }

}
