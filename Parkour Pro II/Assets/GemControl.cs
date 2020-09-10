using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemControl : MonoBehaviour
{
    public int id;
    private bool on = true;

    // Start is called before the first frame update
    void Start()
    {
        id = GetID();
    }

    // Update is called once per frame
    void OnTriggerEnter2D()
    {
        if (on)
        {
            PlayerPrefs.SetInt("Gems", PlayerPrefs.GetInt("Gems") + 1);
            gameObject.SetActive(false);
            Invoke("gameObject.SetActive(false)",300);

        }

    }

    int GetID()
    {
        return Random.Range(1, 9999);
    }
}
