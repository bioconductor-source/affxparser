/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class CCDFProbeInformation {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected CCDFProbeInformation(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(CCDFProbeInformation obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_CCDFProbeInformation(swigCPtr);
    }
    swigCPtr = 0;
  }

  public int GetListIndex() {
    return affx_fusionJNI.CCDFProbeInformation_GetListIndex(swigCPtr);
  }

  public int GetExpos() {
    return affx_fusionJNI.CCDFProbeInformation_GetExpos(swigCPtr);
  }

  public int GetX() {
    return affx_fusionJNI.CCDFProbeInformation_GetX(swigCPtr);
  }

  public int GetY() {
    return affx_fusionJNI.CCDFProbeInformation_GetY(swigCPtr);
  }

  public char GetPBase() {
    return affx_fusionJNI.CCDFProbeInformation_GetPBase(swigCPtr);
  }

  public char GetTBase() {
    return affx_fusionJNI.CCDFProbeInformation_GetTBase(swigCPtr);
  }

  public CCDFProbeInformation() {
    this(affx_fusionJNI.new_CCDFProbeInformation(), true);
  }

}