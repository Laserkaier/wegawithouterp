namespace Content.Server._Wega.Autopsy
{
    [RegisterComponent]
    public sealed partial class AutopsyComponent : Component
    {

        [DataField("weapon")]
        public HashSet<string> weapon = new();

        [DataField("damage")]
        public HashSet<string> damage = new();

        [DataField("typedamage")]
        public HashSet<string> typedamage = new();

        [DataField("time")]
        public HashSet<string> time = new();


    }
}