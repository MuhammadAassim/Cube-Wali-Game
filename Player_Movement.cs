
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward_force = 2000f
    

;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            rb.AddForce(0,0,forward_force * Time.deltaTime);
            

            if(Input.GetKey("d") )
            {
                rb.AddForce(10* Time.deltaTime ,0 ,0, ForceMode.VelocityChange );
            }
              if(Input.GetKey("a") )
            {
                rb.AddForce(-10 * Time.deltaTime ,0 ,0, ForceMode.VelocityChange);
            }
              if(Input.GetKey("w") )
            {
                rb.AddForce(0 ,0 ,20 * Time.deltaTime ,ForceMode.VelocityChange);
            }
               if(Input.GetKey("s") )
            {
                rb.AddForce(0 ,0 , -20 * Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey("q"))
            {
                rb.AddForce(0, 50 * Time.deltaTime, 0 ,ForceMode.VelocityChange );
            }
            if (rb.position.y < -1f)
                {
                    FindObjectOfType<Game_Manager>().EndGame();
                }  

            
    }
}
