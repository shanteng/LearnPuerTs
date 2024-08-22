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
    public class Example4 : MonoBehaviour
    {
        private JsEnv _mJsEnv;
        [FormerlySerializedAs("ModuleName")] public string moduleName; //可配置加载的js模块 
        
        public Button _btn;
        private void OnEnable()
        {
            if (_mJsEnv == null)
            {
                string path = "D:/PuerTs/TestPuerTs/TsProject/output/";
                _mJsEnv = new JsEnv(new DefaultLoader(path), 8080);
            }
            
            _mJsEnv.ExecuteModule(moduleName + ".mjs");
            Application.runInBackground = true;
        }

        public static async Task RotateForSeconds(GameObject go, float duration)
        {
            var endTime = Time.time + duration;
            while (Time.time < endTime)
            {
                go.transform.Rotate(Vector3.one * Time.deltaTime * 150);
                await Task.Yield();
            }
        }
        
        void Update()
        {
            if (_mJsEnv != null)
                _mJsEnv.Tick();
        }
        
    }
}