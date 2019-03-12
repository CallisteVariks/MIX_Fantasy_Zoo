using UnityEngine;

namespace Scripts
{
    internal class AnimController : MonoBehaviour
    {
        private Animator animator;

        public void Anim1(GameObject gameObject)
        {
            if (gameObject.CompareTag("redDragon"))
            {
                Animation animation = gameObject.GetComponent<Animation>();

                animation.Play("sj001_run");
            }
            else
            {
                animator = gameObject.GetComponent<Animator>();
                animator.Play("run");
            }
        }

        public void Anim2(GameObject gameObject)
        {
            if (gameObject.CompareTag("redDragon"))
            {
                Animation animation = gameObject.GetComponent<Animation>();

                animation.Play("sj001_skill2");
            }
            else
            {
                animator = gameObject.GetComponent<Animator>();
                animator.Play("attack 1");
            }
        }

        public void Anim3(GameObject gameObject)
        {
            if (gameObject.CompareTag("redDragon"))
            {
                Animation animation = gameObject.GetComponent<Animation>();

                animation.Play("sj001_skill1");
            }
            else
            {
                animator = gameObject.GetComponent<Animator>();
                animator.Play("attack 2");
            }
        }
    }
}