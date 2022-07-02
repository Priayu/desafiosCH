using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Vector3 bulletDirection;
    public float speed;
    public float damage = 5.5f;
    public float destruction;

    void Start()
    {
        Destroy(this.gameObject, destruction);                
    }

    
    void Update()
    {
        transform.Translate(bulletDirection * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += new Vector3(0.2f,0.2f,0.2f);
        }        
    }
}
