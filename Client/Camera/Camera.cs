using Onvif.Core.Client;
using Onvif.Core.Client.Common;
using Onvif.Core.Client.Imaging;
using Onvif.Core.Client.Media;
using Onvif.Core.Client.Ptz;

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

#pragma warning disable IDE0130 //TODO 命名空间与文件夹结构不匹配
namespace Onvif.Core.Client
#pragma warning restore IDE0130 // 命名空间与文件夹结构不匹配
{
    public class Camera(Account account)
    {
        private static IDictionary<Account, Camera> Cameras { get; set; } = new Dictionary<Account, Camera>();
        public static Camera Create(Account account, Action<Exception> exception)
        {
            Camera camera;
            bool usable;

            if (!Cameras.ContainsKey(account))
            {
                camera = new Camera(account);
                usable = camera.Testing(account, exception).Result;
                if (usable)
                {
                    Cameras.Add(account, camera);
                    Cameras[account].LastUse = System.DateTime.UtcNow;
                    //clear...
                }
                else
                    return null;
            }

            camera = Cameras[account]; ;
            usable = camera.Testing(account, exception).Result;
            if (usable)
                return camera;
            else
                return null;
        }

        public AutoFocusMode FocusMode { get; set; }

        public System.DateTime LastUse { get; set; }

        private Account Account { get; } = account;

#pragma warning disable IDE0060 // TODO 删除未使用的参数
        public async Task<bool> Testing(Account account, Action<Exception> exception)
#pragma warning restore IDE0060 // 删除未使用的参数
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
}
