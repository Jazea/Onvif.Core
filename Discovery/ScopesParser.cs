using System;

namespace Onvif.Core.Discovery
{
    internal static class ScopesParser
    {
        internal static bool Parse(string scopes, out string name, out string model)
        {
            name = string.Empty;
            model = string.Empty;
            unsafe
            {
                fixed (char* p = scopes)
                {
                    int i = 0;
                    int length = scopes.Length;
                    int state = 0;
                    char ch;
                    int stateBack = 0;
                    int startIndex = 0;
                    while (i < length)
                    {
                        ch = p[i++];
                        switch (state)
                        {
                            case 0:
                            case 13:
                            case 45:
                                if (ch == '/')
                                {
                                    stateBack = state;
                                    ++state;
                                }
                                break;
                            case 1:
                                if (ch == 'n')
                                {
                                    state = 2;
                                }
                                else if (ch == 'h')
                                {
                                    stateBack = 0;
                                    state = 30;
                                }
                                else
                                {
                                    state = 0;
                                }
                                break;
                            case 46:
                                state = ch == 'n' ? 47 : 45;
                                break;
                            case 2:
                            case 47:
                                if (ch == 'a')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state = stateBack;
                                }
                                break;
                            case 3:
                            case 48:
                                if (ch == 'm')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state = stateBack;
                                }
                                break;
                            case 4:
                            case 49:
                                if (ch == 'e')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state = stateBack;
                                }
                                break;
                            case 5:
                            case 22:
                            case 37:
                            case 50:
                                if (ch == '/')
                                {
                                    ++state;
                                    startIndex = i;
                                }
                                else
                                {
                                    state = stateBack;
                                }
                                break;
                            case 6:
                            case 23:
                            case 38:
                            case 51:
                                if (ch == ' ')
                                {
                                    ++state;
                                }
                                break;
                            case 7:
                            case 24:
                            case 39:
                            case 52:
                                if (ch == 'o')
                                {
                                    ++state;
                                }
                                else
                                {
                                    --state;
                                    if (ch == ' ')
                                    {
                                        ++state;
                                    }
                                }
                                break;
                            case 8:
                            case 25:
                            case 40:
                            case 53:
                                if (ch == 'n')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state -= 2;
                                    if (ch == ' ')
                                    {
                                        ++state;
                                    }
                                }
                                break;
                            case 9:
                            case 26:
                            case 41:
                            case 54:
                                if (ch == 'v')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state -= 3;
                                    if (ch == ' ')
                                    {
                                        ++state;
                                    }
                                }
                                break;
                            case 10:
                            case 27:
                            case 42:
                            case 55:
                                if (ch == 'i')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state -= 4;
                                    if (ch == ' ')
                                    {
                                        ++state;
                                    }
                                }
                                break;
                            case 11:
                            case 28:
                            case 43:
                            case 56:
                                if (ch == 'f')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state -= 5;
                                    if (ch == ' ')
                                    {
                                        ++state;
                                    }
                                }
                                break;
                            case 12:
                                if (ch == ':')
                                {
                                    name = Uri.UnescapeDataString(scopes.Substring(startIndex, i - 6 - startIndex));
                                    state = 13;
                                }
                                else
                                {
                                    state = 6;
                                    if (ch == ' ')
                                    {
                                        ++state;
                                    }
                                }
                                break;
                            case 57:
                                if (ch == ':')
                                {
                                    name = Uri.UnescapeDataString(scopes.Substring(startIndex, i - 6 - startIndex));
                                    return true;
                                }
                                else
                                {
                                    state = 51;
                                    if (ch == ' ')
                                    {
                                        ++state;
                                    }
                                }
                                break;
                            case 29:///////////////////////////////////////////////////////////////////////
                                if (ch == ':')
                                {
                                    model = Uri.UnescapeDataString(scopes.Substring(startIndex, i - 6 - startIndex));
                                    return true;
                                }
                                else
                                {
                                    state = 23;
                                    if (ch == ' ')
                                    {
                                        ++state;
                                    }
                                }
                                break;
                            case 44://///////////////////////////
                                if (ch == ':')
                                {
                                    model = Uri.UnescapeDataString(scopes.Substring(startIndex, i - 6 - startIndex));
                                    state = 45;
                                }
                                else
                                {
                                    state = 38;
                                    if (ch == ' ')
                                    {
                                        ++state;
                                    }
                                }
                                break;
                            case 14:
                                state = ch == 'h' ? 15 : 13;
                                break;
                            case 15:
                            case 30:
                                if (ch == 'a')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state = stateBack;
                                }
                                break;
                            case 16:
                            case 31:
                                if (ch == 'r')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state = stateBack;
                                }
                                break;
                            case 17:
                            case 32:
                                if (ch == 'd')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state = stateBack;
                                }
                                break;
                            case 18:
                            case 33:
                                if (ch == 'w')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state = stateBack;
                                }
                                break;
                            case 19:
                            case 34:
                                if (ch == 'a')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state = stateBack;
                                }
                                break;
                            case 20:
                            case 35:
                                if (ch == 'r')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state = stateBack;
                                }
                                break;
                            case 21:
                            case 36:
                                if (ch == 'e')
                                {
                                    ++state;
                                }
                                else
                                {
                                    state = stateBack;
                                }
                                break;
                            default:
                                break;
                        }
                    }

                    int count = length - startIndex;
                    string t = count <= 0 ? string.Empty : Uri.UnescapeDataString(scopes.Substring(startIndex, count));
                    switch (state)
                    {
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 51:
                        case 52:
                        case 53:
                        case 54:
                        case 55:
                        case 56:
                        case 57:
                            name = t;
                            return true;
                        case 23:
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                        case 38:
                        case 39:
                        case 40:
                        case 41:
                        case 42:
                        case 43:
                        case 44:
                            model = t;
                            return true;
                        default:
                            return false;
                    }


                }
            }

        }
    }
}