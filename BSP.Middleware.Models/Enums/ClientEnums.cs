using System;
using System.Collections.Generic;
using System.Text;

namespace BSP.Middleware.Models.Enums
{

    public enum AdminRole
    {
        ADMIN = 0,
        FRANCHISE = 1,
        AREA_REPRESENTATION = 2
    }

    public enum MergeAccountWith
    {
        None,
        Emailpass,
        Facebook,
        Google
    }

    public enum AccountType
    {
        Regular = 0,
        Social = 1,
        NotFound = 2,
        Unknown = 3
    }

    public enum PlatformType
    {
        Web = 0,
        WebMobile = 1,
        Android = 2,
        Ios = 3
    }

    public enum ChoiceOption
    {
        Multiple = 0,
        Single = 1,
        SingleOrNone = 2,
        Double = 3,
        MinimumOne = 4
    }

    public enum ModifierQuantityOption
    {
        NoOptions = 0,
        LightNormalExtraSide = 1,
        NormalExtra = 2,
        UnlimitedQuantity = 3
    }

    public enum PredefinedQuantityOption
    {
        Light = 0,
        Normal = 1,
        Extra = 2
    }

    public enum OrderOptions
    {
        OrderAsIsAndCustomize = 0,
        OrderAsIsOnly = 1,
        CustomizeOnly = 2,
    }

    public enum SiteIdType
    {
        InternalId = 0,
        ExternalId = 1
    }

    public enum DistanceUnit
    {
        Miles = 1,
        Kilometers = 2
    }

    public enum SiteStatusUnified
    {
        SiteIsUp = 0,
        Closed = 1,
        UnavailableForOrdering = 2
    }
}
