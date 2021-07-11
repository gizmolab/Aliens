using UnityEngine;

namespace GizmoLab.Gameplay
{
    public class AliensGameCore
    {
        private Player _player;

        private Alien _alien;

        public AliensGameCore()
        {
            _player = new Player();
            _alien = new Alien();
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _player.ShootAt(_alien);
            }
        }
    }
}