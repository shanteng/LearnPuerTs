"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
console.log("Example4");
let cube1 = CS.UnityEngine.GameObject.Find("Cube1");
let cube2 = CS.UnityEngine.GameObject.Find("Cube2");
let example4Mono = CS.UnityEngine.GameObject.FindObjectOfType(puerts.$typeof(CS.TsSamples.Example4));
let clickCall = function () {
    return __awaiter(this, void 0, void 0, function* () {
        yield puerts.$promise(CS.TsSamples.Example4.RotateForSeconds(cube1, 1));
        yield puerts.$promise(CS.TsSamples.Example4.RotateForSeconds(cube2, 2));
    });
};
//example4Mono._btn.onClick.AddListener(clickCall);
example4Mono._btn.onClick.AddListener(() => __awaiter(void 0, void 0, void 0, function* () {
    //await puerts.$promise(CS.TsSamples.Example4.RotateForSeconds(cube1,1));
    //await WaitTimeForSeconds(1);
    //await puerts.$promise(CS.TsSamples.Example4.RotateForSeconds(cube2,2));
    yield RotateForSeconds(cube1, 1);
    yield WaitTimeForSeconds(1);
    yield RotateForSeconds(cube2, 2);
}));
function WaitTimeForSeconds(sec) {
    return __awaiter(this, void 0, void 0, function* () {
        console.log("Ts WaitTimeForSeconds:" + sec);
        let promise = new Promise((resolve, reject) => {
            setTimeout(() => {
                resolve();
            }, sec * 1000);
        });
        return promise;
    });
}
function RotateForSeconds(go, d) {
    return __awaiter(this, void 0, void 0, function* () {
        let endTime = d + CS.UnityEngine.Time.time;
        while (CS.UnityEngine.Time.time < endTime) {
            go.transform.Rotate(CS.UnityEngine.Vector3.op_Multiply(CS.UnityEngine.Vector3.one, CS.UnityEngine.Time.deltaTime * 100));
            yield puerts.$promise(CS.System.Threading.Tasks.Task.Yield());
        }
    });
}
//# sourceMappingURL=Example4.js.map