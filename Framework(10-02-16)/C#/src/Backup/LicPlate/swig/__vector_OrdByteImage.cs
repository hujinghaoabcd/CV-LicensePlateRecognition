/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class __vector_OrdByteImage : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<__OrdByteImage>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal __vector_OrdByteImage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(__vector_OrdByteImage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~__vector_OrdByteImage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete___vector_OrdByteImage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public __vector_OrdByteImage(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (__OrdByteImage element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public __OrdByteImage this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(__OrdByteImage[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(__OrdByteImage[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, __OrdByteImage[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<__OrdByteImage> global::System.Collections.Generic.IEnumerable<__OrdByteImage>.GetEnumerator() {
    return new __vector_OrdByteImageEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new __vector_OrdByteImageEnumerator(this);
  }

  public __vector_OrdByteImageEnumerator GetEnumerator() {
    return new __vector_OrdByteImageEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class __vector_OrdByteImageEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<__OrdByteImage>
  {
    private __vector_OrdByteImage collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public __vector_OrdByteImageEnumerator(__vector_OrdByteImage collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public __OrdByteImage Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (__OrdByteImage)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    VisionLabPINVOKE.__vector_OrdByteImage_Clear(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(__OrdByteImage x) {
    VisionLabPINVOKE.__vector_OrdByteImage_Add(swigCPtr, __OrdByteImage.getCPtr(x));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = VisionLabPINVOKE.__vector_OrdByteImage_size(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = VisionLabPINVOKE.__vector_OrdByteImage_capacity(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    VisionLabPINVOKE.__vector_OrdByteImage_reserve(swigCPtr, n);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __vector_OrdByteImage() : this(VisionLabPINVOKE.new___vector_OrdByteImage__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __vector_OrdByteImage(__vector_OrdByteImage other) : this(VisionLabPINVOKE.new___vector_OrdByteImage__SWIG_1(__vector_OrdByteImage.getCPtr(other)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __vector_OrdByteImage(int capacity) : this(VisionLabPINVOKE.new___vector_OrdByteImage__SWIG_2(capacity), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  private __OrdByteImage getitemcopy(int index) {
    __OrdByteImage ret = new __OrdByteImage(VisionLabPINVOKE.__vector_OrdByteImage_getitemcopy(swigCPtr, index), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private __OrdByteImage getitem(int index) {
    __OrdByteImage ret = new __OrdByteImage(VisionLabPINVOKE.__vector_OrdByteImage_getitem(swigCPtr, index), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, __OrdByteImage val) {
    VisionLabPINVOKE.__vector_OrdByteImage_setitem(swigCPtr, index, __OrdByteImage.getCPtr(val));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(__vector_OrdByteImage values) {
    VisionLabPINVOKE.__vector_OrdByteImage_AddRange(swigCPtr, __vector_OrdByteImage.getCPtr(values));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __vector_OrdByteImage GetRange(int index, int count) {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__vector_OrdByteImage_GetRange(swigCPtr, index, count);
    __vector_OrdByteImage ret = (cPtr == global::System.IntPtr.Zero) ? null : new __vector_OrdByteImage(cPtr, true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, __OrdByteImage x) {
    VisionLabPINVOKE.__vector_OrdByteImage_Insert(swigCPtr, index, __OrdByteImage.getCPtr(x));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, __vector_OrdByteImage values) {
    VisionLabPINVOKE.__vector_OrdByteImage_InsertRange(swigCPtr, index, __vector_OrdByteImage.getCPtr(values));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    VisionLabPINVOKE.__vector_OrdByteImage_RemoveAt(swigCPtr, index);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    VisionLabPINVOKE.__vector_OrdByteImage_RemoveRange(swigCPtr, index, count);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public static __vector_OrdByteImage Repeat(__OrdByteImage value, int count) {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__vector_OrdByteImage_Repeat(__OrdByteImage.getCPtr(value), count);
    __vector_OrdByteImage ret = (cPtr == global::System.IntPtr.Zero) ? null : new __vector_OrdByteImage(cPtr, true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    VisionLabPINVOKE.__vector_OrdByteImage_Reverse__SWIG_0(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    VisionLabPINVOKE.__vector_OrdByteImage_Reverse__SWIG_1(swigCPtr, index, count);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, __vector_OrdByteImage values) {
    VisionLabPINVOKE.__vector_OrdByteImage_SetRange(swigCPtr, index, __vector_OrdByteImage.getCPtr(values));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}