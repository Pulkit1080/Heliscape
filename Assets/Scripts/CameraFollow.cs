using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public GameObject player = GameObject.FindGameObjectWithTag("Player");
    // Update is called once per frame
    void Update()
    {
        Vector3 TargetPos = new Vector3(target.transform.position.x, 11, -22);
        transform.position = TargetPos;
    }
}
 