/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class ForceCallType {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected ForceCallType(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(ForceCallType obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_ForceCallType(swigCPtr);
    }
    swigCPtr = 0;
  }

  public void setPosition(int value) {
    affx_fusionJNI.set_ForceCallType_position(swigCPtr, value);
  }

  public int getPosition() {
    return affx_fusionJNI.get_ForceCallType_position(swigCPtr);
  }

  public void setCall(char value) {
    affx_fusionJNI.set_ForceCallType_call(swigCPtr, value);
  }

  public char getCall() {
    return affx_fusionJNI.get_ForceCallType_call(swigCPtr);
  }

  public void setReason(short value) {
    affx_fusionJNI.set_ForceCallType_reason(swigCPtr, value);
  }

  public short getReason() {
    return affx_fusionJNI.get_ForceCallType_reason(swigCPtr);
  }

  public ForceCallType() {
    this(affx_fusionJNI.new_ForceCallType(), true);
  }

}
