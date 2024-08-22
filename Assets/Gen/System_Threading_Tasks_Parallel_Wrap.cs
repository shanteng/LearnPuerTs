#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class System_Threading_Tasks_Parallel_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(System.Threading.Tasks.Parallel).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Invoke(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 0)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action), 0, paramLen, v8Value0, ref argobj0, ref argType0))
                    {
                        System.Action[] arg0 = ArgHelper.GetParams<System.Action>((int)data, isolate, info, 0, paramLen, v8Value0);

                        System.Threading.Tasks.Parallel.Invoke (arg0);

                        return;
                    }
                }
                if (paramLen == 0)
                {
            
                    {

                        System.Threading.Tasks.Parallel.Invoke (System.Array.Empty<System.Action>());

                        return;
                    }
                }
                if (paramLen >= 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.ParallelOptions), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.Tasks.ParallelOptions>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.Tasks.ParallelOptions arg0 = (System.Threading.Tasks.ParallelOptions)argobj0;
                        System.Action[] arg1 = ArgHelper.GetParams<System.Action>((int)data, isolate, info, 1, paramLen, v8Value1);

                        System.Threading.Tasks.Parallel.Invoke (arg0, arg1);

                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.ParallelOptions), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.Tasks.ParallelOptions>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.Tasks.ParallelOptions arg0 = (System.Threading.Tasks.ParallelOptions)argobj0;

                        System.Threading.Tasks.Parallel.Invoke (arg0, System.Array.Empty<System.Action>());

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Invoke");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_For(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 3)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<int>), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Action<int>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Action<int> arg2 = (System.Action<int>)argobj2;

                        var result = System.Threading.Tasks.Parallel.For (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.BigInt, typeof(long), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.BigInt, typeof(long), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<long>), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        long arg0 = (long)StaticTranslate<long>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        long arg1 = (long)StaticTranslate<long>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Action<long>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Action<long> arg2 = (System.Action<long>)argobj2;

                        var result = System.Threading.Tasks.Parallel.For (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<int, System.Threading.Tasks.ParallelLoopState>), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Action<int, System.Threading.Tasks.ParallelLoopState>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Action<int, System.Threading.Tasks.ParallelLoopState> arg2 = (System.Action<int, System.Threading.Tasks.ParallelLoopState>)argobj2;

                        var result = System.Threading.Tasks.Parallel.For (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.BigInt, typeof(long), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.BigInt, typeof(long), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<long, System.Threading.Tasks.ParallelLoopState>), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        long arg0 = (long)StaticTranslate<long>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        long arg1 = (long)StaticTranslate<long>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Action<long, System.Threading.Tasks.ParallelLoopState>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Action<long, System.Threading.Tasks.ParallelLoopState> arg2 = (System.Action<long, System.Threading.Tasks.ParallelLoopState>)argobj2;

                        var result = System.Threading.Tasks.Parallel.For (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 4)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.ParallelOptions), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<int>), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Threading.Tasks.ParallelOptions>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Threading.Tasks.ParallelOptions arg2 = (System.Threading.Tasks.ParallelOptions)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<System.Action<int>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); System.Action<int> arg3 = (System.Action<int>)argobj3;

                        var result = System.Threading.Tasks.Parallel.For (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.BigInt, typeof(long), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.BigInt, typeof(long), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.ParallelOptions), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<long>), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        long arg0 = (long)StaticTranslate<long>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        long arg1 = (long)StaticTranslate<long>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Threading.Tasks.ParallelOptions>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Threading.Tasks.ParallelOptions arg2 = (System.Threading.Tasks.ParallelOptions)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<System.Action<long>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); System.Action<long> arg3 = (System.Action<long>)argobj3;

                        var result = System.Threading.Tasks.Parallel.For (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.ParallelOptions), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<int, System.Threading.Tasks.ParallelLoopState>), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Threading.Tasks.ParallelOptions>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Threading.Tasks.ParallelOptions arg2 = (System.Threading.Tasks.ParallelOptions)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<System.Action<int, System.Threading.Tasks.ParallelLoopState>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); System.Action<int, System.Threading.Tasks.ParallelLoopState> arg3 = (System.Action<int, System.Threading.Tasks.ParallelLoopState>)argobj3;

                        var result = System.Threading.Tasks.Parallel.For (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.BigInt, typeof(long), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.BigInt, typeof(long), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.ParallelOptions), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<long, System.Threading.Tasks.ParallelLoopState>), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        long arg0 = (long)StaticTranslate<long>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        long arg1 = (long)StaticTranslate<long>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Threading.Tasks.ParallelOptions>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Threading.Tasks.ParallelOptions arg2 = (System.Threading.Tasks.ParallelOptions)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<System.Action<long, System.Threading.Tasks.ParallelLoopState>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); System.Action<long, System.Threading.Tasks.ParallelLoopState> arg3 = (System.Action<long, System.Threading.Tasks.ParallelLoopState>)argobj3;

                        var result = System.Threading.Tasks.Parallel.For (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to For");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
    // ==================== properties end ====================
    // ==================== array item get/set start ====================
    
    
    // ==================== array item get/set end ====================
    // ==================== operator start ====================
    // ==================== operator end ====================
    // ==================== events start ====================
    // ==================== events end ====================

    
    }
#pragma warning disable 0219
}
#endif
