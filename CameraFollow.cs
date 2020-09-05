
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed;
    private Vector3 currentVelocity;
    
    void FixedUpdate()
    {
        if(target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            //transform.position = Vector3.SmoothDamp(transform.position, newPos, ref currentVelocity, smoothSpeed * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed * Time.deltaTime);
        }
    }
}
