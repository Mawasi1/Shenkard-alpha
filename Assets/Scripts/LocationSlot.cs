using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LocationSlot : MonoBehaviour, IDropHandler
{
    public Location location; // Reference to the Location component
    public GameObject locationCardsContainer;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Card card = eventData.pointerDrag.GetComponent<Card>();
            if (card != null)
            {
                // Set the card's parent to the locationCardsContainer
                eventData.pointerDrag.transform.SetParent(locationCardsContainer.transform, false);
                eventData.pointerDrag.transform.localPosition = Vector3.zero; // Optional: Reset local position
                eventData.pointerDrag.transform.localScale = Vector3.one; // Optional: Reset scale

                // Add the card to the location's list and update score, etc.
                if (location != null)
                {
                    location.AddCard(card);
                }
                else
                {
                    Debug.LogError("Location reference not set on LocationSlot.");
                }
            }
            else
            {
                Debug.LogError("Dropped object does not have a Card component.");
            }
        }
    }


}
