using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inimigo;
    public int numini;
    public float randomico;
    void Start()
    {
        numini = Random.Range(1, 10);
        StartCoroutine(Randomizador());
        Debug.Log(numini);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public void Randomizer()
    //{
    //    if (randomico <10 )
    //    {
    //        Instantiate(inimigo,new Vector3(5,3,0), Quaternion.identity);
    //    }
    //    else
    //    {
    //        Instantiate(inimigo, new Vector3(-5, 3, 0), Quaternion.identity);
    //    }
    //    Debug.Log(randomico);
    //}
    public IEnumerator Randomizador()
    {
        if(numini < 10)
        {
            randomico = Random.Range(1, 20);
            Debug.Log(randomico);
            InimigosS();
            yield return new WaitForSeconds(5);
        }
        else
        {
            randomico = Random.Range(1, 20);
            Debug.Log(randomico);
            InimigosS();
            yield return new WaitForSeconds(5);
        }
        yield return new WaitForSeconds(2f);
    }
    public void InimigosS()
    {
        for(var i = 0; i<numini; i++)
        {
            Instantiate(inimigo);
        }
    }
}
