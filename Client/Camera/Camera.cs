using Onvif.Core.Client.Common;
using Onvif.Core.Client.Imaging;
using Onvif.Core.Client.Media;
using Onvif.Core.Client.Ptz;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Onvif.Core.Client.Camera;

public class Camera(Account account)
{
    private static IDictionary<Account, Camera> Cameras { get; set; } = new Dictionary<Account, Camera>();

    private static readonly object s_Locker = new();

    public static Camera Create(Account account, Action<Exception> exception)
    {
        return CreateAsync(account, exception).Result;
    }

    public static async Task<Camera> CreateAsync(Account account, Action<Exception> exception)
    {
        bool usable;
        if (!Cameras.TryGetValue(account, out Camera camera))
        {
            Monitor.Enter(s_Locker);
            try
            {
                if (!Cameras.TryGetValue(account, out camera))
                {
                    camera = new Camera(account);
                    Cameras.Add(account, camera);
                    camera.LastUse = System.DateTime.UtcNow;
                }
            }
            finally
            {
                Monitor.Exit(s_Locker);
            }
        }
        usable = await camera.Testing(exception).ConfigureAwait(false);
        // todo Do we need update LastUse?
        return usable ? camera : null;
    }

    public AutoFocusMode FocusMode { get; set; }

    public System.DateTime LastUse { get; set; }

    private Account Account { get; } = account;

    [Obsolete("Use Testing(Action<Exception>) instead.")]
    public async Task<bool> Testing(Account account, Action<Exception> exception)
    {
        try
        {
            //var device = await OnvifClientFactory.CreateDeviceClientAsync(account.Host, account.UserName, account.Password);
            var response = await Media.GetProfilesAsync().ConfigureAwait(false);
            return true;
        }
        catch (Exception ex)
        {
            exception?.Invoke(ex);
            return false;
        }
    }

    public async Task<bool> Testing(Action<Exception> exception = null)
    {
        try
        {
            var response = await Media.GetProfilesAsync().ConfigureAwait(false);
            return true;
        }
        catch (Exception ex)
        {
            exception?.Invoke(ex);
            return false;
        }
    }


    private PTZClient _ptz;
    public PTZClient Ptz
    {
        get
        {
            _ptz ??= OnvifClientFactory.CreatePTZClientAsync(Account.Host, Account.UserName, Account.Password).Result;
            return _ptz;
        }
    }


    private MediaClient _media;
    public MediaClient Media
    {
        get
        {
            _media ??= OnvifClientFactory.CreateMediaClientAsync(Account.Host, Account.UserName, Account.Password).Result;
            return _media;
        }
    }


    private ImagingClient _imaging;
    public ImagingClient Imaging
    {
        get
        {
            _imaging ??= OnvifClientFactory.CreateImagingClientAsync(Account.Host, Account.UserName, Account.Password).Result;
            return _imaging;
        }
    }

    private Profile _profile;
    public Profile Profile
    {
        get
        {
            if (_profile == null)
            {
                var response = Media.GetProfilesAsync().Result;
                _profile = response.Profiles[0];
            }
            return _profile;
        }
    }

    private VideoSource _videoSource;
    public VideoSource VideoSource
    {
        get
        {
            if (_videoSource == null)
            {
                var response = Media.GetVideoSourcesAsync().Result;
                _videoSource = response.VideoSources[0];
            }
            return _videoSource;
        }
    }
}
