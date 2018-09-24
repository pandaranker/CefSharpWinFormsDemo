# CefSharpWinFormsDemo
Just a clone of "Using HTML as UI Elements in a WinForms Application with Chrome / Chromium Embedded Framework (CEF)" by Ocean Airdrop

Original project:
https://www.codeproject.com/Articles/990346/Using-HTML-as-UI-Elements-in-a-WinForms-Applicatio
https://github.com/OceanAirdrop/WinFormsHTMLChromium/

Updated to .Net 4.6.1 and CefSharp.WinForms v67
I removed buttons JQWidgetsDemo and ExecCsharpFromJS that were not implemented.

Target: x86
See this for AnyCPU (not done) https://ourcodeworld.com/articles/read/173/how-to-use-cefsharp-chromium-embedded-framework-csharp-in-a-winforms-application

Added CefSharpSettings.LegacyJavascriptBindingEnabled = true; for legacy bindings. See https://github.com/cefsharp/CefSharp/issues/2246
