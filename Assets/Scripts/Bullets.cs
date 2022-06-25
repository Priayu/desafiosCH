using UnityEngine;

public class Bullets : MonoBehaviour
{
    public GameObject bullet;
    public Vector3 direction;
    public float speed;
    public Transform spawnPlace;

    void Start()
    {
        Instantiate(bullet,spawnPlace.position,transform.rotation);               
    }

   
    void Update()
    {
        Shooting();        
    }


    void Shooting()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(bullet,spawnPlace.position,transform.rotation);
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(bullet,spawnPlace.position,transform.rotation);
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(bullet,spawnPlace.position,transform.rotation);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet,spawnPlace.position,transform.rotation);
        }
        
    }
}
