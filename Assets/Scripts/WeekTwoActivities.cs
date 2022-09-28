using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OwenGibson
{
    public class WeekTwoActivities : MonoBehaviour
    {
        private string myFavouriteGame = "Minecraft"; // This is my favourite game (it's not actually)
        private float hoursPlayed = 2000f; // I have no idea if this is right
        private float costToPurchase = 15f; // I think it was $15 when I bought it

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("My favourite game is " + myFavouriteGame + ", I have played it for " + hoursPlayed + " hours, and it cost me $" + costToPurchase + ". Therefore, my value of dollars per hour is: $" + (costToPurchase / hoursPlayed) + "/hr.");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
