using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusketScript : MonoBehaviour
{
    private readonly string[] words = {"apple","ball","cat", "doll", "egg", "fish" , "goat", "hen", "icecream" , "jet", "key", "lion" , "monkey", "necklace", "orange" , "pot", "queen", "rat", "star", "tree", "umbrella", "violin", "wagon", "xmas"
                                   ,"yak","zebra"};

    private bool check;
    private string word = "";

    public List<GameObject> sourceObject = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        check = false;
        sourceObject[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckWord()
    {
        for(int i=0;i<26;i++)
        {
           if(words[i].Equals(word))
            {
                Debug.Log("Yes");
            }
        }

        /*for(int i=0;i<wordObject.Capacity-1;i++)
        {
            wordObject[i].transform.position = placeHolder[i].transform.position;
        }*/

        Debug.Log(check);
        check = false;
        //word = "";
    }

   


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        word+=collision.gameObject.tag;
    }
}
