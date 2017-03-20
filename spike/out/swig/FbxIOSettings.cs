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

public class FbxIOSettings : FbxObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxIOSettings(global::System.IntPtr cPtr, bool cMemoryOwn) : base(examplePINVOKE.FbxIOSettings_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxIOSettings obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxClassId ClassId {
    set {
      examplePINVOKE.FbxIOSettings_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxIOSettings_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(examplePINVOKE.FbxIOSettings_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxIOSettings Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxIOSettings_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxIOSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxIOSettings(cPtr, false);
    return ret;
  }

  public new static FbxIOSettings Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxIOSettings_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxIOSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxIOSettings(cPtr, false);
    return ret;
  }

  public FbxProperty AddPropertyGroup(string pName, FbxDataType pDataType, string pLabel) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyGroup__SWIG_0(swigCPtr, pName, FbxDataType.getCPtr(pDataType), pLabel), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyGroup(string pName, FbxDataType pDataType) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyGroup__SWIG_1(swigCPtr, pName, FbxDataType.getCPtr(pDataType)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyGroup(string pName) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyGroup__SWIG_2(swigCPtr, pName), true);
    return ret;
  }

  public FbxProperty AddPropertyGroup(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, bool pVisible, bool pSavable, bool pEnabled) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyGroup__SWIG_3(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, pVisible, pSavable, pEnabled), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyGroup(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, bool pVisible, bool pSavable) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyGroup__SWIG_4(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, pVisible, pSavable), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyGroup(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, bool pVisible) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyGroup__SWIG_5(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, pVisible), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyGroup(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyGroup__SWIG_6(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyGroup(FbxProperty pParentProperty, string pName, FbxDataType pDataType) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyGroup__SWIG_7(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyGroup(FbxProperty pParentProperty, string pName) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyGroup__SWIG_8(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddProperty(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, SWIGTYPE_p_void pValue, bool pVisible, bool pSavable, bool pEnabled) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddProperty__SWIG_0(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, SWIGTYPE_p_void.getCPtr(pValue), pVisible, pSavable, pEnabled), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddProperty(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, SWIGTYPE_p_void pValue, bool pVisible, bool pSavable) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddProperty__SWIG_1(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, SWIGTYPE_p_void.getCPtr(pValue), pVisible, pSavable), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddProperty(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, SWIGTYPE_p_void pValue, bool pVisible) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddProperty__SWIG_2(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, SWIGTYPE_p_void.getCPtr(pValue), pVisible), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddProperty(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, SWIGTYPE_p_void pValue) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddProperty__SWIG_3(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, SWIGTYPE_p_void.getCPtr(pValue)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddProperty(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddProperty__SWIG_4(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddProperty(FbxProperty pParentProperty, string pName, FbxDataType pDataType) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddProperty__SWIG_5(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddProperty(FbxProperty pParentProperty, string pName) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddProperty__SWIG_6(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyMinMax(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, SWIGTYPE_p_void pValue, SWIGTYPE_p_double pMinValue, SWIGTYPE_p_double pMaxValue, bool pVisible, bool pSavable, bool pEnabled) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyMinMax__SWIG_0(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, SWIGTYPE_p_void.getCPtr(pValue), SWIGTYPE_p_double.getCPtr(pMinValue), SWIGTYPE_p_double.getCPtr(pMaxValue), pVisible, pSavable, pEnabled), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyMinMax(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, SWIGTYPE_p_void pValue, SWIGTYPE_p_double pMinValue, SWIGTYPE_p_double pMaxValue, bool pVisible, bool pSavable) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyMinMax__SWIG_1(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, SWIGTYPE_p_void.getCPtr(pValue), SWIGTYPE_p_double.getCPtr(pMinValue), SWIGTYPE_p_double.getCPtr(pMaxValue), pVisible, pSavable), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyMinMax(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, SWIGTYPE_p_void pValue, SWIGTYPE_p_double pMinValue, SWIGTYPE_p_double pMaxValue, bool pVisible) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyMinMax__SWIG_2(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, SWIGTYPE_p_void.getCPtr(pValue), SWIGTYPE_p_double.getCPtr(pMinValue), SWIGTYPE_p_double.getCPtr(pMaxValue), pVisible), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyMinMax(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, SWIGTYPE_p_void pValue, SWIGTYPE_p_double pMinValue, SWIGTYPE_p_double pMaxValue) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyMinMax__SWIG_3(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, SWIGTYPE_p_void.getCPtr(pValue), SWIGTYPE_p_double.getCPtr(pMinValue), SWIGTYPE_p_double.getCPtr(pMaxValue)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyMinMax(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, SWIGTYPE_p_void pValue, SWIGTYPE_p_double pMinValue) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyMinMax__SWIG_4(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, SWIGTYPE_p_void.getCPtr(pValue), SWIGTYPE_p_double.getCPtr(pMinValue)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyMinMax(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel, SWIGTYPE_p_void pValue) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyMinMax__SWIG_5(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel, SWIGTYPE_p_void.getCPtr(pValue)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyMinMax(FbxProperty pParentProperty, string pName, FbxDataType pDataType, string pLabel) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyMinMax__SWIG_6(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType), pLabel), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyMinMax(FbxProperty pParentProperty, string pName, FbxDataType pDataType) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyMinMax__SWIG_7(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName, FbxDataType.getCPtr(pDataType)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty AddPropertyMinMax(FbxProperty pParentProperty, string pName) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_AddPropertyMinMax__SWIG_8(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty GetProperty(string pName) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_GetProperty__SWIG_0(swigCPtr, pName), true);
    return ret;
  }

  public FbxProperty GetProperty(FbxProperty pParentProperty, string pName) {
    FbxProperty ret = new FbxProperty(examplePINVOKE.FbxIOSettings_GetProperty__SWIG_1(swigCPtr, FbxProperty.getCPtr(pParentProperty), pName), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetBoolProp(string pName, bool pDefValue) {
    bool ret = examplePINVOKE.FbxIOSettings_GetBoolProp(swigCPtr, pName, pDefValue);
    return ret;
  }

  public void SetBoolProp(string pName, bool pValue) {
    examplePINVOKE.FbxIOSettings_SetBoolProp(swigCPtr, pName, pValue);
  }

  public double GetDoubleProp(string pName, double pDefValue) {
    double ret = examplePINVOKE.FbxIOSettings_GetDoubleProp(swigCPtr, pName, pDefValue);
    return ret;
  }

  public void SetDoubleProp(string pName, double pValue) {
    examplePINVOKE.FbxIOSettings_SetDoubleProp(swigCPtr, pName, pValue);
  }

  public int GetIntProp(string pName, int pDefValue) {
    int ret = examplePINVOKE.FbxIOSettings_GetIntProp(swigCPtr, pName, pDefValue);
    return ret;
  }

  public void SetIntProp(string pName, int pValue) {
    examplePINVOKE.FbxIOSettings_SetIntProp(swigCPtr, pName, pValue);
  }

  public FbxTime GetTimeProp(string pName, FbxTime pDefValue) {
    FbxTime ret = new FbxTime(examplePINVOKE.FbxIOSettings_GetTimeProp(swigCPtr, pName, FbxTime.getCPtr(pDefValue)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetTimeProp(string pName, FbxTime pValue) {
    examplePINVOKE.FbxIOSettings_SetTimeProp(swigCPtr, pName, FbxTime.getCPtr(pValue));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxString GetEnumProp(string pName, FbxString pDefValue) {
    FbxString ret = new FbxString(examplePINVOKE.FbxIOSettings_GetEnumProp__SWIG_0(swigCPtr, pName, FbxString.getCPtr(pDefValue)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetEnumProp(string pName, int pDefValue) {
    int ret = examplePINVOKE.FbxIOSettings_GetEnumProp__SWIG_1(swigCPtr, pName, pDefValue);
    return ret;
  }

  public int GetEnumIndex(string pName, FbxString pValue) {
    int ret = examplePINVOKE.FbxIOSettings_GetEnumIndex__SWIG_0(swigCPtr, pName, FbxString.getCPtr(pValue));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetEnumProp(string pName, FbxString pValue) {
    examplePINVOKE.FbxIOSettings_SetEnumProp__SWIG_0(swigCPtr, pName, FbxString.getCPtr(pValue));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetEnumProp(string pName, int pValue) {
    examplePINVOKE.FbxIOSettings_SetEnumProp__SWIG_1(swigCPtr, pName, pValue);
  }

  public void RemoveEnumPropValue(string pName, FbxString pValue) {
    examplePINVOKE.FbxIOSettings_RemoveEnumPropValue(swigCPtr, pName, FbxString.getCPtr(pValue));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public void EmptyEnumProp(string pName) {
    examplePINVOKE.FbxIOSettings_EmptyEnumProp(swigCPtr, pName);
  }

  public bool IsEnumExist(FbxProperty pProp, FbxString enumString) {
    bool ret = examplePINVOKE.FbxIOSettings_IsEnumExist(swigCPtr, FbxProperty.getCPtr(pProp), FbxString.getCPtr(enumString));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetEnumIndex(FbxProperty pProp, FbxString enumString, bool pNoCase) {
    int ret = examplePINVOKE.FbxIOSettings_GetEnumIndex__SWIG_1(swigCPtr, FbxProperty.getCPtr(pProp), FbxString.getCPtr(enumString), pNoCase);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetEnumIndex(FbxProperty pProp, FbxString enumString) {
    int ret = examplePINVOKE.FbxIOSettings_GetEnumIndex__SWIG_2(swigCPtr, FbxProperty.getCPtr(pProp), FbxString.getCPtr(enumString));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetFlag(string pName, FbxPropertyFlags.EFlags propFlag, bool pValue) {
    bool ret = examplePINVOKE.FbxIOSettings_SetFlag(swigCPtr, pName, (int)propFlag, pValue);
    return ret;
  }

  public FbxString GetStringProp(string pName, FbxString pDefValue) {
    FbxString ret = new FbxString(examplePINVOKE.FbxIOSettings_GetStringProp(swigCPtr, pName, FbxString.getCPtr(pDefValue)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetStringProp(string pName, FbxString pValue) {
    examplePINVOKE.FbxIOSettings_SetStringProp(swigCPtr, pName, FbxString.getCPtr(pValue));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool ReadXMLFile(FbxString path) {
    bool ret = examplePINVOKE.FbxIOSettings_ReadXMLFile(swigCPtr, FbxString.getCPtr(path));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool WriteXMLFile(FbxString path) {
    bool ret = examplePINVOKE.FbxIOSettings_WriteXMLFile(swigCPtr, FbxString.getCPtr(path));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool WriteXmlPropToFile(FbxString pFullPath, FbxString propPath) {
    bool ret = examplePINVOKE.FbxIOSettings_WriteXmlPropToFile(swigCPtr, FbxString.getCPtr(pFullPath), FbxString.getCPtr(propPath));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxIOPropInfo GetPropInfo(FbxProperty pProp) {
    global::System.IntPtr cPtr = examplePINVOKE.FbxIOSettings_GetPropInfo(swigCPtr, FbxProperty.getCPtr(pProp));
    FbxIOPropInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxIOPropInfo(cPtr, false);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxIOSettings.ELanguage UILanguage {
    set {
      examplePINVOKE.FbxIOSettings_UILanguage_set(swigCPtr, (int)value);
    } 
    get {
      FbxIOSettings.ELanguage ret = (FbxIOSettings.ELanguage)examplePINVOKE.FbxIOSettings_UILanguage_get(swigCPtr);
      return ret;
    } 
  }

  public FbxString GetLanguageLabel(FbxProperty pProp) {
    FbxString ret = new FbxString(examplePINVOKE.FbxIOSettings_GetLanguageLabel(swigCPtr, FbxProperty.getCPtr(pProp)), true);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLanguageLabel(FbxProperty pProp, FbxString pLabel) {
    examplePINVOKE.FbxIOSettings_SetLanguageLabel(swigCPtr, FbxProperty.getCPtr(pProp), FbxString.getCPtr(pLabel));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxIOSettings.ELanguage Get_Max_Runtime_Language(FbxString pRegLocation) {
    FbxIOSettings.ELanguage ret = (FbxIOSettings.ELanguage)examplePINVOKE.FbxIOSettings_Get_Max_Runtime_Language(swigCPtr, FbxString.getCPtr(pRegLocation));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxIOInfo impInfo {
    set {
      examplePINVOKE.FbxIOSettings_impInfo_set(swigCPtr, FbxIOInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxIOSettings_impInfo_get(swigCPtr);
      FbxIOInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxIOInfo(cPtr, false);
      return ret;
    } 
  }

  public FbxIOInfo expInfo {
    set {
      examplePINVOKE.FbxIOSettings_expInfo_set(swigCPtr, FbxIOInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = examplePINVOKE.FbxIOSettings_expInfo_get(swigCPtr);
      FbxIOInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxIOInfo(cPtr, false);
      return ret;
    } 
  }

  public static FbxString GetUserMyDocumentDir() {
    FbxString ret = new FbxString(examplePINVOKE.FbxIOSettings_GetUserMyDocumentDir(), true);
    return ret;
  }

  public void SetPropVisible(FbxProperty pProp, bool pWithChildren, bool pVisible) {
    examplePINVOKE.FbxIOSettings_SetPropVisible(swigCPtr, FbxProperty.getCPtr(pProp), pWithChildren, pVisible);
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ReadXmlPropFromMyDocument(FbxString subDir, FbxString filename) {
    bool ret = examplePINVOKE.FbxIOSettings_ReadXmlPropFromMyDocument(swigCPtr, FbxString.getCPtr(subDir), FbxString.getCPtr(filename));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool WriteXmlPropToMyDocument(FbxString subDir, FbxString filename, FbxString propPath) {
    bool ret = examplePINVOKE.FbxIOSettings_WriteXmlPropToMyDocument(swigCPtr, FbxString.getCPtr(subDir), FbxString.getCPtr(filename), FbxString.getCPtr(propPath));
    if (examplePINVOKE.SWIGPendingException.Pending) throw examplePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string GetFileMergeDescription(int pIndex) {
    string ret = examplePINVOKE.FbxIOSettings_GetFileMergeDescription(pIndex);
    return ret;
  }

  public enum ELanguage {
    eENU,
    eDEU,
    eFRA,
    eJPN,
    eKOR,
    eCHS,
    eLanguageCount
  }

  public enum ELoadMode {
    eCreate,
    eMerge,
    eExclusiveMerge
  }

  public enum EQuaternionMode {
    eAsQuaternion,
    eAsEuler,
    eResample
  }

  public enum EObjectDerivation {
    eByLayer,
    eByEntity,
    eByBlock
  }

  public enum ESysUnits {
    eUnitsUser,
    eUnitsInches,
    eUnitsFeet,
    eUnitYards,
    eUnitsMiles,
    eUnitsMillimeters,
    eUnitsCentimeters,
    eUnitsMeters,
    eUnitsKilometers
  }

  public enum ESysFrameRate {
    eFrameRateUser,
    eFrameRateHours,
    eFrameRateMinutes,
    eFrameRateSeconds,
    eFrameRateMilliseconds,
    eFrameRateGames15,
    eFrameRateFilm24,
    eFrameRatePAL25,
    eFrameRateNTSC30,
    eFrameRateShowScan48,
    eFrameRatePALField50,
    eFrameRateNTSCField60
  }

  public enum EEnveloppeSystem {
    eSkinModifier,
    ePhysic,
    eBonePro,
    eEnveloppeSystemCount
  }

  public enum EGeometryType {
    eTriangle,
    eSimplifiedPoly,
    ePolygon,
    eNurbs,
    ePatch,
    eGeometryTypeCount
  }

  public enum EIKType {
    eNone,
    eFBIK,
    eHumanIK
  }

}

}