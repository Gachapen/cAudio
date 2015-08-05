/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace cAudio {

using System;
using System.Runtime.InteropServices;

public class IDataSource : IRefCounted {
  private HandleRef swigCPtr;

  internal IDataSource(IntPtr cPtr, bool cMemoryOwn) : base(cAudioCSharpWrapperPINVOKE.IDataSource_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IDataSource obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IDataSource() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          cAudioCSharpWrapperPINVOKE.delete_IDataSource(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public IDataSource() : this(cAudioCSharpWrapperPINVOKE.new_IDataSource(), true) {
    SwigDirectorConnect();
  }

  public virtual bool isValid() {
    bool ret = cAudioCSharpWrapperPINVOKE.IDataSource_isValid(swigCPtr);
    return ret;
  }

  public virtual int getCurrentPos() {
    int ret = cAudioCSharpWrapperPINVOKE.IDataSource_getCurrentPos(swigCPtr);
    return ret;
  }

  public virtual int getSize() {
    int ret = cAudioCSharpWrapperPINVOKE.IDataSource_getSize(swigCPtr);
    return ret;
  }

  public virtual int read(SWIGTYPE_p_void output, int size) {
    int ret = cAudioCSharpWrapperPINVOKE.IDataSource_read(swigCPtr, SWIGTYPE_p_void.getCPtr(output), size);
    return ret;
  }

  public virtual bool seek(int amount, bool relative) {
    bool ret = cAudioCSharpWrapperPINVOKE.IDataSource_seek(swigCPtr, amount, relative);
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("grab", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateIDataSource_0(SwigDirectorgrab);
    if (SwigDerivedClassHasMethod("drop", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateIDataSource_1(SwigDirectordrop);
    if (SwigDerivedClassHasMethod("isValid", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateIDataSource_2(SwigDirectorisValid);
    if (SwigDerivedClassHasMethod("getCurrentPos", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateIDataSource_3(SwigDirectorgetCurrentPos);
    if (SwigDerivedClassHasMethod("getSize", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateIDataSource_4(SwigDirectorgetSize);
    if (SwigDerivedClassHasMethod("read", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateIDataSource_5(SwigDirectorread);
    if (SwigDerivedClassHasMethod("seek", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateIDataSource_6(SwigDirectorseek);
    cAudioCSharpWrapperPINVOKE.IDataSource_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(IDataSource));
    return hasDerivedMethod;
  }

  private void SwigDirectorgrab() {
    grab();
  }

  private bool SwigDirectordrop() {
    return drop();
  }

  private bool SwigDirectorisValid() {
    return isValid();
  }

  private int SwigDirectorgetCurrentPos() {
    return getCurrentPos();
  }

  private int SwigDirectorgetSize() {
    return getSize();
  }

  private int SwigDirectorread(IntPtr output, int size) {
    return read((output == IntPtr.Zero) ? null : new SWIGTYPE_p_void(output, false), size);
  }

  private bool SwigDirectorseek(int amount, bool relative) {
    return seek(amount, relative);
  }

  public delegate void SwigDelegateIDataSource_0();
  public delegate bool SwigDelegateIDataSource_1();
  public delegate bool SwigDelegateIDataSource_2();
  public delegate int SwigDelegateIDataSource_3();
  public delegate int SwigDelegateIDataSource_4();
  public delegate int SwigDelegateIDataSource_5(IntPtr output, int size);
  public delegate bool SwigDelegateIDataSource_6(int amount, bool relative);

  private SwigDelegateIDataSource_0 swigDelegate0;
  private SwigDelegateIDataSource_1 swigDelegate1;
  private SwigDelegateIDataSource_2 swigDelegate2;
  private SwigDelegateIDataSource_3 swigDelegate3;
  private SwigDelegateIDataSource_4 swigDelegate4;
  private SwigDelegateIDataSource_5 swigDelegate5;
  private SwigDelegateIDataSource_6 swigDelegate6;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
  private static Type[] swigMethodTypes4 = new Type[] {  };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(SWIGTYPE_p_void), typeof(int) };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(int), typeof(bool) };
}

}
