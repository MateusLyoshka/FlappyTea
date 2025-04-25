using UnityEngine;

public class spoon_score_sensor : MonoBehaviour
{
    public logic_script logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
