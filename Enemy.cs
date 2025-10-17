namespace EffectiveCommunication.Main
{
    public class Enemy
    {
        public void Attack(IAttackable target)
        {
            target.TakeHit();
        }
    }

    public interface IAttackable
    {
        void TakeHit();
    }
}