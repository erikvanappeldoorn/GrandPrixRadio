using System;
using System.Globalization;

namespace GrandPrixRadio.Models
{
    public class RaceEvent
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Day1
        {
            get
            {
                return $"Fri. {FP1.Day} {CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(FP1.Month)}";
            }
        }
        public string Day2
        {
            get
            {
                return $"Sat. {Q.Day} {CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(Q.Month)}";
            }
        }

        public string Day3
        {
            get
            {
                return $"Sun. {R.Day} {CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(R.Month)}";
            }
        }

        public DateTime FP1 { get; set; }

        public DateTime FP2 { get; set; }

        public DateTime FP3 { get; set; }

        public DateTime Q { get; set; }

        public DateTime R { get; set; }

        public string SessionNameFP1 { get; } = "FP1:";

        public string SessionFullNameFP1 { get; } = "Free Practise 1 (FP1)";
        public string SessionNameFP2
        {
            get
            {
                return HasSprintRace ? "Q:" : "FP2:";
            }
        }
        public string SessionFullNameFP2 { 
            get
            {
                return HasSprintRace ? "Qualify (Q)" : "Free Practise 2 (FP2)";
            }
        }

        public string SessionNameFP3
        {
            get
            {
                return HasSprintRace ? "FP2:" : "FP3:";
            }
        }

        public string SessionFullNameFP3
        {
            get
            {
                return HasSprintRace ? "Free Practise 2 (FP2)" : "Free Practise 3 (FP3)";
            }
        }

        public string SessionNameQ
        {
            get
            {
                return HasSprintRace ? "SQ:" : "Q:";
            }
        }

        public string SessionFullNameQ
        {
            get
            {
                return HasSprintRace? "Sprint Qualify (SQ)" : "Qualify (Q)";
            }
        }

        public string SessionNameR { get; } = "R:";

        public string SessionFullNameR { get; } = "Race {R)";


        public string FlagImageName { get; set; }

        public bool HasSprintRace { get; set; } = false;

        public RaceSessionInfo NextSession
        {
            get
            {
                var now = DateTime.Now;
                if (now < FP1) return new RaceSessionInfo { SessionName = "FP1", SessionDateTime = FP1, SessionDay = 1 };
                if (now < FP2) return new RaceSessionInfo { SessionName = "FP2", SessionDateTime = FP2, SessionDay = 1 };
                if (now < FP3) return new RaceSessionInfo { SessionName = "FP3", SessionDateTime = FP3, SessionDay = 2 };
                if (now < Q) return new RaceSessionInfo { SessionName = "Q", SessionDateTime = Q, SessionDay = 2 };
                return new RaceSessionInfo { SessionName = "R", SessionDateTime = R, SessionDay = 3 };
            }
        }

        public string SessionFullName => $"Next session: {SessionFull}";
        private string SessionFull
        {
            get
            {

                switch (NextSession.SessionName)
                {
                    case "FP1": return SessionFullNameFP1;
                    case "FP2": return SessionFullNameFP2;
                    case "FP3": return SessionFullNameFP3;
                    case "Q": return SessionFullNameQ;
                    default: return SessionFullNameR;
                }
            }
         
        }
    }
}
