using UnityEngine;
using System.Collections;

public class forestFollow : MonoBehaviour {

	public float dampTime = 0.5f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
 
    // Update is called once per frame
    void Update () 
    {
       if (target)
       {
         
         transform.position = Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, target.position.y, transform.position.z), ref velocity, dampTime);
       }
 
    }
}
