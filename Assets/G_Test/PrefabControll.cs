using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabControll : MonoBehaviour
{
    [SerializeField] GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpriteCount");
    }

    IEnumerator SpriteCount()
    {
        int count = 0;
        int wide = 0;

        for (count = 0; count < 4; count++)
        {
            for (wide = 0; wide < 4; wide++)
            {


                yield return new WaitForSeconds(1.5f);
                Instantiate(Cube, new Vector2(wide, count), Quaternion.identity);
            }


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
