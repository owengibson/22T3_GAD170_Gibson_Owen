using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OwenGibson
{
    public class LevelLoader : MonoBehaviour
    {
        private void Update() {
            if (Input.GetKeyDown(KeyCode.X)) {
                LoadLevel("WeekTwoActivities");
            }
            else if (Input.GetKeyDown(KeyCode.C)) {
                LoadLevel("SampleScene");
            }
            else if (Input.GetKeyDown(KeyCode.V)) {
                LoadLevel("WeekThreeActivities");
            }
        }

        /// <summary>
        /// This will load a different scene.
        /// </summary>
        private void LoadLevel(string sceneToLoad)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
