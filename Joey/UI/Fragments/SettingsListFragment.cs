﻿using Android.OS;
using Android.Util;
using Android.Views;
using Android.Widget;
using Toggl.Phoebe.Analytics;
using XPlatUtils;
using Toggl.Joey.UI.Adapters;
using ListFragment = Android.Support.V4.App.ListFragment;

namespace Toggl.Joey.UI.Fragments
{
    // Need to use ordinary ListFragment here as PreferenceFragment isn't available in support library.
    public class SettingsListFragment : ListFragment
    {
        public override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);
        }

        public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate (Resource.Layout.SettingsListFragment, container, false);
        }

        public override void OnViewCreated (View view, Bundle savedInstanceState)
        {
            base.OnViewCreated (view, savedInstanceState);

            ListView.SetClipToPadding (false);
            ListAdapter = new SettingsAdapter ();
        }

        public override void OnListItemClick (ListView l, View v, int position, long id)
        {
            ((SettingsAdapter)ListAdapter).OnItemClicked (position);
        }

        public override void OnStart ()
        {
            base.OnStart ();
            ServiceContainer.Resolve<ITracker> ().CurrentScreen = "Settings";
        }
    }
}
