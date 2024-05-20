using System.ComponentModel;

namespace SfDataGridSample.Model
{
    public class Employee : INotifyPropertyChanged
    {
        private int employeeID;
        private string? firstName;
        private string? designation;
        private DateTime birthDate;
        private string? city;
        private string? country;
        private string? telePhone;
        private string? about;

        public event PropertyChangedEventHandler? PropertyChanged;

        
        public int EmployeeID
        {
            get
            {
                return this.employeeID;
            }

            set
            {
                this.employeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }

        public string? Designation
        {
            get
            {
                return this.designation;
            }

            set
            {
                this.designation = value;
                this.RaisePropertyChanged("Designation");
            }
        }

        public string? Name
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
                this.RaisePropertyChanged("FirstName");
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.birthDate;
            }

            set
            {
                this.birthDate = value;
                this.RaisePropertyChanged("DateOfBirth");
            }
        }

        public string? Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.country = value;
                this.RaisePropertyChanged("Country");
            }
        }

        public string? Telephone
        {
            get
            {
                return this.telePhone;
            }

            set
            {
                this.telePhone = value;
                this.RaisePropertyChanged("Telephone");
            }
        }

        public string? About
        {
            get
            {
                return this.about;
            }

            set
            {
                this.about = value;
                this.RaisePropertyChanged("About");
            }
        }


        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
