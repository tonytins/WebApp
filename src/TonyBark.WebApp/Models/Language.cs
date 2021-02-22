using System.Collections.Generic;

namespace TonyBark.WebApp.Models
{
    public record Language(Dictionary<string, Translations> Translations);

    public record Translations(string Meaning);
}