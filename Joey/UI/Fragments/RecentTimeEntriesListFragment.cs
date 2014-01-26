﻿using System;
using System.Linq;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Toggl.Joey.UI.Adapters;

namespace Toggl.Joey.UI.Fragments
{
    public class RecentTimeEntriesListFragment : ListFragment
    {
        public override void OnViewCreated (View view, Bundle savedInstanceState)
        {
            base.OnViewCreated (view, savedInstanceState);

            ListAdapter = new RecentTimeEntriesAdapter ();
        }

        public override void OnListItemClick (ListView l, View v, int position, long id)
        {
            var adapter = l.Adapter as RecentTimeEntriesAdapter;
            if (adapter == null)
                return;

            var model = adapter.GetModel (position);
            if (model == null)
                return;

            model.Continue ();
        }
    }
}
