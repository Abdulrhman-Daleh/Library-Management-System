using DataAccess;
using DataAccess.DTOs;
using LibrarySystem.Common;
using System;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Person
    {
        private const int ValidPhoneLength = 10;

        public enum ModeType
        {
            Add,
            Update
        }

        private PersonDTO _personDto;
        private ModeType _currentMode;

        public int PersonId
        {
            get => _personDto.PersonId;
            set => _personDto.PersonId = value;
        }

        public string NationalNo
        {
            get => _personDto.NationalNo;
            set => _personDto.NationalNo = value;
        }

        public string FirstName
        {
            get => _personDto.FirstName;
            set => _personDto.FirstName = value;
        }

        public string SecondName
        {
            get => _personDto.SecondName;
            set => _personDto.SecondName = value;
        }

        public string ThirdName
        {
            get => _personDto.ThirdName;
            set => _personDto.ThirdName = value;
        }

        public string LastName
        {
            get => _personDto.LastName;
            set => _personDto.LastName = value;
        }

        public DateTime DateOfBirth
        {
            get => _personDto.DateOfBirth;
            set => _personDto.DateOfBirth = value;
        }

        public byte Gender
        {
            get => _personDto.Gender;
            set => _personDto.Gender = value;
        }

        public string ImagePath
        {
            get => _personDto.ImagePath;
            set => _personDto.ImagePath = value;
        }

        public string Phone
        {
            get => _personDto.Phone;
            set => _personDto.Phone = value;
        }

        public string Address
        {
            get => _personDto.Address;
            set => _personDto.Address = value;
        }

        public string Email
        {
            get => _personDto.Email;
            set => _personDto.Email = value;
        }


        public ModeType CurrentMode
        {
            get => _currentMode;
            set => _currentMode = value;
        }
        public string FullName => $"{FirstName} {SecondName} {ThirdName} {LastName}".Trim();

        public bool IsMale() => Gender == Convert.ToByte(PersonDTO.GenderType.Male);

        public void SetGenderToMale() => Gender = Convert.ToByte(PersonDTO.GenderType.Male);

        public void SetGenderToFemale() => Gender = Convert.ToByte(PersonDTO.GenderType.Female);

        public Person()
        {
            _personDto = new PersonDTO();
            _currentMode = ModeType.Add;
        }

        private Person(PersonDTO personDto)
        {
            _personDto = personDto;
            _currentMode = ModeType.Update;
        }

        public static async Task<DataTable> GetAllAsync(User currentUser)
        {
             if (currentUser.HasPermission(User.Permissions.All))
                return await PersonData.GetAllPeopleAsync();

            if (currentUser.HasPermission(User.Permissions.ManagePeople))
                return await PersonData.GetPeopleByPersonIdAsync(currentUser.PersonId);

            return null;
        }

        public static Person FindById(int personId)
        {
            PersonDTO personDto = PersonData.GetPersonById(personId);
            return personDto == null ? null : new Person(personDto);
        }

        public static Person FindByNationalNo(string nationalNo)
        {
            PersonDTO personDto = PersonData.GetPersonByNationalNo(nationalNo);
            return personDto == null ? null : new Person(personDto);
        }

        public static bool Exists(string nationalNo)
        {
            return PersonData.DoesPersonExist(nationalNo);
        }

        private bool Add()
        {
            PersonId = PersonData.CreatePerson(_personDto);
            return PersonId != -1;
        }

        private bool Update()
        {
            return PersonData.UpdatePerson(_personDto);
        }

        public bool Save()
        {
            if (_currentMode == ModeType.Add)
            {
                if (Add())
                {
                    _currentMode = ModeType.Update;
                    return true;
                }

                return false;
            }

            return Update();
        }

        public static bool Delete(int personId)
        {
            return PersonData.DeletePerson(personId);
        }

        public static int CountDigits(string phoneNumber)
        {
            int digitCount = 0;
            foreach (char c in phoneNumber)
            {
                if (char.IsDigit(c))
                    digitCount++;
            }
            return digitCount;
        }

        public static bool IsPhoneValid(string phoneNumber)
        {
             if (string.IsNullOrEmpty(phoneNumber))
                 return false;

            return CountDigits(phoneNumber) == ValidPhoneLength;
        }

        public static Person GetAdminPerson()
        {
            return new Person
            {
                PersonId = -1,
                NationalNo = "N1",
                FirstName = "Amer",
                SecondName = "Khaled",
                ThirdName = "Osama",
                LastName = "Mohammed",
                Phone = "(289)-145-2842",
                Address = "142 Main St W",
                Email = "AmerKhaled@gmail.com",
                ImagePath = "",
                Gender = Convert.ToByte(PersonDTO.GenderType.Male),
                DateOfBirth = DateTime.Now.AddYears(-20)
            };
        }

        public static bool IsCurrentLoggedInPerson(int personId)
        {
            return GlobalContext.CurrentUser.PersonId == personId;
        }
    }
}