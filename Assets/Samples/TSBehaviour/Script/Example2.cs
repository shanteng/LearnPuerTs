using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Puerts;
using Puerts.TSLoader;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace TsSamples
{
    public delegate string DelegateFunc5(int val);

    public delegate GameObject DelegateFunc6(string name);
    public class Example2 : MonoBehaviour
    {
        private JsEnv _mJsEnv;
        [FormerlySerializedAs("ModuleName")] public string moduleName; //可配置加载的js模块 
        
        private void OnEnable()
        {
            if (_mJsEnv == null)
            {
                string path = "D:/PuerTs/TestPuerTs/TsProject/output/";
                _mJsEnv = new JsEnv(new DefaultLoader(path), 8080);
            }
            
            //_mJsEnv.UsingFunc<GameObject,string>();
            
            JSObject jsObj  = _mJsEnv.ExecuteModule(moduleName + ".mjs");
            Action func1 = jsObj.Get<Action>("func1");
            func1();
            
            Action<string> func2 = jsObj.Get<Action<string>>("func2");
            func2("C# Call func2");

            Action<GameObject> func3 = jsObj.Get<Action<GameObject>>("func3");
           // Func<GameObject,string> func3 = jsObj.Get<Func<GameObject, string>>("func3");
            GameObject cube = GameObject.Find("Cube");
            func3(cube);
            
            Action<MonoBehaviour> func4 = jsObj.Get<Action<MonoBehaviour>>("func4");
            // Func<GameObject,string> func3 = jsObj.Get<Func<GameObject, string>>("func3");
            func4(this);

            _mJsEnv.UsingFunc<int,string>();
            DelegateFunc5 func5 = jsObj.Get<DelegateFunc5>("func5");
            var str = func5(123);
            Debug.Log("return str="+str);
            
            _mJsEnv.UsingFunc<string,GameObject>();
            DelegateFunc6 func6 = jsObj.Get<DelegateFunc6>("func6");
            var obj = func6("Cube");
            Debug.Log("find obj="+obj);
            
            Application.runInBackground = true;
        }

        public Action action1 = null;
        void Update()
        {
            action1?.Invoke();
            if (_mJsEnv != null)
                _mJsEnv.Tick();
        }
    }

    public class Example2TestClass
    {
        public string str = "Example2TestClass";

        public void LogStr(string str)
        {
            Debug.Log(str);
        }

        public static int TestAdd(int a, int b)
        {
            return a + b;
        }
    }
}