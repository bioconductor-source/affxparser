/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class AuditFileReader {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected AuditFileReader(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(AuditFileReader obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_AuditFileReader(swigCPtr);
    }
    swigCPtr = 0;
  }

  public AuditFileReader() {
    this(affx_fusionJNI.new_AuditFileReader(), true);
  }

  public boolean Read(String fileName, SWIGTYPE_p_std__listTaffymetrix_calvin_array__ArrayAuditEntry_t auditData) {
    return affx_fusionJNI.AuditFileReader_Read(swigCPtr, fileName, SWIGTYPE_p_std__listTaffymetrix_calvin_array__ArrayAuditEntry_t.getCPtr(auditData));
  }

}