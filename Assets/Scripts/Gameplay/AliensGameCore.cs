using GizmoLab.Gameplay.Armor;
using GizmoLab.Gameplay.Weapons;
using UnityEngine;
using Zenject;

namespace GizmoLab.Gameplay
{
    public class AliensGameCore
    {
        [Inject]
        private Player _player;

        [Inject]
        private Alien _alien;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _player.ShootAt(_alien);
            }
        }
    }
}