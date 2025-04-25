using UnityEngine;

public class cup_script : MonoBehaviour
{
    public Rigidbody2D teaCup;
    public float flapStrength;
    public logic_script logic;
    public bool cupIsAlive = true;
    private int topDeadZone = 4;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }


    void Update()
    {
        deadZoneNotEntered();
        if (Input.GetKeyDown(KeyCode.Space) == true && cupIsAlive)
        {
            teaCup.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void deadZoneNotEntered()
    {
        int bottomDeadZone = -topDeadZone;
        if (teaCup.transform.position.y > topDeadZone || teaCup.transform.position.y < bottomDeadZone)
        {
            logic.gameOver();
            cupIsAlive = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        cupIsAlive = false;
    }
}
