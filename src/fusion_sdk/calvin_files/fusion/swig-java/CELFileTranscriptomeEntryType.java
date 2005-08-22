/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class CELFileTranscriptomeEntryType {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected CELFileTranscriptomeEntryType(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(CELFileTranscriptomeEntryType obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_CELFileTranscriptomeEntryType(swigCPtr);
    }
    swigCPtr = 0;
  }

  public void setIntensity(int value) {
    affx_fusionJNI.set_CELFileTranscriptomeEntryType_Intensity(swigCPtr, value);
  }

  public int getIntensity() {
    return affx_fusionJNI.get_CELFileTranscriptomeEntryType_Intensity(swigCPtr);
  }

  public void setStdv(int value) {
    affx_fusionJNI.set_CELFileTranscriptomeEntryType_Stdv(swigCPtr, value);
  }

  public int getStdv() {
    return affx_fusionJNI.get_CELFileTranscriptomeEntryType_Stdv(swigCPtr);
  }

  public void setPixels(short value) {
    affx_fusionJNI.set_CELFileTranscriptomeEntryType_Pixels(swigCPtr, value);
  }

  public short getPixels() {
    return affx_fusionJNI.get_CELFileTranscriptomeEntryType_Pixels(swigCPtr);
  }

  public CELFileTranscriptomeEntryType() {
    this(affx_fusionJNI.new_CELFileTranscriptomeEntryType(), true);
  }

}
