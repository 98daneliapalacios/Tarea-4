using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.Forms.VideoPlayer;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        String PhotoPath;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnTakeVideo_Clicked(object sender, EventArgs e)
        {
            await TakePhotoAsync();
        }
        async Task TakePhotoAsync()
        {
            try
            {
                var photo = await MediaPicker.CaptureVideoAsync();
                await LoadPhotoAsync(photo);
                Console.WriteLine($"CapturePhotoAsync COMPLETED: {PhotoPath}");
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature is not supported on the device
            }
            catch (PermissionException pEx)
            {
                // Permissions not granted
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
            }
        }

        async Task LoadPhotoAsync(FileResult photo)
        {
            // canceled
            if (photo == null)
            {
                PhotoPath = null;
                return;
            }
            // save the file into local storage
            var newFile = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
            using (var stream = await photo.OpenReadAsync())
            using (var newStream = File.OpenWrite(newFile))
                await stream.CopyToAsync(newStream);

            PhotoPath = newFile;

            UriVideoSource uriVideoSurce = new UriVideoSource()
            {
                Uri = PhotoPath
            };
            videoPlayer.Source = uriVideoSurce;

        }

        private void VideoPlayer_PlayCompletion(object sender, EventArgs e)
        {

        }

        private void videoPlayer_PlayError(object sender, Xam.Forms.VideoPlayer.VideoPlayer.PlayErrorEventArgs e)
        {

        }

        private void videoPlayer_BufferingStart(object sender, EventArgs e)
        {

        }

        private void videoPlayer_BufferingEnd(object sender, EventArgs e)
        {

        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {

        }
    }
}