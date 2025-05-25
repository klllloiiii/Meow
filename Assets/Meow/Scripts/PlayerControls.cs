using System;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
            Debug.Log("¡¿Ã!");
    }
}
