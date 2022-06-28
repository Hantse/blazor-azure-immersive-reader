namespace Blazure.ImmersiveReader.Models
{
    public class Options
    {
        public string? UiLang { get; set; }
        public int? Timeout { get; set; }
        public int? UiZIndex { get; set; }
        public bool? UseWebview { get; set; }
        public Action? OnExit { get; set; }
        public string? CustomDomain { get; set; }
        public bool? AllowFullscreen { get; set; }
        public Node? Parent { get; set; }
        public bool? HideExitButton { get; set; }
        public CookiePolicy? CookiePolicy { get; set; }
        public bool? DisableFirstRun { get; set; }
        public ReadAloudOptions? ReadAloudOptions { get; set; }
        public TranslationOptions? TranslationOptions { get; set; }
        public DisplayOptions? DisplayOptions { get; set; }
        public string? Preferences { get; set; }
        public Action<string>? OnPreferencesChanged { get; set; }
        public bool? DisableGrammar { get; set; }
        public bool? DisableTranslation { get; set; }
        public bool? DisableLanguageDetection { get; set; }

    }
}
