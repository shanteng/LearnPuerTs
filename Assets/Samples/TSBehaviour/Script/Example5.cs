using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Puerts;
using Puerts.TSLoader;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = System.Random;

namespace TsSamples
{
    public delegate void TsInit(Example5 monoBehaviour);
    public class Example5 : MonoBehaviour
    {
        private JsEnv _mJsEnv;
        [FormerlySerializedAs("ModuleName")] public string moduleName; //可配置加载的js模块 

        public Action JsStart;
        public Action JsUpdate;
        public Action JsOnDestory;
        
        private void OnEnable()
        {
            if (_mJsEnv == null)
            {
                string path = "D:/PuerTs/TestPuerTs/TsProject/output/";
                _mJsEnv = new JsEnv(new DefaultLoader(path), 8080);
            }
            
            JSObject jsObj  = _mJsEnv.ExecuteModule(moduleName + ".mjs");
            TsInit initFunc = jsObj.Get<TsInit>("init");
            initFunc(this);
            
            //Action<MonoBehaviour> init = _mJsEnv.ExecuteModule<Action<MonoBehaviour>>(moduleName + ".mjs","init");
            //if (init != null)
              //  init(this);
            Application.runInBackground = true;
        }
        
        private void Start()
        {
            if (JsStart != null)
                JsStart();
        }   

        void Update()
        {
            if (_mJsEnv != null)
                _mJsEnv.Tick();
            
            if (JsUpdate != null)
                JsUpdate();
        }

        private void OnDestroy()
        {
            if (JsOnDestory != null)
                JsOnDestory();
            JsStart = null;
            JsUpdate = null;
            JsOnDestory = null;
        }
    }
}