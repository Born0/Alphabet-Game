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
        }
        else if(alphabet == "B")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[1];
            currentObject.SetActive(true);
        }
        else if (alphabet == "C")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[2];
            currentObject.SetActive(true);
        }
        else if (alphabet == "D")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[3];
            currentObject.SetActive(true);
        }
        else if (alphabet == "E")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[4];
            currentObject.SetActive(true);
        }
        ////////////////
        else if (alphabet == "F")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[5];
            currentObject.SetActive(true);
        }
        else if (alphabet == "G")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[6];
            currentObject.SetActive(true);
        }
        else if (alphabet == "H")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[7];
            currentObject.SetActive(true);
        }
        else if (alphabet == "I")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[8];
            currentObject.SetActive(true);
        }
        else if (alphabet == "J")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[9];
            currentObject.SetActive(true);
        }
        else if (alphabet == "K")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[10];
            currentObject.SetActive(true);
        }
        else if (alphabet == "L")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[11];
            currentObject.SetActive(true);
        }
        else if (alphabet == "M")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[12];
            currentObject.SetActive(true);
        }
        else if (alphabet == "N")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[13];
            currentObject.SetActive(true);
        }
        ///////////////
        else if (alphabet == "O")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[14];
            currentObject.SetActive(true);
        }
        else if (alphabet == "P")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[15];
            currentObject.SetActive(true);
        }
        else if (alphabet == "Q")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[16];
            currentObject.SetActive(true);
        }
        else if (alphabet == "R")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[17];
            currentObject.SetActive(true);
        }
        else if (alphabet == "S")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[18];
            currentObject.SetActive(true);
        }
        else if (alphabet == "T")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[19];
            currentObject.SetActive(true);
        }
        else if (alphabet == "U")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[20];
            currentObject.SetActive(true);
        }
        else if (alphabet == "V")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[21];
            currentObject.SetActive(true);
        }
        else if (alphabet == "W")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[22];
            currentObject.SetActive(true);
        }
        else if (alphabet == "X")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[23];
            currentObject.SetActive(true);
        }
        else if (alphabet == "Y")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[24];
            currentObject.SetActive(true);
        }
        else if (alphabet == "Z")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[25];
            currentObject.SetActive(true);
        }

    }

    public void Next()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
