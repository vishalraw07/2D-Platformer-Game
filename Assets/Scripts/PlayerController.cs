using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed;

     private void Awake() {
        Debug.Log("PlayerController controller awakes");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal"); //value of this [-1 to 1]
        MoveCharacter(horizontal);

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

    //jumping with up arrow key
    bool jump = Input.GetKeyDown(KeyCode.UpArrow);
    animator.SetBool("Jump", jump);
        if(jump == true)
        {
             scale.y = Mathf.Abs(scale.y);
        }
        transform.localScale = scale;



    //crouching with leftctrl key
    bool crouch = Input.GetKeyDown(KeyCode.LeftControl);
    animator.SetBool("Crouch", crouch);
    
        if(crouch == true)
        {
             scale.y = Mathf.Abs(scale.y);
        }
        transform.localScale = scale;
    }


    private void MoveCharacter(float horizontal)
    {
        Vector3 position = transform.position;
        position.x = position.x + horizontal * speed * Time.deltaTime;
        transform.position = position;
    }
   
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Collision: " + collision.gameObject.name);        
    }

}
