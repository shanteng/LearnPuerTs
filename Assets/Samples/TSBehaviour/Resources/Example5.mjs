console.log("Example5");
class Example5 {
    constructor(bindTo) {
        this.bindTo = bindTo;
        this.bindTo.JsStart = this.onStart;
        this.bindTo.JsUpdate = this.onUpdate;
        this.bindTo.JsOnDestory = this.onDestory;
    }
    onStart() {
        console.log("ts onStart");
    }
    onUpdate() {
        console.log("ts onUpdate");
    }
    onDestory() {
        console.log("ts onDestory");
    }
}
export function init(bindTo) {
    new Example5(bindTo);
}
//# sourceMappingURL=Example5.js.map