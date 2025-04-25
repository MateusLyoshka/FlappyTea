using UnityEngine;

public class spoon_score_sensor : MonoBehaviour
{
    public logic_script logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
