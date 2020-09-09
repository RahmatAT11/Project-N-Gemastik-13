using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalLevel : MonoBehaviour
{
    public bool HasMedal { get; set; }

    public GameObject medalSilhouette;
    public GameObject medalColored;

    private void Update()
    {
        if(HasMedal)
        {
            medalColored.SetActive(true);
            medalSilhouette.SetActive(false);
        }
        else
        {
            medalColored.SetActive(false);
            medalSilhouette.SetActive(true);
        }
    }
}
