using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInputController : MonoBehaviour
{
    public float walkSpeed=0.1f;
    public float jumpHeight=0.4f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right")){
            gameObject.transform.position=new Vector3(gameObject.transform.position.x+walkSpeed,gameObject.transform.position.y,gameObject.transform.position.z);
        }
        if (Input.GetKey("up")){
            //inactive until timer is done possibly double jump option
            gameObject.transform.position=new Vector4(gameObject.transform.position.x,gameObject.transform.position.y+jumpHeight,gameObject.transform.position.z);
        }
    }


}
