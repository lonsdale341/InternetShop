using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IS
{
    public class MainLevel : MonoBehaviour
    {
        [HideInInspector]
        public States.StateManager stateManager = new States.StateManager();
        
    }
}