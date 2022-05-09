
using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using UnityEditor.Build;
using System.Collections;
using UnityEngine.TestTools;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Tests;
using Microsoft.MixedReality.Toolkit.Utilities;

namespace HoloTest
{
    public class MainMenuIntroTest
    {
        //manager scene name
        private const string ManagerScene = "Manager Scene";
        //menu scene name
        private const string sceneName = "Menu";
        //name of MRTK profile
        private const string testProfileName = "DefaultHoloLens2tConfigurationProfile";
        //hand object for testing
        private TestHand hand;
        private InputSimulationService simulationService;
        // This method is called once before we enter play mode and execute any of the tests
        // do any kind of setup here that can't be done in playmode
        [UnitySetUp]
        public IEnumerator Setup()
        {
            //load manager scene asynchronously
            AsyncOperation loadOp = SceneManager.LoadSceneAsync(ManagerScene, LoadSceneMode.Single);
            loadOp.allowSceneActivation = true;
            //wait for loading to complete
            while (!loadOp.isDone )
            {
                yield return null;
            }
            yield return true;
            //load menu scene asynchronously
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
            //initialise scene playspace
            TestUtilities.InitializePlayspace();
            //initialise simulation service
            simulationService = GetInputSimulationService();
            simulationService.UserInputEnabled = false;
            //initialise test hand object
            hand = new TestHand(Handedness.Right);
        }


        [UnityTearDown]
        public IEnumerator TearDown()
        {
            //method to unload all scenes
            Scene scene = SceneManager.GetSceneByName(testProfileName);
            if (scene.isLoaded)
            {
                SceneManager.UnloadSceneAsync(scene.buildIndex);
            }
            yield return null;
        }

        [UnityTest]
        //simple test just to check the right configuration file is present
        public IEnumerator CheckConfigurationProfile()
        {
            //expected config file
            var expected = "ManagerMixedRealityToolkitConfigurationProfile";
            //get mrtk object in scene
            var MRTK_gameObject = GameObject.Find("MixedRealityToolkit");
            //get active profile
            var activeProfile = MRTK_gameObject.GetComponent<MixedRealityToolkit>();
            Debug.Log("Active profile used in this scene - " + activeProfile.ActiveProfile.name);
            //check if the config files match
            Assert.AreEqual(activeProfile.ActiveProfile.name, expected);

            yield return null;
        }

        //test to check hand pressing the introButton
        [UnityTest]
        public IEnumerator PressButtonWithHand()
        {
            // Find game objects needed for test
            GameObject testButton = GameObject.Find("introButton");
            PressableButton buttonComponent = testButton.GetComponent<PressableButtonHoloLens2>();

            // Check that objects exist
            Assert.IsNotNull(buttonComponent);

            //make camera look forward
            TestUtilities.PlayspaceToOriginLookingForward();
          
            //boolean flag
            bool buttonPressed = false;
            //add listener to check when button is pressed
            buttonComponent.ButtonPressed.AddListener(() =>
            {
                buttonPressed = true;
            });

            // Move the hand forward to press button
            Vector3 p1 = new Vector3(-0.374f, -0.1f, 1f);
            Vector3 p2 = new Vector3(-0.374f, -0.1f, 1.08f);
            Vector3 p3 = new Vector3(-0.374f, -0.1f, 0.5f);

          //show spawns hand
            yield return hand.Show(p1);
            //moveTo moves hand to the specified point
            yield return hand.MoveTo(p2);
            yield return hand.MoveTo(p3);

            //check if button has been pressed
            Assert.IsTrue(buttonPressed, "Button was not pressed by the simulated hand.");
            yield return new WaitForSeconds(5);

            //the expected scene is the introduction scene
            var currScene = SceneManager.GetSceneByName("Introduction").name;
            //check to make sure we are in the introduction scene, hence the test is successful and teh button is working as expected
            Assert.AreEqual("Introduction", currScene);

            yield return null;
        }

        #region Utility functions borrowed from MRTK
        // Utility function to simplify code for getting access to the running InputSimulationService
        // Returns InputSimulationService registered for playmode test scene
        public static InputSimulationService GetInputSimulationService()
        {
            var inputSimulationService = CoreServices.GetInputSystemDataProvider<InputSimulationService>();
            Debug.Assert((inputSimulationService != null), "InputSimulationService is null!");
            return inputSimulationService;
        }

        #endregion
    }
}
