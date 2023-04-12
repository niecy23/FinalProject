using System;
namespace FinalProject.Models
{
	public class RSVP
	{
		public RSVP()
		{
		}

        public int RsvpID { get; set; }
        public int EventID { get; set; }
        public int UserID { get; set; }
    }
}

