using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OwenGibson
{
    enum CardSuit { Spades, Hearts, Clubs, Diamonds }
    public class Card : MonoBehaviour
    {
        [SerializeField] private CardSuit chosenSuit;
        private string[] values = new string[13] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        public string value;
        public string suit;

        public void SetCardStats(string newValue, string newSuit)
        {
            value = newValue;
            suit = newSuit;
        }

        private void Initialise()
        {
            chosenSuit = (CardSuit)Random.Range(0, 4);
            string randomValue = values[Random.Range(0, values.Length)];

            switch (chosenSuit)
            {
                case CardSuit.Spades:
                    SetCardStats(randomValue, "Spades");
                    break;
                case CardSuit.Hearts:
                    SetCardStats(randomValue, "Hearts");
                    break;
                case CardSuit.Clubs:
                    SetCardStats(randomValue, "Clubs");
                    break;
                case CardSuit.Diamonds:
                    SetCardStats(randomValue, "Diamonds");
                    break;
                default:
                    Debug.Log("No suit selected");
                    break;
            }
        }
    }
}
