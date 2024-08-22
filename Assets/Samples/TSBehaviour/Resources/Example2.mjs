console.log("Example2");
export function func1() {
    console.log("ts:call func1");
}
export function func2(s) {
    console.log("ts:call func2,s=" + s);
}
let go;
export function func3(obj) {
    console.log('ts:call func3,go=' + obj.name);
    go = obj;
    setInterval(() => {
        go.transform.Rotate(300 * CS.UnityEngine.Time.deltaTime, 0, 0);
    });
}
export function func4(component) {
    console.log('ts:call func4,c=' + component);
    let a = 1;
    component.action1 = () => {
        go.transform.localScale = new CS.UnityEngine.Vector3(a, a, a);
        a += CS.UnityEngine.Time.deltaTime;
        a = a >= 3 ? 1 : a;
    };
}
export function func5(val) {
    console.log("ts:call func5=" + val);
    return "from func5 return data";
}
export function func6(objName) {
    let findGo = CS.UnityEngine.GameObject.Find(objName);
    console.log("ts:call func6");
    return findGo;
}
function testCallCSharp() {
    let test = new CS.TsSamples.Example2TestClass();
    console.log("test class str = " + test.str);
    test.LogStr("testCallCSharp");
    let res = CS.TsSamples.Example2TestClass.TestAdd(1, 2);
    console.log("res=" + res);
}
testCallCSharp();
//# sourceMappingURL=Example2.js.map