using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1.0f;

    Vector3 originalScale;
    Animator animator;
    void Awake()
    {
        originalScale = transform.localScale;
        
        animator = GetComponent<Animator>();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Hit()
    {
        animator.SetTrigger("Hit");
    }

    // Update is called once per frame
    void Update()
    { 
       float verticalValue = Input.GetAxisRaw("Vertical");
       float horizontalValue = Input.GetAxisRaw("Horizontal");

       bool rotatePressed = Input.GetButton("Rotate");
       if (rotatePressed)
            Debug.Log(rotatePressed);
       
       // check if move 
       if (horizontalValue != 0 || verticalValue != 0)
       {
           /*
           transform.position += new Vector3(
               speed * horizontalValue * Time.deltaTime, // x value
               speed * verticalValue * Time.deltaTime, // y value
               0); // z value*/
           transform.position += Vector3.right * (speed * horizontalValue * Time.deltaTime);
           transform.position += Vector3.up * (speed * verticalValue * Time.deltaTime);

           

           float sign = 1;
           if (horizontalValue < 0)
               sign = -1;
           
           transform.localScale = new Vector3(
               sign * originalScale.x,
               originalScale.y,
               originalScale.z);
       }
    } 
}
