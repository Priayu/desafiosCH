using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Vector3 bulletDirection;
    public float speed;

    void Start()
    {
        Destroy(this.gameObject, 9.5f);                
    }

    
    void Update()
    {
        transform.Translate(bulletDirection * speed * Time.deltaTime);        
    }
}
