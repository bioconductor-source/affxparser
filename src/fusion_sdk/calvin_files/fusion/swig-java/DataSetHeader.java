/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class DataSetHeader {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected DataSetHeader(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(DataSetHeader obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_DataSetHeader(swigCPtr);
    }
    swigCPtr = 0;
  }

  public DataSetHeader() {
    this(affx_fusionJNI.new_DataSetHeader(), true);
  }

  public void Clear() {
    affx_fusionJNI.DataSetHeader_Clear(swigCPtr);
  }

  public int GetDataSize() {
    return affx_fusionJNI.DataSetHeader_GetDataSize(swigCPtr);
  }

  public int GetRowSize() {
    return affx_fusionJNI.DataSetHeader_GetRowSize(swigCPtr);
  }

  public void SetName(SWIGTYPE_p_std__wstring p) {
    affx_fusionJNI.DataSetHeader_SetName(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(p));
  }

  public SWIGTYPE_p_std__wstring GetName() {
    return new SWIGTYPE_p_std__wstring(affx_fusionJNI.DataSetHeader_GetName(swigCPtr), true);
  }

  public int GetNameValParamCnt() {
    return affx_fusionJNI.DataSetHeader_GetNameValParamCnt(swigCPtr);
  }

  public void AddNameValParam(ParameterNameValueType p) {
    affx_fusionJNI.DataSetHeader_AddNameValParam(swigCPtr, ParameterNameValueType.getCPtr(p));
  }

  public void GetNameValIterators(SWIGTYPE_p_std__vectorTaffymetrix_calvin_parameter__ParameterNameValueType_t__const_iterator begin, SWIGTYPE_p_std__vectorTaffymetrix_calvin_parameter__ParameterNameValueType_t__const_iterator end) {
    affx_fusionJNI.DataSetHeader_GetNameValIterators(swigCPtr, SWIGTYPE_p_std__vectorTaffymetrix_calvin_parameter__ParameterNameValueType_t__const_iterator.getCPtr(begin), SWIGTYPE_p_std__vectorTaffymetrix_calvin_parameter__ParameterNameValueType_t__const_iterator.getCPtr(end));
  }

  public boolean FindNameValParam(SWIGTYPE_p_std__wstring name, ParameterNameValueType result) {
    return affx_fusionJNI.DataSetHeader_FindNameValParam(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(name), ParameterNameValueType.getCPtr(result));
  }

  public void AddColumnType(ColumnType colType) {
    affx_fusionJNI.DataSetHeader_AddColumnType(swigCPtr, ColumnType.getCPtr(colType));
  }

  public void AddIntColumnType() {
    affx_fusionJNI.DataSetHeader_AddIntColumnType(swigCPtr);
  }

  public void AddUIntColumnType() {
    affx_fusionJNI.DataSetHeader_AddUIntColumnType(swigCPtr);
  }

  public void AddShortColumnType() {
    affx_fusionJNI.DataSetHeader_AddShortColumnType(swigCPtr);
  }

  public void AddUShortColumnType() {
    affx_fusionJNI.DataSetHeader_AddUShortColumnType(swigCPtr);
  }

  public void AddByteColumnType() {
    affx_fusionJNI.DataSetHeader_AddByteColumnType(swigCPtr);
  }

  public void AddUByteColumnType() {
    affx_fusionJNI.DataSetHeader_AddUByteColumnType(swigCPtr);
  }

  public void AddFloatColumnType() {
    affx_fusionJNI.DataSetHeader_AddFloatColumnType(swigCPtr);
  }

  public void AddAsciiColumnType(int len) {
    affx_fusionJNI.DataSetHeader_AddAsciiColumnType(swigCPtr, len);
  }

  public void AddUnicodeColumnType(int len) {
    affx_fusionJNI.DataSetHeader_AddUnicodeColumnType(swigCPtr, len);
  }

  public ColumnType GetColumnType(int index) {
    return new ColumnType(affx_fusionJNI.DataSetHeader_GetColumnType(swigCPtr, index), true);
  }

  public int GetRowCnt() {
    return affx_fusionJNI.DataSetHeader_GetRowCnt(swigCPtr);
  }

  public void SetRowCnt(int p) {
    affx_fusionJNI.DataSetHeader_SetRowCnt(swigCPtr, p);
  }

  public int GetColumnCnt() {
    return affx_fusionJNI.DataSetHeader_GetColumnCnt(swigCPtr);
  }

  public void SetHeaderStartFilePos(long pos) {
    affx_fusionJNI.DataSetHeader_SetHeaderStartFilePos(swigCPtr, pos);
  }

  public long GetHeaderStartFilePos() {
    return affx_fusionJNI.DataSetHeader_GetHeaderStartFilePos(swigCPtr);
  }

  public void SetDataStartFilePos(long pos) {
    affx_fusionJNI.DataSetHeader_SetDataStartFilePos(swigCPtr, pos);
  }

  public long GetDataStartFilePos() {
    return affx_fusionJNI.DataSetHeader_GetDataStartFilePos(swigCPtr);
  }

}
