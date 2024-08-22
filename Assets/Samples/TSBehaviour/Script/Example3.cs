using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Puerts;
using Puerts.TSLoader;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = System.Random;

namespace TsSamples
{
    public delegate void MyCallBack1();

    public delegate void MyCallBack2(string s);
    public class Example3 : MonoBehaviour
    {
        private JsEnv _mJsEnv;
        [FormerlySerializedAs("ModuleName")] public string moduleName; //可配置加载的js模块 

        public event MyCallBack1 onClick1;
        public event MyCallBack2 onClick2;
        public Button _btn;
        private void OnEnable()
        {
            if (_mJsEnv == null)
            {
                string path = "D:/PuerTs/TestPuerTs/TsProject/output/"; 
                _mJsEnv = new JsEnv(new DefaultLoader(path), 8080);
            }
            
            _mJsEnv.ExecuteModule(moduleName + ".mjs");
           
            
            this._btn.onClick.AddListener(() =>
            {
                if (onClick1 != null)
                    onClick1();
                
                if (onClick2 != null)
                {
                    var r = new Random();
                    onClick2(r.Next(100).ToString());
                }
            });
            
            
            Application.runInBackground = true;
        }
        
        void Update()
        {
            if (_mJsEnv != null)
                _mJsEnv.Tick();
        }

        protected virtual void OnOnClick1()
        {
            onClick1?.Invoke();
        }
    }
}