using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class AlphabetClickEvent : MonoBehaviour
{

    public List<GameObject> sourceObject = new List<GameObject>();

    private GameObject currentObject;
    public Text name;

    // Start is called before the first frame update
    void Start()
    {
        currentObject = sourceObject[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Rotate(float duration)
    {
        float startRotation = currentObject.transform.eulerAngles.y;
        float endRotation = startRotation + 360.0f;
        float t = 0.0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            float yRotation = Mathf.Lerp(startRotation, endRotation, t / duration) % 360.0f;
            currentObject.transform.eulerAngles = new Vector3(currentObject.transform.eulerAngles.x, yRotation, currentObject.transform.eulerAngles.z);
            yield return null;
        }
    }

    public void AlphabetPress()
    {
        string alphabet = EventSystem.current.currentSelectedGameObject.GetComponent<Button>().GetComponentInChildren<Text>().text;
        if(alphabet!="")
        {
            StartCoroutine(Rotate(5));
        }
        if(alphabet=="A")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[0];
            currentObject.SetActive(true);
            name.text = "APPLE";
        }
        else if(alphabet == "B")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[1];
            currentObject.SetActive(true);
            name.text = "BALL";
        }
        else if (alphabet == "C")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[2];
            currentObject.SetActive(true);
            name.text = "CAT";
        }
        else if (alphabet == "D")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[3];
            currentObject.SetActive(true);
            name.text = "DOLL";
        }
        else if (alphabet == "E")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[4];
            currentObject.SetActive(true);
            name.text = "EGG";
        }
        ////////////////
        else if (alphabet == "F")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[5];
            currentObject.SetActive(true);
            name.text = "FISH";
        }
        else if (alphabet == "G")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[6];
            currentObject.SetActive(true);
            name.text = "GOAT";
        }
        else if (alphabet == "H")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[7];
            currentObject.SetActive(true);
            name.text = "HEN";
        }
        else if (alphabet == "I")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[8];
            currentObject.SetActive(true);
            name.text = "ICE CREAME";
        }
        else if (alphabet == "J")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[9];
            currentObject.SetActive(true);
            name.text = "JET";
        }
        else if (alphabet == "K")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[10];
            currentObject.SetActive(true);
            name.text = "KEY";
        }
        else if (alphabet == "L")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[11];
            currentObject.SetActive(true);
            name.text = "LION";
        }
        else if (alphabet == "M")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[12];
            currentObject.SetActive(true);
            name.text = "MONKEY";
        }
        else if (alphabet == "N")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[13];
            currentObject.SetActive(true);
            name.text = "NECKLACE";
        }
        ///////////////
        else if (alphabet == "O")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[14];
            currentObject.SetActive(true);
            name.text = "ORANGE";
        }
        else if (alphabet == "P")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[15];
            currentObject.SetActive(true);
            name.text = "POT";
        }
        else if (alphabet == "Q")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[16];
            currentObject.SetActive(true);
            name.text = "QUEEN";
        }
        else if (alphabet == "R")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[17];
            currentObject.SetActive(true);
            name.text = "RAT";
        }
        else if (alphabet == "S")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[18];
            currentObject.SetActive(true);
            name.text = "STAR";
        }
        else if (alphabet == "T")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[19];
            currentObject.SetActive(true);
            name.text = "TREE";
        }
        else if (alphabet == "U")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[20];
            currentObject.SetActive(true);
            name.text = "UMBRELLA";
        }
        else if (alphabet == "V")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[21];
            currentObject.SetActive(true);
            name.text = "VIOLIN";
        }
        else if (alphabet == "W")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[22];
            currentObject.SetActive(true);
            name.text = "WAGON";
        }
        else if (alphabet == "X")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[23];
            currentObject.SetActive(true);
            name.text = "XMAS";
        }
        else if (alphabet == "Y")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[24];
            currentObject.SetActive(true);
            name.text = "YAK";
        }
        else if (alphabet == "Z")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[25];
            currentObject.SetActive(true);
            name.text = "ZEBRA";
        }

    }

    public void Next()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
