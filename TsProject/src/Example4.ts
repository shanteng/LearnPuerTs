console.log("Example4");

let cube1 = CS.UnityEngine.GameObject.Find("Cube1");
let cube2 = CS.UnityEngine.GameObject.Find("Cube2");
let example4Mono = CS.UnityEngine.GameObject.FindObjectOfType(puerts.$typeof(CS.TsSamples.Example4)) as CS.TsSamples.Example4;

let clickCall = async function()
{
    await puerts.$promise(CS.TsSamples.Example4.RotateForSeconds(cube1,1));
    await puerts.$promise(CS.TsSamples.Example4.RotateForSeconds(cube2,2));
} 

//example4Mono._btn.onClick.AddListener(clickCall);
example4Mono._btn.onClick.AddListener(async ()=>
{
    //await puerts.$promise(CS.TsSamples.Example4.RotateForSeconds(cube1,1));
    //await WaitTimeForSeconds(1);
    //await puerts.$promise(CS.TsSamples.Example4.RotateForSeconds(cube2,2));
    await RotateForSeconds(cube1,1);
    await WaitTimeForSeconds(1);
    await RotateForSeconds(cube2,2);
});

async function WaitTimeForSeconds(sec:number)
{
    console.log("Ts WaitTimeForSeconds:"+sec);
    let promise = new Promise<void>((resolve,reject)=>
    {
        setTimeout(()=>
        {
            resolve();
        },sec * 1000);
    });
    return promise;
}

async function RotateForSeconds(go:CS.UnityEngine.GameObject,d:number):Promise<void>
{
    let endTime = d + CS.UnityEngine.Time.time;
    while(CS.UnityEngine.Time.time < endTime)
    {
        go.transform.Rotate(CS.UnityEngine.Vector3.op_Multiply(CS.UnityEngine.Vector3.one,CS.UnityEngine.Time.deltaTime * 100));
        await puerts.$promise(<any>CS.System.Threading.Tasks.Task.Yield());
    }
}