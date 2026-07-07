
using UnityEngine;
using System.Collections.Generic;

public class HairManeger : MonoBehaviour
{
    [SerializeField] private List<GameObject> hairStyles = new List<GameObject>();
    private int currentHairIndex = 0;

    public void SetHairStyle(int index)
    {
        foreach (GameObject hair in hairStyles)
        {
            hair.SetActive(false);
        }

        for (int i = 0; i < hairStyles.Count; i++)
        {
            hairStyles[i].SetActive(i == index);
        }
    }
    public void NextHair()
    { 
     currentHairIndex++;
        if (currentHairIndex >= hairStyles.Count)
        {
            currentHairIndex = 0;
        }
        SetHairStyle(currentHairIndex);

    }
    public void PreviousHair()
    {
        currentHairIndex--;
        if (currentHairIndex < 0)
        {
            currentHairIndex = hairStyles.Count - 1;
        }
        SetHairStyle(currentHairIndex);
    

    }

}
