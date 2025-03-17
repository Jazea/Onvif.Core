using System;

namespace Onvif.Core.Discovery
{
    internal static class ScopesParser
    {
        const string PATTERN_NAME = "/name/";
        const string PATTERN_MODEL = "/hardware/";
        const string PATTERN_ONVIF = "onvif";

        internal static void Parse(string scopes, out string name, out string model)
        {
            name = string.Empty;
            model = string.Empty;

            var nameIndex = scopes.IndexOf(PATTERN_NAME);
            if (nameIndex > 0)
            {
                var onvifIndex = scopes.IndexOf(PATTERN_ONVIF, nameIndex);
                if (onvifIndex > 0)
                {
                    name = scopes.Substring(nameIndex + PATTERN_NAME.Length, onvifIndex - nameIndex - PATTERN_NAME.Length).TrimEnd();
                }
                else
                {
                    name = scopes.Substring(nameIndex + PATTERN_NAME.Length).TrimEnd();
                }

                name = Uri.UnescapeDataString(name);
            }

            var modelIndex = scopes.IndexOf(PATTERN_MODEL);
            if (modelIndex > 0)
            {
                var onvifIndex = scopes.IndexOf(PATTERN_ONVIF, modelIndex);
                if (onvifIndex > 0)
                {
                    model = scopes.Substring(modelIndex + PATTERN_MODEL.Length, onvifIndex - modelIndex - PATTERN_MODEL.Length).TrimEnd();
                }
                else
                {
                    model = scopes.Substring(modelIndex + PATTERN_MODEL.Length).TrimEnd();
                }

                model = Uri.UnescapeDataString(model);
            }
        }
    }
}