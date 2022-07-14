using UnityEngine;

public class Mona : MonoBehaviour
{
    Vector3 originalScale;
    public GameObject goldWall;
    public float time = 0;
    public float changeWallTime;
    

    void Start()
    {
        originalScale = transform.localScale;
        TimeReset();                
    }


    void Update()
    {
        if(changeWallTime >= 2.01f)
        {
            TimeReset();
        }                
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.gameObject.name == "ShrinkerWall")
        {
            Debug.Log("ShrinkerWall (Shrinker component)");

            if(transform.localScale.x < 1)
            {
                transform.localScale = new Vector3(1f,1f,1f);                
            }else
            {
                transform.localScale = new Vector3(0.5f,0.5f,0.5f);                
            }
        }
        
    }

    void OnCollisionStay(Collision col)
    {
        if(col.transform.gameObject.name == "BumpWall")
        {
            WallPosition();
            Debug.Log("BumpWall (no Shrinker component)");
        }
    }

    void WallPosition()
    {
        float randomX = Random.Range(-36,36);
        float randomZ = Random.Range(-55,35);
        float random = Random.Range(0,360);
        
        changeWallTime += Time.deltaTime;
        
        if(changeWallTime >= 2)
        {
            goldWall.transform.position = new Vector3(randomX,0,randomZ);
            goldWall.transform.Rotate(0,random,0);
        }
    }

    void TimeReset()
    {
        changeWallTime = time;
    }
}
