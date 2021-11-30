using UnityEngine;

public class player2dcontroller : MonoBehaviour
{
    public float MovementSpeed = 3;
    public float JumpForce = 8;
   
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Jump();
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;
        Vector3 characterScale = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0){
            characterScale.x = -0.3f;
        }
        if(Input.GetAxis("Horizontal") > 0){
            characterScale.x = 0.3f;
        }

        transform.localScale = characterScale;

    }

    void Jump(){
        if (Input.GetKeyDown(KeyCode.Space))
        { 
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
    }}
}
