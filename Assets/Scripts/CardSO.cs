using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Card", fileName ="New Card")]
public class CardSO : ScriptableObject
{
    [SerializeField] string cardName = "Card name";
    [SerializeField] Sprite cardImage = null;
    [TextArea(2,4)]
    [SerializeField] string cardDescription = "Description";
    [SerializeField] string cardCost = "1";
    [SerializeField] string cardEnergy = "1";

    public string GetName() { return cardName; }
    public string GetDescription(){  return cardDescription; }
    public string GetCost() { return cardCost;}
    public string GetEnergy() { return cardEnergy;}

    public Sprite GetCardImage() { return cardImage;}


    
}
