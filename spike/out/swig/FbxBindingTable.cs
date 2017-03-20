//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.11
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FbxSdk {

public class FbxBindingTable : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxBindingTable(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxBindingTable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static FbxClassId ClassId {
    set {
      examplePINVOKE.FbxBindingTable_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxBindingTable_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public virtual FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxBindingTable_GetClassId(swigCPtr), true);
    return ret;
  }

  public static FbxBindingTable Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxBindingTable_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxBindingTable ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxBindingTable(cPtr, false);
    return ret;
  }

  public static FbxBindingTable Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxBindingTable_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxBindingTable ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxBindingTable(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t TargetName {
    set {
      examplePINVOKE.FbxBindingTable_TargetName_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxBindingTable_TargetName_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t TargetType {
    set {
      examplePINVOKE.FbxBindingTable_TargetType_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxBindingTable_TargetType_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t DescRelativeURL {
    set {
      examplePINVOKE.FbxBindingTable_DescRelativeURL_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxBindingTable_DescRelativeURL_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t DescAbsoluteURL {
    set {
      examplePINVOKE.FbxBindingTable_DescAbsoluteURL_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxBindingTable_DescAbsoluteURL_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t DescTAG {
    set {
      examplePINVOKE.FbxBindingTable_DescTAG_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxBindingTable_DescTAG_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t CodeRelativeURL {
    set {
      examplePINVOKE.FbxBindingTable_CodeRelativeURL_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxBindingTable_CodeRelativeURL_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t CodeAbsoluteURL {
    set {
      examplePINVOKE.FbxBindingTable_CodeAbsoluteURL_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxBindingTable_CodeAbsoluteURL_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t CodeTAG {
    set {
      examplePINVOKE.FbxBindingTable_CodeTAG_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxBindingTable_CodeTAG_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public static string sTargetName {
    set {
      examplePINVOKE.FbxBindingTable_sTargetName_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sTargetName_get();
      return ret;
    } 
  }

  public static string sTargetType {
    set {
      examplePINVOKE.FbxBindingTable_sTargetType_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sTargetType_get();
      return ret;
    } 
  }

  public static string sDescRelativeURL {
    set {
      examplePINVOKE.FbxBindingTable_sDescRelativeURL_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sDescRelativeURL_get();
      return ret;
    } 
  }

  public static string sDescAbsoluteURL {
    set {
      examplePINVOKE.FbxBindingTable_sDescAbsoluteURL_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sDescAbsoluteURL_get();
      return ret;
    } 
  }

  public static string sDescTAG {
    set {
      examplePINVOKE.FbxBindingTable_sDescTAG_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sDescTAG_get();
      return ret;
    } 
  }

  public static string sCodeRelativeURL {
    set {
      examplePINVOKE.FbxBindingTable_sCodeRelativeURL_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sCodeRelativeURL_get();
      return ret;
    } 
  }

  public static string sCodeAbsoluteURL {
    set {
      examplePINVOKE.FbxBindingTable_sCodeAbsoluteURL_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sCodeAbsoluteURL_get();
      return ret;
    } 
  }

  public static string sCodeTAG {
    set {
      examplePINVOKE.FbxBindingTable_sCodeTAG_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sCodeTAG_get();
      return ret;
    } 
  }

  public static string sDefaultTargetName {
    set {
      examplePINVOKE.FbxBindingTable_sDefaultTargetName_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sDefaultTargetName_get();
      return ret;
    } 
  }

  public static string sDefaultTargetType {
    set {
      examplePINVOKE.FbxBindingTable_sDefaultTargetType_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sDefaultTargetType_get();
      return ret;
    } 
  }

  public static string sDefaultDescRelativeURL {
    set {
      examplePINVOKE.FbxBindingTable_sDefaultDescRelativeURL_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sDefaultDescRelativeURL_get();
      return ret;
    } 
  }

  public static string sDefaultDescAbsoluteURL {
    set {
      examplePINVOKE.FbxBindingTable_sDefaultDescAbsoluteURL_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sDefaultDescAbsoluteURL_get();
      return ret;
    } 
  }

  public static string sDefaultDescTAG {
    set {
      examplePINVOKE.FbxBindingTable_sDefaultDescTAG_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sDefaultDescTAG_get();
      return ret;
    } 
  }

  public static string sDefaultCodeRelativeURL {
    set {
      examplePINVOKE.FbxBindingTable_sDefaultCodeRelativeURL_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sDefaultCodeRelativeURL_get();
      return ret;
    } 
  }

  public static string sDefaultCodeAbsoluteURL {
    set {
      examplePINVOKE.FbxBindingTable_sDefaultCodeAbsoluteURL_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sDefaultCodeAbsoluteURL_get();
      return ret;
    } 
  }

  public static string sDefaultCodeTAG {
    set {
      examplePINVOKE.FbxBindingTable_sDefaultCodeTAG_set(value);
    } 
    get {
      string ret = examplePINVOKE.FbxBindingTable_sDefaultCodeTAG_get();
      return ret;
    } 
  }

}

}