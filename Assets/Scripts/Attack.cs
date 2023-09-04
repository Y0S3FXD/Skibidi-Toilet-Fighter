public class Attack
{
    public float criticalDamage;
    public void voiddamageDealt(Toilet opponent)
    {
        Toilet.Health -= rnd.Next((criticalDamage * 0.66), criticalDamage);
    }
}