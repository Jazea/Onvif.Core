using Onvif.Core.Client.Camera.Requests;
using Onvif.Core.Client.Common;

using System;
using System.Threading.Tasks;

namespace Onvif.Core.Client.Camera;

public static class CameraExtensions
{
	public static async Task<bool> FocusAsync(this Camera camera, FocusMove focusMove)
	{
		if (camera != null)
		{
			var imaging = camera.Imaging;
			var focus = camera.VideoSource.Imaging.Focus != null;
			var vsource_token = camera.VideoSource.token;
			var focusMode = AutoFocusMode.MANUAL;

			if (focus)// && camera.FocusMode != focusMode
			{
				var image_settings = await imaging.GetImagingSettingsAsync(vsource_token).ConfigureAwait(false);
				if (image_settings.Focus == null)
				{
					image_settings.Focus = new FocusConfiguration20
					{
						AutoFocusMode = focusMode
					};

					await imaging.SetImagingSettingsAsync(vsource_token, image_settings, false).ConfigureAwait(false);
				}
				else if (image_settings.Focus.AutoFocusMode != focusMode)
				{
					image_settings.Focus.AutoFocusMode = focusMode;
					await imaging.SetImagingSettingsAsync(vsource_token, image_settings, false).ConfigureAwait(false);
				}
				camera.FocusMode = focusMode;
			}

			await imaging.MoveAsync(vsource_token, focusMove).ConfigureAwait(false);
			return true;
		}
		return false;
	}


	/// <remarks>
	/// timeout is in millisecond.
	/// <para>This method is retained for Compatibility.</para>
	/// </remarks>
	[Obsolete("Use MoveAsync(Camera, MoveType, PTZVector, PTZSpeed, TimeSpan) instead.")]
	public static async Task<bool> MoveAsync(this Camera camera, MoveType moveType, PTZVector vector, PTZSpeed speed, int timeout)
	{
		return await camera.MoveAsync(moveType, vector, speed, TimeSpan.FromMilliseconds(timeout)).ConfigureAwait(false);
	}
	public static async Task<bool> MoveAsync(this Camera camera, MoveType moveType, PTZVector vector, PTZSpeed speed, TimeSpan? timeout = null)
	{
		if (camera != null)
		{
			var ptz = camera.Ptz;
			var profile_token = camera.Profile.token;
			switch (moveType)
			{
				case MoveType.Absolute:
					await ptz.AbsoluteMoveAsync(profile_token, vector, speed).ConfigureAwait(false);
					return true;
				case MoveType.Relative:
					await ptz.RelativeMoveAsync(profile_token, vector, speed).ConfigureAwait(false);
					return true;
				case MoveType.Continuous:
					await ptz.ContinuousMoveAsync(profile_token, speed, timeout).ConfigureAwait(false);
					return true;
				default:
					break;
			}
		}
		return false;
	}
}
