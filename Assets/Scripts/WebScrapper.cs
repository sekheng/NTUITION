using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Networking;

public class WebScrapper : MonoBehaviour
{
    const string QUERY_INDEED_URL = "https://sg.indeed.com/jobs?";
    public TMP_InputField WhatInput;
    public TMP_InputField WhereInput;

    public Button m_SubmitButton;

    Coroutine m_SubmitCoroutine = null;

    public void submit()
    {
        if (m_SubmitCoroutine == null)
        {
            // then check the input's values
            if (string.IsNullOrEmpty(WhatInput.text) && string.IsNullOrEmpty(WhereInput.text))
            {
                // animate the button to be red!

            }
            else
            {
                string webReq = $"{QUERY_INDEED_URL}q={WhatInput.text}&l={WhereInput.text}";
                UnityWebRequest request = new(webReq);
                var requestOpt = request.SendWebRequest();
                m_SubmitCoroutine = StartCoroutine(RequestCoroutine(requestOpt));
            }
        }
    }

    IEnumerator RequestCoroutine(UnityWebRequestAsyncOperation _op)
    {
        yield return _op;
        if (string.IsNullOrEmpty(_op.webRequest.error))
        {
            // can assume it to be successful
        }
        else
        {
            // assume it failed.
        }
        m_SubmitCoroutine = null;
    }
}
