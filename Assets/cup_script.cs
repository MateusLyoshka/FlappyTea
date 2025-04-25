using UnityEngine;

public class cup_script : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public logic_script logic;
    public bool cupIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && cupIsAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        cupIsAlive = false;
    }
}
