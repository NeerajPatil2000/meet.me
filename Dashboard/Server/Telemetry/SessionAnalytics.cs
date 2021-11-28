/// <author>Harsh Parihar</author>
/// <created> 17/11/2021 </created>
/// <summary>
/// This data will be saved after completion of each session
/// </summary>

using System;
using System.Collections.Generic;

namespace Dashboard.Server.Telemetry
{
    /// <summary>
    ///     The data used to plot the visuals
    /// </summary>
    public class SessionAnalytics
    {
        /// Stores the chat count(int) for each user(UserData)
        public Dictionary<int, int> chatCountForEachUser;

        /// returns the users who were present in the session for less than
        /// a certain minimum time(threshold time)
        public List<int> insincereMembers;

        /// Stores the userCount(int) at every time stamp(DateTime)
        public Dictionary<DateTime, int> userCountAtAnyTime;
    }
}