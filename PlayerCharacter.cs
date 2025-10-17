using UnityEngine;

namespace EffectiveCommunication.Main
{
    public class PlayerCharacter : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private AudioClip shout;
        private float health = 100f;

        public void TakeHit()
        {
            animator.SetTrigger("KnockBack");
            audioSource.PlayOneShot(shout);
            health -= 10;
        }
    }
}