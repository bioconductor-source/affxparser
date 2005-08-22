/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class XYCoord {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected XYCoord(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(XYCoord obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_XYCoord(swigCPtr);
    }
    swigCPtr = 0;
  }

  public XYCoord() {
    this(affx_fusionJNI.new_XYCoord__SWIG_0(), true);
  }

  public XYCoord(short x, short y) {
    this(affx_fusionJNI.new_XYCoord__SWIG_1(x, y), true);
  }

  public void setXCoord(short value) {
    affx_fusionJNI.set_XYCoord_xCoord(swigCPtr, value);
  }

  public short getXCoord() {
    return affx_fusionJNI.get_XYCoord_xCoord(swigCPtr);
  }

  public void setYCoord(short value) {
    affx_fusionJNI.set_XYCoord_yCoord(swigCPtr, value);
  }

  public short getYCoord() {
    return affx_fusionJNI.get_XYCoord_yCoord(swigCPtr);
  }

  public XYCoord XYCoord_assign(XYCoord p) {
    return new XYCoord(affx_fusionJNI.XYCoord_XYCoord_assign(swigCPtr, XYCoord.getCPtr(p)), true);
  }

  public boolean XYCoord_equals(XYCoord p) {
    return affx_fusionJNI.XYCoord_XYCoord_equals(swigCPtr, XYCoord.getCPtr(p));
  }

  public boolean XYCoord_not_equals(XYCoord p) {
    return affx_fusionJNI.XYCoord_XYCoord_not_equals(swigCPtr, XYCoord.getCPtr(p));
  }

  public boolean XYCoord_less_than(XYCoord p) {
    return affx_fusionJNI.XYCoord_XYCoord_less_than(swigCPtr, XYCoord.getCPtr(p));
  }

}
