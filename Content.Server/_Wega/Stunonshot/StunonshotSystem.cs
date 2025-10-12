using Content.Shared._Wega.Snunonshot;
using Content.Shared.Weapons.Ranged.Events;
using Content.Shared.Inventory;
using Content.Shared.Weapons.Ranged.Components;
using Content.Shared.Stunnable;

namespace Content.Server._Wega.StunonshotSystem;

public sealed class StunonshotSystem : EntitySystem
{
    [Dependency] private readonly SharedStunSystem _stun = default!;
    
    public override void Initialize()
    {
        SubscribeLocalEvent<StunonshotComponent, SelfBeforeGunShotEvent>(OnShot);
    }

    private void OnShot(EntityUid shooter, Entity<GunComponent> gun, List<(EntityUid? Entity, IShootable Shootable)> ammo)
    {
        if (HasComp<GunComponent>(gun));
        {
            _stun.TryKnockwon(args.shooter, StunonshotComponent.Stun);
        }
    }
}
