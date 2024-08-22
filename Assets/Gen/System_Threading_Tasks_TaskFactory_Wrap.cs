#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class System_Threading_Tasks_TaskFactory_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                if (paramLen == 0)
                {

                    {
                        var result = new System.Threading.Tasks.TaskFactory();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(System.Threading.Tasks.TaskFactory), result);
                    }
                }
                if (paramLen == 1)
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Threading.CancellationToken), false, false, v8Value0, ref argobj0, ref argType0))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.CancellationToken>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.CancellationToken arg0 = (System.Threading.CancellationToken)argobj0;
                        var result = new System.Threading.Tasks.TaskFactory(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(System.Threading.Tasks.TaskFactory), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.TaskScheduler), false, false, v8Value0, ref argobj0, ref argType0))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.Tasks.TaskScheduler>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.Tasks.TaskScheduler arg0 = (System.Threading.Tasks.TaskScheduler)argobj0;
                        var result = new System.Threading.Tasks.TaskFactory(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(System.Threading.Tasks.TaskFactory), result);
                    }
                }
                if (paramLen == 2)
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskCreationOptions), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskContinuationOptions), false, false, v8Value1, ref argobj1, ref argType1))

                    {
                        System.Threading.Tasks.TaskCreationOptions arg0 = (System.Threading.Tasks.TaskCreationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        System.Threading.Tasks.TaskContinuationOptions arg1 = (System.Threading.Tasks.TaskContinuationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        var result = new System.Threading.Tasks.TaskFactory(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(System.Threading.Tasks.TaskFactory), result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Threading.CancellationToken), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskCreationOptions), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskContinuationOptions), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.TaskScheduler), false, false, v8Value3, ref argobj3, ref argType3))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.CancellationToken>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.CancellationToken arg0 = (System.Threading.CancellationToken)argobj0;
                        System.Threading.Tasks.TaskCreationOptions arg1 = (System.Threading.Tasks.TaskCreationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);
                        System.Threading.Tasks.TaskContinuationOptions arg2 = (System.Threading.Tasks.TaskContinuationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<System.Threading.Tasks.TaskScheduler>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); System.Threading.Tasks.TaskScheduler arg3 = (System.Threading.Tasks.TaskScheduler)argobj3;
                        var result = new System.Threading.Tasks.TaskFactory(arg0, arg1, arg2, arg3);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(System.Threading.Tasks.TaskFactory), result);
                    }
                }

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(System.Threading.Tasks.TaskFactory).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_StartNew(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as System.Threading.Tasks.TaskFactory;
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Action arg0 = (System.Action)argobj0;

                        var result = obj.StartNew (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 2)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Threading.CancellationToken), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Action arg0 = (System.Action)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Threading.CancellationToken>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Threading.CancellationToken arg1 = (System.Threading.CancellationToken)argobj1;

                        var result = obj.StartNew (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskCreationOptions), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Action arg0 = (System.Action)argobj0;
                        System.Threading.Tasks.TaskCreationOptions arg1 = (System.Threading.Tasks.TaskCreationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        var result = obj.StartNew (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Object>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Any, typeof(System.Object), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Action<System.Object>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Action<System.Object> arg0 = (System.Action<System.Object>)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Object arg1 = (System.Object)argobj1;

                        var result = obj.StartNew (arg0, arg1);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Threading.CancellationToken), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskCreationOptions), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.TaskScheduler), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Action>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Action arg0 = (System.Action)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Threading.CancellationToken>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Threading.CancellationToken arg1 = (System.Threading.CancellationToken)argobj1;
                        System.Threading.Tasks.TaskCreationOptions arg2 = (System.Threading.Tasks.TaskCreationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<System.Threading.Tasks.TaskScheduler>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); System.Threading.Tasks.TaskScheduler arg3 = (System.Threading.Tasks.TaskScheduler)argobj3;

                        var result = obj.StartNew (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Object>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Any, typeof(System.Object), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Threading.CancellationToken), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Action<System.Object>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Action<System.Object> arg0 = (System.Action<System.Object>)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Object arg1 = (System.Object)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Threading.CancellationToken>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Threading.CancellationToken arg2 = (System.Threading.CancellationToken)argobj2;

                        var result = obj.StartNew (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Object>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Any, typeof(System.Object), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskCreationOptions), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Action<System.Object>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Action<System.Object> arg0 = (System.Action<System.Object>)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Object arg1 = (System.Object)argobj1;
                        System.Threading.Tasks.TaskCreationOptions arg2 = (System.Threading.Tasks.TaskCreationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);

                        var result = obj.StartNew (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Object>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Any, typeof(System.Object), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Threading.CancellationToken), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskCreationOptions), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.TaskScheduler), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Action<System.Object>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Action<System.Object> arg0 = (System.Action<System.Object>)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Object arg1 = (System.Object)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Threading.CancellationToken>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Threading.CancellationToken arg2 = (System.Threading.CancellationToken)argobj2;
                        System.Threading.Tasks.TaskCreationOptions arg3 = (System.Threading.Tasks.TaskCreationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<System.Threading.Tasks.TaskScheduler>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); System.Threading.Tasks.TaskScheduler arg4 = (System.Threading.Tasks.TaskScheduler)argobj4;

                        var result = obj.StartNew (arg0, arg1, arg2, arg3, arg4);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to StartNew");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_FromAsync(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as System.Threading.Tasks.TaskFactory;
        
                if (paramLen == 2)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.IAsyncResult), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.IAsyncResult>), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IAsyncResult>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IAsyncResult arg0 = (System.IAsyncResult)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.IAsyncResult>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.IAsyncResult> arg1 = (System.Action<System.IAsyncResult>)argobj1;

                        var result = obj.FromAsync (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.IAsyncResult), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.IAsyncResult>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskCreationOptions), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IAsyncResult>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IAsyncResult arg0 = (System.IAsyncResult)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.IAsyncResult>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.IAsyncResult> arg1 = (System.Action<System.IAsyncResult>)argobj1;
                        System.Threading.Tasks.TaskCreationOptions arg2 = (System.Threading.Tasks.TaskCreationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);

                        var result = obj.FromAsync (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.IAsyncResult>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Any, typeof(System.Object), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Func<System.AsyncCallback, System.Object, System.IAsyncResult> arg0 = (System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.IAsyncResult>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.IAsyncResult> arg1 = (System.Action<System.IAsyncResult>)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Object arg2 = (System.Object)argobj2;

                        var result = obj.FromAsync (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.IAsyncResult), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.IAsyncResult>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskCreationOptions), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.TaskScheduler), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IAsyncResult>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IAsyncResult arg0 = (System.IAsyncResult)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.IAsyncResult>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.IAsyncResult> arg1 = (System.Action<System.IAsyncResult>)argobj1;
                        System.Threading.Tasks.TaskCreationOptions arg2 = (System.Threading.Tasks.TaskCreationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<System.Threading.Tasks.TaskScheduler>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); System.Threading.Tasks.TaskScheduler arg3 = (System.Threading.Tasks.TaskScheduler)argobj3;

                        var result = obj.FromAsync (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.IAsyncResult>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Any, typeof(System.Object), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskCreationOptions), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Func<System.AsyncCallback, System.Object, System.IAsyncResult> arg0 = (System.Func<System.AsyncCallback, System.Object, System.IAsyncResult>)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.IAsyncResult>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.IAsyncResult> arg1 = (System.Action<System.IAsyncResult>)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Object arg2 = (System.Object)argobj2;
                        System.Threading.Tasks.TaskCreationOptions arg3 = (System.Threading.Tasks.TaskCreationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);

                        var result = obj.FromAsync (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to FromAsync");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_ContinueWhenAll(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as System.Threading.Tasks.TaskFactory;
        
                if (paramLen == 2)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.Task[]), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Threading.Tasks.Task[]>), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.Tasks.Task[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.Tasks.Task[] arg0 = (System.Threading.Tasks.Task[])argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.Threading.Tasks.Task[]>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.Threading.Tasks.Task[]> arg1 = (System.Action<System.Threading.Tasks.Task[]>)argobj1;

                        var result = obj.ContinueWhenAll (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.Task[]), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Threading.Tasks.Task[]>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Threading.CancellationToken), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.Tasks.Task[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.Tasks.Task[] arg0 = (System.Threading.Tasks.Task[])argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.Threading.Tasks.Task[]>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.Threading.Tasks.Task[]> arg1 = (System.Action<System.Threading.Tasks.Task[]>)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Threading.CancellationToken>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Threading.CancellationToken arg2 = (System.Threading.CancellationToken)argobj2;

                        var result = obj.ContinueWhenAll (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.Task[]), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Threading.Tasks.Task[]>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskContinuationOptions), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.Tasks.Task[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.Tasks.Task[] arg0 = (System.Threading.Tasks.Task[])argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.Threading.Tasks.Task[]>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.Threading.Tasks.Task[]> arg1 = (System.Action<System.Threading.Tasks.Task[]>)argobj1;
                        System.Threading.Tasks.TaskContinuationOptions arg2 = (System.Threading.Tasks.TaskContinuationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);

                        var result = obj.ContinueWhenAll (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.Task[]), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Threading.Tasks.Task[]>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Threading.CancellationToken), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskContinuationOptions), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.TaskScheduler), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.Tasks.Task[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.Tasks.Task[] arg0 = (System.Threading.Tasks.Task[])argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.Threading.Tasks.Task[]>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.Threading.Tasks.Task[]> arg1 = (System.Action<System.Threading.Tasks.Task[]>)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Threading.CancellationToken>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Threading.CancellationToken arg2 = (System.Threading.CancellationToken)argobj2;
                        System.Threading.Tasks.TaskContinuationOptions arg3 = (System.Threading.Tasks.TaskContinuationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<System.Threading.Tasks.TaskScheduler>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); System.Threading.Tasks.TaskScheduler arg4 = (System.Threading.Tasks.TaskScheduler)argobj4;

                        var result = obj.ContinueWhenAll (arg0, arg1, arg2, arg3, arg4);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to ContinueWhenAll");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_ContinueWhenAny(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as System.Threading.Tasks.TaskFactory;
        
                if (paramLen == 2)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.Task[]), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Threading.Tasks.Task>), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.Tasks.Task[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.Tasks.Task[] arg0 = (System.Threading.Tasks.Task[])argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.Threading.Tasks.Task>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.Threading.Tasks.Task> arg1 = (System.Action<System.Threading.Tasks.Task>)argobj1;

                        var result = obj.ContinueWhenAny (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.Task[]), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Threading.Tasks.Task>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Threading.CancellationToken), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.Tasks.Task[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.Tasks.Task[] arg0 = (System.Threading.Tasks.Task[])argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.Threading.Tasks.Task>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.Threading.Tasks.Task> arg1 = (System.Action<System.Threading.Tasks.Task>)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Threading.CancellationToken>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Threading.CancellationToken arg2 = (System.Threading.CancellationToken)argobj2;

                        var result = obj.ContinueWhenAny (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.Task[]), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Threading.Tasks.Task>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskContinuationOptions), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.Tasks.Task[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.Tasks.Task[] arg0 = (System.Threading.Tasks.Task[])argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.Threading.Tasks.Task>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.Threading.Tasks.Task> arg1 = (System.Action<System.Threading.Tasks.Task>)argobj1;
                        System.Threading.Tasks.TaskContinuationOptions arg2 = (System.Threading.Tasks.TaskContinuationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);

                        var result = obj.ContinueWhenAny (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 5)
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
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.Task[]), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(System.Action<System.Threading.Tasks.Task>), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Threading.CancellationToken), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Threading.Tasks.TaskContinuationOptions), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Threading.Tasks.TaskScheduler), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Threading.Tasks.Task[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Threading.Tasks.Task[] arg0 = (System.Threading.Tasks.Task[])argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Action<System.Threading.Tasks.Task>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Action<System.Threading.Tasks.Task> arg1 = (System.Action<System.Threading.Tasks.Task>)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Threading.CancellationToken>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Threading.CancellationToken arg2 = (System.Threading.CancellationToken)argobj2;
                        System.Threading.Tasks.TaskContinuationOptions arg3 = (System.Threading.Tasks.TaskContinuationOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<System.Threading.Tasks.TaskScheduler>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); System.Threading.Tasks.TaskScheduler arg4 = (System.Threading.Tasks.TaskScheduler)argobj4;

                        var result = obj.ContinueWhenAny (arg0, arg1, arg2, arg3, arg4);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to ContinueWhenAny");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_CancellationToken(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as System.Threading.Tasks.TaskFactory;
                var result = obj.CancellationToken;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_Scheduler(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as System.Threading.Tasks.TaskFactory;
                var result = obj.Scheduler;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_CreationOptions(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as System.Threading.Tasks.TaskFactory;
                var result = obj.CreationOptions;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_ContinuationOptions(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as System.Threading.Tasks.TaskFactory;
                var result = obj.ContinuationOptions;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
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
