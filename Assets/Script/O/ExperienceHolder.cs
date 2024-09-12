using UnityEngine;

namespace Script.O
{
  public class ExperienceHolder : MonoBehaviour
  {
    [Tooltip("Experience Of Player")] public float CurrentExperience;


    /// <summary>
    /// Mevcut olan tecrube puanimizla ilgili degisiklikleri yapar.
    /// </summary>
    /// <param name="amount"></param>
    public void GainExperience(float amount) => CurrentExperience += amount;
  }
}
