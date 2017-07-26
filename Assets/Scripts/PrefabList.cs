// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using System.Collections.Generic;


namespace IS
{
    // List of prefabs used by the game.
    // A game object uses this component, and can then be used
    // to access and instantiate the prefabs.  (Also, this serves to
    // force unity to include these prefabs - otherwise Unity automatically
    // strips unused resources from release builds:
    // https://docs.unity3d.com/Manual/iphone-playerSizeOptimization.html)
    public class PrefabList : MonoBehaviour
    {


       

        // List of all the prefabs that contain menu screens for UI.  Populated
        // via the Unity inspector.  Similar to the prefab list, these get
        // processed into a dictionary at runtime to make lookups easier.
        public MenuEntry[] menuScreens;

        // The default audio clip that is used when a GUIButton is clicked.
        public AudioClip DefaultClickAudio;

       
        [HideInInspector]
        public Dictionary<string, GameObject> menuLookup;

        // Array of prefabs names.  Useful because some things (GUI) need
        // them in a plain array of strings.
       
        private void Start()
        {
            

            menuLookup = new Dictionary<string, GameObject>();
            foreach (MenuEntry entry in menuScreens)
            {
                menuLookup[entry.name] = entry.prefab;
            }
        }

        

        [System.Serializable]
        public struct MenuEntry
        {
            public MenuEntry(string name, GameObject prefab)
            {
                this.name = name;
                this.prefab = prefab;
            }

            public string name;
            public GameObject prefab;
        }
    }
}
