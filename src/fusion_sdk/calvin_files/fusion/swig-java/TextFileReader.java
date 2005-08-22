/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class TextFileReader {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected TextFileReader(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(TextFileReader obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_TextFileReader(swigCPtr);
    }
    swigCPtr = 0;
  }

  public TextFileReader() {
    this(affx_fusionJNI.new_TextFileReader(), true);
  }

  public void ReadFile(String fileName, SWIGTYPE_p_std__mapTstd__string_std__string_t textData) {
    affx_fusionJNI.TextFileReader_ReadFile__SWIG_0(swigCPtr, fileName, SWIGTYPE_p_std__mapTstd__string_std__string_t.getCPtr(textData));
  }

  public void ReadFile(SWIGTYPE_p_std__ifstream fileStream, SWIGTYPE_p_std__mapTstd__string_std__string_t textData) {
    affx_fusionJNI.TextFileReader_ReadFile__SWIG_1(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(fileStream), SWIGTYPE_p_std__mapTstd__string_std__string_t.getCPtr(textData));
  }

}
