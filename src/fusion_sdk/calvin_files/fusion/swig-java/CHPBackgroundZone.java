/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class CHPBackgroundZone {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected CHPBackgroundZone(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(CHPBackgroundZone obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_CHPBackgroundZone(swigCPtr);
    }
    swigCPtr = 0;
  }

  public CHPBackgroundZone() {
    this(affx_fusionJNI.new_CHPBackgroundZone__SWIG_0(), true);
  }

  public CHPBackgroundZone(float x, float y, float bg, float smooth) {
    this(affx_fusionJNI.new_CHPBackgroundZone__SWIG_1(x, y, bg, smooth), true);
  }

  public void Clear() {
    affx_fusionJNI.CHPBackgroundZone_Clear(swigCPtr);
  }

  public CHPBackgroundZone CHPBackgroundZone_assign(CHPBackgroundZone zn) {
    return new CHPBackgroundZone(affx_fusionJNI.CHPBackgroundZone_CHPBackgroundZone_assign(swigCPtr, CHPBackgroundZone.getCPtr(zn)), true);
  }

  public float GetCenterX() {
    return affx_fusionJNI.CHPBackgroundZone_GetCenterX(swigCPtr);
  }

  public float GetCenterY() {
    return affx_fusionJNI.CHPBackgroundZone_GetCenterY(swigCPtr);
  }

  public float GetBackground() {
    return affx_fusionJNI.CHPBackgroundZone_GetBackground(swigCPtr);
  }

  public float GetSmoothFactor() {
    return affx_fusionJNI.CHPBackgroundZone_GetSmoothFactor(swigCPtr);
  }

  public void SetCenterX(float p) {
    affx_fusionJNI.CHPBackgroundZone_SetCenterX(swigCPtr, p);
  }

  public void SetCenterY(float p) {
    affx_fusionJNI.CHPBackgroundZone_SetCenterY(swigCPtr, p);
  }

  public void SetBackground(float p) {
    affx_fusionJNI.CHPBackgroundZone_SetBackground(swigCPtr, p);
  }

  public void SetSmoothFactor(float p) {
    affx_fusionJNI.CHPBackgroundZone_SetSmoothFactor(swigCPtr, p);
  }

}