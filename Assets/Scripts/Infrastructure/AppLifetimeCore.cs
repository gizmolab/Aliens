using GizmoLab.Gameplay;
using UnityEngine;
using Zenject;

namespace GizmoLab.Infrastructure
{
    public class AppLifetimeCore : MonoBehaviour
    {
        #region Fields

        [Inject]
        private AliensGameCore _gameCore;
        
        #endregion
        
        #region Methods

        private void Update()
        {
            _gameCore.Update();
        }

        #endregion
    }
}

