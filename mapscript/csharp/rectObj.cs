/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class rectObj : IDisposable {
  /* %typemap(csbody) SWIGTYPE */
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;
  
  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  internal rectObj(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(rectObj obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  internal static HandleRef getCPtrAndDisown(rectObj obj, object parent) {
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
  internal static HandleRef getCPtrAndSetReference(rectObj obj, object parent) {
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

  /* %typemap(csfinalize) SWIGTYPE */
  ~rectObj() {
    Dispose();
  }

  public virtual void Dispose() {
  lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        mapscriptPINVOKE.delete_rectObj(swigCPtr);
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
    return swigCPtr.Handle.Equals(rectObj.getCPtr((rectObj)obj).Handle);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public double minx {
    set {
      mapscriptPINVOKE.rectObj_minx_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = mapscriptPINVOKE.rectObj_minx_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double miny {
    set {
      mapscriptPINVOKE.rectObj_miny_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = mapscriptPINVOKE.rectObj_miny_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double maxx {
    set {
      mapscriptPINVOKE.rectObj_maxx_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = mapscriptPINVOKE.rectObj_maxx_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double maxy {
    set {
      mapscriptPINVOKE.rectObj_maxy_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = mapscriptPINVOKE.rectObj_maxy_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public rectObj(double minx, double miny, double maxx, double maxy, int imageunits) : this(mapscriptPINVOKE.new_rectObj(minx, miny, maxx, maxy, imageunits), true, null) {
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public int project(projectionObj projin, projectionObj projout) {
    int ret = mapscriptPINVOKE.rectObj_project(swigCPtr, projectionObj.getCPtr(projin), projectionObj.getCPtr(projout));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fit(int width, int height) {
    double ret = mapscriptPINVOKE.rectObj_fit(swigCPtr, width, height);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int draw(mapObj map, layerObj layer, imageObj image, int classindex, string text) {
    int ret = mapscriptPINVOKE.rectObj_draw(swigCPtr, mapObj.getCPtr(map), layerObj.getCPtr(layer), imageObj.getCPtr(image), classindex, text);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public pointObj getCenter() {
    /* %typemap(csout, excode=SWIGEXCODE, new="1") SWIGTYPE *, SWIGTYPE [], SWIGTYPE (CLASS::*) */
    IntPtr cPtr = mapscriptPINVOKE.rectObj_getCenter(swigCPtr);
    pointObj ret = (cPtr == IntPtr.Zero) ? null : new pointObj(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public shapeObj toPolygon() {
    /* %typemap(csout, excode=SWIGEXCODE, new="1") SWIGTYPE *, SWIGTYPE [], SWIGTYPE (CLASS::*) */
    IntPtr cPtr = mapscriptPINVOKE.rectObj_toPolygon(swigCPtr);
    shapeObj ret = (cPtr == IntPtr.Zero) ? null : new shapeObj(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string toString() {
    string ret = mapscriptPINVOKE.rectObj_toString(swigCPtr);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
