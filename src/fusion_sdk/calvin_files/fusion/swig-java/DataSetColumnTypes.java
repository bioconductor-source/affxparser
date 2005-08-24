/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public final class DataSetColumnTypes {
  public final static DataSetColumnTypes ByteColType = new DataSetColumnTypes("ByteColType");
  public final static DataSetColumnTypes UByteColType = new DataSetColumnTypes("UByteColType");
  public final static DataSetColumnTypes ShortColType = new DataSetColumnTypes("ShortColType");
  public final static DataSetColumnTypes UShortColType = new DataSetColumnTypes("UShortColType");
  public final static DataSetColumnTypes IntColType = new DataSetColumnTypes("IntColType");
  public final static DataSetColumnTypes UIntColType = new DataSetColumnTypes("UIntColType");
  public final static DataSetColumnTypes FloatColType = new DataSetColumnTypes("FloatColType");
  public final static DataSetColumnTypes ASCIICharColType = new DataSetColumnTypes("ASCIICharColType");
  public final static DataSetColumnTypes UnicodeCharColType = new DataSetColumnTypes("UnicodeCharColType");

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static DataSetColumnTypes swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + DataSetColumnTypes.class + " with value " + swigValue);
  }

  private DataSetColumnTypes(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private DataSetColumnTypes(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private static DataSetColumnTypes[] swigValues = { ByteColType, UByteColType, ShortColType, UShortColType, IntColType, UIntColType, FloatColType, ASCIICharColType, UnicodeCharColType };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}
