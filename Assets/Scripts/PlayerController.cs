using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private BoxCollider2D boxCollider;
    public Animator animator;
    public float speed;
    public float jumpforce;
     
    public bool isGrounded;
    

     private void Awake() {
        Debug.Log("PlayerController controller awakes");
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal"); //value of this [-1 to 1]
        float vertical = Input.GetAxisRaw("Vertical");
        MoveCharacter(horizontal, vertical);
        HorizontalAnimation(horizontal);
        VerticalAnimation(vertical);
   
    }

   private void MoveCharacter(float horizontal, float vertical)
    {
        Vector3 position = transform.position;
        position.x = position.x + horizontal * speed * Time.deltaTime;
        transform.position = position;
    }
    private void HorizontalAnimation(float horizontal)
    {
         animator.SetFloat("Speed", Mathf.Abs(horizontal));

        Vector3 scale = transform.localScale;
        if(horizontal<0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
        }
        else if(horizontal >0)
        {
             scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;
    }

    private void VerticalAnimation(float vertical)
    {
         Vector3 scale = transform.localScale;


        if(vertical > 0 && isGrounded )
        {
            animator.SetBool("Jump", true);
            rb2d.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }
        else
            animator.SetBool("Jump",false);


        bool crouch = Input.GetKeyDown(KeyCode.LeftControl);
        animator.SetBool("Crouch", crouch);
    
        if(crouch == true)
        {
             scale.y = Mathf.Abs(scale.y);
        }
        transform.localScale = scale;

    }

 
   
   private void OnCollisionStay2D(Collision2D other) 
   {    
        if(other.transform.tag== "platform")
            isGrounded= true; 
   }
    private void OnCollisionExit2D(Collision2D other) 
   {    
        if(other.transform.tag== "platform")
            isGrounded= false; 
   }
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Collision: " + collision.gameObject.name);        
    }

}
