using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    public GameObject titlepauseUI;
    public GameObject optionsUI;
    public TMP_Dropdown resolutionDropdown;
    public TMP_Dropdown qualityDropdown;
    public TMP_Dropdown textureDropdown;
    public TMP_Dropdown aaDropdown;
    float currentVolume;
    Resolution[] resolutions;

    void Start()
    {
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        resolutions = Screen.resolutions;
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " +
                resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width
                && resolutions[i].height == Screen.currentResolution.height)
                currentResolutionIndex = i;
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.RefreshShownValue();
        LoadSettings(currentResolutionIndex);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width,
            resolution.height, Screen.fullScreen);
    }

    public void SetTextureQuality(int textureIndex)
    {
        QualitySettings.masterTextureLimit = textureIndex;
    }

    public void SetAntiAliasing(int aaIndex)
    {
        QualitySettings.antiAliasing = aaIndex;
    }

    public void SetQuality(int qualityIndex)
    {
        if (qualityIndex != 7)
            QualitySettings.SetQualityLevel(qualityIndex);
        switch (qualityIndex)
        {
            case 0: // Quality Level: Very Low
                textureDropdown.value = 3;
                aaDropdown.value = 0;
                break;
            case 1: // Quality Level: Low
                textureDropdown.value = 2;
                aaDropdown.value = 0;
                break;
            case 2: // Quality Level: Medium
                textureDropdown.value = 1;
                aaDropdown.value = 0;
                break;
            case 3: // Quality Level: High
                textureDropdown.value = 0;
                aaDropdown.value = 0;
                break;
            case 4: // Quality Level: Very High
                textureDropdown.value = 0;
                aaDropdown.value = 1;
                break;
            case 5: // Quality Level: Ultra
                textureDropdown.value = 0;
                aaDropdown.value = 2;
                break;
            case 6: // Quality Level: Insane
                textureDropdown.value = 0;
                aaDropdown.value = 3;
                break;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("QualitySettingPreference",
            qualityDropdown.value);
        PlayerPrefs.SetInt("ResolutionPreference",
            resolutionDropdown.value);
        PlayerPrefs.SetInt("TextureQualityPreference",
            textureDropdown.value);
        PlayerPrefs.SetInt("AntiAliasingPreference",
            aaDropdown.value);
        PlayerPrefs.SetInt("FullscreenPreference",
            Convert.ToInt32(Screen.fullScreen));
        PlayerPrefs.SetFloat("VolumePreference",
            currentVolume);
    }

    public void LoadSettings(int currentResolutionIndex)
    {
        if (PlayerPrefs.HasKey("QualitySettingPreference"))
            qualityDropdown.value =
                PlayerPrefs.GetInt("QualitySettingPreference");
        else
            qualityDropdown.value = 5;
        if (PlayerPrefs.HasKey("ResolutionPreference"))
            resolutionDropdown.value =
                PlayerPrefs.GetInt("ResolutionPreference");
        else
            resolutionDropdown.value = currentResolutionIndex;
        if (PlayerPrefs.HasKey("TextureQualityPreference"))
            textureDropdown.value =
                PlayerPrefs.GetInt("TextureQualityPreference");
        else
            textureDropdown.value = 0;
        if (PlayerPrefs.HasKey("AntiAliasingPreference"))
            aaDropdown.value =
                PlayerPrefs.GetInt("AntiAliasingPreference");
        else
            aaDropdown.value = 2;
        if (PlayerPrefs.HasKey("FullscreenPreference"))
            Screen.fullScreen =
                Convert.ToBoolean(PlayerPrefs.GetInt("FullscreenPreference"));
        else
            Screen.fullScreen = true;
    }

    public void IntoOptionsMenu()
    {
        optionsUI.SetActive(true);
        titlepauseUI.SetActive(false);
    }

    public void OutOfOptionsMenu()
    {
        optionsUI.SetActive(false);
        titlepauseUI.SetActive(true);
    }
}
