using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeavesSpwan : MonoBehaviour
{
    public List<GameObject> leavesList = new List<GameObject>();

    public List<Vector2> startPosList = new List<Vector2>();
    // Start is called before the first frame update
    void Start()
    {
        int posx = -1600;
        for (int i = 0; i < 16; i++)
        {
            posx = -1600 + i * 200;
            startPosList.Add(new Vector2(posx, 700));
        }
        StartCoroutine(SpawnLeaves());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnLeaves()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            for (int i = 0; i < leavesList.Count; i++)
            {
                int index = Random.Range(0, startPosList.Count);
                GameObject leaf = Instantiate(leavesList[i],transform);
                leaf.GetComponent<RectTransform>().anchoredPosition = startPosList[index];
                leaf.GetComponent<Image>().SetNativeSize();
            }
        }
    }


}
