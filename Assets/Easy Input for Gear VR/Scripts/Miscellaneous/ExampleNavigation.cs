using UnityEngine;
using System.Collections;
using EasyInputVR.Core;
using UnityEngine.SceneManagement;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

namespace EasyInputVR.Misc
{

    [AddComponentMenu("EasyInputGearVR/Miscellaneous/ExampleNavigation")]
    public class ExampleNavigation : MonoBehaviour
    {

        public void button1Submit()
        {
            UnitySceneManager.LoadScene("tiltGearVRControllerExample");
        }

        public void button2Submit()
        {
            UnitySceneManager.LoadScene("controlsExample");
        }

        public void button3Submit()
        {
            UnitySceneManager.LoadScene("firstPersonGearVRController");
        }

        public void button4Submit()
        {
            UnitySceneManager.LoadScene("GuiNavigationExample");
        }

        public void button5Submit()
        {
            UnitySceneManager.LoadScene("GamepadControllerDiagnosticExample");
        }

        public void button6Submit()
        {
            UnitySceneManager.LoadScene("GVRcontrollerDiagnosticExample");
        }

        public void button7Submit()
        {
            UnitySceneManager.LoadScene("bowlingExample");
        }

        public void button8Submit()
        {
            UnitySceneManager.LoadScene("pointerExample");
        }

    }
}