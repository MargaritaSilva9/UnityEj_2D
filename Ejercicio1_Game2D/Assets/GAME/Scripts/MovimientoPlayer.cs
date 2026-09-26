using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public float velocidad = 3f; //Le dice que tan rapido moverse

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
        }
    }
}
