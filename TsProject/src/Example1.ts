console.log("Example1");
const UE = CS.UnityEngine;
const player:CS.UnityEngine.GameObject = CS.UnityEngine.GameObject.Find("Capsule");
CS.UnityEngine.Camera.main.transform.SetParent(player.transform);
CS.UnityEngine.Camera.main.transform.localPosition = new CS.UnityEngine.Vector3(0,2,-3.5);
CS.UnityEngine.Camera.main.transform.localEulerAngles = new CS.UnityEngine.Vector3(15,0,0);

let intervalFun = function()
{
    const moveX:number = CS.UnityEngine.Input.GetAxis("Horizontal") * CS.UnityEngine.Time.deltaTime * 1000;
    const moveZ:number = CS.UnityEngine.Input.GetAxis("Vertical") * CS.UnityEngine.Time.deltaTime * 100;
    player.transform.Rotate(0,moveX,0);
    player.transform.Translate(0,0,moveZ);

    if(CS.UnityEngine.Input.GetKeyDown(UE.KeyCode.Space))
    {
        const rb:CS.UnityEngine.Rigidbody = player.GetComponent(puerts.$typeof(UE.Rigidbody)) as CS.UnityEngine.Rigidbody;
        rb.AddForce(new UE.Vector3(0,5,0),UE.ForceMode.Impulse);
    }
};

setInterval(intervalFun);