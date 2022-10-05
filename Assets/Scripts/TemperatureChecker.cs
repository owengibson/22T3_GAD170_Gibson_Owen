using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OwenGibson
{
   public class TemperatureChecker : MonoBehaviour
    {
        [SerializeField] private float currentPorridgeTemperature = 85.0f;
        private float hotLimitTemperature = 70.0f;
        private float coldLimitTemperature = 40.0f;
        

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) {
                TemperatureTest();
            }
            currentPorridgeTemperature -= Time.deltaTime * 5f;
        }

        void TemperatureTest() {
            if (currentPorridgeTemperature > hotLimitTemperature) {
                Debug.Log("The porridge is too hot. " + (int)currentPorridgeTemperature);
            }
            else if (currentPorridgeTemperature < coldLimitTemperature && currentPorridgeTemperature > 0) {
                Debug.Log("The porridge is too cold. " + (int)currentPorridgeTemperature);
            }
            else if (currentPorridgeTemperature <= 0) {
                Debug.Log("bro ur porridge is literally frozen " + (int)currentPorridgeTemperature);
            }
            else {
                Debug.Log("The porridge is just right 🥣. " + (int)currentPorridgeTemperature);
            }
        }
    } 
}


