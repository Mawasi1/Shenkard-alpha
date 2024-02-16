using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Location : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI locationNameText;
    [SerializeField] Image locationImage;
    [SerializeField] TextMeshProUGUI locationDescriptionText;
    [SerializeField] TextMeshProUGUI locationScoreText; // Updated variable name for clarity
    [SerializeField] LocationSO location;
    private List<Card> cardsInLocation = new List<Card>(); // Store cards in this location
    private int maxCards = 4; // Maximum number of cards the location can hold

    void Start()
    {
        UpdateLocationDisplay();
        location.ResetScore();
    }

    public void AddCard(Card card)
    {
        if (cardsInLocation.Count < maxCards)
        {
            cardsInLocation.Add(card);
            UpdateScore();
            UpdateLocationDisplay();
        }
        else
        {
            Debug.Log("Can't Add more cards!");
        }
    }

    public void RemoveCard(Card card)
    {
        if (cardsInLocation.Remove(card))
        {
            UpdateScore();
            UpdateLocationDisplay();
        }
    }

    private void UpdateScore()
    {
        int totalScore = 0;
        foreach (Card card in cardsInLocation)
        {
            totalScore += card.GetEnergy(); // Assuming Card has a method GetPower()
        }
        location.SetLocationScore(totalScore); // Assuming LocationSO has a method to set score
    }

    private void UpdateLocationDisplay()
    {
        locationNameText.text = location.GetName();
        locationImage.sprite = location.GetLocationImage();
        locationDescriptionText.text = location.GetDescription();
        locationScoreText.text = location.GetLocationScore().ToString();
    }
}
