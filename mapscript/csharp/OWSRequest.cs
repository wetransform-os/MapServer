/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class OWSRequest : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;
  
  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  internal OWSRequest(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(OWSRequest obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  internal static HandleRef getCPtrAndDisown(OWSRequest obj, object parent) {
    if (obj != null)
    {
      obj.swigCMemOwn = false;
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }
  internal static HandleRef getCPtrAndSetReference(OWSRequest obj, object parent) {
    if (obj != null)
    {
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }

  ~OWSRequest() {
    Dispose();
  }

  public virtual void Dispose() {
  lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        mapscriptPINVOKE.delete_OWSRequest(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      swigParentRef = null;
      GC.SuppressFinalize(this);
    }
  }

  public override bool Equals(object obj) {
    if (obj == null)
        return false;
    if (this.GetType() != obj.GetType())
        return false;
    return swigCPtr.Handle.Equals(OWSRequest.getCPtr((OWSRequest)obj).Handle);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public int NumParams {
    get {
      int ret = mapscriptPINVOKE.OWSRequest_NumParams_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public MS_REQUEST_TYPE type {
    set {
      mapscriptPINVOKE.OWSRequest_type_set(swigCPtr, (int)value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      MS_REQUEST_TYPE ret = (MS_REQUEST_TYPE)mapscriptPINVOKE.OWSRequest_type_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string contenttype {
    set {
      mapscriptPINVOKE.OWSRequest_contenttype_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.OWSRequest_contenttype_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string postrequest {
    set {
      mapscriptPINVOKE.OWSRequest_postrequest_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.OWSRequest_postrequest_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string httpcookiedata {
    set {
      mapscriptPINVOKE.OWSRequest_httpcookiedata_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.OWSRequest_httpcookiedata_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public OWSRequest() : this(mapscriptPINVOKE.new_OWSRequest(), true, null) {
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public int loadParams() {
    int ret = mapscriptPINVOKE.OWSRequest_loadParams(swigCPtr);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setParameter(string name, string value) {
    mapscriptPINVOKE.OWSRequest_setParameter(swigCPtr, name, value);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getName(int index) {
    string ret = mapscriptPINVOKE.OWSRequest_getName(swigCPtr, index);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getValue(int index) {
    string ret = mapscriptPINVOKE.OWSRequest_getValue(swigCPtr, index);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getValueByName(string name) {
    string ret = mapscriptPINVOKE.OWSRequest_getValueByName(swigCPtr, name);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}