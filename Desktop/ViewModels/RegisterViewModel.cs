using System;
using System.Collections.Generic;
using System.IO;
using Avalonia.Media.Imaging;
using ReactiveUI;

namespace Desktop.ViewModels
{
	public class RegisterViewModel : ViewModelBase
	{
        private Bitmap _image;

        public RegisterViewModel(MainWindowViewModel mvm) {

            Image = new Bitmap("D:\\desktop\\Desktop\\Desktop\\Assets\\default.png");
        }
        public Bitmap Image { get => _image; set => this.RaiseAndSetIfChanged(ref _image, value); }
    }
}