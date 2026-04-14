using UnityEngine;

public class pipeScript : MonoBehaviour
{
    public float moveSpeed = 5f;    
    public float destroyX = -15f;

    void Update()
    {
        transform.position += new Vector3(-1f,0f,0f) * moveSpeed * Time.deltaTime;

        if(transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
