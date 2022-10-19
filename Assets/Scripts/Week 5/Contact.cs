using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OwenGibson
{
    public enum ContactName {Undefined, MichaelCera, Ratatouille, OscarTheGrouch, HarryStyles}

    public class Contact : MonoBehaviour
    {
        [SerializeField] private ContactName chosenContact = ContactName.Undefined;

        [Header("Contact Details")]
        [SerializeField] private string fullName;
        [SerializeField] private string preferredName;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;

        public void Initialise()
        {
            /*
            if (chosenContact == ContactName.MichaelCera)
            {
                Setup("Michael Cera", "Micky C", "0428789987", "132 Avenue Road", "mickyc@hotmail.com");
            }
            else if (chosenContact == ContactName.Ratatouille)
            {
                Setup("Ratatouille", "Ratboy", "1300728", "La Ratatouille, Paris, France", "ratatouille@ratemail.com");
            }
            else if (chosenContact == ContactName.OscarTheGrouch)
            {
                Setup("Oscar the Grouch", "Grouchy", "000", "3/25 Garbage Way", "oscar@grouchindustries.com");
            }
            */

            switch (chosenContact)
            {
                case ContactName.Undefined:
                    Debug.Log("Contact undefined. Set enum in inspector.");
                    break;
                case ContactName.MichaelCera:
                    Setup("Michael Cera", "Micky C", "0428789987", "132 Avenue Road", "mickyc@hotmail.com");
                    break;
                case ContactName.Ratatouille:
                    Setup("Ratatouille", "Ratboy", "1300728", "La Ratatouille, Paris, France", "ratatouille@ratemail.com");
                    break;
                case ContactName.OscarTheGrouch:
                    Setup("Oscar the Grouch", "Grouchy", "000", "3/25 Garbage Way", "oscar@grouchindustries.com");
                    break;
                case ContactName.HarryStyles:
                    Setup("Harry Styles", "Hazza", "911", "23 street street", "hazza@gmail.com");
                    break;
                default:
                    Debug.Log("Invalid choice.");
                    break;
            }
        }

        public void Setup(string newFullName,
                           string newPreferredName,
                           string newPhoneNumber,
                           string newAddress, 
                           string newEmail)
        {
            fullName = newFullName;
            preferredName = newPreferredName;
            phoneNumber = newPhoneNumber;
            address = newAddress;
            email = newEmail;
        }

    }
}
