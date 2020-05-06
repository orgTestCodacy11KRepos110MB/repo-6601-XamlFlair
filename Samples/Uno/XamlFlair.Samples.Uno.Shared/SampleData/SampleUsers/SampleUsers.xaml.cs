﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Blend.SampleData.SampleUsers
{
    using System; 
    using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
    internal class SampleUsers { }
#else

    public class SampleUsers : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public SampleUsers()
        {
            try
            {
                Uri resourceUri = new Uri("ms-appx:/SampleData/SampleUsers/SampleUsers.xaml", UriKind.RelativeOrAbsolute);
                Windows.UI.Xaml.Application.LoadComponent(this, resourceUri);
            }
            catch
            {
            }
        }

        private Users _Users = new Users();

        public Users Users
        {
            get
            {
                return this._Users;
            }
        }
    }

    public class Users : System.Collections.ObjectModel.ObservableCollection<UsersItem>
    { 
    }

    public class UsersItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private Places _Places = new Places();

        public Places Places
        {
            get
            {
                return this._Places;
            }
        }

        private string _FullName = string.Empty;

        public string FullName
        {
            get
            {
                return this._FullName;
            }

            set
            {
                if (this._FullName != value)
                {
                    this._FullName = value;
                    this.OnPropertyChanged("FullName");
                }
            }
        }

        private string _Email = string.Empty;

        public string Email
        {
            get
            {
                return this._Email;
            }

            set
            {
                if (this._Email != value)
                {
                    this._Email = value;
                    this.OnPropertyChanged("Email");
                }
            }
        }

        private Windows.UI.Xaml.Media.ImageSource _ProfileBackground = null;

        public Windows.UI.Xaml.Media.ImageSource ProfileBackground
        {
            get
            {
                return this._ProfileBackground;
            }

            set
            {
                if (this._ProfileBackground != value)
                {
                    this._ProfileBackground = value;
                    this.OnPropertyChanged("ProfileBackground");
                }
            }
        }

        private string _Address = string.Empty;

        public string Address
        {
            get
            {
                return this._Address;
            }

            set
            {
                if (this._Address != value)
                {
                    this._Address = value;
                    this.OnPropertyChanged("Address");
                }
            }
        }

        private string _PhoneNumber = string.Empty;

        public string PhoneNumber
        {
            get
            {
                return this._PhoneNumber;
            }

            set
            {
                if (this._PhoneNumber != value)
                {
                    this._PhoneNumber = value;
                    this.OnPropertyChanged("PhoneNumber");
                }
            }
        }

        private string _MemberSince = string.Empty;

        public string MemberSince
        {
            get
            {
                return this._MemberSince;
            }

            set
            {
                if (this._MemberSince != value)
                {
                    this._MemberSince = value;
                    this.OnPropertyChanged("MemberSince");
                }
            }
        }

        private bool _IsActive = false;

        public bool IsActive
        {
            get
            {
                return this._IsActive;
            }

            set
            {
                if (this._IsActive != value)
                {
                    this._IsActive = value;
                    this.OnPropertyChanged("IsActive");
                }
            }
        }

        private string _Company = string.Empty;

        public string Company
        {
            get
            {
                return this._Company;
            }

            set
            {
                if (this._Company != value)
                {
                    this._Company = value;
                    this.OnPropertyChanged("Company");
                }
            }
        }

        private Windows.UI.Xaml.Media.ImageSource _ProfilePic = null;

        public Windows.UI.Xaml.Media.ImageSource ProfilePic
        {
            get
            {
                return this._ProfilePic;
            }

            set
            {
                if (this._ProfilePic != value)
                {
                    this._ProfilePic = value;
                    this.OnPropertyChanged("ProfilePic");
                }
            }
        }
    }

    public class Places : System.Collections.ObjectModel.ObservableCollection<PlacesItem>
    { 
    }

    public class PlacesItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _Name = string.Empty;

        public string Name
        {
            get
            {
                return this._Name;
            }

            set
            {
                if (this._Name != value)
                {
                    this._Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        private Windows.UI.Xaml.Media.ImageSource _Image = null;

        public Windows.UI.Xaml.Media.ImageSource Image
        {
            get
            {
                return this._Image;
            }

            set
            {
                if (this._Image != value)
                {
                    this._Image = value;
                    this.OnPropertyChanged("Image");
                }
            }
        }

        private string _Visited = string.Empty;

        public string Visited
        {
            get
            {
                return this._Visited;
            }

            set
            {
                if (this._Visited != value)
                {
                    this._Visited = value;
                    this.OnPropertyChanged("Visited");
                }
            }
        }

        private string _Location = string.Empty;

        public string Location
        {
            get
            {
                return this._Location;
            }

            set
            {
                if (this._Location != value)
                {
                    this._Location = value;
                    this.OnPropertyChanged("Location");
                }
            }
        }

        private string _Description = string.Empty;

        public string Description
        {
            get
            {
                return this._Description;
            }

            set
            {
                if (this._Description != value)
                {
                    this._Description = value;
                    this.OnPropertyChanged("Description");
                }
            }
        }
    }
#endif
}