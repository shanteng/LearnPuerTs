console.log("Example5");
class Example5
{
    public bindTo:CS.TsSamples.Example5;
    constructor(bindTo:CS.TsSamples.Example5)
    {
        this.bindTo = bindTo;
        this.bindTo.JsStart = this.onStart;
        this.bindTo.JsUpdate = this.onUpdate;
        this.bindTo.JsOnDestory = this.onDestory;
    }

    onStart()
    {
        console.log("ts onStart");
    }

    onUpdate()
    {
        console.log("ts onUpdate");
    }

    onDestory()
    {
        console.log("ts onDestory");
    }
}

export function init(bindTo:CS.TsSamples.Example5)
{
    new Example5(bindTo);
}