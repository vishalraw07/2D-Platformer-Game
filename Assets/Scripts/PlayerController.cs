using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed;
    public float jump;
    private Rigidbody2D rb2d;

     private void Awake() {
        Debug.Log("PlayerController controller awakes");
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal"); //value of this [-1 to 1]
        float vertical = Input.GetAxisRaw("Jump");
        MoveCharacter(horizontal, vertical);
        MoveAnimation(horizontal, vertical);

    


    //crouching with leftctrl key
   
    }

    private void MoveAnimation(float horizontal, float vertical)
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


        if(vertical > 0)
            animator.SetBool("Jump", true);
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

    private void MoveCharacter(float horizontal, float vertical)
    {
        Vector3 position = transform.position;
        position.x = position.x + horizontal * speed * Time.deltaTime;
        transform.position = position;

        if(vertical > 0)
        {
            rb2d.AddForce(new Vector2(0f,jump), ForceMode2D.Force);
        }
    }
   
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Collision: " + collision.gameObject.name);        
    }

}
