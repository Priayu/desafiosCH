using UnityEngine;

public class Bullets : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPlace;
    public float time = 2f;
    public float shootTime;

    void Start()
    {
        Instantiate(bullet,spawnPlace.position,transform.rotation);
        TimeReset();               
    }

   
    void Update()
    {
        Shooting();        
    }


    void TimeReset()
    {
        shootTime = time;
    }


    void Shooting()
    {
        shootTime -= Time.deltaTime;
        if(shootTime <= 0)
            {
            TimeReset();
            }
        
        if(shootTime == 2)
        {
            Instantiate(bullet,spawnPlace.position,transform.rotation);            
        }        
    }
}
