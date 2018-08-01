using UnityEngine;
using Com.LuisPedroFonseca.ProCamera2D;


namespace Com.LuisPedroFonseca.ProCamera2D.Platformer
{
    public class ToggleTransitionsFX : MonoBehaviour
    {
        void OnGUI()
        {
            if (Time.deltaTime == 0.1f)
            {
                ProCamera2DTransitionsFX.Instance.TransitionEnter();
            }

            if (Time.deltaTime >= 24f)
            {
                ProCamera2DTransitionsFX.Instance.TransitionExit();
            }
        }
    }
}