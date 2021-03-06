using System;
using SQLite;

namespace Toggl.Phoebe.Data.DataObjects
{
    [Table ("WorkspaceModel")]
    public class WorkspaceData : CommonData
    {
        public WorkspaceData ()
        {
            ProjectCreationPrivileges = AccessLevel.Any;
            BillableRatesVisibility = AccessLevel.Any;
        }

        public WorkspaceData (WorkspaceData other) : base (other)
        {
            Name = other.Name;
            IsPremium = other.IsPremium;
            DefaultRate = other.DefaultRate;
            DefaultCurrency = other.DefaultCurrency;
            ProjectCreationPrivileges = other.ProjectCreationPrivileges;
            BillableRatesVisibility = other.BillableRatesVisibility;
            RoundingMode = other.RoundingMode;
            RoundingPercision = other.RoundingPercision;
            LogoUrl = other.LogoUrl;
        }

        public string Name { get; set; }

        public bool IsPremium { get; set; }

        public decimal? DefaultRate { get; set; }

        public string DefaultCurrency { get; set; }

        public AccessLevel ProjectCreationPrivileges { get; set; }

        public AccessLevel BillableRatesVisibility { get; set; }

        public RoundingMode RoundingMode { get; set; }

        public int RoundingPercision { get; set; }

        public string LogoUrl { get; set; }
    }
}
