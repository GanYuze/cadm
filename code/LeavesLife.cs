using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LeavesLife : MonoBehaviour
{
    public float lifeTime;
    float fade;

    bool isTimeToFade;
    // Start is called before the first frame update
    void Start()
    {
        lifeTime = 8;
        int x = Random.Range(4000, 6000);
        int y = Random.Range(-6000, -4000);
        int a = Random.Range(50, 200);
        fade = (float)a / 255f;
        transform.GetComponent<Image>().color = new Color(1, 1, 1, fade);
        transform.GetComponent<Image>().DOFade(1, 6).OnComplete(()=> 
        {
            transform.GetComponent<Image>().DOFade(0, 2);
        });
        transform.localScale = new Vector3(fade , fade , fade );
        transform.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(x, y));
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;

      
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
        
         
        transform.Rotate(Vector3.forward,Time.deltaTime*60);
    }
}
