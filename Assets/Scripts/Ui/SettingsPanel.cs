using UnityEngine;

namespace UI
{
    public class SettingsPanel : GamePanel
    {
        [SerializeField] private SettingButton _settingsButton;

        protected override void OnEnable()
        {
            base.OnEnable();
            _settingsButton.gameObject.SetActive(false);
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            _settingsButton.gameObject.SetActive(true);
        }
    }
}