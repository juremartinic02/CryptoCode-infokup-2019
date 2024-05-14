using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginRegistration : MonoBehaviour
{

    public InputField LoginUsernameInputField;
    public InputField LoginPasswordInputField;

    public InputField RegistrationUsernameInputField;
    public InputField RegistrationPasswordInputField;
    public InputField RegistrationRepeatPasswordInputField;
    public InputField RegistrationEmailInputField;

    public void Register()
    {
        var username = RegistrationUsernameInputField.GetComponent<InputField>().text;
        var password = RegistrationPasswordInputField.GetComponent<InputField>().text;
        var repeatPassword = RegistrationRepeatPasswordInputField.GetComponent<InputField>().text;
        var email = RegistrationEmailInputField.GetComponent<InputField>().text;

        if (password != repeatPassword)
        {
            return;
        }

        Game.Username = username;
        Game.Password = password;
        Game.Email = email;

        Game.ResetToDefaults();

        Game.Save();

        SceneManager.LoadScene("Level1");
    }

    public void Login()
    {
        var username = LoginUsernameInputField.GetComponent<InputField>().text;
        var password = LoginPasswordInputField.GetComponent<InputField>().text;

        Game.Username = username;
        Game.Password = password;

        if (Game.Load())
        {
            SceneManager.LoadScene("Level1");
        }
    }

}
