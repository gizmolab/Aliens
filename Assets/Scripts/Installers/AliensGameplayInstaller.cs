using GizmoLab.Gameplay;
using GizmoLab.Gameplay.Armor;
using GizmoLab.Gameplay.Weapons;
using Zenject;

namespace Installers
{
    public class AliensGameplayInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<IWeapon>()
                .To<Shotgun>()
                .AsSingle();

            Container
                .Bind<IArmor>()
                .To<LightArmor>()
                .AsSingle();

            Container
                .Bind<Player>()
                .To<Player>()
                .AsSingle();

            Container
                .Bind<Alien>()
                .To<Alien>()
                .AsSingle();

            Container
                .Bind<AliensGameCore>()
                .To<AliensGameCore>()
                .AsSingle();
        }
    }
}