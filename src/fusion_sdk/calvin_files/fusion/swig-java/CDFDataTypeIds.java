/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public final class CDFDataTypeIds {
  public final static CDFDataTypeIds Expression = new CDFDataTypeIds("Expression");
  public final static CDFDataTypeIds Genotyping = new CDFDataTypeIds("Genotyping");
  public final static CDFDataTypeIds Tag = new CDFDataTypeIds("Tag");
  public final static CDFDataTypeIds Resequencing = new CDFDataTypeIds("Resequencing");
  public final static CDFDataTypeIds Control = new CDFDataTypeIds("Control");

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static CDFDataTypeIds swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + CDFDataTypeIds.class + " with value " + swigValue);
  }

  private CDFDataTypeIds(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private CDFDataTypeIds(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private static CDFDataTypeIds[] swigValues = { Expression, Genotyping, Tag, Resequencing, Control };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

