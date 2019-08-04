using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float ForwardSpeed;
    public float jumpPower;
    public float fallPower;
    
    void FixedUpdate()
    {
        Movement();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            Debug.Log("Dead");
            Destroy(gameObject);
        }
    }

    void Movement()
    {
        transform.Translate(new Vector2(ForwardSpeed * Time.deltaTime, 0));

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0))
        {
            transform.Translate(Vector2.up * jumpPower * Time.deltaTime);
        }
        else if (!Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector2.down * fallPower * Time.deltaTime);
        }

    }
}
