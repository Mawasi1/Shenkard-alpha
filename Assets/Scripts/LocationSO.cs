using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Location", fileName ="New Location")]

public class LocationSO : ScriptableObject
{
    [SerializeField] string locationName = "Location name";
    [SerializeField] Sprite locationImage = null;
    [TextArea(2, 4)]
    [SerializeField] string locationDescription = "Description";
    [SerializeField] string locationScore = "0";


    public string GetName() {  return locationName; }
    public string GetDescription() { return locationDescription;}
    public Sprite GetLocationImage() {  return locationImage;}

    public string GetLocationScore() {  return locationScore;}

    public void SetLocationScore(int score)
    {
        locationScore = score.ToString(); // Convert int to string for storage
    }

    public void ResetScore()
    {
        locationScore = "0";
    }


}
