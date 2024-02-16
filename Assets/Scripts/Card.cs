using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI cardNameText;
    [SerializeField] Image cardImage;
    [SerializeField] TextMeshProUGUI cardDescriptionText;
    [SerializeField] TextMeshProUGUI cardCost;
    [SerializeField] TextMeshProUGUI cardEnergy;
    [SerializeField] CardSO card;
    void Start()
    {
        cardNameText.text = card.GetName();
        cardDescriptionText.text = card.GetDescription();
        cardCost.text = card.GetCost();
        cardEnergy.text = card.GetEnergy();
        cardImage.sprite = card.GetCardImage();
    }

    public int GetEnergy()
    {
        return int.Parse(cardEnergy.text); // Convert string to int
    }


}
