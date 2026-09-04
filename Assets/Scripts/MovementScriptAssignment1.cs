using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Movement Script Started");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, moveSpeed * Time.deltaTime, 0f);
    }
}
