using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    /// <summary>
    /// Given an array of meeting time intervals where intervals[i] = [start, end], 
    /// determinr if a person could attend all meetings
    /// </summary>
    public class MeetingRooms
    {
        public static bool canAttendMeetings(List<List<int>> intervals)
        {
            var meeting = new List<List<int>>();    
            foreach(var interval in intervals)
            {
                for (int i = 0; i < meeting.Count; i++)
                {
                    if ((interval[0] > meeting[i][0] && interval[0] < meeting[i][1]) ||
                        (interval[1] > meeting[i][0] && interval[1] < meeting[i][1]))
                    {
                        return false;
                    }
                }
                meeting.Add(interval);
            }
            return true;
        }
    }
}
