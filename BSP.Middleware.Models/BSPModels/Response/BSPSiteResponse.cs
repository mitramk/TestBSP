using System;

namespace BSP.Middleware.Models.BSPModels.Response
{

    public class BSPSiteResponse
    {
        public Site[] sites { get; set; }
        public int totalResults { get; set; }
    }

    public class Site
    {
        public string id { get; set; }
        public string siteName { get; set; }
        public string enterpriseUnitName { get; set; }
        public Hour[] hours { get; set; }
        public Contact contact { get; set; }
        public string timeZone { get; set; }
        public bool locked { get; set; }
        public string description { get; set; }
        public string currency { get; set; }
        public Address address { get; set; }
        public Coordinates coordinates { get; set; }
        public string status { get; set; }
        public string parentEnterpriseUnitId { get; set; }
        public Customattributeset[] customAttributeSets { get; set; }
        public string referenceId { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime lastModifiedOn { get; set; }
        public DateTime deactivatedOn { get; set; }
        public string organizationName { get; set; }
        public Enterprisesetting[] enterpriseSettings { get; set; }
        public int distance { get; set; }
        public object isInDeliveryArea { get; set; }
    }

    public class Contact
    {
        public string contactPerson { get; set; }
        public string phoneNumber { get; set; }
        public string phoneNumberCountryCode { get; set; }
    }

    public class Address
    {
        public string city { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public string state { get; set; }
        public string street { get; set; }
    }

    public class Coordinates
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

    public class Hour
    {
        public Open open { get; set; }
        public Close close { get; set; }
    }

    public class Open
    {
        public string day { get; set; }
        public string time { get; set; }
    }

    public class Close
    {
        public string day { get; set; }
        public string time { get; set; }
    }

    public class Customattributeset
    {
        public Attribute[] attributes { get; set; }
        public string typeName { get; set; }
    }

    public class Attribute
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Enterprisesetting
    {
        public Configurationsetid configurationSetId { get; set; }
        public Configurationsetting[] configurationSettings { get; set; }
        public string enterpriseUnitId { get; set; }
    }

    public class Configurationsetid
    {
        public string name { get; set; }
    }

    public class Configurationsetting
    {
        public string key { get; set; }
        public string value { get; set; }
    }

}
