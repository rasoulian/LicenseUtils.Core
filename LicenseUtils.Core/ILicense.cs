using System;


namespace LicenseUtils.Core
{
    public interface ILicense
    {
        bool IsLicenseValid();

        void GetLicenseInfo();
    }

    public class License : ILicense
    {
        public bool IsLicenseValid()
        {
            Console.WriteLine("License has been valid!");
            return true;
        }

        public void GetLicenseInfo()
        {
            Console.WriteLine("License has been valid!");
        }
    }

    public class Edition
    {
        public int DeviceCount { get; set; }
        public int EmployeeCount { get; set; }

        public Edition(int deviceCount, int employeeCount)
        {
            this.DeviceCount = deviceCount;
            this.EmployeeCount = employeeCount;
        }
    }

    public class LicenseProxy : ILicense
    {
        private Edition edition;
        private ILicense license;

        public LicenseProxy(Edition edition)
        {
            this.edition = edition;
            this.license = new License();
        }

        public bool IsLicenseValid()
        {
            return license.IsLicenseValid();
        }

        public void GetLicenseInfo()
        {
            
        }
    }

}
