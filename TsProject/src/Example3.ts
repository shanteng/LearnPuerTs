console.log("Example3");

let component = CS.UnityEngine.GameObject.FindObjectOfType(puerts.$typeof(CS.TsSamples.Example3)) as CS.TsSamples.Example3;
let cube = CS.UnityEngine.GameObject.Find("Cube");
component.add_onClick1(()=>
{
    console.log("ts click1 lambda call");
    let v1:CS.UnityEngine.Vector3 = new CS.UnityEngine.Vector3(1,1,1);
    let v2 = CS.UnityEngine.Vector3.op_Addition(v1,new CS.UnityEngine.Vector3(1,2,3));
    console.log(`Vector add res:x=${v2.x},y=${v2.y},z=${v2.z}`);
})

const funCall = function()
{
    console.log("ts click1 func call");
    const d = Math.random() * 3 + 1;
    cube.transform.localScale = CS.UnityEngine.Vector3.op_Multiply(CS.UnityEngine.Vector3.one,d);
}

component.add_onClick1(funCall);

component.add_onClick2((s)=>
{
    console.log("ts click2 call,s="+s);
    //component.remove_onClick1(funCall);
    const a:number  = parseFloat(s);
    const r1 = cube.transform.localEulerAngles;
    const r2 = CS.UnityEngine.Vector3.op_Subtraction(r1,new CS.UnityEngine.Vector3(0,a,0));
    cube.transform.localEulerAngles = r2;
});


component._btn.onClick.AddListener(()=>
{
    console.log("ts btn click");
    //component.add_onClick1
});
