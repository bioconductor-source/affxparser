/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class UShortColumnType extends ColumnType {
  private long swigCPtr;

  protected UShortColumnType(long cPtr, boolean cMemoryOwn) {
    super(affx_fusionJNI.SWIGUShortColumnTypeUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(UShortColumnType obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_UShortColumnType(swigCPtr);
    }
    swigCPtr = 0;
    super.delete();
  }

  public UShortColumnType() {
    this(affx_fusionJNI.new_UShortColumnType(), true);
  }

}