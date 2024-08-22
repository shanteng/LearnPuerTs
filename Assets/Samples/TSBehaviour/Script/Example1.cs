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
    public class Example1 : MonoBehaviour
    {
        private JsEnv _mJsEnv;
        [FormerlySerializedAs("ModuleName")] public string moduleName; //可配置加载的js模块 
        
        private void OnEnable()
        {
            if (_mJsEnv == null)
            {
                string path = "D:/PuerTs/TestPuerTs/TsProject/output/";
                _mJsEnv = new JsEnv(new DefaultLoader(path), 8080);
                //_mJsEnv = new JsEnv(new TSLoader());
            }
            
            _mJsEnv.ExecuteModule(moduleName + ".mjs");
           
            Application.runInBackground = true;
        }
        
        void Update()
        {
            if (_mJsEnv != null)
                _mJsEnv.Tick();
        }
    }
}