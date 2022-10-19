using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OwenGibson
{
    public class ContactDirectory : MonoBehaviour
    {
        [SerializeField] private List<Contact> contacts = new List<Contact>();

    private void Start()
        {
            foreach (Contact contact in contacts)
            {
                contact.Initialise();
            }
        }
    }
}
