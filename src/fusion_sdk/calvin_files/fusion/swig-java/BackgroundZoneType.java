/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class BackgroundZoneType {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected BackgroundZoneType(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(BackgroundZoneType obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_BackgroundZoneType(swigCPtr);
    }
    swigCPtr = 0;
  }

  public void setCenterx(float value) {
    affx_fusionJNI.set_BackgroundZoneType_centerx(swigCPtr, value);
  }

  public float getCenterx() {
    return affx_fusionJNI.get_BackgroundZoneType_centerx(swigCPtr);
  }

  public void setCentery(float value) {
    affx_fusionJNI.set_BackgroundZoneType_centery(swigCPtr, value);
  }

  public float getCentery() {
    return affx_fusionJNI.get_BackgroundZoneType_centery(swigCPtr);
  }

  public void setBackground(float value) {
    affx_fusionJNI.set_BackgroundZoneType_background(swigCPtr, value);
  }

  public float getBackground() {
    return affx_fusionJNI.get_BackgroundZoneType_background(swigCPtr);
  }

  public BackgroundZoneType _BackgroundZoneType_assign(BackgroundZoneType zn) {
    return new BackgroundZoneType(affx_fusionJNI.BackgroundZoneType__BackgroundZoneType_assign(swigCPtr, BackgroundZoneType.getCPtr(zn)), true);
  }

  public BackgroundZoneType() {
    this(affx_fusionJNI.new_BackgroundZoneType(), true);
  }

}