using UnityEngine;
using Agava.YandexGames;

namespace YandexSDK
{
    public class GameReady : MonoBehaviour
    {
#if UNITY_WEBGL && !UNITY_EDITOR
    private void Start()
    {
        YandexGamesSdk.GameReady();
    }
#endif
    }
}