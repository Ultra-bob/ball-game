using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateGems : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("Gems").ToString();
    }
}
