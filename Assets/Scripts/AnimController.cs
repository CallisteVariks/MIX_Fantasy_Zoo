using UnityEngine;

namespace Scripts
{
    internal class AnimController : MonoBehaviour
    {
        private Animator animator;
        public GameObject gameObj;
        public void Anim1()
        {
            if (gameObj.CompareTag("redDragon"))
            {
                Animation animation = gameObj.GetComponent<Animation>();

                animation.Play("sj001_run");
            }
            else
            {
                animator = gameObj.GetComponent<Animator>();
                animator.Play("run");
            }
        }

        public void Anim2()
        {
            if (gameObj.CompareTag("redDragon"))
            {
                Animation animation = gameObj.GetComponent<Animation>();

                animation.Play("sj001_skill2");
            }
            else
            {
                animator = gameObj.GetComponent<Animator>();
                animator.Play("attack 1");
            }
        }

        public void Anim3()
        {
            if (gameObj.CompareTag("redDragon"))
            {
                Animation animation = gameObj.GetComponent<Animation>();

                animation.Play("sj001_skill1");
            }
            else
            {
                animator = gameObj.GetComponent<Animator>();
                animator.Play("attack 2");
            }
        }
    }
}