using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_6
{
    //You are given a string s representing an attendance record for a student where each character signifies whether the student was absent, late, or present on that day. The record only contains the following three characters:

    //'A': Absent.
    //'L': Late.
    //'P': Present.
    //The student is eligible for an attendance award if they meet both of the following criteria:

    //The student was absent('A') for strictly fewer than 2 days total.
    //The student was never late ('L') for 3 or more consecutive days.
    //Return true if the student is eligible for an attendance award, or false otherwise.
    internal class StudentAttendanceRecordI
    {
        public static bool StudentAttendnceRecord(string records)
        {
            int absents = 0;
            bool lates = false;
            for (int i = 0; i < records.Length; i++)
            {
                if (records[i] == 'A')
                    absents++;
                if (records[i] == 'L' && records.Length - i >= 3)
                    if (records[i].Equals(records[i + 1]) && records[i + 1].Equals(records[i + 2]))
                        lates = true;
            }
            return absents < 2 && !lates;
        }

        public static bool StudentsAttendnceRecord2(string record)
        {
            int absents = 0;
            int lates = 0;
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == 'A')
                {
                    absents++;
                    if (absents == 2)
                        return false;
                }
                if (record[i] == 'L')
                {
                    lates++;
                    if (lates > 2)
                        return false;
                }
                else
                    lates = 0;
            }
            return true;
        }

        public static bool StudentsAttendnceRecord3(string record)
        {
            return (!record.Contains("LLL") && (record.Length - record.Replace("A", "").Length < 2));
        }
    }
}
