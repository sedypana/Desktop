using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks.Dataflow;
using Avalonia.Media.Imaging;
using Desktop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ReactiveUI;

namespace Desktop.ViewModels
{
	public class OrganizeProfileViewModel : ViewModelBase
	{
        private string nameFirst;
        private string nameLast;
        private string patronymic;
        private string numberPhone;
        private Bitmap image;
        private DateTime dr;
        public ObservableCollection<Organizer> Organizers { get; set; } = new();

        public string NameFirst { get => nameFirst; set => this.RaiseAndSetIfChanged(ref nameFirst, value); }
        public string NameLast { get => nameLast; set => this.RaiseAndSetIfChanged(ref nameLast, value); }
        public string Patronymic { get => patronymic; set => this.RaiseAndSetIfChanged(ref patronymic, value); }
        public string NumberPhone { get => numberPhone; set => this.RaiseAndSetIfChanged(ref numberPhone, value); }
        public Bitmap Image { get => image; set => this.RaiseAndSetIfChanged(ref image, value); }
        public DateTime Dr { get => dr; set => this.RaiseAndSetIfChanged(ref dr, value); }
        public ReactiveCommand<Unit, object> NavigatetoOrganize { get; }

        public OrganizeProfileViewModel(MainWindowViewModel mvm, Organizer organizer) {
			NameFirst = organizer.NameFirst;
            NameLast = organizer.NameLast;
            Patronymic = organizer.Patronymic;
            NumberPhone = organizer.NumberPhone;
            Image = organizer.Image;
            Dr = organizer.Dr;
            NavigatetoOrganize = ReactiveCommand.Create(() => mvm.CurrentView = new OrganizeViewModel(mvm,organizer)); 
        }
	}
}