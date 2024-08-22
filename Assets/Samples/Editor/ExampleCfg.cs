using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Puerts;

[Configure]
public class ExampleCfg
{
   [Binding]
   static IEnumerable<Type> Bindings
   {
      get
      {
         return new List<Type>()
         {
            typeof(Debug),
            typeof(Vector3),
            typeof(List<int>),
            typeof(Dictionary<string, List<int>>),
            typeof(Time),
            typeof(Transform),
            typeof(Component),
            typeof(GameObject),
            typeof(UnityEngine.Object),
            typeof(Delegate),
            typeof(System.Object),
            typeof(System.Array),
            typeof(Type),
            typeof(ParticleSystem),
            typeof(Canvas),
            typeof(Behaviour),
            typeof(MonoBehaviour),
            
            typeof(UnityEngine.EventSystems.UIBehaviour),
            typeof(UnityEngine.UI.Selectable),
            typeof(UnityEngine.UI.Button),
            typeof(UnityEngine.UI.Button.ButtonClickedEvent),
            typeof(UnityEngine.Events.UnityEvent),
            typeof(UnityEngine.UI.InputField),
            typeof(UnityEngine.UI.Toggle),
            typeof(UnityEngine.UI.Toggle.ToggleEvent),
            typeof(UnityEngine.Events.UnityEvent<bool>),
            
            //self define
            typeof(TsSamples.Example1),
            typeof(TsSamples.Example2TestClass),
         };
      }
   }

   [Filter]
   static bool FilterMethods(System.Reflection.MemberInfo mb)
   {
      //排除 MonoBehaviour.runInEditMode, 在 Editor 环境下可用发布后不存在
      if (mb.DeclaringType == typeof(MonoBehaviour) && mb.Name.Equals("runInEditMode"))
         return true;
      return false;
   }
}
