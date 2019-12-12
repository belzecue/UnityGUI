﻿using UnityEngine;

namespace Gameframe.GUI.PanelSystem 
{
    public class PanelViewControllerRegisterer : MonoBehaviour
    {
        [SerializeField] 
        private PanelViewControllerProvider provider = null;

        private void Start()
        {
            var controller = GetComponent<IPanelViewController>();
            if (controller != null)
            {
                provider.Add(controller);
            }
        }
    }
}
