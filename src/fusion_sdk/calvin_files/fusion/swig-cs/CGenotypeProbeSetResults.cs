/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CGenotypeProbeSetResults : CProbeSetResults {
  private HandleRef swigCPtr;

  internal CGenotypeProbeSetResults(IntPtr cPtr, bool cMemoryOwn) : base(affx_fusionPINVOKE.CGenotypeProbeSetResultsUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CGenotypeProbeSetResults obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CGenotypeProbeSetResults() {
    Dispose();
  }

  public override void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CGenotypeProbeSetResults(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
    base.Dispose();
  }

  public byte AlleleCall {
    set {
      affx_fusionPINVOKE.set_CGenotypeProbeSetResults_AlleleCall(swigCPtr, value);
    } 
    get {
      byte ret = affx_fusionPINVOKE.get_CGenotypeProbeSetResults_AlleleCall(swigCPtr);
      return ret;
    } 
  }

  public float Confidence {
    set {
      affx_fusionPINVOKE.set_CGenotypeProbeSetResults_Confidence(swigCPtr, value);
    } 
    get {
      float ret = affx_fusionPINVOKE.get_CGenotypeProbeSetResults_Confidence(swigCPtr);
      return ret;
    } 
  }

  public float RAS1 {
    set {
      affx_fusionPINVOKE.set_CGenotypeProbeSetResults_RAS1(swigCPtr, value);
    } 
    get {
      float ret = affx_fusionPINVOKE.get_CGenotypeProbeSetResults_RAS1(swigCPtr);
      return ret;
    } 
  }

  public float RAS2 {
    set {
      affx_fusionPINVOKE.set_CGenotypeProbeSetResults_RAS2(swigCPtr, value);
    } 
    get {
      float ret = affx_fusionPINVOKE.get_CGenotypeProbeSetResults_RAS2(swigCPtr);
      return ret;
    } 
  }

  public float pvalue_AA {
    set {
      affx_fusionPINVOKE.set_CGenotypeProbeSetResults_pvalue_AA(swigCPtr, value);
    } 
    get {
      float ret = affx_fusionPINVOKE.get_CGenotypeProbeSetResults_pvalue_AA(swigCPtr);
      return ret;
    } 
  }

  public float pvalue_AB {
    set {
      affx_fusionPINVOKE.set_CGenotypeProbeSetResults_pvalue_AB(swigCPtr, value);
    } 
    get {
      float ret = affx_fusionPINVOKE.get_CGenotypeProbeSetResults_pvalue_AB(swigCPtr);
      return ret;
    } 
  }

  public float pvalue_BB {
    set {
      affx_fusionPINVOKE.set_CGenotypeProbeSetResults_pvalue_BB(swigCPtr, value);
    } 
    get {
      float ret = affx_fusionPINVOKE.get_CGenotypeProbeSetResults_pvalue_BB(swigCPtr);
      return ret;
    } 
  }

  public float pvalue_NoCall {
    set {
      affx_fusionPINVOKE.set_CGenotypeProbeSetResults_pvalue_NoCall(swigCPtr, value);
    } 
    get {
      float ret = affx_fusionPINVOKE.get_CGenotypeProbeSetResults_pvalue_NoCall(swigCPtr);
      return ret;
    } 
  }

  public string GetAlleleCallString() {
    string ret = affx_fusionPINVOKE.CGenotypeProbeSetResults_GetAlleleCallString(swigCPtr);
    return ret;
  }

  public CGenotypeProbeSetResults CGenotypeProbeSetResults_assign(CGenotypeProbeSetResults src) {
    CGenotypeProbeSetResults ret = new CGenotypeProbeSetResults(affx_fusionPINVOKE.CGenotypeProbeSetResults_CGenotypeProbeSetResults_assign(swigCPtr, CGenotypeProbeSetResults.getCPtr(src)), true);
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CGenotypeProbeSetResults() : this(affx_fusionPINVOKE.new_CGenotypeProbeSetResults(), true) {
  }

}